using System.Collections.Generic;

namespace CsharpTest
{


    class Program
    {



        // Basic C# functional programming
        static void Main(string[] args)
        {
            List<tbl_Employee> tbl_List = new List<tbl_Employee>();
            tbl_List.Add(new tbl_Employee { Id = 0, Name = "Ovi" });
            tbl_List.Add(new tbl_Employee { Id = 1, Name = "Matal" });

            List<EmployeeViewModel> viewModel = new List<EmployeeViewModel>();
            viewModel.CopyPropertiesFrom(tbl_List);


        }

    }


    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class tbl_Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
