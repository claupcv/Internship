using System.IO;

namespace Core.IO
{
  public class DefaultPathServices : IPathServices
  {
    public string GetCurrentDirectory()
    {
      return Directory.GetCurrentDirectory();
    }
  }
}
