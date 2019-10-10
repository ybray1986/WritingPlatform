using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WritingPlatform.AUTH.Entities;

namespace WritingPlatform.AUTH.Infrastucture
{
    public interface IAuthProvider
    {
        bool isValid(string email, string password);
        void Add(AppUser model);
        AppUser GetUserById(int id);
        AppUser GetUserByEmail(AppUser model);
        IEnumerable<AppUser> GetListUsers();
        void Edit(AppUser model);
        void Delete(int id);
    }
}
