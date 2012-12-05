using System;
using System.Data;

namespace prep.collections
{
  public class Calculator
  {
      public IDbConnection idbc;

      public Calculator()
      {
      }

      public int add(int i, int i1)
      {
          idbc.Open();

          if ((i < 0) || (i1 < 0))
              throw new ArgumentException();
          return i + i1;
      }
  }
}