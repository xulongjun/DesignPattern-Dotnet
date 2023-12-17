using PrototypeExample.Models;
using PrototypeExample.Prototype;

namespace PrototypeExample.Tests
{
    public class PrototypeExampleUnitTest
    {
        public string ExpectedName { get; set; } = "XU";
        public string ExpectedAddress { get; set; } = "FirstAddress";

        [Theory]
        [InlineData("Permanent")]
        [InlineData("Temporary")]
        public void WhenTestingPermanentEmployee_ThenShowRightShallowCopyBehavior(string typeEmployee)
        {
            // Arrange
            Employee? emp1 = CreateEmployeeByType(typeEmployee);
            if (emp1 is null) return;

            // Act
            Employee emp2 = emp1.GetClone();
            emp2.Name = "Test";
            emp2.EmpAddress.address = "SecondeAddress";

            //Assert
            Assert.Equal(ExpectedName, emp1.Name);
            Assert.NotEqual(ExpectedAddress, emp2.EmpAddress.address);
            Assert.NotEqual(ExpectedAddress, emp1.EmpAddress.address);
        }

        private Employee? CreateEmployeeByType(string typeEmployee)
        {
            switch (typeEmployee)
            {
                case "Permanent":
                    int expectedSalary = 100000;
                    return new PermanentEmployee()
                    {
                        Name = ExpectedName,
                        EmpAddress = new Address() { address = ExpectedAddress },
                        Salary = expectedSalary
                    };
                case "Temporary":
                    int expectedFixedAmount = 1000000;
                    return new TemporaryEmployee()
                    {
                        Name = ExpectedName,
                        EmpAddress = new Address() { address = ExpectedAddress },
                        FixedAmount = expectedFixedAmount
                    };
                default:
                    return null;
            }
        }

        [Fact]
        public void WhenTestingDeepCloneEmployee_ThenShowRightDeepCopyBehavior()
        {
            // Arrange
            DeepCloneEmployee emp1 = new()
            {
                Name = ExpectedName,
                EmpAddress = new DeepAddress() { address = ExpectedAddress },
            };

            // Act
            DeepCloneEmployee emp2 = emp1.GetClone();
            emp2.Name = "Test";
            emp2.EmpAddress.address = "SecondeAddress";

            //Assert
            Assert.Equal(ExpectedName, emp1.Name);
            Assert.NotEqual(ExpectedAddress, emp2.EmpAddress.address);
            Assert.Equal(ExpectedAddress, emp1.EmpAddress.address);
        }
    }
}