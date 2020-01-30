using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// big integer lives in here
using System.Numerics;
// StringBuilder lives in here!
//using System.Text;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalVarDeclarations();
            Console.WriteLine();
            NewingDataTypes();
            Console.WriteLine();
            ObjectFunctionality();
            Console.WriteLine();
            DataTypeFunctionality();
            Console.WriteLine();
            CharFunctionality();
            Console.WriteLine();
            ParseFromStrings();
            Console.WriteLine();
            ParseFromStringsWithTryParse();
            Console.WriteLine();
            UseDateAndTimes();
            Console.WriteLine();
            UseBigInteger();
            Console.WriteLine();
            DigitSeparators();
            Console.WriteLine();
            BinaryLiterals();
            Console.WriteLine();
            BasicStringFunctionality();
            Console.WriteLine();
            StringConcatenation();
            Console.WriteLine();
            EscapeChars();
            Console.WriteLine();
            StringEquality();
            Console.WriteLine();
            StringsAreImmutable();

            Console.WriteLine();
            FunWithStringBuilder();
            Console.WriteLine();
            StringInterpolation();
            Console.ReadLine();

        }

        static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations:");
            // Local variables are declared as so:
            // dataType varName
            // or dataType varName = intitialValue;
            int myInt = 0;

            // or you can declare on two lines..
            string myString;
            myString = "This is my character data";


            // or more than one (of the same type)
            // 3 bools here
            bool b1 = true, b2 = false, b3 = true;

            // Using System.Boolean to declare a bool
            System.Boolean b4 = false;

            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",
                myInt, myString, b1, b2, b3, b4);
            Console.WriteLine();
        }

        static void DefaultDeclarations()
        {
            Console.WriteLine("=> Default Declarations:");
            int myInt = default;
        }

        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables:");
            bool b = new bool();
            int i = new int();
            double d = new double();
            DateTime dt = new DateTime();
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }

        static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Fucntionality");

            // a C# int is really a shorthand for System.Int32,
            // which inherits the following members from System.Object
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
        }

        static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type functionality");

            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}",
                double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}",
                double.NegativeInfinity);
            Console.WriteLine();

            // bool data type members
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
        }


        static void CharFunctionality()
        {
            Console.WriteLine("=> char type functionality");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello there', at 5): {0}", char.IsWhiteSpace("Hello There!!", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello there', at 6): {0}", char.IsWhiteSpace("Hello There!!", 6));
            Console.WriteLine("char.isPunctuation('?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }
            

        static void ParseFromStrings()
        {
            Console.WriteLine("=>>> Data type parsing");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);
            double d = double.Parse("99.884");
            Console.WriteLine("Value of d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
            char c = Char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);
            Console.WriteLine();
        }

        static void ParseFromStringsWithTryParse()
        {
            Console.WriteLine("--->> Data type parsing with TryParse:");
            if (bool.TryParse("True", out bool b))
            {
                Console.WriteLine("Value of b: {0}", b);
            }
            string value = "Hello";
            if (double.TryParse(value, out double d))
            {
                Console.WriteLine("Value of d: {0}", d);
            }
            else
            {
                Console.WriteLine("Failed to convert the input ({0}) to a double value", value);
            }
            Console.WriteLine();
        }

        static void UseDateAndTimes()
        {
            Console.WriteLine("====>>> Date and times for the beginner");

            // This constructor take (year, month, day)
            DateTime dt = new DateTime(2015, 10, 17);

            // What day of the month is thissss?
            Console.WriteLine("the day of {0} is totally {1}", dt.Date, dt.DayOfWeek);

            // Month is now become December
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings : {0}", dt.IsDaylightSavingTime());

            // This consctuctor takes (hours, minutes, seconds)
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);

            // Subtracting 15 minutes from the current TimeSpan
            // and printing the results
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
            
        }

        static void UseBigInteger()
        {
            Console.WriteLine("=====>>>>> Using BigInteger");
            BigInteger biggy = BigInteger.Parse("9999999999999999999999999999999999");
            Console.WriteLine("value of biggy is : {0}", biggy);
            Console.WriteLine("but is biggy an even value?: {0}", biggy.IsEven);
            Console.WriteLine("or is it a power of two?: {0}", biggy.IsPowerOfTwo);
            BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("66666666666666666666666666666"));
            Console.WriteLine("Value of reallyBig is {0}", reallyBig);
        }


        static void DigitSeparators()
        {
            Console.WriteLine("----> using digit separators");
            Console.Write("Integer:");
            Console.WriteLine(123_456);
            Console.Write("Long:");
            Console.WriteLine(1234_345_566L);
            Console.Write("Float");
            Console.WriteLine(123_456.1234F);
            Console.Write("Double");
            Console.WriteLine(123_456.12);
            Console.Write("Decimal:");
            Console.WriteLine(123_456.12M);

        }

        static void BinaryLiterals()
        {
            Console.WriteLine("=====>> using binary literals");
            Console.WriteLine("Sixteen: {0}", 0b0001_0000);
            Console.WriteLine("Thirty two: {0}", 0b0010_0000);
            Console.WriteLine("Sizty four: {0}", 0b0100_0000);
        }

        static void BasicStringFunctionality()
        {
            string firstName = "Freddy";
            Console.WriteLine("value of firstname: {0}", firstName);
            Console.WriteLine("firstname has {0} characters", firstName.Length);
            Console.WriteLine("firstname in uppercase {0} ", firstName.ToUpper());
            Console.WriteLine("firstname in lowercase {0} ", firstName.ToLower());
            Console.WriteLine("firstname has {0} characters", firstName.Length);
            Console.WriteLine("firstname contains the letter 'y'? {0} ", firstName.Contains("y"));
            Console.WriteLine("firstname after replace: {0} ", firstName.Replace("dy", "zinga"));
            Console.WriteLine();
        }


        static void StringConcatenation()
        {
            Console.WriteLine("--->> concatenating");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (pTP)";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine();
        }


        static void EscapeChars()
        {
            Console.WriteLine("-----> escape chars here");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone loves \"Hellow World\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");
            // four blank lines and another beep :)
            Console.WriteLine("All finished. \n\n\n\a ");
            Console.WriteLine();
        }


        static void StringEquality()
        {
            Console.WriteLine("--> string equality here");
            string s1 = "Hello!";
            string s2 = "Yo!!!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            // testing these strings for equality
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo!!!.Equals(s2): {0}", "Yo!!!".Equals(s2));
            Console.WriteLine();

        }

        static void StringsAreImmutable()
        {
            // set initial string value
            string s1 = "This is my striiiing";
            Console.WriteLine("s1 = {0}", s1);

            // Uppercsae s1?
            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);

            // Nope! s1 is in the same format!!
            Console.WriteLine("s1 = {0}", s1);
        }


        static void FunWithStringBuilder()
        {
            Console.WriteLine("---->> using StringBuilder");
            StringBuilder sb = new StringBuilder("**** fun gamez ****");
            sb.Append("\n");
            sb.AppendLine("Half-life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", " Invisible War (meh)");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars", sb.Length);
            Console.WriteLine();

        }

        static void StringInterpolation()
        {
            // some local variables we will plug in our loarger string
            int age = 4;
            string name = "Soren";

            // using curly bracket synntax yuck
            string greeting = string.Format("Hello {0} you are {1} years old", name.ToLower(), age);

            // using string interpolation yay
            string greeting2 = $"Hello {name.ToUpper()} you are {age += 1} years old";

            Console.WriteLine(greeting);
            Console.WriteLine(greeting2);
        }


        static void
    }
}
