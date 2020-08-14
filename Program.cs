using System;

namespace Puzzles
{
    class Program
    {
                //Random Array 
        //Create a function called RandomArray() that returns an integer array 
        //Place 10 random integer values between 5-25 into the array 
        //Print the min and max values of the array 
        //Print the sum of all the values 
        static int[] RandomArray() 
        { 
            var rand = new Random(); 
            var randArr = new int[10]; 
            for(int i=0;i<10;i++) 
            { 
                randArr[i]= rand.Next(5,25); 
            } 
            int min = randArr[0]; 
            int max = randArr[0];; 
            int sum = 0; 
            for(int i=0;i<randArr.Length;i++) 
            { 
                if (min>randArr[i]) 
                { 
                    min=randArr[i]; 
                } 
                if (max<randArr[i]) 
                { 
                    max=randArr[i]; 
                } 
                    sum=sum+randArr[i]; 
            } 
            Console.WriteLine("Max: "+max); 
            Console.WriteLine("Min: "+min); 
            Console.WriteLine("Sum: "+sum); 
            return randArr; 
        } 

                // Coin Flip 
        //Create a function called TossCoin() that returns a string 

        //Have the function print "Tossing a Coin!" 
        //Randomize a coin toss with a result signaling either side of the coin 
        //Have the function print either "Heads" or "Tails" 
        //Finally, return the result 
        //Create another function called TossMultipleCoins(int num) that returns a Double 

        //Have the function call the tossCoin function multiple times based on num value 
        //Have the function return a Double that reflects the ratio of head toss to total toss 
        static string Tosscoin() 
        {
            Console.WriteLine("Tossing a Coin!");
            var rand = new Random();
            int num = rand.Next(0,2);
            if (num ==1) 
            {
                Console.WriteLine("Heads");
                return "Heads";
            }
            else
            {
                Console.WriteLine("Tails");
                return "Tails";
            }
        }

        static double TossMultipleCoins(int num)
        {
            double heads = 0;
            double tails = 0;
            for (int i=num;i>0;i--)
            {
                var coin = Tosscoin();
                if (coin=="Heads")
                {
                    heads++;
                }
                if (coin=="Tails")
                {
                    tails++;
                }
            }
            double ratio=(heads/num); 
            Console.WriteLine("Ratio: "+ ratio);
            return ratio;
        }
        //         Names
        // Build a function Names that returns a list of strings.  In this function:

        // Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
        // Shuffle the list and print the values in the new order
        // Return a list that only includes names longer than 5 characters
        static string[] Names()
        {
            
        }


        static void Main(string[] args)
        {
            var array=RandomArray(); 
            foreach(int item in array) 
            { 
                Console.Write(item+", "); 
            }
            Tosscoin();
            TossMultipleCoins(10);
        }
    }
}
