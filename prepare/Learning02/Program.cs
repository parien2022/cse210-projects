using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Sofware Engineer";
        job1._company = "Apple";
        job1._startYear = 2022;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Back-end Engineer";
        job2._company = "Microsoft";
        job2._startYear = 2019;
        job2._endYear = 2021;


        Resume jobs = new Resume();
        jobs._personName = "Agustin Pariente";
        jobs._jobList.Add(job1);
        jobs._jobList.Add(job2);
        jobs.Display();
        
    }


}