// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u0019;
using \u001A;
using \u001D;
using \u0081;
using \u0082;
using \u0084;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace \u001A
{
  internal class \u0003 : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private Button \u0001;
    private Button \u0002;
    private Button \u0003;
    private Button \u0004;
    private ListBox \u0001;
    private OpenFileDialog \u0001;
    private Button \u0005;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    private System.Type \u0001;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public \u001B SelectedFileInfo { get; private set; }

    public string InputLabelMessage { get; set; }

    public string InputText { get; set; }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public \u001B[] FileInfo
    {
      get
      {
        return \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001).OfType<\u001B>().ToArray<\u001B>();
      }
      set
      {
        \u001A\u001E.\u007E\u0017\u0088((object) this.\u0001);
        \u0099\u001F.\u007E\u0015\u0088((object) this.\u0001, false);
        \u001A\u001E.\u007E\u001F\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001));
        \u0003\u0083.\u007E\u001D\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object[]) value);
        \u0099\u001F.\u007E\u0015\u0088((object) this.\u0001, true);
        \u001A\u001E.\u007E\u0018\u0088((object) this.\u0001);
      }
    }

    public string Filter
    {
      get
      {
        return \u0002\u007F.\u007E\u0094\u008A((object) this.\u0001);
      }
      set
      {
        \u0092\u0081.\u007E\u0095\u008A((object) this.\u0001, value);
      }
    }

    public string InstallFolder { get; set; }

    public string FileExtension { get; set; }

    public event EventHandler<\u0011<string>> InputValidating;

    static \u0003()
    {
      \u0004.\u001D\u0005(typeof (\u0003));
      \u0003.\u0001 = \u0003.\u0001(48410);
      \u0003.\u0002 = \u0003.\u0001(48483);
      \u0003.\u0003 = \u0003.\u0001(48512);
      \u0003.\u0004 = \u0003.\u0001(48537);
      \u0003.\u0005 = \u0003.\u0001(48606);
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
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      this.\u0003 = new Button();
      this.\u0004 = new Button();
      this.\u0001 = new ListBox();
      this.\u0001 = new OpenFileDialog();
      this.\u0005 = new Button();
      \u001A\u001E.\u0084\u0086((object) this);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Bottom | AnchorStyles.Left);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(93, 190));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(48319));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0003.\u0001(44169));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Bottom | AnchorStyles.Right);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(207, 190));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0003.\u0001(48332));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0003.\u0001(48345));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u007F\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0003, AnchorStyles.Bottom | AnchorStyles.Right);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(288, 190));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0003.\u0001(48354));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0003.\u0001(6774));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0003, new EventHandler(this.\u001D\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0004, AnchorStyles.Bottom | AnchorStyles.Right);
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0004, DialogResult.Cancel);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(369, 190));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0003.\u0001(8170));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0003.\u0001(8183));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0004, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0004, new EventHandler(this.\u001E\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
      \u0099\u001F.\u007E\u0007\u0088((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 9));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0003.\u0001(45257));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(432, 173));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0087\u007F.\u007E\u0016\u0088((object) this.\u0001, new EventHandler(this.\u0081\u0005));
      \u0087\u007F.\u007E\u008B\u0084((object) this.\u0001, new EventHandler(this.\u0082\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0005, AnchorStyles.Bottom | AnchorStyles.Left);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(12, 190));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0003.\u0001(48367));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 4);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u0003.\u0001(48380));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0005, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0005, new EventHandler(this.\u0080\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(456, 223));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0003.\u0001(7109)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u000E\u001F.\u007E\u0007\u0084((object) this, new Size(429, 158));
      \u0092\u0081.\u0010\u0084((object) this, \u0003.\u0001(48389));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterParent);
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    public void \u001D\u0005<T>() where T : \u0014
    {
      // ISSUE: type reference
      this.\u0001 = \u009C\u0082.\u0016\u0097(__typeref (T));
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      if (!this.\u001D\u0005())
        return;
      this.\u001E\u0005();
    }

    private void \u001E\u0005()
    {
      this.SelectedFileInfo = \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001) as \u001B;
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.Cancel);
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      if (!this.\u001D\u0005())
        return;
      \u001B obj = \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001) as \u001B;
      if (\u0017.\u001E\u0005(\u009E\u0081.\u001F\u0093(\u0003.\u0004, (object) obj.\u0001), \u0003.\u0005, \u0016.\u0006, \u0016.\u0007) != DialogResult.Yes)
        return;
      \u001E.\u0019.\u007F\u0005(obj.\u0002);
      \u008E\u007F.\u007E\u0082\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) obj);
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      if (\u0097\u001E.\u007E\u0088\u0088((object) this.\u0001) != DialogResult.OK)
        return;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0003.\u0001 obj1 = new \u0003.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = \u0092\u001E.\u007E\u001A\u0093((object) \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001), \u000F\u001C.\u0011\u009C());
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = (\u001B) null;
      // ISSUE: reference to a compiler-generated method
      if (((IEnumerable<\u001B>) this.FileInfo).\u001D\u0005<\u001B>(new Func<\u001B, bool>(obj1.\u001D\u0005)))
      {
        // ISSUE: reference to a compiler-generated field
        this.SelectedFileInfo = obj1.\u0001;
        \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
      }
      else
      {
        // ISSUE: type reference
        System.Type type = \u009C\u0082.\u0016\u0097(__typeref (\u0014));
        if (\u0091\u001F.\u001B\u0097(this.\u0001, (System.Type) null))
          type = this.\u0001;
        \u0014 obj2 = (\u0014) \u009D\u001B.\u0084\u0094(type);
        try
        {
          obj2.LabelMessage = this.InputLabelMessage;
          \u0092\u0081.\u007E\u001D\u0084((object) obj2, this.InputText);
          obj2.InputValidating += (EventHandler<\u0011<string>>) ((obj, args) =>
          {
            if (this.\u0001 != null)
              goto label_2;
label_1:
            args.IsValid = true;
            return;
label_2:
            this.\u0001((object) this, args);
            goto label_1;
          });
          if (\u0097\u001E.\u007E\u0099\u008B((object) obj2) != DialogResult.OK)
            return;
          // ISSUE: reference to a compiler-generated field
          if (this.InstallFolder != null && !\u0014.\u001D\u0005(this.InstallFolder, \u009C\u0080.\u0005\u009F(obj1.\u0001)))
          {
            if (\u008F\u0084.\u009E\u0092(this.FileExtension))
              throw new InvalidOperationException(\u0003.\u0001);
            string str = \u0016.\u001E\u0005(this.InstallFolder, this.FileExtension);
            try
            {
              // ISSUE: reference to a compiler-generated field
              \u0096\u0083.\u008F\u009E(obj1.\u0001, str);
            }
            catch (Exception ex)
            {
              // ISSUE: reference to a compiler-generated field
              \u0017.\u001D\u0005(ex, obj1.\u0001);
              return;
            }
            // ISSUE: reference to a compiler-generated field
            obj1.\u0001 = str;
          }
          // ISSUE: reference to a compiler-generated field
          this.SelectedFileInfo = new \u001B(obj2.Value, obj1.\u0001);
          int num = \u007F\u001F.\u007E\u001C\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) new \u001B(this.SelectedFileInfo.\u0001, this.SelectedFileInfo.\u0002));
          \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
        }
        finally
        {
          if (obj2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj2);
        }
      }
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      if (!this.\u001D\u0005())
        return;
      \u0003.\u001E\u0005((\u0005\u007F.\u007E\u0012\u0088((object) this.\u0001) as \u001B).\u0002);
    }

    private bool \u001D\u0005()
    {
      if (\u0005\u0081.\u007E\u0008\u0088((object) this.\u0001) != -1)
        return true;
      \u0017.\u001D\u0005(\u0003.\u0002, \u0003.\u0003);
      return false;
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, \u0005\u0081.\u007E\u0008\u0088((object) this.\u0001) > -1);
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      if (\u0005\u0081.\u007E\u0008\u0088((object) this.\u0001) <= -1)
        return;
      this.\u001E\u0005();
    }
  }
}
