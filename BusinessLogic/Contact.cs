using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{


    public class Contact
    {

        public String Name { get; set; }
        public String PhoneNumber { get; set; }
        public String Address { get; set; }

        public Contact()
        {
            this.Name = String.Empty;
            this.PhoneNumber = String.Empty;
            this.Address = String.Empty;
        }

        public override string ToString()
        {
            var strB= new StringBuilder();
            strB.Append(this.Name);
            strB.Append(" ");
            strB.Append(this.PhoneNumber);
            strB.Append(" ");
            strB.Append(this.Address);
                      
            return strB.ToString();
        }
    }



}
