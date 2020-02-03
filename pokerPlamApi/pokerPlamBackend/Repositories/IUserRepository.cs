using PokerPlamApi.Models;
using System.Collections.Generic;
using System.Linq;


namespace PokerPlamApi.Repositories
{
  public interface IUserRepository
  {
    List<User> Get();

    User Get(string id);

    User Create(User user);

    void Update(string id, User userIn);

    void Remove(User userIn);

    void Remove(string id);
  }
}