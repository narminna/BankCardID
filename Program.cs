using System;

namespace BankCard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BankCard bankCard = new BankCard("1234 5678 9012 3456", "123", "12/26", "Cooper Joseph", "ABB", 5000m);
            bankCard.Car();

            Console.ReadKey();
        }
    }

    class BankCard
    {
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public string ExpiryDate { get; set; }
        public string CardholderName { get; set; }
        public string BankName { get; set; }
        public decimal Balance { get; set; }

        public BankCard(string cardNumber, string cvv, string expiryDate, string cardholderName, string bankName, decimal balance)
        {
            this.CardNumber = cardNumber;
            this.CVV = cvv;
            this.ExpiryDate = expiryDate;
            this.CardholderName = cardholderName;
            this.BankName = bankName;
            this.Balance = balance;
        }

        public void Car()
        {
            Console.WriteLine("Bank Card Data: " + CardNumber + " " + CVV + " " + ExpiryDate + " " + CardholderName + " " + BankName + " " + Balance);
        }
    }
}
