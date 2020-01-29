 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GuestRequest
    {
        public string GuestRequestKey { get; set; }
        public string PrivateName { get; set; }
        public string FamilyName { get; set; }
        public string MailAddress { get; set; }
        public bool Status { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Area { get; set; }
        public int SubArea { get; set; }
        public int Type { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public int Pool { get; set; }
        public int Jacuzzi { get; set; }
        public int Garden { get; set; }
        public int ChildrensAttractions { get; set; }
        public override string ToString()
        {
            return PrivateName + ",    " + FamilyName + ",   " + MailAddress;
        }


    }
}
