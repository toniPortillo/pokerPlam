using System;
using Xunit;
using Moq;
using PokerPlamApi.Models;
using PokerPlamApi.Repositories;

namespace PokerPlamApi.UnitTests.Services
{
    public class UserRepository_IsShould
    {
        private readonly UserRepository _userRepository;

        private readonly IPokerPlamDatabaseSettings settings;

        public UserRepository_IsShould()
        {
            _userRepository = new UserRepository(settings);
        }

        [Fact]
        public void Get_returnTrue(string id)
        {
            var result = _userRepository.Get("5e36fade083a65569765297a");
            Assert.Null(result);
        }
    }
}
