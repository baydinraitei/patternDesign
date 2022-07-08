using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class Gestionnaire
    {
        public Gestionnaire Next { protected get; set; }

        public abstract void GetMontant(float montant);

        public float MinimumMontant { get; protected set; }
        public float MaximumMontant { get; protected set; }
    }
}
