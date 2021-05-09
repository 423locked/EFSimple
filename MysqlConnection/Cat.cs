using System;
using System.Collections.Generic;
using System.Text;

namespace EFSimple
{
    class Cat
    {
        /// <summary>
        /// Creating an instance of a Cat
        /// </summary>
        /// <param name="Breed">Порода</param>
        /// <param name="Name">Кличка</param>
        public Cat(string Name, string Breed)
        {
            this.Name = Name;
            this.Breed = Breed;
        }

        public Cat() { }
        public string Breed { get; set; }
        public string Name { get; set; }
        public int CatID { get; set; }
    }
}
