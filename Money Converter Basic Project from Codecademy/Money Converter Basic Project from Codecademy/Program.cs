namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.Write("What is the value in cents you are trying to convert into coins? ");
            string valueInput = Console.ReadLine();
            double valueOriginal = Convert.ToDouble(valueInput);
            Console.WriteLine($"We are going to convert {valueOriginal} into coins...");
            int goldvalue = 10;
            int silvervalue = 5;
            double goldCoins = Math.Floor(valueOriginal / goldvalue);
            double valueAfterGold = (valueOriginal % goldvalue);
            double silverCoins = Math.Floor(valueAfterGold / silvervalue);
            double valueAfterSilver = (valueAfterGold % silvervalue);
            Console.WriteLine("The value in cents you entered is worth...");
            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {valueAfterSilver}");
            Console.WriteLine("Enter another value you wish to organize in USD.");
            string dollarInput = Console.ReadLine();
            decimal dollardollabillyall = Convert.ToDecimal(dollarInput);

            Console.WriteLine($"The amount ${dollardollabillyall} USD can be organized into the following denominations.");
            int benjamin = 100;
            int jackson = 20;
            int lincoln = 5;
            int washington = 1;
            decimal quarter = .25m;
            decimal dime = .10m;
            decimal nickel = .05m;
            decimal penny = .01m;

            decimal numbenjamins = Math.Floor(dollardollabillyall / benjamin);
            dollardollabillyall = dollardollabillyall % benjamin;
            Console.WriteLine(dollardollabillyall);
            decimal numjackson = Math.Floor(dollardollabillyall / jackson);
            dollardollabillyall = dollardollabillyall % jackson;

            decimal numlincolns = Math.Floor(dollardollabillyall / lincoln);
            dollardollabillyall = dollardollabillyall % lincoln;

            decimal numwashingtons = Math.Floor(dollardollabillyall / washington);
            dollardollabillyall = dollardollabillyall % washington;

            decimal numquarters = Math.Floor(dollardollabillyall / quarter);
            dollardollabillyall = dollardollabillyall % quarter;
            Console.WriteLine(dollardollabillyall);
            decimal numdimes = Math.Floor(dollardollabillyall / dime);
            dollardollabillyall = dollardollabillyall % dime;

            decimal numnickels = Math.Floor(dollardollabillyall / nickel);
            dollardollabillyall = dollardollabillyall % nickel;

            Console.WriteLine(dollardollabillyall);
            decimal numpennies = Math.Ceiling(dollardollabillyall / penny);

            
            Console.WriteLine($"$100 bills: {numbenjamins}.");
            Console.WriteLine($"$20 bills: {numjackson}.");
            Console.WriteLine($"$5 bills: {numlincolns}.");
            Console.WriteLine($"$1 bills: {numwashingtons}.");
            Console.WriteLine($"Quarters: {numquarters}.");
            Console.WriteLine($"Dimes: {numdimes}.");
            Console.WriteLine($"Nickels: {numnickels}.");
            Console.WriteLine($"Pennies: {numpennies}.");
            Console.WriteLine("This is the most efficient, not the most practical conversion. Thank you :)");


            string RuckyDesc = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(RuckyDesc) && RuckyDesc.Contains("Gay"))
            {
                Console.WriteLine("He is indeed happy!");
            }
            else if (!RuckyDesc.Contains("Gay") && RuckyDesc.Length > 0)
            {
                Console.WriteLine("He is a sad boi :(");
            }
            else
            {
                Console.WriteLine("We don't know whats going on in his head.");
            }

        }
    }
}