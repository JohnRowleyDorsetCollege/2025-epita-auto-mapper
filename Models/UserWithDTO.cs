using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_epita_auto_mapper.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }   
    }

    public class UserDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
