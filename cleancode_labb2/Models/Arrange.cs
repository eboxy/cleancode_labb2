using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cleancode_labb2.Models;
using cleancode_labb2.Controllers;
using Moq;

namespace cleancode_labb2.Models
{
    public class Arrange
    {
        private CarPart carPart;
        private Mock<IApiRequestSend<CarPart>> mocka = new Mock<IApiRequestSend<CarPart>>();
        private ApiCarPartController apiCarPartController;

        public CarPart CarPart { get { return carPart; } set { carPart = value; } }

        public Mock<IApiRequestSend<CarPart>> Mocka { get { return mocka; } set { mocka = value; } }


        //Modernt skräp :-P
        //public Mock<IApiRequestSend<CarPart>> Mocka { get; set; } = new Mock<IApiRequestSend<CarPart>>();

        public ApiCarPartController ApiCarPartController { get { return apiCarPartController; }
               set {apiCarPartController = value; } }
    }


}

