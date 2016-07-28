// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace \u0019
{
  internal sealed class \u0015 : Control
  {
    private Image \u0001;
    private Timer \u0001;
    private int \u0001;
    private int \u0002;
    private int \u0003;
    private int \u0004;
    private int \u0005;
    private int \u0006;
    private int \u0007;
    private bool \u0001;
    private readonly float[][] \u0001;

    public int AnimationInterval
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        this.\u0001 = value;
        \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, this.\u0001);
      }
    }

    [DefaultValue(typeof (Image), null)]
    public Image BaseImage
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
        if (this.\u0001 == null)
        {
          \u0011\u001F.\u0084\u0084((object) this, this.\u0006 = 0);
          \u0011\u001F.\u0099\u0083((object) this, this.\u0007 = 0);
        }
        else if (this.\u0001)
        {
          \u0011\u001F.\u0084\u0084((object) this, this.\u0006 = \u0005\u0081.\u007E\u007F\u001F((object) this.\u0001));
          \u0011\u001F.\u0099\u0083((object) this, this.\u0007 = \u0005\u0081.\u007E\u0080\u001F((object) this.\u0001));
        }
        else
        {
          \u0011\u001F.\u0084\u0084((object) this, this.\u0006 = \u0005\u0081.\u007E\u007F\u001F((object) this.\u0001) / this.\u0003);
          \u0011\u001F.\u0099\u0083((object) this, this.\u0007 = \u0005\u0081.\u007E\u0080\u001F((object) this.\u0001) / this.\u0002);
        }
      }
    }

    public int Columns
    {
      get
      {
        return this.\u0003;
      }
      set
      {
        this.\u0003 = value;
      }
    }

    public int Rows
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        this.\u0002 = value;
      }
    }

    public bool StaticImage
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        this.\u0001 = value;
      }
    }

    public bool CurrentlyAnimating
    {
      get
      {
        return \u0099\u0082.\u007E\u009E\u008F((object) this.\u0001);
      }
    }

    public \u0015()
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
      this.\u0001 = new Timer();
      \u0099\u001F.\u007E\u009F\u008F((object) this.\u0001, false);
      // ISSUE: method pointer
      \u0087\u007F.\u007E\u009D\u008F((object) this.\u0001, new EventHandler((object) this, __methodptr(\u001D\u0005)));
      \u0011\u001F.\u007E\u0001\u0090((object) this.\u0001, this.\u0001);
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.FixedWidth | ControlStyles.FixedHeight | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
      \u0082\u0086.\u0082\u0086((object) this, ControlStyles.Selectable, false);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u009D\u0084((object) this, disposing);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      if (!this.\u0001)
        goto label_8;
      else
        goto label_5;
label_4:
      \u001A\u001E.\u007E\u001E\u0086((object) this);
      return;
label_5:
      if ((double) this.\u0001[3][3] >= 1.0)
      {
        this.\u001E\u0005();
        this.\u0001[3][3] = 1f;
        goto label_4;
      }
      else
      {
        this.\u0001[3][3] += 0.05f;
        goto label_4;
      }
label_8:
      if (this.\u0004 != this.\u0003)
      {
        ++this.\u0004;
        goto label_4;
      }
      else if (this.\u0005 == this.\u0002)
      {
        this.\u0004 = 1;
        this.\u0005 = 1;
        goto label_4;
      }
      else
      {
        this.\u0004 = 1;
        ++this.\u0005;
        goto label_4;
      }
    }

    public void \u001D\u0005()
    {
      if (\u0099\u0082.\u007E\u009E\u008F((object) this.\u0001))
        return;
      \u001A\u001E.\u007E\u0002\u0090((object) this.\u0001);
      if (!this.\u0001)
        goto label_5;
      else
        goto label_4;
label_2:
      \u001A\u001E.\u007E\u001E\u0086((object) this);
      return;
label_4:
      this.\u0001[3][3] = 0.05f;
      goto label_2;
label_5:
      ++this.\u0004;
      goto label_2;
    }

    public void \u001E\u0005()
    {
      \u001A\u001E.\u007E\u0003\u0090((object) this.\u0001);
      this.\u0004 = 1;
      this.\u0005 = 1;
      \u001A\u001E.\u007E\u001E\u0086((object) this);
      this.\u0001[3][3] = 0.0f;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      \u0099\u0083.\u007E\u007F\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), CompositingQuality.HighSpeed);
      \u0094\u0081.\u007E\u0083\u007F((object) \u0004\u007F.\u007E\u0092\u0086((object) e), InterpolationMode.Low);
      if (this.\u0001 == null)
        return;
      if (!this.\u0001)
      {
        \u008C\u0082.\u007E\u0002\u0080((object) \u0004\u007F.\u007E\u0092\u0086((object) e), this.\u0001, new Rectangle(0, 0, this.\u0006, this.\u0007), new Rectangle((this.\u0004 - 1) * this.\u0006, (this.\u0005 - 1) * this.\u0007, this.\u0006, this.\u0007), GraphicsUnit.Pixel);
      }
      else
      {
        ImageAttributes imageAttributes = new ImageAttributes();
        try
        {
          \u009C\u0086.\u007E\u000F\u0082((object) imageAttributes, new ColorMatrix(this.\u0001), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
          \u0098\u0084.\u007E\u0003\u0080((object) \u0004\u007F.\u007E\u0092\u0086((object) e), this.\u0001, new Rectangle(0, 0, this.\u0006, this.\u0007), 0, 0, this.\u0006, this.\u0007, GraphicsUnit.Pixel, imageAttributes);
        }
        finally
        {
          if (imageAttributes != null)
            \u001A\u001E.\u007E\u0094\u0092((object) imageAttributes);
        }
      }
    }
  }
}
