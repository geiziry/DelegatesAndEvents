using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
        public delegate int WorkPerformedHandler(int hours, WorkType workType);
    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
            WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);

            del1 += del2+del3;

           int finalHours= del1(10, WorkType.GoToMeetings);

            Console.WriteLine(finalHours);


            Console.Read();
        }

        static void DoWork(WorkPerformedHandler del1)
        {
            del1(5, WorkType.GoToMeetings);
        }
        static int WorkPerformed1(int hrs,WorkType WT)
        {
            Console.WriteLine("WorkPerf1 called"+hrs.ToString());
            return hrs + 1;
        }

        static int WorkPerformed2(int hrs, WorkType WT)
        {
            Console.WriteLine("WorkPerf2 called" + hrs.ToString());
            return hrs + 2;

        }
        static int WorkPerformed3(int hrs, WorkType WT)
        {
            Console.WriteLine("WorkPerf3 called" + hrs.ToString());
            return hrs + 3;

        }

    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
