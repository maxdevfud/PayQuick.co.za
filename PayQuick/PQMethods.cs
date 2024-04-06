using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mainModel;

namespace PayQuick
{

    public static class PQMethods
    {

        //public Employee retEmp;
        //private Employee retEmp;
        public static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
        public static Employee blankEmp(Employee retEmp)
        {
            retEmp.ID = 0;
            retEmp.lastname = "";
            retEmp.firstname = "";
            retEmp.identity_no = "";
            retEmp.pay_id = "";
            retEmp.occupation = "";
            retEmp.appointed_date = DateTime.Today;
            retEmp.tax_id = "";
            retEmp.status = "Active";
            return retEmp;
        }
    }

    
    //Method

}
