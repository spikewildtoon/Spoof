// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001C;
using \u001E;
using \u001F;
using \u0080;
using System;
using System.Drawing;

namespace \u001C
{
  internal sealed class \u0080 : \u007F
  {
    [NonSerialized]
    internal new static \u0002 \u0001;
    private int \u0001;

    public int OrganicQuantity
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        if (this.\u0001 == value)
          return;
        this.\u0001 = value;
        base.\u001D\u0005();
      }
    }

    public int OrganicDamage
    {
      get
      {
        double num = \u0007\u0081.\u0094\u0096((double) this.Damage / 10.0);
        return this.Damage + (num > 1.0 ? (int) num : 1);
      }
    }

    static \u0080()
    {
      \u0004.\u001D\u0005(typeof (\u001C.\u0080));
    }

    public override void \u0001(\u0082 e)
    {
      Font font1 = base.Font;
      if (!this.Owner.Enabled || font1 == null)
        return;
      SolidBrush solidBrush1 = new SolidBrush(base.\u001D\u0005());
      try
      {
        \u008E\u0082 obj = \u008E\u0082.\u007E\u009A\u007F;
        Graphics graphics = e.Graphics;
        string string1 = this.NormalQuantity.ToString();
        Font font2 = font1;
        SolidBrush solidBrush2 = solidBrush1;
        Rectangle bounds = e.Bounds;
        PointF pointF = \u001C\u0086.\u001E\u0080(bounds.Location.\u001D\u0005(2, 2));
        obj((object) graphics, string1, font2, (Brush) solidBrush2, pointF);
        string string2 = this.OrganicQuantity.ToString();
        SizeF sizeF = \u0095\u001D.\u007E\u009D\u007F((object) e.Graphics, string2, font1);
        \u008E\u0082.\u007E\u009A\u007F((object) e.Graphics, this.OrganicQuantity.ToString(), font1, (Brush) solidBrush1, \u001C\u0086.\u001E\u0080(e.Bounds.\u0080\u0005().\u001D\u0005(-1 - (int) sizeF.Width, 2)));
      }
      finally
      {
        if (solidBrush1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) solidBrush1);
      }
    }

    public override string ToString()
    {
      \u001B.\u001E.\u0001 owner = this.Owner;
      if (owner == null)
        return string.Empty;
      return \u0013\u001C.\u0080\u0093(\u001C.\u0080.\u0001(61551), (object) owner.Name, (object) this.Damage, (object) this.OrganicDamage);
    }
  }
}
