/* 
Author: Maylee Portales Picazo
Enhancement: Added the GetPlayerLevel() method in the GoalManager class to show to the user where level they are according to their earned points; added a "|" delimiter so that the program cannot be broken if the user type a "," while describing their goal. 

*/ 

using System;

class Program
{
    static void Main(string[] args)
    {
       GoalManager goalManager = new GoalManager();
       goalManager.Start();
    }
}