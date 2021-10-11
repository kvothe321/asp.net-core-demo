using System;

namespace asp.net_core_demo.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public int Gender { get; set; }

    }
}
