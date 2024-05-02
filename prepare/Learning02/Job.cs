using System;


public class Job
{
    public string _JobTittle;
    public string _Company;
    public int _StartYear;
    public int _EndYear;
    
    public void Display()
    {
        Console.WriteLine($"{_JobTittle} {_Company} {_StartYear}-{_EndYear}");

    }
}

    
    
