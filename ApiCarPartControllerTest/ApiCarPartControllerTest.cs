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
        public void ApiCarPartController_TryGetAllDataIfEmpty_Success()
        {
            var mock = new Mock<IApiRequestSend<CarPart>>();
            var apiCarPartControllerMock = new ApiCarPartController(mock.Object);

            apiCarPartControllerMock.GetAllData();
            mock.Verify(m => m.GetAllData(), Times.Once);
        }

        [Fact]
        public void ApiCarPartController_TryGetAllDataFromList_Success()
        {
            var mock = new Mock<IApiRequestSend<CarPart>>();
            IEnumerable<CarPart> products = new[]
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
            mock.Setup(m => m.GetAllData()).Returns(products);

            var actualObjects = mock.Object.GetAllData();
            var expectedObjects = products;

            Assert.Equal(expectedObjects, actualObjects);

        }

        [Fact]
        public void ApiCarPartController_TryAddEntity_Success()
        {
            var product = GetProduct();
            var mock = new Mock<IApiRequestSend<CarPart>>();
            var apiCarPartControllerMock = new ApiCarPartController(mock.Object);

            apiCarPartControllerMock.AddProduct(product);
            mock.Verify(m => m.AddEntity(product), Times.Once);
        }

        [Fact]
        public void ApiCarPartController_TryModifyEntity_Success()
        {
            var product = GetProduct();
            var mock = new Mock<IApiRequestSend<CarPart>>();
            var apiCarPartControllerMock = new ApiCarPartController(mock.Object);

            apiCarPartControllerMock.EditProduct(product.Id, product);
            mock.Verify(m => m.ModifyEntity(product.Id, product), Times.Once);
        }


        [Fact]
        public void ApiCarPartController_TryDeleteEntity_Success()
        {
            var product = GetProduct();
            var mock = new Mock<IApiRequestSend<CarPart>>();
            var apiCarPartControllerMock = new ApiCarPartController(mock.Object);

            apiCarPartControllerMock.DeleteProduct(product);
            mock.Verify(m => m.DeleteEntity(product), Times.Once);
        }





        public CarPart GetProduct()
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
