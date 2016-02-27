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
                CFDI F = new CFDI(@"C:\Users\carlos\github\CFDI-CFD_Validator\InvoiceValidator\Dependencies\cfdv32.xsd",
                                  @"C:\Users\carlos\github\CFDI-CFD_Validator\InvoiceValidator\Dependencies\\TimbreFiscalDigital.xsd",
                                  @"C:\Users\carlos\Desktop\ZABE701111KR6CFDI0000009356.xml");

                F.Validate();

                if (F.Messages.Count > 0)
                    foreach (string Message in F.Messages)
                        Console.WriteLine(Message);

                F.Generate();

                Console.WriteLine(F.IsValid);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
