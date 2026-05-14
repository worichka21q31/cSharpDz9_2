using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ConsoleApp2
{
    public struct Cash : Payment
    {
        public static string methodPayment = "Наличка";
        public decimal amount { get; set; }
        public decimal сhange { get; set; }
        public string GetmethodPayment()
        {
            return methodPayment;
        }
    }
}
