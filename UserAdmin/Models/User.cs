using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace UserAdmin.Models
{
    class User
    {
        public string? Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public DateTime RegisteredAt { get; set; }
        
    }
}
