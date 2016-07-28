// Decompiled with JetBrains decompiler
// Type: TSN.wyUpdate.Controls.FailedToInitializeException
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using System;

namespace TSN.wyUpdate.Controls
{
  [Serializable]
  public sealed class FailedToInitializeException : Exception
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string Exception_MustInitialize;

    static FailedToInitializeException()
    {
      \u0004.\u001D\u0005(typeof (FailedToInitializeException));
      FailedToInitializeException.Exception_MustInitialize = FailedToInitializeException.\u0001(54688);
    }

    public FailedToInitializeException()
      : base(FailedToInitializeException.Exception_MustInitialize)
    {
    }
  }
}
