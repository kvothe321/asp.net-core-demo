using asp.net_core_demo.Dto;
using asp.net_core_demo.Entities;
using asp.net_core_demo.Repositories;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace asp.net_core_demo.Services
{
    public class UserService
    {
        private readonly UserRepository _personRepository;
        private readonly IMapper _mapper;    

        public UserService(UserRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;            
        }

        public async Task<List<UserBasicDTO>> GetAll()
        {
            var usersRepo = await _personRepository.GetAll();
            return _mapper.Map<List<UserBasicDTO>>(usersRepo);
        }

        public async Task AddUser(UserRegisterDTO user)
        {         
            User userToBeInserted = _mapper.Map<User>(user);
            await _personRepository.AddUser(userToBeInserted);

        }
    }
}
