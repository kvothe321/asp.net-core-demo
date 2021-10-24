using asp.net_core_demo.Database;
using asp.net_core_demo.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_demo.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        private readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext)
            : base(dataContext)
        {
            _dataContext = dataContext;
        }

    }
}
