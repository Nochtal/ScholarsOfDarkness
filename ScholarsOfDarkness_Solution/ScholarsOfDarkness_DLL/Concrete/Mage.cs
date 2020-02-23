using ScholarsOfDarkness_DLL.Abstract;

namespace ScholarsOfDarkness_DLL.Concrete
{
    public class Mage : iMage
    {
        #region Properties
        public int Death
        {
            get
            {
                return Death;
            }

            set
            {
                Death = value;
            }
        }

        public int Fate
        {
            get
            {
                return Fate;
            }

            set
            {
                Fate = value;
            }
        }

        public int Forces
        {
            get
            {
                return Forces;
            }

            set
            {
                Forces = value;
            }
        }

        public int Gnosis
        {
            get
            {
                return Gnosis;
            }

            set
            {
                Gnosis = value;
            }
        }

        public int Life
        {
            get
            {
                return Life;
            }

            set
            {
                Life = value;
            }
        }

        public int Matter
        {
            get
            {
                return Matter;
            }

            set
            {
                Matter = value;
            }
        }

        public int Mind
        {
            get
            {
                return Mind;
            }

            set
            {
                Mind = value;
            }
        }

        public string Path
        {
            get
            {
                return Path;
            }
            set
            {
                Path = value;
            }
        }

        public int Prime
        {
            get
            {
                return Mind;
            }

            set
            {
                Mind = value;
            }
        }

        public int Space
        {
            get
            {
                return Space;
            }

            set
            {
                Space = value;
            }
        }

        public int Spirit
        {
            get
            {
                return Spirit;
            }

            set
            {
                Spirit = value;
            }
        }

        public int Time
        {
            get
            {
                return Time;
            }

            set
            {
                Time = value;
            }
        }
        #endregion
        #region Methods
        public bool isRuling(string arcanum)
        {
            switch (Path)
            {
                case "Acanthus":
                    if (arcanum == "" || arcanum == "") return true;
                    break;
                case "Mastigos":
                    if (arcanum == "" || arcanum == "") return true;
                    break;
                case "Moros":
                    if (arcanum == "" || arcanum == "") return true;
                    break;
                case "Obrimos":
                    if (arcanum == "" || arcanum == "") return true;
                    break;
                case "Thyrsus":
                    if (arcanum == "" || arcanum == "") return true;
                    break;
                default: 
                    return false;
            }
            return false;
        }
        #endregion
    }
}
