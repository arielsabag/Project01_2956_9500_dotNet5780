using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class Dal_imp : Idal
    {
        public void addGuestRequest(GuestRequest guestRequest)
        {
            foreach (var item in DS.DataSource.guestRequestList)
            {
                if (item.GuestRequestKey == guestRequest.GuestRequestKey)
                {
                    throw new Exception("Guest request key already exists.");
                }
            }
            DS.DataSource.guestRequestList.Add(guestRequest);
        }

        public void addHostingUnit(HostingUnit hostingUnit)
        {
            foreach (var item in DS.DataSource.hostingUnitList)
            {
                if (item.HostingUnitKey == hostingUnit.HostingUnitKey)
                {
                    throw new Exception("Hosting unit key already exists.");
                }
            }
            DS.DataSource.hostingUnitList.Add(hostingUnit);

        }

        public void addOrder(Order order)
        {
            foreach (var item in DS.DataSource.orderList)
            {
                if (item.OrderKey == order.OrderKey)
                {
                    throw new Exception("Order key already exists.");
                }
            }
            DS.DataSource.orderList.Add(order);

        }

        public void delleteHostingUnit(HostingUnit hostingUnit)
        {
            DS.DataSource.hostingUnitList.Remove(hostingUnit);
        }

        public List<BankBranch> getAllBankBranchesInIsraelList()
        {
            List<BankBranch> tmpList = new List<BankBranch>();
            tmpList.Add(new BE.BankBranch() { BankName = "ba1", BankNumber = 1, BranchAddress = "israel", BranchCity = "zefat", BranchNumber = 711 });
            tmpList.Add(new BE.BankBranch() { BankName = "ba2", BankNumber = 2, BranchAddress = "israel2", BranchCity = "carmiel", BranchNumber = 712 });
            tmpList.Add(new BE.BankBranch() { BankName = "ba3", BankNumber = 3, BranchAddress = "israel3", BranchCity = "ashkelon", BranchNumber = 713 });
            tmpList.Add(new BE.BankBranch() { BankName = "ba4", BankNumber = 4, BranchAddress = "israel4", BranchCity = "telaviv", BranchNumber = 714 });
            tmpList.Add(new BE.BankBranch() { BankName = "ba5", BankNumber = 5, BranchAddress = "israel5", BranchCity = "eilat", BranchNumber = 715 });
            return tmpList;
        }

        public List<GuestRequest> getAllGuestsRequestsList()
        {
            return (from GuestRequest item in DS.DataSource.guestRequestList
                    select item).ToList<GuestRequest>();
        }

        public List<HostingUnit> getAllHostingUnitsList()
        {
            return (from HostingUnit item in DS.DataSource.hostingUnitList
                    select item).ToList<HostingUnit>();
        }

        public List<Order> getAllOrdersList()
        {
            return (from Order item in DS.DataSource.orderList
                    select item).ToList<Order>();
        }
        public List<Host> getAllHostsList()
        {
            return (from Host item in DS.DataSource.hostList
                    select item).ToList<Host>();
        }

        public void updateGuestRequest(GuestRequest guestRequest)
        {
            throw new NotImplementedException();
        }

        public void updateHostingUnit(HostingUnit hostingUnit)
        {
            throw new NotImplementedException();
        }

        public void updateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
