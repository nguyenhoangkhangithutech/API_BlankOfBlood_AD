using System;

namespace API_BloodBank_v1.Data
{
    public abstract class Person
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime DOB   { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Sdt { get; set; }

        public string HinhAnh { get; set; }


    }
}
