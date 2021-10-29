using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using Moq;

using BusinessLayer.CustomerUseCases;
using BusinessLayer.Gateways;
using DalDTO = BusinessLayer.DalDTO;

namespace BusinessLayerTests
{
    public class WatchCatalogUseCaseTest
    {
        [Fact]
        public void GetCategories_WithTwoExistingCategories_ShouldGetCorrectTwoCategoryes()
        {
            //Arrange
            var gatewayMock = new Mock<ICategoryGateway>();
            gatewayMock.Setup(gateway => gateway.RetrieveAllCategories())
                .Returns(GetTwoTestCategoryes());

            var useCase = new WatchCatalogUseCase(gatewayMock.Object);

            //Act
            var categories = useCase.GetCategories();

            //Assert
            categories.Should().NotBeNullOrEmpty();
            categories.Should().HaveCount(2);

            foreach (var category in categories)
            {
                category.Should().NotBeNull();
                category.Name.Should().NotBeNullOrEmpty();
                category.ImageLink.Should().NotBeNullOrEmpty();
            }

        }

        private IEnumerable<DalDTO::Category> GetTwoTestCategoryes()
        {
            List<DalDTO::Category> categories = new()
            {
                new() { Name = "TestCategory1", ImageLink = "TestImageLink1" },
                new() { Name = "TestCategory2", ImageLink = "TestImageLink2" }
            };

            return categories;
        }
    }
}
