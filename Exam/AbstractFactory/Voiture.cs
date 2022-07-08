using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface Voiture
    {
        Supercar ajouterSupercar(string denominationCommerciale);

        Hypercar ajouterHypercar(string denominationCommerciale);

    }
}
