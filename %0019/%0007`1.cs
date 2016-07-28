// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;
using System.Linq.Expressions;
using System.Reflection;

namespace \u0019
{
  internal static class \u0007<T>
  {
    public static PropertyInfo \u001D\u0005<TValue>(Expression<Func<T, TValue>> selector)
    {
      Expression expression = (Expression) selector;
      if (expression is LambdaExpression)
        expression = \u008C\u001D.\u007E\u001A\u0005\u0002((object) (LambdaExpression) expression);
      if (\u001B\u001D.\u007E\u0019\u0005\u0002((object) expression) == ExpressionType.MemberAccess)
        return (PropertyInfo) \u0001\u0087.\u007E\u001B\u0005\u0002((object) (MemberExpression) expression);
      throw new InvalidOperationException();
    }
  }
}
