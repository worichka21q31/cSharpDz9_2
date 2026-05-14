using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public struct NonCash : Payment
    {
        public static string methodPayment = "Безнал";
        public decimal amount { get; set; }
        public string idCard { get; set; }
        public string dateIssue { get; set; }
        public string fio { get; set; }
        public int codeCVC { get; set; }

        public string GetmethodPayment()
        {
            return methodPayment;
        }

    }
}
