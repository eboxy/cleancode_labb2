using System;
using cleancode_labb2.Controllers;
using cleancode_labb2.Models;
using Xunit;
using Moq;
using System.Collections.Generic;

namespace ApiCarPartControllerTest
{
    public class ApiCarPartControllerTest
    {

        [Fact]
        public void GetAllData_AttemptToGetAllData_Success()
        {
            var mock = new Mock<IApiRequestSend<CarPart>>();
            var apiCarPartControllerMock = new ApiCarPartController(mock.Object);

            apiCarPartControllerMock.GetAllData();
            mock.Verify(m => m.GetAllData(), Times.Once);
        }

        [Fact]
        public void GetAllData_AttemptToGetAllItemsFromProductCatalog_Success()
        {
            var mock = new Mock<IApiRequestSend<CarPart>>();
            IEnumerable<CarPart> carParts = new[]
            {
                new CarPart()
                {
                    Id = 1,
                    PartName = "Fiat_Gearbox",
                    PartPrice = 3200,
                    PartCategory = "Transmission",
                    Quantity = 23,
                    Section = "Q3"
                },
                 new CarPart()
                {
                    Id = 2,
                    PartName = "BMW_Muffler",
                    PartPrice = 4200,
                    PartCategory = "Exhaustion",
                    Quantity = 43,
                    Section = "Section-R32"
                },
                   new CarPart()
                {
                    Id = 3,
                    PartName = "Porsche_Windshield",
                    PartPrice = 7800,
                    PartCategory = "View",
                    Quantity = 23,
                    Section = "Section-F34"
                }

            };

            var ApiCarPartControllerMockMock = new ApiCarPartController(mock.Object);
            mock.Setup(m => m.GetAllData()).Returns(carParts);

            var actualObjects = mock.Object.GetAllData();
            var expectedObjects = carParts;

            Assert.Equal(expectedObjects, actualObjects);

        }

        [Fact]
        public void AddProduct_AttemptToAddEntity_Success()
        {
            //Lägg i en kontroll - upprepad kod
            var carPart = FetchCarPart();
            var mock = new Mock<IApiRequestSend<CarPart>>();
            var apiCarPartControllerMock = new ApiCarPartController(mock.Object);

            apiCarPartControllerMock.AddProduct(carPart);
            mock.Verify(m => m.AddEntity(carPart), Times.Once);
        }

        [Fact]
        public void EditProduct_AttemptToModifyEntity_Success()
        {
            //Lägg i en kontroll - upprepad kod
            var carPart = FetchCarPart();
            var mock = new Mock<IApiRequestSend<CarPart>>();
            var apiCarPartControllerMock = new ApiCarPartController(mock.Object);

            apiCarPartControllerMock.EditProduct(carPart.Id, carPart);
            mock.Verify(m => m.ModifyEntity(carPart.Id, carPart), Times.Once);
        }


        [Fact]
        public void DeleteProduct_AttemptToDeleteEntity_Success()
        {
            //Lägg i en kontroll - upprepad kod
            var carPart = FetchCarPart();
            var mock = new Mock<IApiRequestSend<CarPart>>();
            var apiCarPartControllerMock = new ApiCarPartController(mock.Object);

            apiCarPartControllerMock.DeleteProduct(carPart);
            mock.Verify(m => m.DeleteEntity(carPart), Times.Once);
        }





        private CarPart FetchCarPart()
        {
            return new CarPart()
            {
                Id = 4,
                PartName = "Volvo_Clutch",
                PartPrice = 1200,
                PartCategory = "Transmission",
                Quantity = 21,
                Section = "Section-YR1"
            };


        }






    }  //class ends here!!
}  //namespace ends here!!
