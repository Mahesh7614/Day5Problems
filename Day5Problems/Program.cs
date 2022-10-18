namespace Day5Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Flip Coin and print percentage of Heads and Tails
            var fl = UserInputForFlip();
            FlipCoinPercentage coin = new FlipCoinPercentage(fl.Times);
            coin.getPercentageOfFlipCion();

            //Leap Year
            var l1 = YearInput();
            LeapYear Year = new LeapYear(l1.year);
            Year.toCheckLeapYear();

            // Power of 2
            var p = UserInputPowerOf2();
            PowerOf2 power = new PowerOf2(p.N);
            power.getPowerOf2();

            //Harmonic Number
            var hr = UserInputForHarmonicSeries();
            HarmonicNumber Harmonic = new HarmonicNumber(hr.n);
            Harmonic.harmonicSeries();

            //Factors
            var ft = userInputPrimeFactorNumber();
            PrimeFactorsOfNumber factor = new PrimeFactorsOfNumber(ft.Number);
            factor.PrimeFactors();

            //Compute Quotient and Remainder
            var cal = UserInputForDivision();
            QuotientNdRemainder Qr = new QuotientNdRemainder(cal.dividend,cal.divisor);
            Qr.Calculation();

            //Swap Two Numbers
            var sp = UserInputNumbers();
            SwapTwoNumbers swap = new SwapTwoNumbers(sp.Number1, sp.Number2);
            swap.SwappingOfTwoNumbers();

            //Check Whether a Number is Even or Odd
            var Eo = UserInputNum();
            EvenOrOdd evenOrOdd = new EvenOrOdd(Eo.Number);
            evenOrOdd.checkEvenOdd();

            //Check Whether an Alphabet is Vowel or Consonant
            var vc = UserInputAlphabet();
            VowelOrConsonent vowelOrConsonent = new VowelOrConsonent(vc.Alphabet);
            vowelOrConsonent.CheckVowelOrConsonent();

            //Find the Largest Among Three Numbers
            var lr = UserInputForLargestNum();
            LargestNumberAmongUs largest = new LargestNumberAmongUs(lr.Num1,lr.Num2,lr.Num3);
            largest.CalculateLargestNumber();


        }
        //Flip Coin and print percentage of Heads and Tails
        public static FlipCoinPercentage UserInputForFlip()
        {
            Console.WriteLine("Enter How Many Times You Have to Flip a Coin : ");
            int C = Convert.ToInt32(Console.ReadLine());

            return new FlipCoinPercentage(C)
            {
                Times = C
            };
        }
        //Leap Year
        public static LeapYear YearInput()
        {
            Console.WriteLine("Enter the Year to Check Whether Leap Year or Not : ");
            int yeartoread = Convert.ToInt32(Console.ReadLine());

            return new LeapYear(yeartoread)
            {
                year = yeartoread
            };
        }
        // Power of 2
        public static PowerOf2 UserInputPowerOf2()
        {
            Console.WriteLine("Enter the Index of 2 : ");
            int Power = Convert.ToInt32(Console.ReadLine());

            return new PowerOf2(Power)
            {
                N = Power
            };
        }
        //Harmonic Number
        public static HarmonicNumber UserInputForHarmonicSeries()
        {
            Console.WriteLine("Enter Number : ");
            int H = Convert.ToInt32(Console.ReadLine());

            return new HarmonicNumber(H)
            {
                n = H
            };
        }
        //Factors
        public static PrimeFactorsOfNumber UserInputPrimeFactorNumber()
        {
            Console.WriteLine("Enter the Number For Prime Factor : ");
            int F = Convert.ToInt32(Console.ReadLine());

            return new PrimeFactorsOfNumber(F)
            {
                Number = F
            };
        }
        //Compute Quotient and Remainder
        public static QuotientNdRemainder UserInputForDivision()
        {
            Console.WriteLine("Enter Divident : ");
            int Di = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor : ");
            int Dv = Convert.ToInt32(Console.ReadLine());

            return new QuotientNdRemainder(Di,Dv)
            {
                dividend = Di,
                divisor = Dv
            };
        }
        //Swap Two Numbers
        public static SwapTwoNumbers UserInputNumbers()
        {
            Console.WriteLine("Enter Number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            return new SwapTwoNumbers(num1,num2)
            {
                Number1 = num1,
                Number2 = num2
            };
        }
        //Check Whether a Number is Even or Odd
        public static EvenOrOdd UserInputNum()
        {
            Console.WriteLine("Enter Number to Check Even or Odd : ");
            int num = Convert.ToInt32(Console.ReadLine());

            return new EvenOrOdd(num)
            {
                    Number = num
            };
        }
        //Check Whether an Alphabet is Vowel or Consonant
        public static VowelOrConsonent UserInputAlphabet()
        {
            Console.WriteLine("Enter Alphabet to Check Vowel or Consonant : ");
            char alpha = Convert.ToChar(Console.ReadLine().ToLower());

            return new VowelOrConsonent(alpha)
            {
                Alphabet = alpha
            };
        }
        // Find the Largest Among Three Numbers
        public static LargestNumberAmongUs UserInputForLargestNum()
        {
            Console.WriteLine("To Find Largest Number Enter Three Numbers Below");
            Console.WriteLine("Enter Number 1 : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 3 : ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            return new LargestNumberAmongUs(n1,n2,n3)
            {
                Num1 = n1,
                Num2 = n2,
                Num3 = n3
            };
        }
    }
}