using System;

namespace _02_Variables
{
    internal class Lecture
    {
        int age = 15;//This is a variable of type integer
        public static void Main(string[] args)
        {
            int age = 20; //New value is assigned.
            Console.WriteLine(age);//Output will be 20 as the variable is being called.
        }
        //if a value is not assigned a default value will be assigned. For example with int, the default value will be 0.
        //Variables are still scoped in C#. If they are in the method... I'm assuming public static void Main(string[] args) then can only work within the method just like a function. If declared outside of the methods they can be used in multiple methods.

        //static
        //{
         //   int iAmANumber = 5;
       // }
        //Type Name Data

        //int holds a number
        //float pi = 3.1425
        //Type Name Data
        //bool isGPSEnabled = true

        //The first word is the data type. It must be indicated prior to declaring a variable.
        //Float used to store numbers with decimal points.
        //bool is used to store true or false values.

        //string... "names"
        //char stores characters such as @. Ex. char at = '@'
    }
}
