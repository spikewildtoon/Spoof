// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u0018;
using \u001C;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace \u001C
{
  internal sealed class \u0003 : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private PictureBox \u0001;
    private \u0019 \u0001;
    private Panel \u0001;
    private Button \u0001;
    private Label \u0001;
    private Button \u0002;
    private Button \u0003;
    private Label \u0002;
    private Label \u0003;
    private Label \u0004;
    private SaveFileDialog \u0001;
    private Bitmap \u0001;

    public Bitmap Screenshot
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        this.\u0001 = value;
        \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) this.\u0001);
      }
    }

    static \u0003()
    {
      \u0004.\u001D\u0005(typeof (\u0003));
    }

    public \u0003()
    {
      this.\u001D\u0005();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0003)));
      this.\u0001 = new PictureBox();
      this.\u0001 = new Panel();
      this.\u0004 = new Label();
      this.\u0002 = new Label();
      this.\u0002 = new Button();
      this.\u0003 = new Button();
      this.\u0003 = new Label();
      this.\u0001 = new Label();
      this.\u0001 = new Button();
      this.\u0001 = new SaveFileDialog();
      this.\u0001 = new \u0019();
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0012\u0082.\u007E\u001C\u008E((object) this.\u0001, BorderStyle.FixedSingle);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(9, 7));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(58051));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(140, 140));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0001, PictureBoxSizeMode.StretchImage);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0001, 0);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0001, false);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(4, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(57682));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(386, 182));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u009A\u0080.\u0016\u0081());
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0004, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(165, 134));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0003.\u0001(58072));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(205, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 15);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0003.\u0001(58097));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0003.\u0001(8052), 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0090\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(165, 71));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0003.\u0001(58154));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(206, 47));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 12);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0003.\u0001(58191));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(208, 153));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0003.\u0001(58333));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(89, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0003.\u0001(58354));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001D\u0005));
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0003, DialogResult.Cancel);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(303, 153));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0003.\u0001(58375));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0003.\u0001(36921));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0003, new EventHandler(this.\u001E\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u0003.\u0001(9578), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(191, 19));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0003.\u0001(58388));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(154, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0003.\u0001(58417));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0003.\u0001(9578), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(164, 45));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(18349));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(208, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0003.\u0001(58442));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(9, 153));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(58471));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(140, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0003.\u0001(58496));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      \u0092\u0081.\u007E\u0095\u008A((object) this.\u0001, \u0003.\u0001(58517));
      this.\u0001.BorderSize = 4;
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Fill);
      this.\u0001.EnableFlashing = true;
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0005\u007F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(58562));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(394, 190));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001D.\u000E\u008B((object) this, (IButtonControl) this.\u0003);
      \u000E\u001F.\u0010\u008B((object) this, new Size(394, 190));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(7595)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0003.\u0001(58587));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0003.\u0001(58620));
      \u0099\u001F.\u0086\u008B((object) this, true);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u0001.EnableFlashing = false;
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, false);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      if (this.\u0001 == null)
      {
        \u0017.\u001D\u0005(\u0003.\u0001(58665), \u0003.\u0001(58758));
      }
      else
      {
        if (\u0097\u001E.\u007E\u0088\u0088((object) this.\u0001) != DialogResult.OK)
          return;
        try
        {
          switch (\u0005\u0081.\u007E\u0096\u008A((object) this.\u0001))
          {
            case 1:
              Stream image_stream1 = (Stream) \u008F\u001C.\u0093\u009E(\u0002\u007F.\u007E\u0092\u008A((object) this.\u0001), FileMode.Create, FileAccess.Write, FileShare.None);
              try
              {
                \u0008.\u001E\u0005(this.\u0001, image_stream1, 100);
                break;
              }
              finally
              {
                if (image_stream1 != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) image_stream1);
              }
            case 2:
              Stream image_stream2 = (Stream) \u008F\u001C.\u0093\u009E(\u0002\u007F.\u007E\u0092\u008A((object) this.\u0001), FileMode.Create, FileAccess.Write, FileShare.None);
              try
              {
                \u0008.\u001D\u0005(this.\u0001, image_stream2, 100);
                break;
              }
              finally
              {
                if (image_stream2 != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) image_stream2);
              }
          }
        }
        catch (Exception ex)
        {
          \u0017.\u001D\u0005(ex, \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001));
        }
      }
    }
  }
}
