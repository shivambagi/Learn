using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Mobile { get; set; }
        public int Salary { get; set; }

        public int DeptID { get; set; }
    }

    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class LINQ
    {
        List<Department> dept = new List<Department>
            {
                new Department(){ ID = 1,Name="HR" },
                new Department(){ID=2,Name="IT"},
                new Department(){ID=3,Name="RND"}
            };

        List<Employee> emp = new List<Employee>
            {
                new Employee{ ID = 1,Name="Shivam",Mobile=6548956,Salary=65463,DeptID=1 },
                new Employee{ID=2,Name="asdwas",Mobile=648654564,Salary=65462,DeptID=2 },
                new Employee{ID=3,Name="Vishwajeet",Mobile=12323,Salary=65461,DeptID=1 },
                new Employee{ID=4,Name="Bagi",Mobile=11122323,Salary=15461,DeptID=3 },
            };

        
        public void Method()
        {
            var list = from s in emp
                       where s.Salary < 30000
                       orderby s.Name
                       select s;

            var joins = from e in emp
                        join d in dept
                        on e.DeptID equals d.ID
                        select new { NAme = e.Name, Department = d.Name, Salary = e.Salary };

            var methodjoin = emp.Join(dept,
                e => e.DeptID,
                d => d.ID,
                (e, d) => new
                {
                    Name = e.Name,
                    Salary = e.Salary,
                    Department = d.Name
                }
                ).Where(x=>x.Salary > 20000);

            //index
            var indexlist = emp.Select((x, index) => new
            {
                Position = index,
                IDs = x.ID,
                Name = x.Name
            });

            foreach (var item in joins)
            {
                Console.WriteLine(item.NAme + " " + item.Salary + " " + item.Department);
            }
            Console.WriteLine("Avg Salary {0} ", emp.Select(e => e.Salary).Average());

            var name = (from s in emp
                        select new { s.Name, s.Salary });

            foreach (var item in name)
            {
                Console.WriteLine(item.Name);
            }


            
            

        }

    }

    class Order
    {
        public int Id;
        public string Name;
    }
    class OrderItem
    {
        public int Id;
        public string Name;
        public int OrderId;
    }

    public class ProgramLINQ
    {
        public void Method()
        {
            var orders = new List<Order> 
            {
                new Order { Id = 1, Name = "One" } ,
                new Order { Id = 2, Name = "Two" }
            };
            List<OrderItem> orderItems = new List<OrderItem>
            {
                new OrderItem { Id = 1, Name = "Item One", OrderId = 1 },
                new OrderItem { Id = 2, Name = "Item Two", OrderId = 1 },
                new OrderItem { Id = 3, Name = "Item Three", OrderId = 1 },
                new OrderItem { Id = 4, Name = "Item Four", OrderId = 2 },
                new OrderItem { Id = 5, Name = "Item Five", OrderId = 2 }
            };
           

            var result = orders.Join(orderItems, order => order.Id, orderitem => orderitem.OrderId,
                (order, orderitem) => new
                {
                    Name = order.Name,
                    Quantity = orderitem.OrderId
                }
                ).GroupBy(x=>x.Name);

            

            var result2 = (from order in orders
                          join orderitem in orderItems
                          on order.Id equals orderitem.OrderId
                          select new { order.Name, orderitem.OrderId }).GroupBy(x=>x.Name);

            var result23 = from order in orders
                           join orderitem in orderItems
                           on order.Id equals orderitem.OrderId
                           select new { order.Name, orderitem };

            var results = from order in orders
                          join orderItem in orderItems 
                          on order.Id equals orderItem.OrderId 
                          into GroupOrderItems
                          select new { order, GroupOrderItems };

            var resultss = orders.GroupJoin(orderItems, order => order.Id, orderitem => orderitem.OrderId,
               (order, orderitem) => new
               {
                   Name = order.Name,
                   Quantity = orderitem
               }
               );

            foreach (var item in results)
            {
                Console.WriteLine("{0} {1}",item.order.Name,item.GroupOrderItems.Count());
                foreach (var i in item.GroupOrderItems)
                {
                    Console.WriteLine("{0}", i.Name);
                }
            }



            foreach (var item in resultss)
            {
                Console.WriteLine("{0} {1}", item.Name, item.Quantity.Count());
                foreach (var i in item.Quantity)
                {
                    Console.WriteLine("{0}", i.Name);
                }
            }




        }
    }



    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Barnch { get; set; }
        public int Age { get; set; }
        public static List<Student> GetStudents()
        {
            return new List<Student>()
        {
            new Student { ID = 1001, Name = "Preety", Gender = "Female",
                                         Barnch = "CSE", Age = 20 },
            new Student { ID = 1002, Name = "Snurag", Gender = "Male",
                                         Barnch = "ETC", Age = 21  },
            new Student { ID = 1003, Name = "Pranaya", Gender = "Male",
                                         Barnch = "CSE", Age = 21  },
            new Student { ID = 1004, Name = "Anurag", Gender = "Male",
                                         Barnch = "CSE", Age = 20  },
            new Student { ID = 1005, Name = "Hina", Gender = "Female",
                                         Barnch = "ETC", Age = 20 },
            new Student { ID = 1006, Name = "Priyanka", Gender = "Female",
                                         Barnch = "CSE", Age = 21 },
            new Student { ID = 1007, Name = "santosh", Gender = "Male",
                                         Barnch = "CSE", Age = 22  },
            new Student { ID = 1008, Name = "Tina", Gender = "Female",
                                         Barnch = "CSE", Age = 20  },
            new Student { ID = 1009, Name = "Celina", Gender = "Female",
                                         Barnch = "ETC", Age = 22 },
            new Student { ID = 1010, Name = "Sambit", Gender = "Male",
                                         Barnch = "ETC", Age = 21 }
        };
        }
    }

    class studenlinq
    {
        public void Method()
        {
            var studentlist = Student.GetStudents().GroupBy(x => x.Barnch).Select(
                std => new
                {
                    Key = std.Key,
                    Students = std
                }
                );

            var qslist = from std in Student.GetStudents()
                          group std by std.Barnch into stdlist
                          select new { 
                            Name = stdlist.Key,
                            Students = stdlist
                          }
                          ;


            foreach (var item in qslist)
            {
                Console.WriteLine(item.Name);
                foreach (var i in item.Students)
                {
                    Console.WriteLine(i.Name, i.Age);
                }
            }
        }
    }
}
