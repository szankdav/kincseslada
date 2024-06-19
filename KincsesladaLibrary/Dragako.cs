using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KincsesladaLibrary
{
    internal class Dragako : IKincs
    {
        enum DragakoTipus
        {
            zafír,
            smaragd,
            gyémánt
        }

        enum Meret
        {
            kis,
            közepes,
            nagy
        }

        static Dictionary<string, int> ertek = new Dictionary<string, int>()
        {
            { "zafír", 500 },
            { "smaragd", 400 },
            { "gyémánt", 1000 }
        };

        public string Nev => Tipus;
        public string Leiras => $"Egy gyönyörű {((Meret)Nagysag).ToString()}méretű {Tipus}.";
        public string Tipus { get; }
        public int Ertek => ertek[Tipus] * (int)Math.Pow(Nagysag, 2); 

        public int Nagysag { get; }

        public Dragako(int tipus, int nagysag)
        {
            Tipus = ((DragakoTipus)tipus).ToString();
            Nagysag = nagysag;
        }

        public override string ToString()
        {
            return Leiras;
        }
    }
}
