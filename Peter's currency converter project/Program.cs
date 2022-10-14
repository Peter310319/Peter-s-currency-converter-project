namespace Peter_s_currency_converter_project
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Peter's Currency Converter.\nWhat currency do you want to convert to? 1 for GBP, 2 for USD, 3 for Euro");
            var currencyFrom =(Currency)int.Parse(Console.ReadLine());
            Console.WriteLine("How much do you want to convert?");
            var amountToConvert = double.Parse(Console.ReadLine());
            var convertedAmount = CurrencyUtility.Convert(amountToConvert,currencyFrom);
            Console.WriteLine(convertedAmount);
            
        }

    }
    static class CurrencyUtility
    {
        public static double Convert(double amountValue, Currency currency)
        {
            double returnAmount=0;
            if (currency == Currency.GBP)
            {
                returnAmount= amountValue * 0.0020;
            }
            if (currency == Currency.USD)
            {
                returnAmount= amountValue * 0.0023;
            }
            if (currency == Currency.Euro)
            {
                returnAmount= amountValue * 0.0023;
            }
            return returnAmount;
        }

            
           
            
    }
}enum Currency
{
    GBP=1,
    
    USD,

    Euro
}
