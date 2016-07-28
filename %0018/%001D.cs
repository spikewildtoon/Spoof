// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0018;
using \u001B;
using System.Windows.Forms;

namespace \u0018
{
  internal sealed class \u001D : \u001C
  {
    public MouseButtons MouseButton { get; private set; }

    public \u001D(\u001E.\u0001 buttonBoardButton, MouseButtons button)
      : base(buttonBoardButton)
    {
      this.MouseButton = button;
    }
  }
}
