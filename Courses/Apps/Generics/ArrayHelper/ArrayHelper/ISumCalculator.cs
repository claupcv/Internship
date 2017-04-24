using System;

namespace ArrayHelper
{
  public interface ISumCalculator<T>
  {
    T Sum(T a, T b);
  }

  public abstract class SumCalculator<T> : ISumCalculator<T>
  {
    public abstract T Sum(T a, T b);
  }

  public class KnownTypesSumCalculator<T> : SumCalculator<T>
  {
    public override T Sum(T a, T b)
    {
      Type genericType = typeof(T);
      if (genericType == typeof(bool))
      {
        var calculator = new BooleanSumCalculator();
        var sum = calculator.Sum(MyConverter.Convert<T, bool>(a), MyConverter.Convert<T, bool>(b));
        return MyConverter.Convert<bool, T>(sum);
      }
      else if (genericType == typeof(byte))
      {
        var calculator = new ByteSumCalculator();
        var sum = calculator.Sum(MyConverter.Convert<T, byte>(a), MyConverter.Convert<T, byte>(b));
        return MyConverter.Convert<byte, T>(sum);
      }
      else if (genericType == typeof(sbyte))
      {
        var calculator = new SByteSumCalculator();
        var sum = calculator.Sum(MyConverter.Convert<T, sbyte>(a), MyConverter.Convert<T, sbyte>(b));
        return MyConverter.Convert<sbyte, T>(sum);
      }
      else if (genericType == typeof(short))
      {
        var calculator = new ShortIntSumCalculator();
        var sum = calculator.Sum(MyConverter.Convert<T, short>(a), MyConverter.Convert<T, short>(b));
        return MyConverter.Convert<short, T>(sum);
      }

      throw new NotImplementedException($"Cannot handle the sum of two elements of type {typeof(T)}");
    }

    private class BooleanSumCalculator : SumCalculator<bool>
    {
      public override bool Sum(bool a, bool b)
      {
        return a || b;
      }
    }

    private class ByteSumCalculator : SumCalculator<byte>
    {
      public override byte Sum(byte a, byte b)
      {
        return (byte)(a + b);
      }
    }

    private class SByteSumCalculator : SumCalculator<sbyte>
    {
      public override sbyte Sum(sbyte a, sbyte b)
      {
        return (sbyte)(a + b);
      }
    }

    private class ShortIntSumCalculator : SumCalculator<short>
    {
      public override short Sum(short a, short b)
      {
        return (short)(a + b);
      }
    }
  }
}
