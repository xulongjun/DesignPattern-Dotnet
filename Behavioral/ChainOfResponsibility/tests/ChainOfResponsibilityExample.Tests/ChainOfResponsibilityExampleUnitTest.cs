using ChainOfResponsibilityExample.Handler;

namespace ChainOfResponsibilityExample.Tests
{
    public class ChainOfResponsibilityExampleUnitTest
    {
        // Arrange
        private readonly TeamLeader teamLeader = new();
        private readonly ProjectLeader projectLeader = new();
        private readonly HR hr = new();

        public ChainOfResponsibilityExampleUnitTest()
        {
            teamLeader.SetNextSupervisor(projectLeader);
            projectLeader.SetNextSupervisor(hr);
        }

        [Theory]
        [InlineData("John Doe", 10, typeof(TeamLeader), "TeamLeader Approved 10 Days Leave for the Employee John Doe")]
        [InlineData("John Doe", 15, typeof(ProjectLeader), "ProjectLeader Approved 15 Days Leave for the Employee John Doe")]
        [InlineData("John Doe", 25, typeof(HR), "HR Approved 25 Days Leave for the employee John Doe")]
        [InlineData("John Doe", 35, typeof(HR), "Leave Application Suspended for Employee John Doe, Please contact HR")] // HR should approve
        public void WhenApplyLeave_ThenShouldUseCorrectHandler(string employeeName, int leaveDays, Type expectedHandlerType, string expectedMessage)
        {
            // Act
            teamLeader.ApplyLeave(employeeName, leaveDays);

            // Assert
            EmployeeLeaveHandler handlerUsed = leaveDays <= 10 ? teamLeader :
                                               leaveDays <= 20 ? projectLeader : hr;
            _ = leaveDays <= 10 ? teamLeader.LastMessage :
                                   leaveDays <= 20 ? projectLeader.LastMessage : hr.LastMessage;

            Assert.IsType(expectedHandlerType, handlerUsed);
            Assert.Equal(expectedMessage, handlerUsed.LastMessage);
        }
    }
}