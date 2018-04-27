using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students;

namespace sharp1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Скільки студентів бажаєте додати?");
            int k = Convert.ToInt32(Console.ReadLine());
              //  Book mn = new Book;
               Student mn = new Student();
        
            // mn[1] = new Student();
            //   mn[2] = new Student();
            //  mn[1].InputStudent();

         //   mn.InputStudent();           
           mn.InputInXml();
             mn.Print1XML();
            mn.GetXML().PrintStudent();
             //   Console.WriteLine(mn[0]);//Виведе масив оцінок які відносяться до девелопера
                // mn[2].InputStudent();
           
            
            //Random rnd = new Random();
            //int randomN = rnd.Next(Int32.MinValue, Int32.MaxValue);
            //Student a = new Student(246);

            //Student b = new Student(123);
            // b.InputStudent();
            //  b.PrintStudent();

           
            //  Console.WriteLine( b.SerMark());

          //  Console.WriteLine(b.ToString());
          //  Console.WriteLine( b.Equals(n));
            Console.ReadKey();
        }
    }

}
    
