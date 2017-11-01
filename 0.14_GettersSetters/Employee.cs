using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_GettersSetters
{
    class Employee
    {
        //Backing Field
        private int _id;
        private string _name;
        private string _workQuote;

        //Properties
        public int ID
        {
            get
            {
                return _id;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception("The employee ID is invalid");
                }
                _id = value;
            }
        }
            
        

         //Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                         
                if (String.IsNullOrWhiteSpace(value))
                {
                throw new Exception("Employee Name is reruired");
                }
                _name = value.Trim().ToUpper();
                }
            }


        //Methods

        public void SetWorkQuote (string quote)
        {
            this._workQuote = quote;
        }

        public string GetQuote()
        {
            return this._workQuote;
        }

    }
}
