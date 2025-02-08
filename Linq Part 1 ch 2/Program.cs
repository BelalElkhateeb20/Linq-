using System.Linq;
using System.Collections.Generic;
using Int32Extension;
namespace Linq_Part_1_ch_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region// Linq:language Independent Query
            // use 40+ c# functions (Query operator) Against Data ,regarless of data store
            // L2object ,L2XMl,L2(SQl) ORM
            #endregion
            #region implicit type local variable 
            var D = 123456;
            Console.WriteLine(D.GetType());
            #endregion
            #region //Extension Method

            List<int> lst = new List<int> { 1, 2, 5, 4, 7, 8, 9, 56, 4 };
            int y = 123456;
            var x = y.Mirror();
            #endregion
            #region//Anonymous Type
            var emp = new { Id = 100, Name = "belal", salary = 2000m };
            //emp.Name = "abdo";///Immutable object
            Console.WriteLine(emp.GetType().Name);
            var emp1 = new { Id = 1001, Name = "saly", depart = "HR", salary = 5400 };
            Console.WriteLine(emp1.GetType().Name);
            var emp2 = new { Name = "saly", Id = 1001, salary = 32m };
            Console.WriteLine(emp2.GetType().Name);
            #endregion
            //sequance :class implement IEnumrable<T>Interface
            //Local Sequance :L2object ,L2ADO,L2XML
            //Remote Sequance :L2Sql,L2E
            //Sequance contain elements
            List<int> Lst = new List<int> { 1, 5, 47, 8, 6, 54, 6, 3, 21 };
            List<string> LstName = new List<string> { "belal", "mohamed", "somaya", "class" };
            //fluent syntax

            //call where as a  static function membre in Enumerable 
            #region //where 
            var resuls = Enumerable.Where(Lst, n => n % 2 == 0);
            var R = Lst.Where(n => n < 50);
            foreach (var item in resuls)
            {
                Console.WriteLine($"{item}");

            }
            Console.WriteLine("\n");
            //Query Expresion\\Query syntax (SQl Query)
            var r = from i in Lst
                    where i % 2 == 0
                    orderby i descending// this to reverse the numbers
                    select i;
            foreach (var items in r)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("\n");

            #endregion
            //Imidiate Execution
            //casting ,Element Operator are Imidiate Execution Operator such >>> ToString() ,ToList()

            var results = Lst.Where(n => n % 2 == 0);//Deferd Execution

            var results1 = Lst.Where(n => n % 2 == 0).ToList();//Imidite Execution
            Lst.Add(2);
            Lst.Add(23);
            Lst.Add(3);
            Lst.Remove(23);

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
            Employee e1 = new Employee { Id=1,Name="belal",Salary=10021,Department="HR"};
            Employee e2 = new Employee { Id=1,Name="belal",Salary=10021,Department="HR"};
            Employee e3 = e2;
            Console.WriteLine(e1 == e2); //reference Comparison return false 

            //To compare between content use  the overreded method >>(Equal())

            Console.WriteLine(e3 == e2); //return true

            var w = "hello";
            var p = "hello";
            Console.WriteLine(p == w); //return true cus string is a reference type & this Comparison between the content

        }
        public class Employee
        {
 
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Salary { get; set; }
            public string Department { get; set; }

        }
    }
}

