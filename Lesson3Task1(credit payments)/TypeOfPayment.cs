using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3Task1_credit_payments_
{
    static class TypeOfPayment
    {
        public static void DifferentiatedPayment(decimal amountOfMoney, int months, double percent)
        {
            decimal basePayment = amountOfMoney / months;
            decimal paymentForimonth;
            decimal sum = 0;
            Console.WriteLine("Вы выбрали дифференцированный  платеж");
            for (int i = 0; i < months; i++)
            {
                paymentForimonth = (basePayment + (amountOfMoney - basePayment * i) * (decimal)(percent / 100 / 12));
                Console.WriteLine($"за {i + 1} месяц вы заплатите {paymentForimonth}");
                sum += paymentForimonth;
            }
            Console.WriteLine($"Общая сумма кредита = {sum}");

        }
        public static void AnnuityPayment(decimal amountOfMoney, int months, double percent)
        {
            decimal paymentForimonth;
            double onetwelfth = (percent / 100 / 12);
            decimal sum = 0;
            Console.WriteLine("Вы выбрали аннуитентный платеж");
            for (int i = 0; i < months; i++)
            {
                paymentForimonth = (amountOfMoney * (decimal)(onetwelfth + onetwelfth / (Math.Pow((1 + onetwelfth), months) - 1)));
                Console.WriteLine($"за {i + 1} месяц вы заплатите {paymentForimonth}");
                sum += paymentForimonth;
            }
            Console.WriteLine($"Общая сумма кредита = {sum}");

        }
    }
}
