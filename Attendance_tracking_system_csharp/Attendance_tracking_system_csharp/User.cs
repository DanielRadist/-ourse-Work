using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_tracking_system_csharp
{
    //
    //описание классов в которых будут хранится данные для авторизации
    //
    //
    public class User
    {
        //КОНСТРУКТОР
        public User(string surName, string name, string middleName, string uuid, string group, string number)
        {
            this.SurName = surName;
            this.Name = name;
            this.MiddleName = middleName;
            this.Uuid = new Guid(uuid);
            this.Group = group;
            this.Number = number;
        }

        //СВОЙСТВА
        public string SurName
        {
            set { surName = value; }
            get { return surName; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string MiddleName
        {
            set { middleName = value; }
            get { return middleName; }
        }
        public Guid Uuid
        {
            set { uuid = value; }
            get { return uuid; }
        }
        public string Group
        {
            set { group = value; }
            get { return group; }
        }
        public string Number
        {
            set { number = value; }
            get { return number; }
        }
        

        protected string surName;               //фамилия
        protected string name;                  //имя
        protected string middleName;            //отчество

        /*UUID представляет собой 16-байтный (128-битный) номер.
         * В каноническом представлении UUID изображают в виде числа в шестнадцатеричной системе счисления,
         * разделённого дефисами на пять групп в формате 8-4-4-4-12. Такое представление занимает 32 символа:
        123e4567-e89b-12d3-a456-426655440000
        xxxxxxxx-xxxx-Mxxx-Nxxx-xxxxxxxxxxxx
         4 бита M обозначают версию ("version") UUID, а 1-3 старших бита N обозначают вариант ("variant") UUID.*/
        protected Guid uuid;                    //uuid карты
        protected string group;                 //название группы
        protected string number;                //персональный номер
    }
    public class Admin : User
    {
        public Admin(string surName, string name, string middleName, string uuid, string group, string number, string password)
            : base(surName, name, middleName, uuid, group, number)
        {
            this.Password = password;
        }
        public string Password
        {
            private set { password = value; }
            get { return password; }
        }

        private string password;                //пароль
    }

    /*public class PasswordForAdmin
    {
        public PasswordForAdmin(string number, string password)
        {
            this.Number = number;
            this.Password = password;
        }
        public string Number
        {
            private set { number = Convert.ToUInt32(value); }
            get { return Convert.ToString(number); }
        }
        public string Password
        {
            private set { password = value; }
            get { return password; }
        }

        private uint number;
        private string password;
    }*/
}
