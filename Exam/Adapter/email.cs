using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class email : communicationstart
    {
        private mailRouter mailRouter;
        public email()
        {
            mailRouter = new mailRouter();
            Console.WriteLine("Le 'email' qui permet l'adaptation entre 'communicationstart' and 'mailRouter' est effectif");
        }

        public void envoyer(string uttilisateur, string corps)
        {
            mailRouter.send(uttilisateur, corps);
        }
    }
}
