﻿using C_Sharp;
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

            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee(){Id=1,Name="Fagun",Email="fagun@gmail.com"},
            //    new Employee(){Id=2,Name="Mamun",Email="mamun@gmail.com"},
            //    new Employee(){Id=3,Name="Enayet",Email="enayet@gmail.com"}
            //};

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

            //List<int> list = new List<int>() { 6, 1, 2, 3, 4, 7, 8, 9, 5};

            //var QuerySyntex = (from i in list 
            //           orderby i
            //           select i).ToList(); 
            //var MathodSyntex = list.OrderByDescending(i => i).ToList();

            //foreach (var i in MathodSyntex)
            //{
            //    Console.WriteLine(i);
            //}

            ////sorting in object;
            //var sortobj = (from i in employees
            //               orderby i.Name descending
            //               select i);



            //foreach(var emp in sortobj)
            //{
            //    Console.WriteLine($"Id  = {emp.Id}, Name = {emp.Name}");
            //}

            //var f = employees.Any(e => e.Id > 3);

            //var qs = (from i in employees select i).Any(x => x.Id > 2);
            //if(qs)
            //{
            //    Console.WriteLine("Yes");
            //}

            //public class Student2
            //{
            //    public string StdName { get; set; }
            //    public int StdId { get; set; }
            //    public List<Subject> AllSubject { get; set; }
            //}
            //public class Subject
            //{
            //    public string SubjectName { get; set; }
            //    public int SubjectMarks { get; set; }
            //}

            //static void Main(string[] args)
            //{
            //    Student2[] students =
            //    {
            //                new Student2
            //                {
            //                    StdName = "Mamun",
            //                    StdId = 1,
            //                    AllSubject = new List<Subject>
            //                    {
            //                        new Subject{SubjectName="Physics", SubjectMarks=80},
            //                        new Subject{SubjectName="Chem", SubjectMarks=78},
            //                        new Subject{SubjectName="Biology", SubjectMarks=90},
            //                    }
            //                },
            //                new Student2
            //                {
            //                    StdName = "Liz",
            //                    StdId = 2,
            //                    AllSubject = new List<Subject>
            //                    {
            //                        new Subject{SubjectName="Physics", SubjectMarks=85},
            //                        new Subject{SubjectName="Chem", SubjectMarks=79},
            //                        new Subject{SubjectName="Biology", SubjectMarks=95},
            //                    }
            //                },
            //                new Student2
            //                {
            //                    StdName = "Akand",
            //                    StdId = 1,
            //                    AllSubject = new List<Subject>
            //                    {
            //                        new Subject{SubjectName="Physics", SubjectMarks=92},
            //                        new Subject{SubjectName="Chem", SubjectMarks=60},
            //                        new Subject{SubjectName="Biology", SubjectMarks=70},
            //                    }
            //                }

            //            };


            //List<string> students = new List<string>() { "Fagun","Mamun","Enayet","Abc","Def"};

            //var res = students.Contains("Abc");
            //var result = (from st in students select st).Contains("Fagun");

            //Console.WriteLine(result);

            //List<student> students = new List<student>()
            //{
            //    new student() {Id=1,name="Fagun"},
            //    new student() {Id=2,name="Mamun"},
            //    new student() {Id=3,name="Fagun"},
            //    new student() {Id=4,name="Mamun"}
            //};


            //var ms = students.Select(student => student.name).Distinct().ToList();
            

            //var res = students.Contains(new student() { Id = 1, name = "Fagun" });
            //Console.WriteLine(res);

            //List<int> list = new List<int>() { 1,1,1,2,2,3,4,5,5,5};
            //var ns = list.Distinct().ToList();
            //var qs = (from i in ns select i).ToList();
            
            //practice take

            //var ms = list.Where(x=>x>2).Take(5).ToList();
            //var qs = (from i in list select i).Take(5).ToList();

            //practice skip

            //var ms = list.Where(x=>x>2).Skip(2).ToList();
            //var qs = (from i in list select i).Skip(3).ToList();

            //foreach(var i in ms)
            //{
            //    Console.WriteLine(i);
            //}

            //var students = new List<Students>()
            //{
            //    new Students() {Id = 1, Name ="A" , AddressId=1},
            //    new Students() {Id = 2, Name ="B" , AddressId=0},
            //    new Students() {Id = 3, Name ="C" , AddressId=2},
            //    new Students() {Id = 4, Name ="D" , AddressId=0},
            //    new Students() {Id = 5, Name ="E" , AddressId=3},
            //};

            //var addresses = new List<Address>()
            //{
            //    new Address() {Id = 1, AddressLine="Line 1"},
            //    new Address() {Id = 2, AddressLine="Line 2"},
            //    new Address() {Id = 3, AddressLine="Line 3"},
            //    new Address() {Id = 4, AddressLine="Line 4"},
            //    new Address() {Id = 5, AddressLine="Line 5"},

            //};

            //var qs = (from student in students
            //         join address in addresses
            //         on student.AddressId equals address.Id
            //         select new
            //         {
            //             studentName = student.Name,
            //             Line = address.AddressLine,
            //         }).ToList();

            //Console.WriteLine(qs);


            var student = new List<students> ()
            {
               new students {Id=1, Name="A", CategoryId=1},
               new students {Id=2, Name="B", CategoryId=1},
               new students {Id=3, Name="C"},
               new students {Id=4, Name="D", CategoryId=3},
               new students {Id=5, Name="E", CategoryId=5},

            };

            var category = new List<category>
            {
                new category {CatId=1,CatName="Monitor"},
                new category {CatId=2,CatName="Desciple"},
                new category {CatId=3,CatName="Nothing"},
            };

            var qs = (from std in student
                     join c in category
                     on std.CategoryId equals c.CatId into stdGrop
                     from studentGrop in stdGrop.DefaultIfEmpty()
                     select new { studentName = std.Name , CategoryName = studentGrop !=null ? studentGrop.CatName : "NA"  }).ToList();

            //foreach(var item in  qs)
            //{
            //    Console.WriteLine(item.c.CatName + "=>");

            //    foreach(var c in item.stdGrop)
            //    {
            //        Console.WriteLine(c.Name);
            //    }
            //}

            Console.WriteLine();


        }

        class students
        {

            public int Id;
            public string Name;
            public int CategoryId;


        }
        class category
        {
            public int CatId { get; set; }
            public string CatName { get; set; }
        }

    }
}

