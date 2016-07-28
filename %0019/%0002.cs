// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.Drawing;
using System.Windows.Forms;

namespace \u0019
{
  internal class \u0002 : Form
  {
    protected bool FullScreen { get; private set; }

    protected FormWindowState PreviousWindowState { get; private set; }

    protected Rectangle PreviousWindowBounds { get; private set; }

    protected FormBorderStyle PreviousFormBorderStyle { get; private set; }

    protected void \u001E\u0005(bool fullScreen)
    {
      \u001A\u001E.\u0084\u0086((object) this);
      if (!fullScreen)
      {
        \u0007\u001F.\u0008\u008B((object) this, this.PreviousFormBorderStyle);
        \u000E\u0080.\u0081\u0083((object) this, this.PreviousWindowBounds);
        \u0097\u001C.\u0088\u008B((object) this, this.PreviousWindowState);
        this.FullScreen = false;
      }
      else
        goto label_3;
label_2:
      \u0099\u001F.\u007F\u0086((object) this, true);
      return;
label_3:
      this.PreviousWindowState = \u0098\u001E.\u0087\u008B((object) this);
      \u0097\u001C.\u0088\u008B((object) this, FormWindowState.Normal);
      this.PreviousWindowBounds = \u008D\u0084.\u0080\u0083((object) this);
      this.PreviousFormBorderStyle = \u0004\u0084.\u0007\u008B((object) this);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.None);
      \u000E\u0080.\u0081\u0083((object) this, \u008D\u0084.\u007E\u0013\u008F((object) \u0017\u0081.\u0017\u008F((Control) this)));
      this.FullScreen = true;
      goto label_2;
    }
  }
}
