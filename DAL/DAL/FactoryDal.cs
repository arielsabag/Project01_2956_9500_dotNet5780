using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FactoryDal
    {
        private static Dal_imp dal;
        public static Idal getDal()
        {
            if (dal == null)
            {
                dal = new Dal_imp();
            }
            return dal;
        }
    }
}