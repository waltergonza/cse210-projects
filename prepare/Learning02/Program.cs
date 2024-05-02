using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {

        Job Job1 = new Job();
        Job1._JobTittle =  "Software Engineer";
        Job1._Company = "(Microsoft)";
        Job1._StartYear = 2019;
        Job1._EndYear = 2022;

        Job Job2 = new Job();
        Job2._JobTittle =  "Manager";
        Job2._Company = "(Apple)";
        Job2._StartYear = 2022;
        Job2._EndYear = 2023;


        Resume resume1 = new Resume();
        
        resume1._Name = "Allison Rose";

        resume1._jobs.Add(Job1);
        resume1._jobs.Add(Job2);

        resume1.FinalDisplay();
    

    }
    
}