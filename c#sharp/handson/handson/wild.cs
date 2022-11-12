using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class wildAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string Animaltype)
        {
            if (Animaltype.Equals("tiger"))
            {
                return new tiger();
            }
            else if (Animaltype.Equals("elephant"))
            {
                return new elephant();
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