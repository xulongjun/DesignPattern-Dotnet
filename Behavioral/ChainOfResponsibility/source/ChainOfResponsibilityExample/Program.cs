using ChainOfResponsibilityExample.Handler;

namespace ChainOfResponsibilityExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TeamLeader teamLeader = new();
            ProjectLeader projectLeader = new();
            HR hr = new();
            teamLeader.SetNextSupervisor(projectLeader);
            projectLeader.SetNextSupervisor(hr);
            teamLeader.ApplyLeave("Anurag", 9);
            Console.WriteLine();
            teamLeader.ApplyLeave("Pranaya", 18);
            Console.WriteLine();
            teamLeader.ApplyLeave("Priyanka", 30);
            Console.WriteLine();
            teamLeader.ApplyLeave("Ramesh", 50);
        }
    }
}
