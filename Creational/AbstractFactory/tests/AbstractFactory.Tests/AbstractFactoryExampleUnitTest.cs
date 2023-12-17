using AbstractFactoryExample.IAbstractFactory;
using AbstractFactoryExample.IAbstractProductA;
using System.Linq.Expressions;

namespace AbstractFactoryExample.Tests
{
    public class AbstractFactoryExampleUnitTest
    {
        private static IVehicleFactory RegularVehicleFactory => new RegularVehicleFactory();

        private static IVehicleFactory SportsVehicleFactory => new SportsVehicleFactory();

        [Theory]
        [InlineData("RegularBike")]
        [InlineData("SportsBike")]
        [InlineData("RegularCar")]
        [InlineData("SportsCar")]
        public void WhenTestingVehicle_ThenShowVehicleDetail(string typeVehicle)
        {
            // Arrange
            string expectedMessage = $"Fetching {typeVehicle} Details..";
            using StringWriter sw = new();
            Console.SetOut(sw);

            // Act
            VehicleFactoryAct(typeVehicle);

            // Assert
            string resultMessage = sw.ToString().Trim();
            Assert.Equal(expectedMessage, resultMessage);
        }

        private static void VehicleFactoryAct(string typeVehicle)
        {
            switch (typeVehicle)
            {
                case "RegularBike":
                    RegularVehicleFactory.CreateBike().GetDetails();
                    break;
                case "SportsBike":
                    SportsVehicleFactory.CreateBike().GetDetails();
                    break;
                case "RegularCar":
                    RegularVehicleFactory.CreateCar().GetDetails();
                    break;
                case "SportsCar":
                    SportsVehicleFactory.CreateCar().GetDetails();
                    break;
                default:
                    break;
            }
        }
    }
}