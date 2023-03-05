namespace ShowListing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Audience[] audience = new Audience[5];
            audience[0] = new Audience("buggernut", new DateTime(2002, 4, 10), 'M', "Filipino", "salemmichaelcyegmail.com", "Gwapoko_123");

            Console.WriteLine(User.IsValidEmail(audience[0].Email));
            Console.WriteLine(audience[0].MaskedPassword());
        }

    }
}