using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorEventHandlingApp.Model;

namespace CalculatorEventHandlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.AddCompletion += PrintResult;
            c.AddCompletion += GeneratePdf;
            c.Add(15, 20);
            Console.ReadLine();
        }
        static void PrintResult(Calculator obj)
        {
            Console.WriteLine("Addition of " + obj.X + " and " + obj.Y + " is " + obj.Result);
        }

        static void GeneratePdf(Calculator obj)
        {
            using (FileStream fs = new FileStream(@"D:\\test\\.NET\\AdditionRes.html", FileMode.Create))
            {
                using (StreamWriter st = new StreamWriter(fs, Encoding.UTF8))
                {
                    st.WriteLine("<h1> Addition of " + obj.X + " and " + obj.Y + " is " + obj.Result + "</h1>");
                }     
            }
        }
    }
}
