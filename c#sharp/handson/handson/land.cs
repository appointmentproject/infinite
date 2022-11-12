using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string Animaltype)
        {
            if (Animaltype.Equals("Dog"))
            {
                return new Dog();
            }
            else if (Animaltype.Equals("Cat"))
            {
                return new Cat();
            }
            else if (Animaltype.Equals("Lion"))
            {
                return new Lion();
            }
            else
                return null;
        }
    }
}