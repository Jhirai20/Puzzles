﻿using System;

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
            int num = rand.Next(0,1);
            Console.WriteLine(num);
            if (num ==0) 
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
            
        }


        static void Main(string[] args)
        {
            var array=RandomArray(); 
            foreach(int item in array) 
            { 
                Console.Write(item+", "); 
            }
            Tosscoin();
        }
    }
}