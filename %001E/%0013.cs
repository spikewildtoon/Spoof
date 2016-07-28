// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001A;
using \u001C;
using \u001E;
using \u0081;
using System.ComponentModel;

namespace \u001E
{
  internal static class \u0013
  {
    public static bool \u001D\u0005(\u000F builder)
    {
      return \u0013.\u001D\u0005(builder.\u001D\u0005());
    }

    public static bool \u001D\u0005(\u0007[] inputs)
    {
      if ((int) \u000E.\u001D\u0005((uint) inputs.Length, inputs, \u000F.\u0001) != 0)
        return true;
      new Win32Exception().\u001D\u0005();
      return false;
    }
  }
}
