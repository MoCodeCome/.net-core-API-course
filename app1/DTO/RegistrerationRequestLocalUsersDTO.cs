﻿using System.Security.Principal;

namespace app1.DTO
{
    public class RegistrerationRequestLocalUsersDTO
    {
        public string UserName {  get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
