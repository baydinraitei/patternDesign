using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class PaySimpleGestionnaire : Gestionnaire
    {
        public PaySimpleGestionnaire()
        {
            this.MinimumMontant = 0;
            this.MaximumMontant = 100;
        }
        public override void GetMontant(float montant)
        {
            if(montant >= MinimumMontant && montant < MaximumMontant)
                Console.WriteLine($" minimum : {MinimumMontant}  montant : {montant} \t max : {MaximumMontant} Signature : Payement simple accepté");

            else if(Next != null)
                Next.GetMontant(montant);
        }
    }
}
