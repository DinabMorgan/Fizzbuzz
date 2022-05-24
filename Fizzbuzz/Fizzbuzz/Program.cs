// See https://aka.ms/new-console-template for more information


Console.WriteLine(" Lets play FizzBuzz!");
int count = 0;

while (count <= 100) { 
    

       if (count % 15==0) 
        
    {
        Console.WriteLine("FizzBuzz");

    }
    else if (count %5 == 0)
    {
        Console.WriteLine("BUZZ!!");
    }
    else if (count % 3 == 0)
    { 
    Console.WriteLine("FiZZ");
    } 
      else
    {
        Console.WriteLine(count);
    }
       count++;
   }
