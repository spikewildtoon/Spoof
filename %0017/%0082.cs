// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001C;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace \u0017
{
  internal sealed class \u0082 : Control
  {
    private Bitmap \u0001;
    private \u0019 \u0001;
    private bool \u0001;
    private readonly float[][] \u0001;

    [DefaultValue(typeof (Bitmap), null)]
    public Bitmap Image
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
        \u001A\u001E.\u0004\u0086((object) this);
      }
    }

    public bool Selected
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
        \u001A\u001E.\u0004\u0086((object) this);
        if (!this.\u0001 || this.\u0002 == null)
          return;
        \u0095\u001E.\u007E\u009E\u0095((object) this.\u0002, (object) this, EventArgs.Empty);
      }
    }

    public event EventHandler ShowScreenshot;

    public event EventHandler ButtonSelected;

    public \u0082()
    {
      float[][] numArray1 = new float[5][];
      float[][] numArray2 = numArray1;
      int index1 = 0;
      float[] numArray3 = new float[5];
      numArray3[0] = 1f;
      float[] numArray4 = numArray3;
      numArray2[index1] = numArray4;
      float[][] numArray5 = numArray1;
      int index2 = 1;
      float[] numArray6 = new float[5];
      numArray6[1] = 1f;
      float[] numArray7 = numArray6;
      numArray5[index2] = numArray7;
      float[][] numArray8 = numArray1;
      int index3 = 2;
      float[] numArray9 = new float[5];
      numArray9[2] = 1f;
      float[] numArray10 = numArray9;
      numArray8[index3] = numArray10;
      numArray1[3] = new float[5];
      float[][] numArray11 = numArray1;
      int index4 = 4;
      float[] numArray12 = new float[5];
      numArray12[4] = 1f;
      float[] numArray13 = numArray12;
      numArray11[index4] = numArray13;
      this.\u0001 = numArray1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      \u0099\u001F.\u001B\u0084((object) this, false);
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
      // ISSUE: method pointer
      \u0086\u001D.\u0098\u0084((object) this, new PreviewKeyDownEventHandler((object) this, __methodptr(\u001D\u0005)));
    }

    private void \u001D\u0005()
    {
      if (this.\u0001 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
    }

    private void \u001D\u0005(object sender, PreviewKeyDownEventArgs e)
    {
      if (\u007F\u0081.\u007E\u0082\u008E((object) e) != Keys.Tab)
        return;
      \u0099\u001F.\u007E\u0083\u008E((object) e, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      if (this.Image != null)
      {
        Rectangle rectangle = new Rectangle(\u0097\u0086.\u0088\u0084((object) this).Left, \u0097\u0086.\u0088\u0084((object) this).Top, \u0005\u0081.\u0083\u0084((object) this) - \u0097\u0086.\u0088\u0084((object) this).Horizontal, \u0005\u0081.\u0098\u0083((object) this) - \u0097\u0086.\u0088\u0084((object) this).Vertical);
        ImageAttributes imageAttributes = new ImageAttributes();
        try
        {
          this.\u0001[3][3] = \u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) \u0019.\u0002) || this.Selected ? 1f : 0.9f;
          \u009C\u0086.\u007E\u000F\u0082((object) imageAttributes, new ColorMatrix(this.\u0001), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
          \u0098\u0084.\u007E\u0003\u0080((object) \u0004\u007F.\u007E\u0092\u0086((object) e), (System.Drawing.Image) this.Image, rectangle, 0, 0, \u0005\u0081.\u007E\u007F\u001F((object) this.Image), \u0005\u0081.\u007E\u0080\u001F((object) this.Image), GraphicsUnit.Pixel, imageAttributes);
          if (this.Selected)
          {
            Pen pen = new Pen(\u001B\u001C.\u0015\u007F(209, 19, 19, 19), 6f);
            try
            {
              \u0007\u0084.\u007E\u008D\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), pen, rectangle);
            }
            finally
            {
              if (pen != null)
                \u001A\u001E.\u007E\u0094\u0092((object) pen);
            }
          }
          else if (\u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) \u0019.\u0002))
          {
            Pen pen = new Pen(\u001B\u001C.\u0015\u007F(209, 51, 153, (int) byte.MaxValue), 6f);
            try
            {
              \u0007\u0084.\u007E\u008D\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), pen, rectangle);
            }
            finally
            {
              if (pen != null)
                \u001A\u001E.\u007E\u0094\u0092((object) pen);
            }
          }
        }
        finally
        {
          if (imageAttributes != null)
            \u001A\u001E.\u007E\u0094\u0092((object) imageAttributes);
        }
      }
      \u0092\u001C.\u0017\u0086((object) this, e);
    }

    protected override void OnMouseEnter(EventArgs e)
    {
      \u0088\u001C.\u0013\u0086((object) this, e);
      this.\u0001 |= \u0019.\u0002;
      \u001A\u001E.\u0004\u0086((object) this);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
      \u0088\u001C.\u0014\u0086((object) this, e);
      this.\u0001 &= ~\u0019.\u0002;
      \u001A\u001E.\u0004\u0086((object) this);
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
      \u001E\u001C.\u0012\u0086((object) this, e);
      this.Selected = true;
      this.\u0001 |= \u0019.\u0003;
      \u001A\u001E.\u0004\u0086((object) this);
      this.\u001D\u0005();
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
      \u001E\u001C.\u0016\u0086((object) this, e);
      this.\u0001 &= ~\u0019.\u0003;
      \u001A\u001E.\u0004\u0086((object) this);
    }
  }
}
