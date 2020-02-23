
namespace ScholarsOfDarkness_DLL.Abstract
{
    public interface iMage
    {
        #region Properties

        int Gnosis { get; set; }
        string Path { get; set; }
        int Death { get; set; }
        int Fate { get; set; }
        int Forces { get; set; }
        int Life { get; set; }
        int Matter { get; set; }
        int Mind { get; set; }
        int Prime { get; set; }
        int Space { get; set; }
        int Spirit { get; set; }
        int Time { get; set; }

        #endregion
        #region Methods

        bool isRuling(string arcanum);

        #endregion
    }
}
