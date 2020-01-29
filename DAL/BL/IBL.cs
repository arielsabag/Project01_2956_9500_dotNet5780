using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    interface IBL
    {
        void addGuestRequest(BE.GuestRequest guestRequest);
        void updateGuestRequest(BE.GuestRequest guestRequest);
        void addHostingUnit(BE.HostingUnit hostingUnit);
        void delleteHostingUnit(BE.HostingUnit hostingUnit);
        void updateHostingUnit(BE.HostingUnit hostingUnit);
        void addOrder(BE.Order order);
        void updateOrder(BE.Order order);
        List<BE.HostingUnit> getAllHostingUnitsList();
        List<BE.GuestRequest> getAllGuestsRequestsList();
        List<BE.Order> getAllOrdersList();
        List<BE.BankBranch> getAllBankBranchesInIsraelList();

    }
}
