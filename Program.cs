using ef_firstproject.Data;

namespace ef_firstproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            using (var context = new PersonDbContext())
            {
                var persons=context.Persons;

                foreach(var person in persons)
                {
                    Console.WriteLine(person.FirstName);
                    Console.ReadKey();
                }
            }
        }
    }
}