
namespace ScholarsOfDarkness_DLL.Abstract
{
    public interface iSpellFactor
    {
        string SpellFactorName { get; set; }
        bool Primary { get; set; }
        bool Advanced { get; set; }
        int BaseLevel { get; set; }
        int ModLevel { get; set; }
        int DiePenalty { get; set; }
    }
}
