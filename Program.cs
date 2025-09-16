namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var guessFavNumber = r.Next(1,50);
            int response = 1;
            
            

            while (response != guessFavNumber)
            {
                Console.WriteLine("guessFavNumber. Between 1 and 50"); 
                response = int.Parse(Console.ReadLine());


                if(response < guessFavNumber)
                {
                    Console.WriteLine("too low");
                }

                else if(guessFavNumber > response)
                {
                    Console.WriteLine("too high");
                }
                
                else
                {
                    Console.WriteLine($"great job! you got it.\n The favorite number was {guessFavNumber}");
                }  
            }
            
        }
        
        
        
    }
}
