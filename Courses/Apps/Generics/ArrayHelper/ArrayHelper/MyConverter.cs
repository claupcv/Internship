namespace ArrayHelper
{
  public static class MyConverter
  {
    public static TTo Convert<TFrom, TTo>(TFrom value)
    {
      if (value == null)
      {
        return default(TTo);
      }

      object converted = System.Convert.ChangeType(value, typeof(TTo));

      return (TTo)converted;
    }
  }
}
