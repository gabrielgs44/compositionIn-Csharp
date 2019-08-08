using System;


namespace ExercicioComposition3.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BithDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BithDate = birthDate;
        }
    }
}
