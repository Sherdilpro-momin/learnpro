using System.Threading.Tasks;
using learnpro.Models.TokenAuth;
using learnpro.Web.Controllers;
using Shouldly;
using Xunit;

namespace learnpro.Web.Tests.Controllers
{
    public class HomeController_Tests: learnproWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}