using InvoiceValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //CFDI F = new CFDI(@"C:\Users\carlos\Desktop\ZABE701111KR6CFDI0000009356.xml");
                //CFDI F = new CFDI(@"C:\Users\carlos\Desktop\mala.xml");
                CFDI F = new CFDI(@"C:\Users\carlos\Desktop\EjemploAddenda.XML");

                F.InitialzeValidation();

                if (F.Messages != null && F.Messages.Count > 0)
                    foreach (string Message in F.Messages)
                        Console.WriteLine(Message);

                if (F.IsValid)
                    F.GenerateObj();
                else
                    Console.WriteLine("No es válido el CFDI");

                Console.WriteLine(F.IsValid);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
