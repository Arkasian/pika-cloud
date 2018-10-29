using System.Threading.Tasks;

namespace FMS2.Services{
    public interface IZipper
    {
        Task ZipDirectoryAsync(string absolutPath, string output);
        void Cancel();
    }
}