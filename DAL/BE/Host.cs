using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Host
    {
        public string HostKey { get; set; }
        public string PrivateName { get; set; }
        public string FamilyName { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAddress { get; set; }
        public BankBranch BankBranchDetails { get; set; }
        public string BankAccountNumber { get; set; }
        public bool CollectionClearance { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }

        public string UserName { get; set; }

        public string Password { get; set; }


    }
}
