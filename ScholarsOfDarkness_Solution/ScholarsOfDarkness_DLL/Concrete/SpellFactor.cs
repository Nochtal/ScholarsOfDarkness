using ScholarsOfDarkness_DLL.Abstract;

namespace ScholarsOfDarkness_DLL.Concrete
{
    public class SpellFactor : iSpellFactor
    {

        public string SpellFactorName
        {
            get
            {
                return SpellFactorName;
            }
            set
            {
                SpellFactorName = value;
            }
        }
        public bool Advanced
        {
            get
            {
                return Advanced;
            }

            set
            {
                Advanced = value;
            }
        }

        public int BaseLevel
        {
            get
            {
                return BaseLevel;
            }

            set
            {
                BaseLevel = value;
            }
        }

        public int DiePenalty
        {
            get
            {
                return DiePenalty;
            }

            set
            {
                DiePenalty = value;
            }
        }

        public int ModLevel
        {
            get
            {
                return ModLevel;
            }

            set
            {
                ModLevel = value;
            }
        }

        public bool Primary
        {
            get
            {
                return Primary;
            }

            set
            {
                Primary = value;
            }
        }

    }
}
