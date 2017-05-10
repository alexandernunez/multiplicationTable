using System;

namespace multiplicationTable
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type a integer number");
            int n = int.Parse(Console.ReadLine());

            // Declaring variables to keep track of the position of the number to print in the matrix
            int row;
            int col;

            // Looping and multiplicating each row by each column.                       
            for(row=1;row<=n;row++)
            {
                for(col=1;col<=n;col++){
                    Console.Write(row*col);
                    if(col<n){
                        Console.Write(" ");
                    }
                    if((row*col)<10){
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}