namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int facebook = 150;
            int instaGram = 100;
            int reddit = 50;




            for (int i = 0; i < n; i++)
            {
                string webSite = Console.ReadLine();
                if (webSite == "Facebook")
                {
                    salary -= facebook;
                    if (salary <= 0)
                    {
                        Console.WriteLine("You have lost your salary.");
                    }

                }
                else if (webSite == "Instagram")
                {
                    salary -= instaGram;
                    if (salary <= 0)
                    {
                        Console.WriteLine("You have lost your salary.");
                    }
                }
                else if (webSite == "Reddit")
                {

                    salary -= reddit;
                    if (salary <= 0)
                    {
                        Console.WriteLine("You have lost your salary.");

                    }

                }



            }
            if (salary > 0)
            {
                Console.WriteLine($"{salary}");
            }

        }
    }
}
