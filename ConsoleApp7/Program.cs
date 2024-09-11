namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
        begin:
            Console.WriteLine("Hello, World! Which is Today name?");
            string Day = Convert.ToString; Day.ToLower(string.Empty); Console.ReadLine();

             
            while (true)
            {
                
                if (Day == "Monday")
                {
                    Console.WriteLine("1st day");
                }
                else if (Day == "Tuesday")
                {
                    Console.WriteLine("2nd day");
                }
                else if (Day == "Wednesday")
                {
                    Console.WriteLine("3rd day");
                }
                else if (Day == "Thursday")
                {
                    Console.WriteLine("4th day");
                }
                else if (Day == "Friday")
                {
                    Console.WriteLine("5th day");
                }
                else if (Day == "Saturday")
                {
                    Console.WriteLine("6th day");
                }
                else if (Day == "Sunday")
                {
                    Console.WriteLine("7th day");
                }
             
            else
            {
                Console.WriteLine("1 Week only is 7 day");
                Thread.Sleep(1000);
                Console.Clear();

            }
                goto begin;
}

       
            
       }
    }
}
