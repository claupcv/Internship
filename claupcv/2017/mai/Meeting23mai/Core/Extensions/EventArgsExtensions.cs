using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
  public static class EventArgsExtensions
  {
    public static TDerived As<TDerived>(this EventArgs e)
      where TDerived : EventArgs
    {
      return e as TDerived;
    }
  }
}
