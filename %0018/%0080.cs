// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0018;
using \u001A;
using \u001E;
using \u007F;
using \u0083;
using \u0084;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0018
{
  internal sealed class \u0080 : Form
  {
    private bool \u0001 = true;
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    private static readonly string \u0006;
    private static readonly string \u0007;
    private static readonly string \u0008;
    private static readonly string \u000E;
    private static readonly string \u000F;
    private static readonly string \u0010;
    private static readonly string \u0011;
    private static readonly string \u0012;
    private static readonly string \u0013;
    private static readonly string \u0014;
    private static readonly string \u0015;
    private \u001C.\u0082 \u0001;
    private \u001F.\u001C \u0001;
    private \u0004 \u0001;
    private \u001F.\u0001 \u0001;
    private IContainer \u0001;
    private Button \u0001;
    private PictureBox \u0001;
    private Label \u0001;
    private Label \u0002;
    private Label \u0003;
    private Label \u0004;
    private Button \u0002;
    private OpenFileDialog \u0001;
    private MenuStrip \u0001;
    private ToolStripMenuItem \u0001;
    private ToolStripMenuItem \u0002;
    private ToolStripMenuItem \u0003;
    private ToolStripMenuItem \u0004;
    private ToolStripMenuItem \u0005;
    private ToolStripMenuItem \u0006;
    private ToolStripSeparator \u0001;
    private ToolStripMenuItem \u0007;
    private ToolStripMenuItem \u0008;
    private ToolStripSeparator \u0002;
    private ToolStripMenuItem \u000E;
    private ToolStripSeparator \u0003;
    private ToolStripMenuItem \u000F;
    private ToolStripMenuItem \u0010;
    private ToolStripSeparator \u0004;
    private ToolStripMenuItem \u0011;
    private ToolStripMenuItem \u0012;
    private ToolStripMenuItem \u0013;
    private ToolStripSeparator \u0005;
    private ToolStripMenuItem \u0014;
    private ToolStripMenuItem \u0015;
    private ToolStripMenuItem \u0016;
    private ToolStripMenuItem \u0017;
    private ToolStripMenuItem \u0018;
    private ToolStripMenuItem \u0019;
    private ToolStripMenuItem \u001A;
    private ToolStripMenuItem \u001B;

    static \u0080()
    {
      \u0004.\u001D\u0005(typeof (\u0018.\u0080));
      \u0018.\u0080.\u0001 = \u0018.\u0080.\u0001(39641);
      \u0018.\u0080.\u0002 = \u0018.\u0080.\u0001(25061);
      \u0018.\u0080.\u0003 = \u0018.\u0080.\u0001(39714);
      \u0018.\u0080.\u0004 = \u0018.\u0080.\u0001(24947);
      \u0018.\u0080.\u0005 = \u0018.\u0080.\u0001(39888);
      \u0018.\u0080.\u0006 = \u0018.\u0080.\u0001(39252);
      \u0018.\u0080.\u0007 = \u0018.\u0080.\u0001(40090);
      \u0018.\u0080.\u0008 = \u0018.\u0080.\u0001(24374);
      \u0018.\u0080.\u000E = \u0018.\u0080.\u0001(40340);
      \u0018.\u0080.\u000F = \u0018.\u0080.\u0001(23182);
      \u0018.\u0080.\u0010 = \u0018.\u0080.\u0001(20856);
      \u0018.\u0080.\u0011 = \u0018.\u0080.\u0001(40526);
      \u0018.\u0080.\u0012 = \u0018.\u0080.\u0001(23429);
      \u0018.\u0080.\u0013 = \u0018.\u0080.\u0001(40732);
      \u0018.\u0080.\u0014 = \u0018.\u0080.\u0001(40894);
      \u0018.\u0080.\u0015 = \u0018.\u0080.\u0001(41060);
    }

    public \u0080()
    {
      this.\u001D\u0005();
      this.\u0001 = new \u001F.\u001C();
      \u0099\u001F.\u007E\u008D\u008D((object) this.\u0016, \u0081.\u0080.Instance.JoeFishSettings.ShowStatisticsAfterRunning);
      \u0099\u001F.\u007E\u008D\u008D((object) this.\u000E, \u0081.\u0080.Instance.JoeFishSettings.StopWhenNewSpecies);
      string customCaptureFile = \u0081.\u0080.Instance.JoeFishSettings.CustomCaptureFile;
      if (\u008F\u0084.\u009E\u0092(customCaptureFile) || !\u008F\u0084.\u0092\u009E(customCaptureFile))
        this.\u001D\u0005(true);
      else if (!this.\u001D\u0005(customCaptureFile))
        this.\u001D\u0005(true);
      string wayPointSettings = \u0081.\u0080.Instance.JoeFishSettings.CustomWayPointSettings;
      if (\u008F\u0084.\u009E\u0092(wayPointSettings) || !\u008F\u0084.\u0092\u009E(wayPointSettings))
        this.\u001E\u0005(true);
      else if (!this.\u001E\u0005(wayPointSettings))
        this.\u001E\u0005(true);
      this.Shown += (EventHandler) ((sender, e) =>
      {
        if (\u008F\u0084.\u0092\u009E(\u001A.\u007F.\u001D))
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          \u0018.\u0080.\u0001 obj = new \u0018.\u0080.\u0001();
          // ISSUE: reference to a compiler-generated field
          obj.\u0001 = this;
          // ISSUE: reference to a compiler-generated field
          obj.\u0001 = new \u0014.\u001A();
          try
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            obj.\u0001.Shown += new EventHandler(obj.\u001D\u0005);
            // ISSUE: reference to a compiler-generated field
            int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj.\u0001);
          }
          finally
          {
            // ISSUE: reference to a compiler-generated field
            if (obj.\u0001 != null)
            {
              // ISSUE: reference to a compiler-generated field
              \u001A\u001E.\u007E\u0094\u0092((object) obj.\u0001);
            }
          }
        }
        else
          this.\u0001 = new \u0004();
      });
      this.FormClosing += (FormClosingEventHandler) ((sender, e) =>
      {
        if (this.\u0001 == null)
          return;
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u0018.\u0080.\u0002 obj = new \u0018.\u0080.\u0002();
        // ISSUE: reference to a compiler-generated field
        obj.\u0001 = this;
        // ISSUE: reference to a compiler-generated field
        obj.\u0001 = new \u0014.\u001A();
        try
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          obj.\u0001.Shown += new EventHandler(obj.\u001D\u0005);
          // ISSUE: reference to a compiler-generated field
          int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj.\u0001);
        }
        finally
        {
          // ISSUE: reference to a compiler-generated field
          if (obj.\u0001 != null)
          {
            // ISSUE: reference to a compiler-generated field
            \u001A\u001E.\u007E\u0094\u0092((object) obj.\u0001);
          }
        }
      });
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      this.\u0001.\u001D\u0005((Form) this, (EventHandler<\u0080.\u0017>) null);
    }

    private bool \u001D\u0005()
    {
      if (!this.\u0001.ProcessOpen && !this.\u0001.\u001D\u0005((Form) this))
        return false;
      if (this.\u0001 == null)
      {
        \u0018.\u0017.\u001D\u0005(\u0018.\u0080.\u0003, \u0018.\u0080.\u0004);
        return false;
      }
      if (this.\u0001 != null)
        return true;
      \u0018.\u0017.\u001D\u0005(\u0018.\u0080.\u0001, \u0018.\u0080.\u0002);
      return false;
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      if (!this.\u001D\u0005())
        return;
      \u0081.\u0081 joeFishSettings = \u0081.\u0080.Instance.JoeFishSettings;
      \u0007 obj1 = new \u0007((Form) this);
      try
      {
        \u0080.\u001F obj2 = new \u0080.\u001F(this.\u0001.MainWindowHandle, \u0019.\u0081.\u0001, this.\u0001, this.\u0001, this.\u0001);
        try
        {
          obj1.\u007F\u0005((Form) obj2);
          if (\u0097\u001E.\u007E\u0099\u008B((object) obj2) != DialogResult.Abort)
          {
            if (joeFishSettings.ShowStatisticsAfterRunning)
            {
              \u001A\u001E.\u009B\u0084((object) this);
              \u001A\u001E.\u0091\u008B((object) this);
              \u0083.\u001A right = new \u0083.\u001A(obj2.StartTime, obj2.EndTime, obj2.FishCaught, obj2.BootsCaught, obj2.BucketsSold, obj2.Casts);
              \u0081.\u0081 obj3 = joeFishSettings;
              \u0082.\u001C obj4 = \u0082.\u001C.\u001D\u0005(obj3.JoeFishTotalRunStatistics, right);
              obj3.JoeFishTotalRunStatistics = obj4;
              \u0002 obj5 = new \u0002();
              try
              {
                obj5.JoeFishRunStatistics = new \u0083.\u001A?(right);
                int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj5);
              }
              finally
              {
                if (obj5 != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) obj5);
              }
            }
          }
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
      this.\u0001.\u001D\u0005();
    }

    private bool \u001D\u0005(\u001C.\u0082 settings)
    {
      if (settings.BootCaughtCapture != null && settings.BucketFullCapture != null && (settings.CastCapture != null && settings.EstateSellFishCapture != null) && (settings.ExitFishingCapture != null && (settings.FishCaughtCapture != null && settings.FishCaughtDuringBingoCapture != null) && (settings.NewSpeciesCapture != null && settings.NewSpeciesDuringBingoCapture != null && settings.NoBeansCapture != null)))
        return settings.SellFishCapture != null;
      return false;
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      \u001B selectedFile;
      if (!\u0080.\u007F.\u001D\u0005(out selectedFile))
        return;
      if (!this.\u001D\u0005(selectedFile.\u0002))
        goto label_5;
      else
        goto label_4;
label_2:
      \u0081.\u0080.\u001D\u0005();
      return;
label_4:
      \u0081.\u0080.Instance.JoeFishSettings.CustomCaptureFile = selectedFile.\u0002;
      goto label_2;
label_5:
      this.\u001D\u0005(false);
      goto label_2;
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      this.\u001D\u0005(true);
      \u0081.\u0080.\u001D\u0005();
    }

    private void \u001D\u0005(bool displayErrorIfFailure)
    {
      \u0081.\u0080.Instance.JoeFishSettings.CustomCaptureFile = (string) null;
      if (\u008F\u0084.\u0092\u009E(\u001A.\u007F.\u001A))
      {
        bool flag = false;
        \u001C.\u0082 settings = (\u001C.\u0082) null;
        try
        {
          settings = new \u001C.\u0082(\u001A.\u007F.\u001A);
          flag = true;
        }
        catch (Exception ex)
        {
          if (settings != null)
            settings.Dispose();
          settings = (\u001C.\u0082) null;
          if (displayErrorIfFailure)
            ex.\u001D\u0005((object) \u001A.\u007F.\u001A);
        }
        if (flag && this.\u001D\u0005(settings))
        {
          if (this.\u0001 != null)
            this.\u0001.Dispose();
          this.\u0001 = settings;
          \u0099\u001F.\u007E\u008D\u008D((object) this.\u0005, true);
          \u0099\u001F.\u007E\u008D\u008D((object) this.\u0006, false);
        }
        else
        {
          if (settings != null)
            settings.Dispose();
          if (!displayErrorIfFailure)
            return;
          \u0018.\u0017.\u001D\u0005(\u0018.\u0080.\u0013, \u0018.\u0080.\u000F);
        }
      }
      else
      {
        if (this.\u0001 != null)
          this.\u0001.Dispose();
        this.\u0001 = (\u001C.\u0082) null;
        if (displayErrorIfFailure)
          \u0018.\u0017.\u001D\u0005(\u0018.\u0080.\u0011, \u0018.\u0080.\u0012);
        \u0099\u001F.\u007E\u008D\u008D((object) this.\u0005, false);
        \u0099\u001F.\u007E\u008D\u008D((object) this.\u0006, false);
      }
    }

    private bool \u001D\u0005(string filePath)
    {
      \u001C.\u0082 settings = (\u001C.\u0082) null;
      bool flag = false;
      try
      {
        settings = new \u001C.\u0082(filePath);
        flag = true;
      }
      catch (Exception ex)
      {
        if (settings != null)
          settings.Dispose();
        settings = (\u001C.\u0082) null;
        ex.\u001D\u0005((object) \u009E\u0081.\u001F\u0093(\u0018.\u0080.\u0010, (object) filePath));
        \u0018.\u0017.\u001D\u0005(ex, filePath);
      }
      if (flag && this.\u001D\u0005(settings))
      {
        if (this.\u0001 != null)
          this.\u0001.Dispose();
        this.\u0001 = settings;
        \u0099\u001F.\u007E\u008D\u008D((object) this.\u0006, true);
        \u0099\u001F.\u007E\u008D\u008D((object) this.\u0005, false);
        return true;
      }
      if (settings != null)
        settings.Dispose();
      \u0099\u001F.\u007E\u008D\u008D((object) this.\u0005, false);
      \u0099\u001F.\u007E\u008D\u008D((object) this.\u0006, false);
      \u0018.\u0017.\u001D\u0005(\u0018.\u0080.\u000E, \u0018.\u0080.\u000F);
      return false;
    }

    private void \u001E\u0005(bool displayErrorIfFailure)
    {
      \u0081.\u0080.Instance.JoeFishSettings.CustomWayPointSettings = (string) null;
      if (\u008F\u0084.\u0092\u009E(\u001A.\u007F.\u001C))
      {
        bool flag;
        try
        {
          this.\u0001 = new \u001F.\u0001(\u001A.\u007F.\u001C);
          flag = true;
        }
        catch (Exception ex)
        {
          this.\u0001 = (\u001F.\u0001) null;
          if (displayErrorIfFailure)
            \u0018.\u0017.\u001D\u0005(ex, \u001A.\u007F.\u001C);
          flag = false;
        }
        if (flag)
        {
          \u0099\u001F.\u007E\u008D\u008D((object) this.\u0012, true);
          \u0099\u001F.\u007E\u008D\u008D((object) this.\u0013, false);
        }
        else
        {
          \u0099\u001F.\u007E\u008D\u008D((object) this.\u0012, false);
          \u0099\u001F.\u007E\u008D\u008D((object) this.\u0013, false);
        }
      }
      else
      {
        this.\u0001 = (\u001F.\u0001) null;
        \u0099\u001F.\u007E\u008D\u008D((object) this.\u0012, false);
        \u0099\u001F.\u007E\u008D\u008D((object) this.\u0013, false);
        if (!displayErrorIfFailure)
          return;
        \u0018.\u0017.\u001D\u0005(\u0018.\u0080.\u0007, \u0018.\u0080.\u0008);
      }
    }

    private bool \u001E\u0005(string filePath)
    {
      bool flag;
      try
      {
        this.\u0001 = new \u001F.\u0001(filePath);
        flag = true;
      }
      catch (Exception ex)
      {
        \u0018.\u0017.\u001D\u0005(ex, filePath);
        flag = false;
      }
      if (flag)
      {
        \u0099\u001F.\u007E\u008D\u008D((object) this.\u0012, false);
        \u0099\u001F.\u007E\u008D\u008D((object) this.\u0013, true);
      }
      else
      {
        \u0099\u001F.\u007E\u008D\u008D((object) this.\u0012, false);
        \u0099\u001F.\u007E\u008D\u008D((object) this.\u0013, false);
      }
      return flag;
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005(true);
      \u0081.\u0080.\u001D\u0005();
    }

    private void \u0083\u0005(object sender, EventArgs e)
    {
      if (\u0097\u001E.\u007E\u0088\u0088((object) this.\u0001) != DialogResult.OK)
        return;
      \u0081.\u0080.Instance.JoeFishSettings.CustomWayPointSettings = string.Empty;
      if (this.\u001E\u0005(\u0002\u007F.\u007E\u0092\u008A((object) this.\u0001)))
        \u0081.\u0080.Instance.JoeFishSettings.CustomWayPointSettings = \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001);
      else
        this.\u001E\u0005(false);
      \u0081.\u0080.\u001D\u0005();
    }

    private void \u0084\u0005(object sender, EventArgs e)
    {
      \u0007 obj1 = new \u0007((Form) this);
      try
      {
        \u0018.\u0001 obj2 = new \u0018.\u0001(true);
        try
        {
          obj1.\u007F\u0005((Form) obj2);
          int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj2);
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
    }

    private void \u0086\u0005(object sender, EventArgs e)
    {
      \u0002 obj = new \u0002();
      try
      {
        int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj);
      }
      finally
      {
        if (obj != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj);
      }
    }

    private void \u0087\u0005(object sender, EventArgs e)
    {
      \u0081.\u0080.Instance.JoeFishSettings.ShowStatisticsAfterRunning = !\u0081.\u0080.Instance.JoeFishSettings.ShowStatisticsAfterRunning;
      \u0099\u001F.\u007E\u008D\u008D((object) this.\u0016, \u0081.\u0080.Instance.JoeFishSettings.ShowStatisticsAfterRunning);
      \u0081.\u0080.\u001D\u0005();
    }

    private void \u0088\u0005(object sender, EventArgs e)
    {
      if (!this.\u001D\u0005())
        return;
      if (this.\u0001)
      {
        this.\u0001 = false;
        if (2 == (int) \u0018.\u0017.\u001E\u0005(\u0018.\u0080.\u0005, \u0018.\u0080.\u0006, \u0018.\u0016.\u0001, \u0018.\u0016.\u0002))
          return;
      }
      \u0007 obj1 = new \u0007((Form) this);
      try
      {
        \u0080.\u001F obj2 = new \u0080.\u001F(this.\u0001.MainWindowHandle, \u0019.\u0081.\u0002, this.\u0001, this.\u0001, this.\u0001);
        try
        {
          obj1.\u007F\u0005((Form) obj2);
          int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj2);
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
      this.\u0001.\u001D\u0005();
    }

    private void \u0089\u0005(object sender, EventArgs e)
    {
      \u0007 obj1 = new \u0007((Form) this);
      try
      {
        \u0016.\u0015 obj2 = new \u0016.\u0015();
        try
        {
          obj1.\u007F\u0005((Form) obj2);
          int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj2);
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
      }
      finally
      {
        if (obj1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj1);
      }
    }

    private void \u008A\u0005(object sender, EventArgs e)
    {
      \u0005 obj = new \u0005();
      try
      {
        if (\u0097\u001E.\u007E\u0099\u008B((object) obj) != DialogResult.OK)
          return;
        \u0081.\u0080.\u001D\u0005();
      }
      finally
      {
        if (obj != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj);
      }
    }

    private void \u008B\u0005(object sender, EventArgs e)
    {
      \u0081.\u0080.Instance.JoeFishSettings.StopWhenNewSpecies = !\u0081.\u0080.Instance.JoeFishSettings.StopWhenNewSpecies;
      \u0099\u001F.\u007E\u008D\u008D((object) this.\u000E, \u0081.\u0080.Instance.JoeFishSettings.StopWhenNewSpecies);
      \u0081.\u0080.\u001D\u0005();
    }

    private void \u008C\u0005(object sender, EventArgs e)
    {
      \u0080.\u0082.\u001D\u0005(\u0002.\u0008);
    }

    protected override void Dispose(bool disposing)
    {
      if (this.\u0001 != null)
        this.\u0001.Dispose();
      if (this.\u0001 != null)
        this.\u0001.Dispose();
      if (this.\u0001 != null)
        goto label_8;
label_1:
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
      return;
label_8:
      this.\u0001.Dispose();
      goto label_1;
    }

    private void \u001D\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0018.\u0080)));
      this.\u0001 = new Button();
      this.\u0001 = new PictureBox();
      this.\u0001 = new Label();
      this.\u0002 = new Label();
      this.\u0003 = new Label();
      this.\u0004 = new Label();
      this.\u0002 = new Button();
      this.\u0001 = new OpenFileDialog();
      this.\u0001 = new MenuStrip();
      this.\u0001 = new ToolStripMenuItem();
      this.\u0002 = new ToolStripMenuItem();
      this.\u0003 = new ToolStripMenuItem();
      this.\u0004 = new ToolStripMenuItem();
      this.\u0005 = new ToolStripMenuItem();
      this.\u0006 = new ToolStripMenuItem();
      this.\u0001 = new ToolStripSeparator();
      this.\u0007 = new ToolStripMenuItem();
      this.\u0008 = new ToolStripMenuItem();
      this.\u0012 = new ToolStripMenuItem();
      this.\u0013 = new ToolStripMenuItem();
      this.\u0005 = new ToolStripSeparator();
      this.\u0014 = new ToolStripMenuItem();
      this.\u0002 = new ToolStripSeparator();
      this.\u000E = new ToolStripMenuItem();
      this.\u0003 = new ToolStripSeparator();
      this.\u000F = new ToolStripMenuItem();
      this.\u0010 = new ToolStripMenuItem();
      this.\u0004 = new ToolStripSeparator();
      this.\u0011 = new ToolStripMenuItem();
      this.\u0015 = new ToolStripMenuItem();
      this.\u0016 = new ToolStripMenuItem();
      this.\u0017 = new ToolStripMenuItem();
      this.\u0018 = new ToolStripMenuItem();
      this.\u0019 = new ToolStripMenuItem();
      this.\u001A = new ToolStripMenuItem();
      this.\u001B = new ToolStripMenuItem();
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(18, 119));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0018.\u0080.\u0001(38843));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(252, 33));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0018.\u0080.\u0001(38860));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u007F\u0005));
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0018.\u0080.\u0001(6237)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(275, 31));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0018.\u0080.\u0001(6262));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(128, 128));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0001, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0001, 1);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0001, false);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0018.\u0080.\u0001(8688), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(43, 40));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0018.\u0080.\u0001(38881));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(79, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0018.\u0080.\u0001(38898));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0018.\u0080.\u0001(3759), 9f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(121, 48));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0018.\u0080.\u0001(5976));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(121, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0018.\u0080.\u0001(38911));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u0018.\u0080.\u0001(3759), 9f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(17, 100));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0018.\u0080.\u0001(5926));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(252, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0018.\u0080.\u0001(38940));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0004, new Font(\u0018.\u0080.\u0001(3759), 9f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(78, 66));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0018.\u0080.\u0001(5884));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(122, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0018.\u0080.\u0001(39005));
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0002, DialogResult.Cancel);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(439, 113));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0018.\u0080.\u0001(36014));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 11);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0002, false);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0018.\u0080.\u0001(36031));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001D\u0005));
      \u0092\u0081.\u007E\u0095\u008A((object) this.\u0001, \u0018.\u0080.\u0001(31447));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0001), new ToolStripItem[5]
      {
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0003,
        (ToolStripItem) this.\u0015,
        (ToolStripItem) this.\u0018,
        (ToolStripItem) this.\u001A
      });
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0018.\u0080.\u0001(39038));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(420, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 12);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0018.\u0080.\u0001(6300));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0001), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u0002
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0018.\u0080.\u0001(21835));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(37, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u0018.\u0080.\u0001(6330));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0018.\u0080.\u0001(21957));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0002, Keys.W | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(148, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0002, \u0018.\u0080.\u0001(6514));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0003), new ToolStripItem[9]
      {
        (ToolStripItem) this.\u0004,
        (ToolStripItem) this.\u0008,
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u000E,
        (ToolStripItem) this.\u0003,
        (ToolStripItem) this.\u000F,
        (ToolStripItem) this.\u0010,
        (ToolStripItem) this.\u0004,
        (ToolStripItem) this.\u0011
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u0018.\u0080.\u0001(21978));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(75, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0003, \u0018.\u0080.\u0001(22003));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0004), new ToolStripItem[4]
      {
        (ToolStripItem) this.\u0005,
        (ToolStripItem) this.\u0006,
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0007
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0004, \u0018.\u0080.\u0001(22020));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0004, new Size(270, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0004, \u0018.\u0080.\u0001(22045));
      \u0099\u001F.\u007E\u008D\u008D((object) this.\u0005, true);
      \u0014\u001D.\u007E\u008E\u008D((object) this.\u0005, CheckState.Checked);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0005, \u0018.\u0080.\u0001(22058));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0005, new Size(116, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0005, \u0018.\u0080.\u0001(22091));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0005, new EventHandler(this.\u0081\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0006, \u0018.\u0080.\u0001(22104));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0006, new Size(116, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0006, \u0018.\u0080.\u0001(22137));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0006, new EventHandler(this.\u0080\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0018.\u0080.\u0001(39055));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(113, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0007, \u0018.\u0080.\u0001(22179));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0007, new Size(116, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0007, \u0018.\u0080.\u0001(22212));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0007, new EventHandler(this.\u0089\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0008), new ToolStripItem[4]
      {
        (ToolStripItem) this.\u0012,
        (ToolStripItem) this.\u0013,
        (ToolStripItem) this.\u0005,
        (ToolStripItem) this.\u0014
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0008, \u0018.\u0080.\u0001(22225));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0008, new Size(270, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0008, \u0018.\u0080.\u0001(22250));
      \u0099\u001F.\u007E\u008D\u008D((object) this.\u0012, true);
      \u0014\u001D.\u007E\u008E\u008D((object) this.\u0012, CheckState.Checked);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0012, \u0018.\u0080.\u0001(22267));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0012, new Size(116, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0012, \u0018.\u0080.\u0001(22091));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0012, new EventHandler(this.\u0082\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0013, \u0018.\u0080.\u0001(22300));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0013, new Size(116, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0013, \u0018.\u0080.\u0001(22137));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0013, new EventHandler(this.\u0083\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0005, \u0018.\u0080.\u0001(39084));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0005, new Size(113, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0014, \u0018.\u0080.\u0001(22374));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0014, new Size(116, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0014, \u0018.\u0080.\u0001(22212));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0014, new EventHandler(this.\u0084\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0018.\u0080.\u0001(6379));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(267, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u000E, \u0018.\u0080.\u0001(39113));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u000E, new Size(270, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u000E, \u0018.\u0080.\u0001(39166));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u000E, new EventHandler(this.\u008B\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u0018.\u0080.\u0001(6468));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(267, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u000F, \u0018.\u0080.\u0001(39215));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u000F, new Size(270, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u000F, \u0018.\u0080.\u0001(39252));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u000F, new EventHandler(this.\u0088\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0010, \u0018.\u0080.\u0001(39281));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0010, new Size(270, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0010, \u0018.\u0080.\u0001(39314));
      \u0099\u001F.\u007E\u0083\u0087((object) this.\u0010, false);
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0004, \u0018.\u0080.\u0001(39339));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0004, new Size(267, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0011, \u0018.\u0080.\u0001(39368));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0011, new Size(270, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0011, \u0018.\u0080.\u0001(22469));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0011, new EventHandler(this.\u008A\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0015), new ToolStripItem[2]
      {
        (ToolStripItem) this.\u0016,
        (ToolStripItem) this.\u0017
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0015, \u0018.\u0080.\u0001(39393));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0015, new Size(65, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0015, \u0018.\u0080.\u0001(39418));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0016, \u0018.\u0080.\u0001(39435));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0016, new Size(248, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0016, \u0018.\u0080.\u0001(39484));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0016, new EventHandler(this.\u0087\u0005));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0017, \u0018.\u0080.\u0001(39529));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0017, new Size(248, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0017, \u0018.\u0080.\u0001(39562));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0017, new EventHandler(this.\u0086\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0018), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u0019
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0018, \u0018.\u0080.\u0001(22482));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0018, new Size(63, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0018, \u0018.\u0080.\u0001(18429));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0019, \u0018.\u0080.\u0001(31755));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0019, new Size(213, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0019, \u0018.\u0080.\u0001(18471));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0019, new EventHandler(this.\u001F\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u001A), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u001B
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u001A, \u0018.\u0080.\u0001(6649));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u001A, new Size(44, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u001A, \u0018.\u0080.\u0001(6666));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u001B, \u0018.\u0080.\u0001(6675));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u001B, Keys.F1);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u001B, new Size(124, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u001B, \u0018.\u0080.\u0001(6696));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u001B, new EventHandler(this.\u008C\u0005));
      \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) this.\u0001);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001D.\u000E\u008B((object) this, (IButtonControl) this.\u0002);
      \u000E\u001F.\u0010\u008B((object) this, new Size(420, 165));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0018.\u0080.\u0001(6705)));
      \u001A\u001D.\u0019\u008B((object) this, this.\u0001);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0018.\u0080.\u0001(39571));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0018.\u0080.\u0001(39584));
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }
  }
}
