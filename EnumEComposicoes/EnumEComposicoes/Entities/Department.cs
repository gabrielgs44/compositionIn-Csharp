﻿namespace EnumEComposicoes.Entities
{
    class Department
    {
        public string Name { get; set; }

        public Department(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Departament: {Name}";
        }
    }
}
