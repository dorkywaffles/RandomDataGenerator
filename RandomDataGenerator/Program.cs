namespace RandomDataGenerator
{
    public class Program
    {
        static List<Person> persons = new List<Person>();

        public static void Main(string[] args)
        {
            var choice = 0;
            do
            {
                DisplayMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                MenuChoice(choice);
                Console.WriteLine("\nHit Enter To Return To The Menu...");
                Console.ReadLine();
                Console.Clear();
            } while (choice != 0);
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("------ MENU ------");
            Console.WriteLine("1) Create A Person");
            Console.WriteLine("2) View All People");
            Console.WriteLine("3) Remove A Person");
            Console.WriteLine("4) View Random Last Name");
            Console.WriteLine("5) View Random SSN");
            Console.WriteLine("6) View Random Phone Number");
            Console.WriteLine("0) Exit");
            Console.WriteLine("------------------");
        }

        public static void MenuChoice(int choice)
        {
            Random random = new Random();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("How Many Person(s) Would You Like To Create?(Enter A Number): ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < amount; i++)
                        persons.Add(new Person());
                    Console.WriteLine($"{amount} Person(s) Created");
                    break;
                case 2:
                    foreach (Person person in persons)
                        Console.WriteLine(person);
                    break;
                case 3:
                    foreach (Person person in persons)
                        Console.WriteLine(person);
                    Console.WriteLine("Which Person Would You Like To Remove?(Enter Number) ");
                    int remove = Convert.ToInt32(Console.ReadLine);
                    persons.RemoveAt(remove - 1);
                    break;
                case 4:
                    // work in progress
                    break;
                case 5:
                    Person rando = persons[random.Next(persons.Count)];
                    Console.WriteLine(rando.SSN);
                    break;
                case 6:
                    // work in progress
                    break;
                case 0:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid Option, Try Again...");
                    break;
            }
        }
    }
}
