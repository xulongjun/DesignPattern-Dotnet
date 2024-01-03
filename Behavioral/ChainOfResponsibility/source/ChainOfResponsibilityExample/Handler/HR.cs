namespace ChainOfResponsibilityExample.Handler
{
    //Concrete Handler 3
    //The following class implement the EmployeeLeaveHandler abstract class and 
    //Provide Implementation for ApplyLeave abstract method
    public class HR : EmployeeLeaveHandler
    {
        // HR can only approve up to 30 days of leave
        private readonly int MAX_LEAVES_CAN_APPROVE = 30;
        public override void ApplyLeave(string EmployeeName, int NumberOfDaysLeave)
        {
            if (NumberOfDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                LastMessage = $"HR Approved {NumberOfDaysLeave} Days Leave for the employee {EmployeeName}";
                Console.WriteLine(LastMessage);
            }
            else
            {
                LastMessage = $"Leave Application Suspended for Employee {EmployeeName}, Please contact HR";
                Console.WriteLine(LastMessage);
            }
        }
    }
}
