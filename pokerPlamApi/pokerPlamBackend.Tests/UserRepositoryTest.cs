using System;
using System.Linq;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;
using Moq;
using PokerPlamApi.Models;
using PokerPlamApi.Repositories;
using pokerPlamBackend.Controllers;

namespace PokerPlamApi.UnitTests.Services
{
    public class UserRepository_IsShould
    {
        [Fact]
        public void Get_returnTrue()
        {
            // Arrange
            string id = "5e36fade083a655697652979"; 
            var user = new User();
            user.Id = id;
            var mockUserRepository = new Mock<IUserRepository>();
            mockUserRepository.Setup(m => m.Get(id)).Returns(user);
            var userController = new UsersController(mockUserRepository.Object);
            // Act
            var dummy = userController.Get(id);
            // Assert
            dummy.Should().BeSameAs(user);
        }
    }
}
