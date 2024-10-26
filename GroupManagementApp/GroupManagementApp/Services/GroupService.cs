using GroupManagementApp.Enums;
using GroupManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GroupManagementApp.Services
{
    internal class GroupService:Models.Group
    {
        public static List<Models.Group> Groups = new();



        public void CreateGroup()
        {


            Console.WriteLine("kategoriyanı daxil edin:(P/D/SA)");
        category: string category = Console.ReadLine().ToLower();
            if (category != "p" && category != "d" && category != "sa")
            {
                Console.WriteLine("qrup tipini duzgun daxil edin");
                goto category;

            }

            Console.WriteLine("nomreni  daxil edin:");
        no: string no = Console.ReadLine();
            foreach (var item in no)
            {
                if (!Char.IsDigit(item))
                {
                    Console.WriteLine("nomre ancaq reqemlerden ibaret olmalıdır");
                    goto no;
                }
            }
            int intNo = Convert.ToInt32(no);


            if (intNo < 99 || intNo > 999)
            {
                Console.WriteLine("duzgun qrup nomresi daxil edin (100-999)");
                goto no;
            }


            if (Groups.Exists(g => g.No == no && g.Category == category))
            {

                Console.WriteLine("bu qrup movcuddur basqa nomre daxil edin");
                goto no;

            }



            Console.WriteLine("onlinedirmi?(beli/xeyr)");
        online: string online = Console.ReadLine();
            if (online != "beli" && online != "xeyr") {
                Console.WriteLine("duzgun daxil edin: ");
                goto online;
            
            }
            if(online == "beli")
            {
               
            }
            if (IsOnline)
            {
                Limit = 15;
                
            }
            else
            {
                Limit = 10;
                
            }


          

            Models.Group group = new(category, no)
            {
                IsOnline = IsOnline,
                Limit = Limit
            };
            Groups.Add(group);
            Console.WriteLine($"{category}{no} qrupu yaradıldı");



        }

        public void ShowGroups()
        {
            Console.WriteLine("Qruplar:");
            foreach (var item in Groups)
            {
                string onlineStatus = item.IsOnline ? "beli" : "xeyr";
                switch (item.Category)
                {
                    case "p":
                        Console.WriteLine($"{CategoryEnum.Programming} {item.Category}{item.No} Limit: {item.Limit} onlinedir:{onlineStatus}");
                        break;
                    case "d":
                        Console.WriteLine($"{CategoryEnum.Desing} {item.Category}{item.No} Limit: {item.Limit} onlinedir: {onlineStatus}");
                        break;
                    case "sa":
                        Console.WriteLine($"{CategoryEnum.SystemAdmistration} {item.Category}{item.No} Limit: {item.Limit} onlinedir: {onlineStatus}");
                        break;

                }

            }

        }



      
        public void EditGroup()
        {
            Console.WriteLine("deyisiklik etmek istediyiniz qrup nomresini daxil edin: ");
            string num = Console.ReadLine();
            Console.WriteLine("kategoriyani daxil edin: ");
            string category = Console.ReadLine();
            foreach (var item in Groups)
            {
                if (item.Category == category && item.No == num)
                {

                   
                        Console.WriteLine("yeni qrup nomresini daxil edin: ");
                        string newNum = Console.ReadLine();
                    item.No = newNum;
                       
                   
                    
                }
            }



        }



    }
}
