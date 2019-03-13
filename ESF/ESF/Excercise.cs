using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESF
{
    class Excercise
    {
        /// <summary>
        ///Adattagok létrehozása: Public, private , protedted
        ///public: nyílvános elérés
        ///private: Csak az osztály számára látszik
        /// </summary>
       public string Name;

        //konstruktor
        public Excercise(string aName)
        {
            Name = aName;
        }
    }
}
