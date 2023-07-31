using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPcomposite
{
    internal class Personne
    {

        public string Nom { get; set; }
        private List<Personne> enfants;

        public Personne(string nom)
        {
            Nom = nom;
            enfants = new List<Personne>();
        }

        public void AjouterEnfant(Personne enfant)
        {
            enfants.Add(enfant);
        }

        public void SupprimerEnfant(Personne enfant)
        {
            enfants.Remove(enfant);
        }

        public List<Personne> GetEnfants()
        {
            return enfants;
        }

        public override string ToString()
        {
            return ToString(0);
        }

        private string ToString(int profon)
        {
            string indentation = new string(' ', profon * 4);
            string result = indentation + Nom + Environment.NewLine;

            foreach (Personne enfant in enfants)
            {
                result += enfant.ToString(profon + 1);
            }

            return result;
        }



    }
}
