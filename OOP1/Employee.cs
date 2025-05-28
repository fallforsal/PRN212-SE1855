using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    
    public class Employee
    {
        #region Nhóm các thuộc tính của employee
        private int _id;
        private string _name;
        private string _email;
        private string _phone;
        private string _id_card;
        #endregion

        #region Nhóm các constructor
        public Employee() { }
        
        
        public Employee(int id, string _name ,string _email, string _phone, string _id_card)
        {
            this._id = id;
            this._name = _name;
            this._email = _email;
            this._phone = _phone;   
            this._id_card = _id_card;   


        }
        #endregion

        #region Nhóm các getter setter
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Id_card
        {
            get { return _id_card; }
            set { _id_card = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        #endregion
        public void PrintInfor()
        {
            String msg = $"{Id}\t{Id_card}\t{Name}\t{Email}\t{Phone}\t";
            Console.WriteLine(msg);
        }
        public override string ToString()
        {
            String msg = $"{Id}\t{Id_card}\t{Name}\t{Email}\t{Phone}\t";
            return msg;
        }
    }
  
}