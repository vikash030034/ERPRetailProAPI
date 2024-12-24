using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.User
{
    public interface IUserService
    {
         Task<Users> FindByUserAsync(string userId);
         bool CheckUserPasswordAsync(Users user,string pwd);
        Task<IEnumerable<Users>> GetAllUsersList();

    }
}
