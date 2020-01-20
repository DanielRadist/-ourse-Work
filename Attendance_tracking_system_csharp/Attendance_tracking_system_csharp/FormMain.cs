using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_tracking_system_csharp
{
    public partial class FormMain : Form
    {
        public FormMain(string pathData)                                                    //принимаем строку с адресов БД
        {
            this.pathData = pathData;                                                       //адрес расположения файлов
            InitializeComponent();                                                          //загрузка компонентов окна
            labelForFormMainLoginUserOrAdminSTATUS.Text = "";                               //выводим пустую строку в статусе окна

            ///
            ///загрузка данных о логинах:
            ///
            //подсчет размеров массивов
            countAdmin = System.IO.File.ReadAllLines(pathData + "\\admin.dat").Length;      //считаем кол-во строк в файле = кол-во записей об администраторах
            countUser = System.IO.File.ReadAllLines(pathData + "\\data.dat").Length - countAdmin;

            try
            {
                if (countAdmin < 0 || countUser < 0)
                    throw new Exception("Problem with admin.dat and data.dat. Negative number of array elements. ");

                //выделение памяти
                Admins = new Admin[countAdmin];
                Users = new User[countUser];

                //загрузка в память данных
                using (StreamReader inputData = new StreamReader(pathData + "\\data.dat", System.Text.Encoding.Default))
                {
                    using (StreamReader inputAdmin = new StreamReader(pathData + "\\admin.dat", System.Text.Encoding.Default))
                    {
                        string line;
                        for (int iAdmin = 0, iUser = 0; (line = inputData.ReadLine()) != null; )
                        {

                            string[] words = line.Split(new char[] { ' ' },
                                StringSplitOptions.RemoveEmptyEntries);                     //получаем масcив слов

                            if (words[4] == "adminGroup")                                   //проверка на админа
                            {   
                                ///
                                ///админ
                                ///
                                string passLine = inputAdmin.ReadLine();

                                if(passLine == null)                                        //исключение, что мало строк в admin.dat
                                    throw new Exception("Problem with admin.dat and data.dat. Little data in admin.dat. ");

                                string[] passWords = passLine.Split(new char[] { ' ' },
                                    StringSplitOptions.RemoveEmptyEntries);

                                if(passWords[0] == words[5])                                //если номера совпадают (то есть БД целая), иначе создаем исключение
                                {
                                    Admins[iAdmin++] = new Admin(words[0], words[1], words[2], words[3], words[4], words[5], passWords[1]);
                                }
                                else
                                {
                                    throw new Exception("Problem with admin.dat and data.dat. No data matching. ");
                                }
                                
                            }
                            else
                            {   
                                ///
                                ///юзер
                                ///
                                Users[iUser++] = new User(words[0], words[1], words[2], words[3], words[4], words[5]);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(
                    e.Message + "Contact your system administrator.",
                    "Error base data.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Environment.Exit(-1);                                                       //закрытие программы
            }

        }

        // Обработка кнопки по закрытию программы
        private void buttonForFormMainLoginUserOrAdminExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Событие по закрытию главной формы
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        // Событие, когда вот-вот закрылась форма
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        // Нажатие на кпоку авторизации
        private void buttonForFormMainLoginUserOrAdminLOGIN_Click(object sender, EventArgs e)
        {
            bool labelStatus = false;                                                       //статус того, что вход разрешен
            bool adminStatus = false;                                                       //статус токо, кем заходит
            string loginIn = textBoxForFormMainLoginUserOrAdminLogin.Text;                  //получение логина
            string passwordIn = textBoxForFormMainLoginUserOrAdminPassword.Text;            //и пароля из тектбоксов

            if(passwordIn != "")                                                            //если пустое поле, значит попытка зайти как User
            {
                ///admin
                ///
                adminStatus = true;
                labelStatus = false;

                for (int i = 0; i < countAdmin && labelStatus == false; i++)
                {
                    if (loginIn == Admins[i].Number)
                    {
                        if (passwordIn == Admins[i].Password)
                        {
                            labelStatus = true;
                        }
                    }
                }
            }
            else
            {
                ///user
                ///
                adminStatus = false;
                labelStatus = false;

                for (int i = 0; i < countUser && labelStatus == false; i++)
                {
                    if(loginIn == Users[i].Number)
                    {
                        labelStatus = true;
                    }
                }
            }

            if (labelStatus == false)                                                       //изменение статуса в label
            {
                labelForFormMainLoginUserOrAdminSTATUS.Text = "Неверный номер или пароль!";
                labelForFormMainLoginUserOrAdminSTATUS.ForeColor = Color.Red;
            }
            else
            {
                labelForFormMainLoginUserOrAdminSTATUS.Text = "";
            }

            ///ОТКРЫТИЕ ОКОН ПОЛЬЗОВАТЕЛЕЙ
            ///

            if (adminStatus == true && labelStatus == true)                                 //открыть окно admin
            {
                formAdminMain = new FormAdminMain();
                this.Hide();
                formAdminMain.Show();                
            }
            if (adminStatus == false && labelStatus == true)                                //открыть окно user
            {

            }
        }

        FormAdminMain formAdminMain;
        string pathData;
        int countUser;
        int countAdmin;
        User [] Users;
        Admin [] Admins;
    }
}
