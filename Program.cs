namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var GuessFavNumber = r.Next(1,50);
            int response = 1;
            
            //EXERCISE 1: Favorite Number
            {
               Console.WriteLine("GuessFavNumber. Between 1 and 50"); 
                response = int.Parse(Console.ReadLine());


                if(response < GuessFavNumber)
                {
                    Console.WriteLine("too low");
                }

                else if(GuessFavNumber > response)
                {
                    Console.WriteLine("too high");
                }
                
                else
                {
                   Console.WriteLine($"great job! you got it.\n The favorite number was {GuessFavNumber}");
                }  
            }
            
            FavSchoolSubject();
            
        }
        
        //EXERCISE 2: Favorite school subject

        public static void  FavSchoolSubject()

        {
            Console.WriteLine("What is your favorite school subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())

            {
                case "science":
                    Console.WriteLine("my favorite school subject!");
                    break;

                case "history":
                    Console.WriteLine("depends on the branch or era.");
                    break;

                case "math":
                    Console.WriteLine("not my strongest subject. I do enjoy math in physics though");
                    break;
                    
                case "Writing":
                    Console.WriteLine("I am terrible at this. 0/10. Do not recommend.");
                    break;
                case "Biology/Anatomy":
                    Console.WriteLine("Absolutely love it! 10/10 so much fun");
                    break;
                default:
                    Console.WriteLine("That's pretty cool! You are smart");
                    break;
            }
        }
        
    }
}
