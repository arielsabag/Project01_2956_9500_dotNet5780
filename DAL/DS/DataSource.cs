using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class DataSource
    {
        #region Guest Request List
        public static List<BE.GuestRequest> guestRequestList = new List<BE.GuestRequest>()
        {
             new BE.GuestRequest()
                        {
                            GuestRequestKey = BE.Configuration.guestRequestKey.ToString(),
                            PrivateName = "guestrequest PrivateName 1",
                            FamilyName="guestrequest FamilyName 1",
                            MailAddress="guestrequest1#@gmail.com"
                        },
              new BE.GuestRequest()
                        {
                            PrivateName = "guestrequest PrivateName 2",
                            FamilyName="guestrequest FamilyName 2",
                            MailAddress="guestrequest2#@gmail.com"
                        },
               new BE.GuestRequest()
                        {
                            PrivateName = "guestrequest PrivateName 3",
                            FamilyName="guestrequest FamilyName 3",
                            MailAddress="guestrequest3#@gmail.com"
                        },
                new BE.GuestRequest()
                        {
                            PrivateName = "guestrequest PrivateName 4",
                            FamilyName="guestrequest FamilyName 4",
                            MailAddress="guestrequest4#@gmail.com"
                        },
                 new BE.GuestRequest()
                        {
                            PrivateName = "guestrequest PrivateName 5",
                            FamilyName="guestrequest FamilyName 5",
                            MailAddress="guestrequest5#@gmail.com"
                        }
        };
        #endregion

        #region Host List
        public static List<BE.Host> hostList = new List<BE.Host>()
        {
             new BE.Host()
                        {
                            PrivateName = "host PrivateName 1",
                            FamilyName="host FamilyName 1",
                            MailAddress="host1#@gmail.com",
                            PhoneNumber="05111111111111",
                            UserName = "Host1",
                            Password = "1",
                            CollectionClearance = true
                         },
              new BE.Host()
                        {
                            PrivateName = "host PrivateName 2",
                            FamilyName="host FamilyName 2",
                            MailAddress="host2#@gmail.com",
                            PhoneNumber="0522222222222",
                              UserName = "Host2",
                            Password = "2",
                            CollectionClearance = false

                         },
               new BE.Host()
                        {
                            PrivateName = "host PrivateName 3",
                            FamilyName="host FamilyName 3",
                            MailAddress="host3#@gmail.com",
                            PhoneNumber="053333333333",
                              UserName = "Host3",
                            Password = "3",
                            CollectionClearance = false
                         },
                new BE.Host()
                        {
                            PrivateName = "host PrivateName 4",
                            FamilyName="host FamilyName 4",
                            MailAddress="host4#@gmail.com",
                            PhoneNumber="05444444444",
                              UserName = "Host4",
                            Password = "4",
                            CollectionClearance = true

                         },
                 new BE.Host()
                        {
                            PrivateName = "host PrivateName 5",
                            FamilyName="host FamilyName 5",
                            MailAddress="host5#@gmail.com",
                            PhoneNumber="055555555555",
                              UserName = "Host5",
                            Password = "5",
                            CollectionClearance = false
                         }
        };
        #endregion

        #region Hosting Unit List
        public static List<BE.HostingUnit> hostingUnitList = new List<BE.HostingUnit>()
        {
             new BE.HostingUnit()
                        {
                            HostingUnitName = "hosting unit  1"
                        },
              new BE.HostingUnit()
                        {
                            HostingUnitName = "hosting unit  2"
                        },
               new BE.HostingUnit()
                        {
                            HostingUnitName = "hosting unit  3"
                        },
                new BE.HostingUnit()
                        {
                            HostingUnitName = "hosting unit  4"
                        },
                 new BE.HostingUnit()
                        {
                            HostingUnitName = "hosting unit  5"
                        }

        };
        #endregion

        #region Order List
        public static List<BE.Order> orderList = new List<BE.Order>()
        {
             new BE.Order()
                        {
                            HostingUnitKey = "hosting unit  1",
                 GuestRequestKey = "1",
                 OrderKey= "dd",
                 Status = BE.enum_s.orderStatus.טרם_טופל,
                 CreateDate =DateTime.Now,
                 OrderDate = DateTime.Now
                        },
              new BE.Order()
                        {
                            HostingUnitKey = "hosting unit  2",
                 GuestRequestKey = "1",
                 OrderKey= "dd",
                 Status = BE.enum_s.orderStatus.טרם_טופל,
               CreateDate =DateTime.Now,
                 OrderDate = DateTime.Now
                        },
               new BE.Order()
                        {
                            HostingUnitKey = "hosting unit  3",
                GuestRequestKey = "1",
                 OrderKey= "dd",
                 Status = BE.enum_s.orderStatus.טרם_טופל,
                CreateDate =DateTime.Now,
                 OrderDate = DateTime.Now
                        },
                new BE.Order()
                        {
                           HostingUnitKey = "hosting unit  4",
                  GuestRequestKey = "1",
                 OrderKey= "dd",
                 Status = BE.enum_s.orderStatus.טרם_טופל,
                CreateDate =DateTime.Now,
                 OrderDate = DateTime.Now
                        },
                 new BE.Order()
                        {
                            HostingUnitKey = "hosting unit  5",
                 GuestRequestKey = "1",
                 OrderKey= "dd",
                 Status = BE.enum_s.orderStatus.טרם_טופל,
                CreateDate =DateTime.Now,
                 OrderDate = DateTime.Now
                        }

        };
        #endregion

    }
}
