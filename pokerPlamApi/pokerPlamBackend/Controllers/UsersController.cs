using PokerPlamApi.Models;
using PokerPlamApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PokerPlamApi.Controllers
{
  [Route("api/[Controller]")]
  [ApiController]
  public class UsersController : ControllerBase
  {
    private readonly UserRepository _userRepository;

    public UsersController(UserRepository userRepository)
    {
      _userRepository = userRepository;
    }

    [HttpGet]
    public ActionResult<List<User>> Get() =>
      _userRepository.Get();
    
    [HttpGet("{id:length(24)}", Name = "GetUser")]
    public ActionResult<User> Get(string id)
    {
      var user = _userRepository.Get(id);

      if (user == null)
      {
        return NotFound();
      }

      return user;
    }

    [HttpPost]
    public ActionResult<User> Create(User user)
    {
      _userRepository.Create(user);

      return CreatedAtRoute("GetUser", new { id = user.Id.ToString() }, user);
    }

    [HttpPut("{id:length(24)}")]
    public IActionResult Update(string id, User userIn)
    {
      var user = _userRepository.Get(id);

      if (user == null)
      {
        return NotFound();
      }

      _userRepository.Update(id, userIn);

      return NoContent();
    }

    [HttpDelete("{id:length(24)}")]
    public IActionResult Delete(string id)
    {
      var user = _userRepository.Get(id);

      if (user == null)
      {
        return NotFound();
      }

      _userRepository.Remove(user.Id);

      return NoContent();
    }
  }
}