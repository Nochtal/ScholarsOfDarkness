using ScholarsOfDarkness_DLL.Abstract;
using System.Collections.Generic;

namespace ScholarsOfDarkness_DLL.Concrete
{
    public class Spell : iSpell
    {
        public string SpellArcanum
        {
            get
            {
                return SpellArcanum;
            }

            set
            {
                SpellArcanum = value;
            }
        }

        public string SpellDescription
        {
            get
            {
                return SpellDescription;
            }

            set
            {
                SpellDescription = value;
            }
        }

        public int SpellLevel
        {
            get
            {
                return SpellLevel;
            }

            set
            {
                SpellLevel = value;
            }
        }

        public int SpellMana
        {
            get
            {
                return SpellMana;
            }

            set
            {
                SpellMana = value;
            }
        }

        public string SpellName
        {
            get
            {
                return SpellName;
            }

            set
            {
                SpellName = value;
            }
        }

        public string SpellPractice
        {
            get
            {
                return SpellPractice;
            }

            set
            {
                SpellPractice = value;
            }
        }

        public List<iReach> SpellReach
        {
            get
            {
                return SpellReach;
            }

            set
            {
                SpellReach = value;
            }
        }

        public string SpellWithstand
        {
            get
            {
                return SpellWithstand;
            }

            set
            {
                SpellWithstand = value;
            }
        }

        public bool SpellWithstood
        {
            get
            {
                return SpellWithstood;
            }

            set
            {
                SpellWithstood = value;
            }
        }
    }
}
