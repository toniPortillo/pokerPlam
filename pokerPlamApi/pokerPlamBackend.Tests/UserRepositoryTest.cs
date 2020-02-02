using System;
using Xunit;
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
        public void Test1()
        {

        }
    }
}
