using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class PaySmsGestionnaire : Gestionnaire
    {
        public PaySmsGestionnaire()
        {
            this.MinimumMontant = 100;
            this.MaximumMontant = 500;
        }
        public override void GetMontant(float montant)
        {
            if (montant >= MinimumMontant && montant < MaximumMontant)
                Console.WriteLine($" minimum : {MinimumMontant}  montant : {montant} \t max : {MaximumMontant} Signature :une signature sms est requise");

                
            else if (Next != null)
                Next.GetMontant(montant);
        }
    }
}
