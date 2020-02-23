using ScholarsOfDarkness_DLL.Abstract;

namespace ScholarsOfDarkness_DLL.Concrete
{
    public class Reach : iReach
    {

        public Reach(int _reachCost, string _reachDescription, int _reachMana)
        {
            ReachCost = _reachCost;
            ReachDescription = _reachDescription;
            ReachMana = _reachMana;
        }

        public int ReachCost
        {
            get
            {
                return ReachCost;
            }

            set
            {
                ReachCost = value;
            }
        }

        public string ReachDescription
        {
            get
            {
                return ReachDescription;
            }

            set
            {
                ReachDescription = value;
            }
        }

        public int ReachMana
        {
            get
            {
                return ReachMana;
            }

            set
            {
                ReachMana = value;
            }
        }
    }
}
