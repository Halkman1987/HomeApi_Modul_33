using HomeApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace HomeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private ILogger _logger;
        public UserController(ILogger logger)
        {
            _logger = logger;
            
            logger.WriteEvent ("event");
            logger.WriteError("error");
            
        }
        [HttpGet]
        public User GetUser()
        {
            return new User()
            {
                Id = new Guid(),
                FirstName = "dima",
                LastName = "balaban",
                Email = "3r4@mail.ru",
                Password = "434344",
                Login = "jgfghfgh"
            };
        }
        [HttpGet]
        [Route("viewmodel")]
        public UserViewModel GetUserViewModel()
        {
            var user = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Ivan",
                LastName = "Ivanov",
                Email = "ivan@gmail.ru",
                Password = "gbfbdfyht",
                Login = "ivashka"
            };
            UserViewModel userViewModel = new UserViewModel(user);
            return userViewModel;
        }
    }
}
