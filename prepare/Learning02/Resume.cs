using System;
using System.Collections.Generic;


public class Resume
{
    public string _Name;
    public List<Job> _jobs = new List<Job>(); 

    public void FinalDisplay ()
    {
        Console.WriteLine($"Name: {_Name}\nJobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }


}
