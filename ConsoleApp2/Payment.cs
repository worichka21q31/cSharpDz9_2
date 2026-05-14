using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public interface Payment
    {
        public static string methodPayment;
        decimal amount { get; set; }

        public string GetmethodPayment();
    }
}
