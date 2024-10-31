using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._10.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public UserSettings UserSettings { get; set; }
    }
}
