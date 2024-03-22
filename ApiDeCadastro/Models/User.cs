﻿namespace ApiDeCadastro.Models
{
    public class User : BaseClass
    {
        public string Name { get; set; } = default!;
        public string Surname { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string Username { get; set; } = default!;
        public DateTime DateCreating { get; set; }
    }
}
