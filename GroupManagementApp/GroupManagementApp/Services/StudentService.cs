using GroupManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml;

namespace GroupManagementApp.Services
{
    internal class StudentService : Student
    {


        
        public static List<Student> Students = new();
        public static List<Student> GroupStudents = new();






        public void CreateStudent()
        {

            Console.WriteLine("tehsil zemaneti:(var/yoxdur)");
        type: string insurance = Console.ReadLine().Trim().ToLower();
            if (insurance != "var" && insurance != "yoxdur")
            {
                Console.WriteLine("duzgun daxil edin");
                
                goto type;
            }
            else
            {
                if (insurance == "var")
                {
                    Type = true;
                }

            }
            Console.WriteLine("adi daxil edin: ");
        name: string name = Console.ReadLine().ToLower();
            if (!Regex.IsMatch(name, @"^[a-z]{3,25}$"))
            {
                Console.WriteLine("duzgun ad daxil edin");
                
                goto name;
            }
            Console.WriteLine("soyadi daxil edin: ");
        surname: string surname = Console.ReadLine().ToLower();
            if (!Regex.IsMatch(surname, @"^[a-z]{3,25}$"))
            {
                Console.WriteLine("duzgun soyad daxil edin");
                
                goto surname;
            }



            Student student = new Student()
            {
                Name = name,
                Surname = surname,
                Type = Type
            };



            Console.WriteLine($"{name} {surname} yaradıldı ");

            Students.Add(student);
            Console.WriteLine("qrupun kategoriyasını daxil edin: ");
          setType:string groupType = Console.ReadLine().ToLower();
            Console.WriteLine("group nomresini daxil edin: ");
            string groupNo = Console.ReadLine();
            foreach (var g in GroupService.Groups)
            {
                if (groupNo == g.No && groupType == g.Category)
                {
                    Group = g;
                    
                     if(GroupStudents.Count < Group.Limit)
                    {
                        GroupStudents.Add(student);
                        Console.WriteLine($"telebe {Group.Category}{Group.No} qrupuna elave olundu");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("qrupda yer yoxdur");
                    }
                       
                   
                  

                }
                else
                {
                    Console.WriteLine("bele bir qrup yoxdur");
                    
                    goto setType;


                }


            }






        }

        public void ShowStudents()
        {

            string type = Type ? "beli" : "xeyr";
            if (Students.Count > 0)
            {
                Console.WriteLine("Telebeler:");
                foreach (var student in Students)
                {
                    Console.WriteLine($"{student.Name} {student.Surname} zemantelidir? {type}");
                }

            }
            else
            {
                Console.WriteLine("telebe yoxdur");
            }



        }

        public void ShowStudentsinGroup()
        {

            Console.WriteLine("qrupun kategoriyasını daxil edin: ");
         setType: string groupType = Console.ReadLine().ToLower();

            Console.WriteLine("group nomresini daxil edin: ");
            string groupNo = Console.ReadLine();
           
            foreach (var g in GroupService.Groups)
            {

                if (groupNo == g.No && groupType == g.Category)
                {
                    Group = g;

                    foreach (var student in GroupStudents)
                    {
                        Console.WriteLine($"{Group.Category}{Group.No}: {student.Name} {student.Surname} ");
                    }
                    break;

                }
                else {
                    Console.WriteLine("bele bir qrup yoxdur");
                    
                    goto setType;

                
                }


            }


        }
    }
}
