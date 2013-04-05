Scheduler
=========

A very simple library for Schedule recurring operations in C# in Specific Intervals.

How to use?

Create any class that inherits Job, override the method PerformRunJob ando whatever you want to do,
for example, send email, create a file, check some log, etc.
The execution interval must be specified in minutes.
Just call the ScheduleTasks Method.

            Scheduler.ScheduleTasks(new JobTest(), 1);
          
