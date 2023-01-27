
//using FakeItEasy;
using FieryRestaurent.Dal.DataBase;
using FieryRestaurent.Entity.DtoModels;
using FieryRestaurent.Entity.Entity;
using FieryRestaurent_Service.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace FieryRestaurent.SupplierService.UnitTest
{
    [TestClass]
    public class SuppliersControllerTest
    {
        [TestMethod]
        public void PostSupplier_Takes_All_The_Data_Sends_To_ServiceLayer()
        {
            //Arrange
            //Act
            //Assert
        }
        [TestMethod]
        public void PostSupplier_Not_Sending_Data_To_ServiceLayer()
        {
            //Arrange
            //Act
            //Assert
        }
        [TestMethod]
        public void Get_All_Supplier_Takes_All_The_Data_From_SupplierServiceImpl()
        {
            //Arrange
            //Act
            //Assert
        }
        [TestMethod]
        public void Get_All_Supplier_Not_Getting_The_Whole_Data_From_SupplierServiceImpl()
        {
            //Arrange
            //Act
            //Assert
        }
        [TestMethod]
        public void GetSupplierByID_Gets_The_Correct_Supplier_From_SupplierServiceImpl_By_SupplierId()
        {
            //Arrange
            //Act
            //Assert
        }
        [TestMethod]
        public void GetSupplierByID_NotGetting_The_Correct_Supplier_From_SupplierServiceImpl_By_SupplierId()
        {
            //Arrange
            //Act
            //Assert
        }
        [TestMethod]
        public void Get_All_Supplier_ShouldReturnOk_WhenDataFound()
        {
            //Arrange   
            //var controller = new SuppliersController();
            //// Act on Test  
            //var response = controller.Get('36BBF770-3E5A-4965-B656-D47099724253');
            //var ContentResult = asOkNegotiatedContentResult<SupplierDto>;
            //// Assert the result 
            //Assert.IsNotNull(ContentResult);
            //Assert.IsNotNull(ContentResult.Content);
            //Assert.AreEqual(1, ContentResult.Content.SupplierID);
        }
        [TestMethod]
        public void Get_Supplier_Not_Found()
        {
           // var controller = new SuppliersController();
            // Act  
          //  IHttpActionResult actionResult = controller.Get();
            // Assert  
         //   Assert.IsInstanceOfType(actionResult, typeof(NotFoundResult));
        }
    }
}