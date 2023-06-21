using System;
namespace BankCard
{
    public class BankCard
    {
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public string ExpiryDate { get; set; }
        public string CardholderName { get; set; }
        public string BankName { get; set; }
        public decimal Balance { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            BankCard myCard = new BankCard();

            myCard.CardNumber = "1234 5678 9123 4567";
            myCard.CVV = "123";
            myCard.ExpiryDate = "12/26";
            myCard.CardholderName = "Cooper Joseph";
            myCard.BankName = "ABB";
            myCard.Balance = 5000;
        }
    }
}


