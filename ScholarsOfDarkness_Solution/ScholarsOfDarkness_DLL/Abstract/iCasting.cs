using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarsOfDarkness_DLL.Abstract
{
    public interface iCasting
    {
        iMage Mage { get; set; }
        iSpell Spell { get; set; }
        
        iSpellFactor Potency { get; set; }
        iSpellFactor Duration { get; set; }
        iSpellFactor Scale { get; set; }
        iSpellFactor Range { get; set; }
        iSpellFactor CastingTime { get; set; }

        int FreeReach();
        int ReachTotal();
        int ManaTotal();
        int PenaltyTotal();
        

    }
}
