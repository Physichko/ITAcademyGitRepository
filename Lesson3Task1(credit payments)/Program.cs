using System;

namespace Lesson3Task1_credit_payments_
{
    class Program
    {
        //Мне просто захотелось вставить делегаты в тернарный оператор и использовать лямбда-метод(правда так как событие типа класса делегата Payment,пришлось вставить ненужные(для функционирования метода) аргументы)
        public delegate void Payment(decimal amountOfMoney, int months, double percent);
        public static event Payment TypeOfCredit;

        static void Main()
        {
            Console.WriteLine("Добро пожаловать в кредитный отдел");
            Console.WriteLine("Какую сумму вы желаете взять?");
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Хорошо, а на какое время(в месяцах)?");
            int months = int.Parse(Console.ReadLine());
            Console.WriteLine("Под какой процент вам будет удобнее?");
            double percent = double.Parse(Console.ReadLine());
            Console.WriteLine("Какой вид платежа вас интересует (введите 1 чтобы выбрать аннуитентный платеж или 2 чтобы выбрать дифференцированный  платеж) ?");
            byte typeOfPayment = byte.Parse(Console.ReadLine());

            Payment differentiatedPayment = new Payment(TypeOfPayment.DifferentiatedPayment);
            Payment annuityPayment = new Payment(TypeOfPayment.AnnuityPayment);

            TypeOfCredit += (typeOfPayment == 1) ? annuityPayment : (typeOfPayment == 2) ? differentiatedPayment : delegate (decimal amountOfMoney, int months, double percent) { Console.WriteLine("Такого вида платежа не существует"); };
            TypeOfCredit?.Invoke(amountOfMoney, months, percent);
        }
    }
}
