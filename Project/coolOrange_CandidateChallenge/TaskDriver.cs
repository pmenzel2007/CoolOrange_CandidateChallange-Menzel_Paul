using System;
using System.Collections.Generic;

namespace coolOrange_CandidateChallenge
{
    internal class TaskDriver
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();

            Task task1 = new Task("Doing Homework");
            task1.setPriority(Priority.MAX_PRIORITY);
            task1.setComplexity(8);
            tasks.Add(task1);

            Task task2 = new Task("Eating Lunch");
            task2.setPriority(Priority.MIN_PRIORITY);
            task2.setComplexity(2);
            tasks.Add(task2);

            Task task3 = new Task("Programming");
            task3.setPriority(Priority.MED_PRIORITY);
            task3.setComplexity(5);
            tasks.Add(task3);

            Task mostImportant = task1;

            Console.WriteLine("TO-DO\n---------");
            foreach (Task task in tasks)
            {
                Console.WriteLine("Name: {0}, Priority: {1}, Complexity: {2}",
                                  task.getName(), task.getPriority(), task.getComplexity());
                if (task.getPriority() > mostImportant.getPriority())
                {
                    mostImportant = task;
                }
            }
            Console.WriteLine("{0} is one of the most important tasks", mostImportant.getName());
        }
    }
}
