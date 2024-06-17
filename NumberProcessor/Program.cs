class NumberProcessor
{
    public static void Main(string[]args)
    {
        
        int number = Convert.ToInt32(Console.ReadLine());

        string command;
        do
        {
            command = Console.ReadLine();

            switch (command)
            {
                case "Inc":
                    number++;
                    break;
                case "Dec":
                    number--;
                    break;
                case "End":
                    Console.WriteLine(number);
                    break;
                
            }
        } while (command != "End");
    }
}
  

                        

        
    
