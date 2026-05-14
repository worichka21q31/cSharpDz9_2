using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Purchase<T> where T : struct, Payment
    {
        public long numPhone;
        public T paymentMethod;
        decimal summ;
        public decimal purchaseAmount { get; set; }

        public Purchase(T paymentMethod, long numPhone, decimal summ)
        {
            this.paymentMethod = paymentMethod;
            this.numPhone = numPhone;
            this.summ = summ;
            this.purchaseAmount = summ; // можно синхронизировать со свойством
        }

        public string Info()
        {
            string additionalInfo = "";

            if (paymentMethod is Cash cash)
            {
                additionalInfo = $", Сдача: {cash.сhange}";
            }
            else if (paymentMethod is NonCash nonCash)
            {
                additionalInfo = $", Номер карты: {nonCash.idCard}";
                additionalInfo += $", Номер карты: {nonCash.idCard}";
            }

            return $"Номер телефона: {numPhone}\n" +
                   $"Сумма покупки: {summ}\n" +
                   $"Способ оплаты: {paymentMethod.GetmethodPayment()}{additionalInfo}\n";
        }
    }
}
