using System.Collections.Generic;

namespace ScholarsOfDarkness_DLL.Abstract
{
    public interface iSpell
    {
        #region Properties

        string SpellName { get; set; }
        string SpellArcanum { get; set; }
        string SpellPractice { get; set; }
        int SpellLevel { get; set; }
        int SpellMana { get; set; }
        bool SpellWithstood { get; set; }
        string SpellWithstand { get; set; }
        string SpellDescription { get; set; }
        List<iReach> SpellReach { get; set; }

        #endregion
    }
}
