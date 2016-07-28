// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u007F;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace \u007F
{
  internal sealed class \u0002 : UserControl
  {
    private GraphicsPath \u0001 = new GraphicsPath();
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private Timer \u0001;
    private static readonly int \u0001;
    private static readonly int \u0002;
    private Point[] \u0001;
    private int \u0003;
    private int \u0004;
    private int \u0005;
    private bool \u0001;
    private int \u0006;

    static \u0002()
    {
      \u0004.\u001D\u0005(typeof (\u0002));
      \u0002.\u0001 = 30;
      \u0002.\u0002 = 4;
    }

    public \u0002()
    {
      this.\u001D\u0005();
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, \u0002.\u0001);
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
      this.\u001E\u0005();
    }

    protected override void Dispose(bool disposing)
    {
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u009A\u0081((object) this.\u0001);
      this.\u0001 = (GraphicsPath) null;
      this.\u0001 = (Point[]) null;
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009A\u0086((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      this.\u0001 = new Timer(this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, true);
      \u0087\u007F.\u007E\u009D\u008F((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0092\u0081.\u0010\u0084((object) this, \u0002.\u0001(75281));
      \u000E\u001F.\u0018\u0084((object) this, new Size(100, 20));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    protected override void OnEnabledChanged(EventArgs e)
    {
      \u0088\u001C.\u0008\u0086((object) this, e);
      \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, \u0002.\u0001);
      Matrix matrix = new Matrix();
      try
      {
        \u0014\u001F.\u007E\u0018\u0082((object) matrix, (float) (this.\u0004 - this.\u0005), 0.0f);
        this.\u0005 = this.\u0004;
        \u0001\u0084.\u007E\u0006\u0082((object) this.\u0001, matrix);
      }
      finally
      {
        if (matrix != null)
          \u001A\u001E.\u007E\u0094\u0092((object) matrix);
      }
      this.\u0001 = false;
      \u001A\u001E.\u0004\u0086((object) this);
      \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, \u0099\u0082.\u008E\u0083((object) this));
    }

    protected override void OnSizeChanged(EventArgs e)
    {
      \u0088\u001C.\u0018\u0086((object) this, e);
      this.\u001E\u0005();
      \u001A\u001E.\u0004\u0086((object) this);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      \u0092\u001C.\u0017\u0086((object) this, e);
      \u0098\u0081.\u007E\u0098\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), \u0017\u001E.\u008D\u001F(), this.\u0001);
      \u008A\u0082.\u007E\u0090\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), \u0012\u001E.\u0017\u0080(), this.\u0001);
    }

    private void \u001E\u0005()
    {
      this.\u0003 = \u0005\u0081.\u0098\u0083((object) this) - \u0097\u0086.\u0002\u0084((object) this).Vertical;
      \u0084.\u007F.\u001D\u0005(this.\u0003, out this.\u0001);
      \u001A\u001E.\u007E\u009B\u0081((object) this.\u0001);
      \u001A\u001E.\u007E\u009C\u0081((object) this.\u0001);
      for (int index = 0; index < this.\u0001.Length - 1; ++index)
        \u0093\u0080.\u007E\u009E\u0081((object) this.\u0001, this.\u0001[index].X, this.\u0001[index].Y, this.\u0001[index + 1].X, this.\u0001[index + 1].Y);
      \u001A\u001E.\u007E\u009D\u0081((object) this.\u0001);
      Matrix matrix1 = new Matrix();
      try
      {
        \u0082\u001E.\u007E\u0019\u0082((object) matrix1, 270f);
        \u0001\u0084.\u007E\u0006\u0082((object) this.\u0001, matrix1);
      }
      finally
      {
        if (matrix1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) matrix1);
      }
      this.\u0006 = -(this.\u0003 + 1);
      Matrix matrix2 = new Matrix();
      try
      {
        \u0014\u001F.\u007E\u0018\u0082((object) matrix2, (float) (\u0005\u0081.\u0083\u0084((object) this) + this.\u0003 / 2), (float) (\u0005\u0081.\u0098\u0083((object) this) / 2));
        \u0001\u0084.\u007E\u0006\u0082((object) this.\u0001, matrix2);
      }
      finally
      {
        if (matrix2 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) matrix2);
      }
      this.\u0005 = this.\u0004 = (int) \u0007\u0081.\u0094\u0096((double) \u0019\u001E.\u007E\u0008\u0082((object) this.\u0001)[4].X);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      Matrix matrix = new Matrix();
      try
      {
        if (this.\u0001)
        {
          \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, \u0002.\u0001);
          this.\u0005 = this.\u0004;
          \u0014\u001F.\u007E\u0018\u0082((object) matrix, (float) (this.\u0005 - this.\u0006), 0.0f);
          this.\u0001 = false;
        }
        else
        {
          if (this.\u0005 - \u0002.\u0002 < this.\u0006)
          {
            \u0014\u001F.\u007E\u0018\u0082((object) matrix, (float) (this.\u0006 - this.\u0005), 0.0f);
            this.\u0005 = this.\u0006;
          }
          else
          {
            \u0014\u001F.\u007E\u0018\u0082((object) matrix, (float) -\u0002.\u0002, 0.0f);
            this.\u0005 -= \u0002.\u0002;
          }
          if (this.\u0005 == this.\u0006)
          {
            this.\u0001 = true;
            \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, 500);
          }
        }
        \u0001\u0084.\u007E\u0006\u0082((object) this.\u0001, matrix);
        \u001A\u001E.\u0004\u0086((object) this);
        \u001A\u001E.\u0086\u0086((object) this);
      }
      finally
      {
        if (matrix != null)
          \u001A\u001E.\u007E\u0094\u0092((object) matrix);
      }
    }
  }
}
