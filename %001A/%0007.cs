// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.Drawing;
using System.Windows.Forms;

namespace \u001A
{
  internal sealed class \u0007 : FlowLayoutPanel
  {
    private bool \u0001;

    protected override Point ScrollToControl(Control activeControl)
    {
      if (this.\u0001)
        return \u008C\u0083.\u0096\u0086((object) this, activeControl);
      return \u008D\u0084.\u007E\u0089\u0083((object) this).Location;
    }

    public void \u001D\u0005(Control activeControl)
    {
      this.\u0001 = true;
      \u009B\u0081.\u0095\u0086((object) this, activeControl);
      this.\u0001 = false;
    }
  }
}
