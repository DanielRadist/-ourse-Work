using System;
using System.IO;                            //было добавленно для проверки БД
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_tracking_system_csharp
{   
    static class Program
    {
        static void createFiles(string path)
        {
            using (FileStream fstream = new FileStream(path + "\\data.dat", FileMode.Create))
            {
                ///Файл: «data.dat». Строки в файле представляют собой запись об одном из людей:
                ///1) Фамилия (максимум 50 символов),
                ///2) Имя (максимум 50 символов),
                ///3) Отчество (максимум 50 символов),
                ///4) UID карты в шестнадцатеричном представлении (максимум 50 символов),
                ///5) название группы (максимум 10 символов),
                ///6) персональный номер (номер студенческого или номер телефона) (максимум 10 символов)),
                ///7) далее через пробел даты в формате: ЧЧММГГ (у каждого человека записывается только те даты, на которых он был.
                ///
                string tmp = "SurName " + "Name " + "MiddleName " + "00000000-0000-0000-0000-000000000000 " + "adminGroup " + "12345 " + '\n';

                byte[] array = System.Text.Encoding.Default.GetBytes(tmp);      // преобразуем строку в байты
                fstream.Write(array, 0, array.Length);                          // запись массива байтов в файл
                Console.WriteLine("File \"data.dat\" created");
            }
            using (FileStream fstream = new FileStream(path + "\\admin.dat", FileMode.Create))
            {
                ///Файл «admin.dat». Строки в файле представляют собой:
                ///1) персональные номера администраторов
                ///2) пароль
                ///то есть, если существует запись персонального номера человека в данном файле, у него будут привилегии администратора после авторизации.
                ///
                string tmp = "12345 " + "admin " + '\n';

                byte[] array = System.Text.Encoding.Default.GetBytes(tmp);      // преобразуем строку в байты
                fstream.Write(array, 0, array.Length);                          // запись массива байтов в файл
                Console.WriteLine("File \"admin.dat\" created");
            }
            using (FileStream fstream = new FileStream(path + "\\groups.dat", FileMode.Create))
            {
                ///Файл «grop.dat». Строки в файле:
                ///1) название группы (формат выше)
                ///2) даты, когда были пары у этих групп (формат выше)
                ///3) примечания (без пробелов максимум 10 символов).
            }
        }

        [STAThread]
        static void Main()
        {
            /// <проверка БД>
            /// Проверка на наличие папки "data" и наличие в этой папке трех файлов: "data.dat", "admin.dat", "groups.dat"
            /// если файлы отсутствуют то создать новые пустые, но файлах "admin.dat" и "data.dat" должны быть данные для того, чтобы администатор смог зайти и создать уже свой аккаунт.

            string pathData = "";                                       //по итогу будет: "полный путь до .exe" + "data";
            pathData += Directory.GetCurrentDirectory();
            pathData += "\\data";

            DirectoryInfo dirInfo = new DirectoryInfo(pathData);        //dirInfo.CreateSubdirectory(subpath); <- это на всякий случай
            if (!dirInfo.Exists)                                        //если директории нет...
            {
                dirInfo.Create();                                       //...создать её...
                createFiles(pathData);                                  //... и создать файлы
            }
            if (!(File.Exists(pathData + "\\data.dat") && File.Exists(pathData + "\\admin.dat") && File.Exists(pathData + "\\groups.dat")))
            {                                                           //если хотя бы один файл отсутствует, пересоздаем все файлы
                createFiles(pathData);                                  //создать файлы
            }

            /// </проверка БД>


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain(pathData));                    //запуск окна авторизации
        }
    }
}
