using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class sms: communicationstart
    {
        private autoCom autoCom;
        public sms()
        {
            autoCom = new autoCom();
            Console.WriteLine("L'adapteur qui permet la transition vers le sms depuis 'communicationstart' et 'autoCom' est fonctionel");
        }

        public void envoyer(string uttilisateur, string corps)
        {
            autoCom.send(uttilisateur, corps);
        }


    }
}
