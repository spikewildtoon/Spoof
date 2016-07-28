// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001B;
using \u001F;
using System.Drawing;

namespace \u001C
{
  internal class \u001F : \u001E.\u0001.\u0001, \u0018.\u001B
  {
    \u001E.\u0001 \u001E.\u0001.\u0001.TheToonTownSpoofer\u002EControls\u002EButtonBoard\u002EButtonBoardButton\u002EIButtonBoardButtonOverlay\u002EOwner
    {
      get
      {
        return this.Owner;
      }
      set
      {
        this.Owner = value;
      }
    }

    protected \u001E.\u0001 Owner { get; set; }

    protected Font Font
    {
      get
      {
        \u001E.\u0001 owner = this.Owner;
        if (owner == null)
          return (Font) null;
        return owner.Font;
      }
    }

    protected Color \u001D\u0005()
    {
      \u001E.\u0001 owner = this.Owner;
      if (owner != null)
        goto label_6;
label_5:
      return \u0001.\u0010;
label_6:
      if (owner.Down && !owner.Selected)
        return \u0001.\u0008;
      if (owner.Selected)
        return \u0001.\u000E;
      if (owner.Hover)
        return \u0001.\u000F;
      goto label_5;
    }

    protected void \u001D\u0005()
    {
      \u001E.\u0001 owner = this.Owner;
      if (owner == null)
        return;
      owner.\u001C\u0007();
    }

    public override string ToString()
    {
      \u001E.\u0001 owner = this.Owner;
      if (owner == null)
        return string.Empty;
      return owner.Name;
    }

    public virtual void \u0001(\u0082 e)
    {
    }
  }
}
