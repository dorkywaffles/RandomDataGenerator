namespace RandomDataGenerator
{
    public class Phone
    {
        public string Number { get; init; }

        public Phone()
        {
            Number = Format();
        }

        public string Format(char separator = '-')
        {
            Random r = new Random();
            int[] randomNumbers = new int[10];
            string phoneNumber = "";

            for (int i = 0; i < randomNumbers.Length; i++)
                randomNumbers[i] = r.Next(10);

            if (randomNumbers[0] == 0 || randomNumbers[0] == 1)
                randomNumbers[0] = r.Next(2, 10);

            foreach (int i in randomNumbers)
                phoneNumber += i;

            phoneNumber = phoneNumber.Insert(3, separator.ToString()).Insert(7, separator.ToString());

            return phoneNumber;
        }

        public override string ToString()
        {
            return Number;
        }
    }
}