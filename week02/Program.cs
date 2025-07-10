using System;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();

        Job1._company = "microsoft";
        Job1._jobTitle = "Software Engineer";
        Job1._startYear = 2020;
        Job1._endYear = 2021;

        Job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        job2.Display();

        Resume resume = new Resume();
        resume._name = "Madut Bol";

       
        
       
        resume._jobs.Add(Job1);
        resume._jobs.Add(job2);



        resume.Display();
    }
}