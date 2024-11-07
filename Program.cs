using C_Sharp;
using System;
using System.ComponentModel;
namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9};

            //var qu = from i in list where i > 4 select i;

            //foreach (var i in qu)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Mathodsytex");

            //qu = list.Where(i => i > 4);

            //foreach (var i in qu)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Max value");

            //var mixsyntex = (from i in list select i).Max();
            //Console.WriteLine(mixsyntex.ToString());

            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=1,Name="Fagun",Email="fagun@gmail.com"},
                new Employee(){Id=2,Name="Mamun",Email="mamun@gmail.com"},
                new Employee(){Id=3,Name="Enayet",Email="enayet@gmail.com"}
            };

            //IEnumerable<Employee> query = from emp in employees where emp.Id==1 select emp;

            //IQueryable<Employee> query1 = employees.AsQueryable().Where(x=>x.Id==1);

            //foreach(Employee emp in query1)
            //{
            //    Console.WriteLine("Id : " + emp.Id + " Name : " + emp.Name);
            //}

            //var basicQuery = (from emp in employees select emp).ToList();
            //var basicMathod = employees.ToList();

            //var basicPropQuery = from emp in employees select emp.Id+1;

            //foreach (var emp in basicMathod)
            //{
            //    Console.WriteLine($"Id  = {emp.Id}, Name = {emp.Name}");
            //}

            /// Different operation

            //    var selectQueray = (from emp in employees
            //                        select new Student()
            //                        {
            //                            StudentId = emp.Id,
            //                            FullName = emp.Name,
            //                            SEmail = emp.Email,
            //                        });

            //    var selectMathod = employees.Select(emp=>new Student()
            //    {
            //        StudentId=emp.Id,
            //        FullName = emp.Name,
            //        SEmail = emp.Email,
            //    }).ToList();

            //    foreach(var emp in selectMathod )
            //    {
            //        Console.WriteLine($"Id  = {emp.StudentId}, Name = {emp.FullName}, {emp.SEmail}");
            //    }

            //Sorting 

            List<int> list = new List<int>() { 6, 1, 2, 3, 4, 7, 8, 9, 5};

            var QuerySyntex = (from i in list 
                       orderby i
                       select i).ToList(); 
            var MathodSyntex = list.OrderByDescending(i => i).ToList();

            foreach (var i in MathodSyntex)
            {
                Console.WriteLine(i);
            }

            //sorting in object;
            var sortobj = (from i in employees
                           orderby i.Name descending
                           select i);



            foreach(var emp in sortobj)
            {
                Console.WriteLine($"Id  = {emp.Id}, Name = {emp.Name}");
            }

        }

        //class Employee
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //}

    }
}