using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0807POS機系統
{
    public class ClsMember
    {
        
        public string txtlastname { get; set; }
        public string txtfirstname { get; set; }
        public string txtphone { get; set; }
        


        public string memberName
        {
            get
            {

                return txtlastname;
            }
            set
            {

                txtlastname = value;
            }
        }

        public string memberfirstName
        {
            get
            {

                return txtfirstname;
            }
            set
            {

                txtfirstname = value;
            }
        }
        private string memberphone;
        public string phonenumber
        {
            get
            {
                return txtphone;
            }
            set
            {
                txtphone = value;
            }
        }
    }
     
}
