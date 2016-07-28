// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0084;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace \u0084
{
  internal sealed class \u001B
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    public readonly string \u0001;
    public readonly string \u0002;

    static \u001B()
    {
      \u0004.\u001D\u0005(typeof (\u001B));
    }

    public \u001B(string fileName)
    {
      if (\u008F\u0084.\u009E\u0092(fileName))
        throw new ArgumentNullException(\u001B.\u0001(59763));
      if (\u0005\u0081.\u007E\u0001\u0093((object) fileName) > 3)
      {
        while ((int) \u008C\u0086.\u007E\u009C\u0092((object) fileName, \u0005\u0081.\u007E\u0001\u0093((object) fileName) - 1) == (int) Path.DirectorySeparatorChar)
          fileName = \u0084\u0080.\u007E\u0006\u0093((object) fileName, 0, \u0005\u0081.\u007E\u0001\u0093((object) fileName) - 1);
      }
      this.\u0001 = string.Empty;
      this.\u0002 = \u009C\u0080.\u0007\u009F(fileName);
    }

    public \u001B(string displayName, string fileName)
      : this(fileName)
    {
      switch (displayName)
      {
        case null:
          break;
        default:
          this.\u0001 = displayName;
          break;
      }
    }

    [SpecialName]
    public static bool \u001D\u0005(\u001B a, object b)
    {
      if (\u0013\u0080.\u0089\u0091((object) a, b))
        return true;
      if (a == null || b == null)
        return false;
      return \u0013\u0080.\u007E\u0088\u0091((object) a, b);
    }

    [SpecialName]
    public static bool \u001E\u0005(\u001B a, object b)
    {
      return !\u001B.\u001D\u0005(a, b);
    }

    public override bool Equals(object obj)
    {
      \u001B obj1 = obj as \u001B;
      if (obj1 == null)
        return false;
      return \u0008\u0080.\u0099\u0092(this.\u0002, obj1.\u0002, StringComparison.OrdinalIgnoreCase);
    }

    public override int GetHashCode()
    {
      return \u0089\u0086.\u007E\u0096\u0093((object) \u0093\u001B.\u0090\u0093(), this.\u0002);
    }

    public override string ToString()
    {
      return this.\u0001;
    }
  }
}
