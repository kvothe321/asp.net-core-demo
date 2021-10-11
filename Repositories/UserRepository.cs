using asp.net_core_demo.Database;
using asp.net_core_demo.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_demo.Repositories
{
    public class UserRepository
    {
        private readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<User>> GetAll()
        {
            return await _dataContext.Users.ToListAsync();
        }

        public List<User> GetAllSync()
        {
            return _dataContext.Users.ToList();
        }

        public async Task AddUser(User user)
        {            
            await _dataContext.Users.AddAsync(user);
            await _dataContext.SaveChangesAsync();
        }

    }
}
