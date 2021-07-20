﻿using System; 
using System.Collections.Generic;   
using System.Linq;
using System.Security.Cryptography;

namespace Airport_Challenge
{
    
       class Weather 
    {
        
        public string DayWeather() 
        {   
            Random random = new Random(); 
            string[] weather = {"Sun", "Rain", "Stormy", "Snow", "Sun"};   
            string[] weatherDay = weather.OrderBy(x => random.Next()).ToArray(); 
            return weatherDay[0];  
        }
    }
    class Program
    {    
        public static List<string> item = new List<string>();     

        public static Weather weather = new Weather();   

        public static int capcity = 2; 

        
        public static void Main() 
        {    
            // Weather weather = new Weather();  

            Land_Plan(); 
            Land_Plan();  
            Land_Plan();  
            Hanger(); 
           
        }    

        public static void Hanger()
        {
            Console.WriteLine("Number plans in the Hunger is " + item.Count + ".");  
        }

        public static void Land_Plan() 
        {
            if (item.Count >= capcity ) 
            {
                Console.WriteLine("Sorry Airport is full"); 
            } 
            else if (weather.DayWeather() == "Stormy")
            {
                Console.WriteLine("Sorry Plans can not land due to the bad weather:("); 
            } 
            else
            {
                item.Add("Plan");  
                Console.WriteLine("Plan has Landed."); 
            }
        }  

        public static void TakeOff()
        {
            if (item.Count == 0)
            {
                Console.WriteLine("The airport is empty");
            } 
            else if (weather.DayWeather() == "Stormy") 
            {
                Console.WriteLine("Sorry Plans can not take off due to the bad weather:("); 
            } 
            else 
            {
                item.Remove("Plan");  
                Console.WriteLine("Plan has taken off."); 
            }
        } 
    }
}