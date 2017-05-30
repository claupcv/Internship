using System;

namespace Presentation.Views.Abstractions
{
  public interface IEventPublishView<T> : IView<T>
  {
    event EventHandler OnViewEvent;
  }
}
