using Microsoft.AspNetCore.Hosting;

namespace HomeApi.Model
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetByLogin(string login)
        {
            throw new NotImplementedException();
        }

       /* Метод IEnumerable<User> GetAll() должен возвращать всех пользователей (достаточно трёх).
        
          Метод User GetByLogin(string login) должен возвращать одного пользователя по его логину или значение null,
          если пользователь не найден (используйте Linq и его метод FirstOrDefault).

          Подключить зависимость репозитория с жизненным циклом Singleton, сделав соответствующие настройки в классе StartUp.

          Внедрить зависимость в контроллер UserRepository.*/
    }
}
