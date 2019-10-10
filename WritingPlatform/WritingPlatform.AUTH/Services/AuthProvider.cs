using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WritingPlatform.AUTH.Entities;
using WritingPlatform.AUTH.Infrastucture;

namespace WritingPlatform.AUTH.Services
{
    class AuthProvider : IAuthProvider
    {
        public void Add(AppUser model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(AppUser model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AppUser> GetListUsers()
        {
            throw new NotImplementedException();
        }

        public AppUser GetUserByEmail(AppUser model)
        {
            throw new NotImplementedException();
        }

        public AppUser GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public bool isValid(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
