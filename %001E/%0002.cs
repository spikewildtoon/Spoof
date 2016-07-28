// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0018;
using \u001E;
using System;

namespace \u001E
{
  internal static class \u0002
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0002()
    {
      \u0004.\u001D\u0005(typeof (\u0002));
    }

    public static void \u001D\u0005(string[] files, string destinationDirectory)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0002.\u0001 obj1 = new \u0002.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = files;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = destinationDirectory;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = 0;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0002.\u0002 obj2 = new \u0002.\u0002();
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = obj1;
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = new \u001A();
      try
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        obj2.\u0001.Shown += new EventHandler(obj2.\u001D\u0005);
        // ISSUE: reference to a compiler-generated field
        int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj2.\u0001);
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        if (obj2.\u0001 != null)
        {
          // ISSUE: reference to a compiler-generated field
          \u001A\u001E.\u007E\u0094\u0092((object) obj2.\u0001);
        }
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (obj1.\u0001.Length == obj1.\u0001)
      {
        // ISSUE: reference to a compiler-generated field
        \u0017.\u001D\u0005(\u009E\u0081.\u001F\u0093(\u0002.\u0001(64692), (object) obj1.\u0001), \u0002.\u0001(64749));
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        \u0017.\u001D\u0005(\u009E\u0081.\u001F\u0093(\u0002.\u0001(64770), (object) obj1.\u0001), \u0002.\u0001(64749));
      }
    }
  }
}
