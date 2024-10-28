using GroupManagementApp.Services;

namespace GroupManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("1.grup yarat\n2.Gruplarin siyahisini goster\n3.grup uzerinde duzelish etmek\n4.qrupdaki telebelerin siyahisini goster\n5.butun telebelerin siyahisini goster\n6. telebe yarat\n\n0.cixish");
                 answer = Console.ReadLine().Trim();
                GroupService groupService = new GroupService();
                StudentService studentService = new StudentService();
                switch (answer) {
                    case "1":
                        groupService.CreateGroup();
                         break;

                    case "2":
                        groupService.ShowGroups();
                        break;

                    case "3":
                        groupService.EditGroup();
                        break;
                    case "4":
                        studentService.ShowStudentsinGroup();
                        break;
                    case"5":
                        studentService.ShowStudents();
                        break;

                    case "6":
                        studentService.CreateStudent();
                        break;
                       
                    case "0":
                        break;
                }

            }
            while (answer!="0");
        }
    }
}
