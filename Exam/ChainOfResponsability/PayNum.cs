using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class PayNumGestionnaire : Gestionnaire
    {
        public PayNumGestionnaire()
        {
            this.MinimumMontant = 500;
            this.MaximumMontant = float.PositiveInfinity;
        }
        public override void GetMontant(float montant)
        {
            if (montant >= MinimumMontant && montant < MaximumMontant)
                Console.WriteLine($" minimum : {MinimumMontant}  montant : {montant} \t max : Infinity Signature : Signature numérique requise");
            else if (Next != null)
                Next.GetMontant(montant);
        }
    }
}
