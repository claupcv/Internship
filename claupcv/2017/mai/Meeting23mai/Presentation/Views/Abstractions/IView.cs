﻿namespace Presentation.Views.Abstractions
{
  public interface IView<T>
  {
    void Render(T data);
  }
}
