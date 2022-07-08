using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface portable
    {
        public void connecter();
        public void deconnecter();
        public void Setmarque(string marque);
        public string compatible();
    }
}
