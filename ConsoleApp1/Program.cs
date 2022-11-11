using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class book
    {
        public string Name
        {get; set;}
        public string Price
        {get; set;}
        public string Rprice
        {get; set;}
        public book ()
        {
            Name = "dwdwdwdd";
            Price = "1313131";
            Rprice = "14414";
            Console.WriteLine ("Book name is "+Name);
            Console.WriteLine ("Book price is "+Price);
            Console.WriteLine ("Book rent price for a day is "+Rprice);
        }
        public book (int id)
        {
            Name = "dwdwdwdd";
            Price = "1313131";
            Rprice = "14414";
            Console.WriteLine ("Book ID is "+id);
            Console.WriteLine ("Book name is "+Name);
            Console.WriteLine ("Book price is "+Price);
            Console.WriteLine ("Book rent price for a day is "+Rprice);
        }
    }
    public class category : book
    {
        private string Category1
        {get; set;}
        private string Subcategory
        {get; set;}
        public string Nvol
        {get; set;}
         public category () : base()
        {
            Category1 = "qwdfwqq";
            Subcategory = "qwdwqdwq";
            Nvol = "131345";
            Console.WriteLine ("Book category is "+Category1);
            Console.WriteLine ("Book subcategory is "+Subcategory);
            Console.WriteLine ("The Book has "+Nvol+" volumes for "+Price+" each");            
        }
        public category (int id) : base(id)
        {
            Category1 = "qwdfwqq";
            Subcategory = "qwdwqdwq";
            Nvol = "131345";
            Console.WriteLine ("Book category is "+Category1);
            Console.WriteLine ("Book subcategory is "+Subcategory);
            Console.WriteLine ("The Book has "+Nvol+" volumes for "+Price+" each");            
        }
    }
    sealed public class customer
    {
        public string Name
        {get; set;}
        public string Age
        {get; set;}
        public string Type
        {get; set;}
        public customer ()
        {
            Name = "qwdfwqq";
            Age = "qwdwqdwq";
            Type = "131345";
            Console.WriteLine ("customer name is "+Name);
            Console.WriteLine ("customer age is "+Age);
            Console.WriteLine ("customer type is "+Type);            
        }
        public customer (int id)
        {
            Name = "qwdfwqq";
            Age = "qwdwqdwq";
            Type = "131345";
            Console.WriteLine("customer ID is"+id);
            Console.WriteLine ("customer name is "+Name);
            Console.WriteLine ("customer age is "+Age);
            Console.WriteLine ("customer type is "+Type);             
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            category bok = new category();
            category bok1 = new category(1);
            customer co = new customer();
            customer co1 = new customer(1);
        }
    }
}
