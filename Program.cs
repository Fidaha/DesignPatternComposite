using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPcomposite
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Personne grandParent = new Personne("Grandparent");
            Personne parent1 = new Personne("Parent 1");
            Personne parent2 = new Personne("Parent 2");
            Personne enfant1 = new Personne("Enfant 1");
            Personne enfant2 = new Personne("Enfant 2");
            Personne grandEnfant = new Personne("Grandenfant");

            grandParent.AjouterEnfant(parent1);
            grandParent.AjouterEnfant(parent2);
            parent1.AjouterEnfant(enfant1);
            parent1.AjouterEnfant(enfant2);
            enfant1.AjouterEnfant(grandEnfant);

            Console.WriteLine(grandParent.ToString());

        }
    }
}
