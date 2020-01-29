using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public class Bl_imp : IBL
    {
        public void addGuestRequest(GuestRequest guestRequest)
        {
            if (!(guestRequest.EntryDate < guestRequest.ReleaseDate))
            {
                throw new Exception("Entry date must be at least one day earlier than release date.");
            }
            DAL.FactoryDal.getDal().addGuestRequest(guestRequest);

        }

        public void addHostingUnit(HostingUnit hostingUnit)
        {
        }

        public void addOrder(BE.Order order)
        {

        }


        public void delleteHostingUnit(HostingUnit hostingUnit)
        {

            var a = getAllOrdersList();
            foreach (var item in a)
            {
                if (hostingUnit.HostingUnitKey == item.HostingUnitKey)
                {
                    if (item.Status == BE.enum_s.orderStatus.נשלח_מייל || item.Status == BE.enum_s.orderStatus.טרם_טופל)
                    {
                        throw new Exception("cannot delete hosting unit while the request is not closed");
                    }

                }
            }
        }

        public List<BankBranch> getAllBankBranchesInIsraelList()
        {
            DAL.Dal_imp a = new DAL.Dal_imp();
            return a.getAllBankBranchesInIsraelList();
        }

        public List<GuestRequest> getAllGuestsRequestsList()
        {
            DAL.Dal_imp a = new DAL.Dal_imp();
            return a.getAllGuestsRequestsList();
        }

        public List<HostingUnit> getAllHostingUnitsList()
        {
            DAL.Dal_imp a = new DAL.Dal_imp();
            return a.getAllHostingUnitsList();
        }

        public List<Order> getAllOrdersList()
        {
            DAL.Dal_imp a = new DAL.Dal_imp();
            return a.getAllOrdersList();
        }
        public List<Host> getAllHostsList()
        {
            DAL.Dal_imp a = new DAL.Dal_imp();
            return a.getAllHostsList();
        }

        public void updateGuestRequest(GuestRequest guestRequest)
        {
            throw new NotImplementedException();
        }



        public void updateHostingUnit(HostingUnit hostingUnit)
        {

            var a = getAllOrdersList();
            var b = getAllGuestsRequestsList();
            foreach (var item in a)
            {
                foreach (var item1 in b)
                {
                    if (hostingUnit.HostingUnitKey == item.HostingUnitKey && item1.GuestRequestKey == item.GuestRequestKey)
                    {
                        if (item.Status == BE.enum_s.orderStatus.נסגר_בהיענות_של_הלקוח)
                        {
                            for (DateTime date = item1.EntryDate; date <= item1.ReleaseDate; date = date.AddDays(1))
                            {
                                hostingUnit.Diary[date.Day, date.Month] = true;

                            }
                        }
                    }
                }
            }

        }

        public void updateOrder(Order order)
        {
            List<Order> tmp = getAllOrdersList();
            Order t = (Order)(from Order item in tmp
                              where item.OrderKey == order.OrderKey
                              select item);

            if (order.Status == BE.enum_s.orderStatus.נסגר_בהיענות_של_הלקוח)
            {
                throw new Exception("After the order status has changed to 'closing a deal' it is forbidden toto change the order status anymore.");
            }
            else if (order.Status == BE.enum_s.orderStatus.נשלח_מייל)
            {
                if (!BE.Configuration.CurrentHost.CollectionClearance)
                {
                    throw new Exception("collection clearance is not approved and therefore could not send mail");
                }
                else
                {
                }
            }

        }
    }
}
