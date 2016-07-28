// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u0081;
using \u0082;
using \u0083;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0018
{
  internal sealed class \u0002 : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private Button \u0001;
    private Label \u0001;
    private ListBox \u0001;
    private Button \u0002;

    public \u001A? JoeFishRunStatistics { get; set; }

    static \u0002()
    {
      \u0004.\u001D\u0005(typeof (\u0002));
    }

    public \u0002()
    {
      this.\u001D\u0005();
      \u0080\u0086.\u0016\u008B((object) this, \u0013.PenPaper_Icon);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = new Button();
      this.\u0001 = new Label();
      this.\u0001 = new ListBox();
      this.\u0002 = new Button();
      \u001A\u001E.\u0084\u0086((object) this);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(202, 210));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0002.\u0001(32185));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0002.\u0001(7538));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0002.\u0001(8465), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(7, 11));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0002.\u0001(32194));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(88, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 11);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0002.\u0001(32215));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0002.\u0001(5360), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0099\u001F.\u007E\u0007\u0088((object) this.\u0001, true);
      \u0011\u001F.\u007E\u0010\u0088((object) this.\u0001, 16);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 40));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0002.\u0001(32232));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(265, 164));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 12);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(121, 210));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0002.\u0001(13905));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 13);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0002.\u0001(13918));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001F\u0005));
      \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) this.\u0001);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(289, 243));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0002.\u0001(32253));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterParent);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0002.\u0001(32278));
      \u0087\u007F.\u008E\u008B((object) this, new EventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005();
    }

    private void \u001E\u0005()
    {
      if (this.JoeFishRunStatistics.HasValue)
        goto label_2;
label_1:
      \u001C totalRunStatistics = \u0080.Instance.JoeFishSettings.JoeFishTotalRunStatistics;
      int num1 = \u007F\u001F.\u007E\u001C\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) \u0081\u0086.\u0086\u0093(\u0002.\u0001(32452), \u0002.\u001D\u0005(totalRunStatistics.TotalRunTime)));
      int num2 = \u007F\u001F.\u007E\u001C\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) \u0081\u0086.\u0086\u0093(\u0002.\u0001(32477), totalRunStatistics.TotalFishCaught.ToString()));
      int num3 = \u007F\u001F.\u007E\u001C\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) \u0081\u0086.\u0086\u0093(\u0002.\u0001(32506), totalRunStatistics.TotalCasts.ToString()));
      int num4 = \u007F\u001F.\u007E\u001C\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) \u0081\u0086.\u0086\u0093(\u0002.\u0001(32527), \u0002.\u001D\u0005(totalRunStatistics.TotalFishCaught, totalRunStatistics.TotalCasts)));
      int num5 = \u007F\u001F.\u007E\u001C\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) \u0081\u0086.\u0086\u0093(\u0002.\u0001(32556), totalRunStatistics.TotalBootsCaught.ToString()));
      int num6 = \u007F\u001F.\u007E\u001C\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) \u0081\u0086.\u0086\u0093(\u0002.\u0001(32585), totalRunStatistics.TotalBucketsSold.ToString()));
      return;
label_2:
      \u001A obj = this.JoeFishRunStatistics.Value;
      int num7 = \u007F\u001F.\u007E\u001C\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) \u0081\u0086.\u0086\u0093(\u0002.\u0001(32307), obj.StartTime.ToString(\u0002.\u0001(32320))));
      int num8 = \u007F\u001F.\u007E\u001C\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) \u0081\u0086.\u0086\u0093(\u0002.\u0001(32325), obj.EndTime.ToString(\u0002.\u0001(32320))));
      TimeSpan time = \u001B\u0082.\u001F\u0094(obj.EndTime, obj.StartTime);
      int num9 = \u007F\u001F.\u007E\u001C\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) \u0081\u0086.\u0086\u0093(\u0002.\u0001(32338), \u0002.\u001D\u0005(time)));
      int num10 = \u007F\u001F.\u007E\u001C\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) \u0081\u0086.\u0086\u0093(\u0002.\u0001(32355), obj.FishCaught.ToString()));
      int num11 = \u007F\u001F.\u007E\u001C\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) \u0081\u0086.\u0086\u0093(\u0002.\u0001(32376), obj.Casts.ToString()));
      int num12 = \u007F\u001F.\u007E\u001C\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) \u0081\u0086.\u0086\u0093(\u0002.\u0001(32389), \u0002.\u001D\u0005(obj.FishCaught, obj.Casts)));
      int num13 = \u007F\u001F.\u007E\u001C\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) \u0081\u0086.\u0086\u0093(\u0002.\u0001(32410), obj.BootsCaught.ToString()));
      int num14 = \u007F\u001F.\u007E\u001C\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) \u0081\u0086.\u0086\u0093(\u0002.\u0001(32431), obj.BucketsSold.ToString()));
      goto label_1;
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      if (\u0017.\u001E\u0005(\u0002.\u0001(32614), \u0002.\u0001(32683), \u0016.\u0006, \u0016.\u0007) != DialogResult.Yes)
        return;
      this.JoeFishRunStatistics = new \u001A?();
      \u0080.Instance.JoeFishSettings.JoeFishTotalRunStatistics = \u001C.\u0001;
      \u001A\u001E.\u007E\u001F\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001));
      this.\u001E\u0005();
    }

    private static string \u001D\u0005(uint fishCaught, uint totalCasts)
    {
      if ((int) totalCasts == 0)
        return \u0002.\u0001(27758);
      return \u009E\u0081.\u001F\u0093(\u0002.\u0001(32700), (object) ((double) fishCaught / (double) totalCasts * 100.0));
    }

    private static string \u001D\u0005(TimeSpan time)
    {
      string str = string.Empty;
      if (time.Days > 0)
        str = \u001F\u0082.\u0087\u0093(str, time.Days.ToString(), \u0002.\u0001(32713));
      return \u0081\u0086.\u0086\u0093(str, time.ToString(\u0002.\u0001(32726)));
    }
  }
}
