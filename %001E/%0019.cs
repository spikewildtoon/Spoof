// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001E;
using System;

namespace \u001E
{
  internal static class \u0019
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0019()
    {
      \u0004.\u001D\u0005(typeof (\u0019));
    }

    public static bool \u001D\u0005(string directory)
    {
      if (\u0019.\u001F\u0005(directory))
        goto label_4;
label_3:
      return false;
label_4:
      if (\u0019.\u001E\u0005(directory))
      {
        try
        {
          \u009C\u001F.\u0081\u009E(directory);
          return true;
        }
        catch (Exception ex)
        {
          ex.\u001D\u0005((object) \u0081\u0086.\u0086\u0093(\u0019.\u0001(66546), directory));
          return false;
        }
      }
      else
        goto label_3;
    }

    public static bool \u001E\u0005(string directory)
    {
      try
      {
        return \u009A\u0084.\u001E\u009E(directory).Length > 0 && \u009A\u0084.\u007F\u009E(directory).Length > 0;
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005((object) \u0081\u0086.\u0086\u0093(\u0019.\u0001(66546), directory));
        return true;
      }
    }

    public static bool \u001F\u0005(string directory)
    {
      try
      {
        return \u008F\u0084.\u001D\u009E(directory);
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005((object) \u0081\u0086.\u0086\u0093(\u0019.\u0001(66546), directory));
        return false;
      }
    }

    public static bool \u007F\u0005(string fileName)
    {
      if (!\u0019.\u0080\u0005(fileName))
        return false;
      try
      {
        \u009C\u001F.\u0091\u009E(fileName);
        return true;
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005((object) \u0081\u0086.\u0086\u0093(\u0019.\u0001(66563), fileName));
        return false;
      }
    }

    public static bool \u0080\u0005(string fileName)
    {
      try
      {
        return \u008F\u0084.\u0092\u009E(fileName);
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005((object) \u0081\u0086.\u0086\u0093(\u0019.\u0001(66563), fileName));
        return false;
      }
    }
  }
}
