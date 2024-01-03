using Vehicle.Cars;

namespace Vehicle
{
    namespace Cars
    {
        public struct Car
        {
            public string Name { get; set; }

            public static void SayHello() { }
        }
    }
}

namespace TeamsLektionEtt
{
    public class Person
    {
        public string Name { get; set; }
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.age = age;
        }

        public void Print()
        {
            Console.WriteLine(this.Name);
        }
    }

    class Program
    {
        static string? PrintHello(string name)
        {
            Car.SayHello();
            if (name == "Hulk")
            {
                return null;
            }

            return "Hello " + name;
        }

        static void Main(string[] args)
        {
            // Namngivning
            // Syntax
            // Kommentarer

            /*
            hej
            då
            */

            // Datatyper
            // byte, short, int, long
            // -127 till 127
            // -34000 till 34000
            // float, double, decimal
            // char a, 4, -
            // string, object

            // Variabler
            int num = 3;
            string name = "Ironman";

            Console.WriteLine(num);
            // Type casting
            double rate = 4.0;
            int someValue = 4 + (int)rate;

            Console.WriteLine(someValue);

            // Operatörer
            int a = 3 + 4;
            int b = 7 * 3;

            bool bigger = a > b;

            // Strängar
            string text = $"Hej {name}";
            Console.WriteLine(text);
            string newString = text.Replace("Hej", "Hello");

            Console.WriteLine(newString);

            // Arrayer

            string[] foods = { "Pannkakor", "Hamburgare", "Tacos" };
            Console.WriteLine(foods[2]);

            // Kodblock / scopes
            int g = 3;
            {
                Console.WriteLine(g);
            }

            // Villkorssatser (if, switch)
            if (g > 4 || g == 3)
            {
                Console.WriteLine("Hej från if!");
            }
            else if (true) { }
            else if (true) { }
            else { }

            switch (g)
            {
                case 1:
                    Console.WriteLine(3);
                    break;
                default:
                    Console.WriteLine(3);
                    break;
            }

            // Loopar
            int l = 0;
            while (l < 10)
            {
                l++;
            }

            for (int i = 0; i < 10; i++) { }

            // IEnumerable
            // Iterators
            foreach (string food in foods)
            {
                Console.WriteLine(food);
            }

            // Funktioner / metoder
            string? msg = PrintHello("Ironman");
            if (msg != null)
            {
                Console.WriteLine(msg);
            }

            // Klasser, structs och enums
            Person ironman = new Person("Hulk", 4);
            ironman.Name = "Superman";
            Console.WriteLine(ironman.Name);
            ironman.Print();

            Day day = Day.Saturday;
            switch (day)
            {
                case Day.Monday:
                    break;
                case Day.Tuesday:
                    break;
            }

            // Datastrukturer
            List<Person> people = new List<Person>();
            people.Add(ironman);
            people.Add(new Person("Ironman", 45));

            people.Remove(ironman);
            people.RemoveAt(0);

            for (int i = 0; i < people.Count; i++)
            {
                Person person = people[i];
            }

            foreach (Person person in people) { }

            Dictionary<string, BalanceAndGrade> bankBalances =
                new Dictionary<string, BalanceAndGrade>();
            bankBalances.Add("Ironman", new BalanceAndGrade("VG", 55.0));
            bankBalances.Add("Hulk", new BalanceAndGrade("G", 3.0));

            BalanceAndGrade hulkBalance = bankBalances["Hulk"];
            try
            {
                hulkBalance.SetGrade("hferuihiu");
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine("Wrong input!" + exception.ToString());
                return;
            }
            catch (FormatException exception) { }

            Console.WriteLine("Efter!");
            // Console.WriteLine(hulkBalance.Grade);
            // Console.WriteLine(hulkBalance.Balance);

            // Namespaces
            Car car = new Car();

            // static
            // Exceptions
        }
    }

    public class BalanceAndGrade
    {
        private string grade;
        public double Balance { get; set; }

        public BalanceAndGrade(string grade, double balance)
        {
            this.grade = grade;
            this.Balance = balance;
        }

        public void SetGrade(string grade)
        {
            if (grade != "VG" && grade != "G" && grade != "IG")
            {
                throw new ArgumentException("Grade must be IG, G or VG.");
            }

            throw new CannotJumpWhileInAirException();

            this.grade = grade;
        }

        public string GetGrade()
        {
            return this.grade;
        }
    }

    enum Error
    {
        Overflow,
        WrongInput,
    }

    enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }

    enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }

    public class CannotJumpWhileInAirException : Exception { }
}
