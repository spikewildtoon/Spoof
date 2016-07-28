// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0016;
using \u001A;
using \u0082;
using \u0083;
using System;

namespace \u0082
{
  internal sealed class \u0014 : \u007F
  {
    private static Lazy<\u0014> \u0001 = new Lazy<\u0014>((Func<\u0014>) (() => new \u0014(\u0002\u007F.\u007E\u0087\u0091((object) \u0008.Current.Guid))));

    public static \u0014 Instance
    {
      get
      {
        return \u0014.\u0001.Value;
      }
    }

    private \u0014(string autoUpdateID)
      : base(autoUpdateID, \u007F.\u0016)
    {
    }
  }
}
