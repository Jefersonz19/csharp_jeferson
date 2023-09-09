namespace HelloWorld
{

    class Program
    {
        static void Main()
        {
            DateOnly dateConverted = new DateOnly();
            string NameInput;
            string birthdayInput;
            Console.WriteLine("Hello Welcome to Age Calculator!");
            Console.WriteLine("Write your name here: ");
            NameInput = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {NameInput} ");
            Console.WriteLine("Write your birthday (dd/mm/yy): ");
            birthdayInput=Console.ReadLine();
            bool isDateValid=DateOnly.TryParse(birthdayInput,out dateConverted);
            if (isDateValid==false)
            Console.WriteLine("The birthday is invalid, Erronous data input: ");

            var person = new Person{
                Name = NameInput,
                Birthday=dateConverted,
                Age=DateTime.Now.Year - dateConverted.Year
            };

            Console.WriteLine($"Your name {person.Name} ");
            Console.WriteLine($"Your birthday: {person.Birthday}");
            Console.WriteLine($"Your are: {person.Age} years old");

            Console.ReadLine();

        }
    }

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public DateOnly Birthday { get; set; }
    }
}
