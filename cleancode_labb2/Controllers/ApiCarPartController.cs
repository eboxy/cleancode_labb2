using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using cleancode_labb2.Models;
using cleancode_labb2.Controllers;


namespace cleancode_labb2.Controllers
{
    [Produces("application/json")]
    [Route("api/ApiCarPart")]
    public class ApiCarPartController : Controller
    {
        
        private readonly IApiRequestSend<CarPart> ApiRequestSend;
        

        public ApiCarPartController(IApiRequestSend<CarPart> apiRequestSend) 
        {
           ApiRequestSend = apiRequestSend;
            
        }


        public void AddProduct(CarPart product)
        {
            ApiRequestSend.AddEntity(product);
        }


        public void EditProduct(int id, CarPart product)
        {
            ApiRequestSend.ModifyEntity(id, product);
        }


        public void DeleteProduct(CarPart product)
        {
            ApiRequestSend.DeleteEntity(product);
        }


        public void GetAllData() => ApiRequestSend.GetAllData();

    }
}