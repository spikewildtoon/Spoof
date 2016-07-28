// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0018;
using \u001A;
using \u001B;
using \u0082;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u0014
{
  internal sealed class \u001C : Form
  {
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
    private \u001D.\u0001 \u0001;
    private \u0003 \u0001;
    private IContainer \u0001;
    private \u001A.\u0082 \u0001;
    private TextBox \u0001;
    private TextBox \u0002;
    private TextBox \u0003;
    private Button \u0001;
    private Button \u0002;
    private Button \u0003;
    private Button \u0004;
    private Button \u0005;
    private RadioButton \u0001;
    private RadioButton \u0002;
    private \u001C \u0001;
    private Label \u0001;
    private Label \u0002;
    private Label \u0003;
    private Label \u0004;
    private Label \u0005;
    private Label \u0006;
    private ToolTip \u0001;
    private Button \u0006;
    private Button \u0007;

    static \u001C()
    {
      \u0004.\u001D\u0005(typeof (\u001C));
      \u001C.\u0001 = \u001C.\u0001(7397);
      \u001C.\u0002 = \u001C.\u0001(7458);
      \u001C.\u0003 = \u001C.\u0001(7487);
      \u001C.\u0004 = \u001C.\u0001(7536);
      \u001C.\u0005 = \u001C.\u0001(7561);
      \u001C.\u0006 = \u001C.\u0001(7610);
      \u001C.\u0007 = \u001C.\u0001(7635);
      \u001C.\u0008 = \u001C.\u0001(7712);
    }

    public \u001C()
    {
      this.\u001F\u0005();
      this.\u0001 = \u0081.\u0080.Instance.ConnectSettings;
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0001, (Image) \u0013.Save_16x16);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0002, (Image) \u0013.Cancel_16x16);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0003, (Image) \u0013.Delete_16x16);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0005, (Image) \u0013.Checkmark_16x16);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0004, (Image) \u0013.Edit_16x16);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0006, (Image) \u0013.Down_16x16);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0007, (Image) \u0013.Up_16x16);
      \u0003\u0083.\u007E\u001D\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object[]) this.\u0001.ToonTownAccounts.ToArray());
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u0001 = \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001) as \u0003;
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, this.\u0001.ReferenceName);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, this.\u0001.Username);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, this.\u0001.Password);
      if (this.\u0001.ToonTownAccountType == \u0080.\u0001.\u0002)
        \u0099\u001F.\u007E\u0091\u008E((object) this.\u0002, true);
      else
        \u0099\u001F.\u007E\u0091\u008E((object) this.\u0001, true);
      this.\u001E\u0005();
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      \u0003 obj = \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001) as \u0003;
      if (6 != (int) \u0017.\u001E\u0005(\u009E\u0081.\u001F\u0093(\u001C.\u0007, (object) obj.ReferenceName), \u001C.\u0008, \u0016.\u0006, \u0016.\u0007))
        return;
      this.\u0001.ToonTownAccounts.Remove(obj);
      \u008E\u007F.\u007E\u0082\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) obj);
      this.\u001E\u0005();
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      this.\u0001 = (\u0003) null;
      this.\u001D\u0005();
      this.\u001E\u0005();
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      if (\u008F\u0084.\u009E\u0092(\u0002\u007F.\u007E\u001C\u0084((object) this.\u0001)))
      {
        \u0017.\u001D\u0005(\u001C.\u0001, \u001C.\u0002);
        int num = \u0099\u0082.\u007E\u009E\u0084((object) this.\u0001) ? 1 : 0;
      }
      else if (\u008F\u0084.\u009E\u0092(\u0002\u007F.\u007E\u001C\u0084((object) this.\u0002)))
      {
        \u0017.\u001D\u0005(\u001C.\u0003, \u001C.\u0004);
        int num = \u0099\u0082.\u007E\u009E\u0084((object) this.\u0002) ? 1 : 0;
      }
      else if (\u008F\u0084.\u009E\u0092(\u0002\u007F.\u007E\u001C\u0084((object) this.\u0003)))
      {
        \u0017.\u001D\u0005(\u001C.\u0005, \u001C.\u0006);
        int num = \u0099\u0082.\u007E\u009E\u0084((object) this.\u0003) ? 1 : 0;
      }
      else
      {
        \u0080.\u0001 type = !\u0099\u0082.\u007E\u0090\u008E((object) this.\u0002) ? \u0080.\u0001.\u0003 : \u0080.\u0001.\u0002;
        if (this.\u0001 == null)
        {
          \u0003 obj = new \u0003(\u0002\u007F.\u007E\u001C\u0084((object) this.\u0001), \u0002\u007F.\u007E\u001C\u0084((object) this.\u0002), \u0002\u007F.\u007E\u001C\u0084((object) this.\u0003), type);
          this.\u0001.ToonTownAccounts.Add(obj);
          int num = \u007F\u001F.\u007E\u001C\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), (object) obj);
        }
        else
        {
          this.\u0001.ReferenceName = \u0002\u007F.\u007E\u001C\u0084((object) this.\u0001);
          this.\u0001.Username = \u0002\u007F.\u007E\u001C\u0084((object) this.\u0002);
          this.\u0001.Password = \u0002\u007F.\u007E\u001C\u0084((object) this.\u0003);
          this.\u0001.ToonTownAccountType = type;
          this.\u0001.\u0087\u0002(\u0005\u0081.\u007E\u0008\u0088((object) this.\u0001));
          this.\u0001 = (\u0003) null;
        }
        this.\u001D\u0005();
        this.\u001E\u0005();
      }
    }

    private void \u001D\u0005()
    {
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, string.Empty);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, string.Empty);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, string.Empty);
      \u0099\u001F.\u007E\u0091\u008E((object) this.\u0002, true);
      \u0099\u001F.\u007E\u0091\u008E((object) this.\u0001, false);
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005();
    }

    private void \u001E\u0005()
    {
      if (this.\u0001 == null)
      {
        \u0099\u001F obj = \u0099\u001F.\u007E\u008F\u0083;
        Button button = this.\u0004;
        bool flag;
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, flag = \u0005\u0081.\u007E\u0008\u0088((object) this.\u0001) > -1);
        int num = flag ? 1 : 0;
        obj((object) button, num != 0);
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, true);
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, false);
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0006, \u0005\u0081.\u007E\u0008\u0088((object) this.\u0001) < \u0005\u0081.\u007E\u001B\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001)) - 1);
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0007, \u0005\u0081.\u007E\u0008\u0088((object) this.\u0001) > 0);
      }
      else
      {
        \u0099\u001F obj1 = \u0099\u001F.\u007E\u008F\u0083;
        Button button1 = this.\u0007;
        \u0099\u001F obj2 = \u0099\u001F.\u007E\u008F\u0083;
        Button button2 = this.\u0006;
        \u0099\u001F obj3 = \u0099\u001F.\u007E\u008F\u0083;
        \u001A.\u0082 obj4 = this.\u0001;
        \u0099\u001F obj5 = \u0099\u001F.\u007E\u008F\u0083;
        Button button3 = this.\u0004;
        bool flag1;
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, flag1 = false);
        int num1;
        bool flag2 = (num1 = flag1 ? 1 : 0) != 0;
        obj5((object) button3, num1 != 0);
        int num2;
        bool flag3 = (num2 = flag2 ? 1 : 0) != 0;
        obj3((object) obj4, num2 != 0);
        int num3;
        bool flag4 = (num3 = flag3 ? 1 : 0) != 0;
        obj2((object) button2, num3 != 0);
        int num4 = flag4 ? 1 : 0;
        obj1((object) button1, num4 != 0);
        \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, true);
      }
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001D\u0005(object sender, HelpEventArgs hlpevent)
    {
      \u0080.\u0082.\u001D\u0005(\u0002.\u007F);
      \u0099\u001F.\u007E\u0003\u008C((object) hlpevent, true);
    }

    private void \u001D\u0005(bool move_up)
    {
      int index1 = \u0005\u0081.\u007E\u0008\u0088((object) this.\u0001);
      int index2 = !move_up ? index1 + 1 : index1 - 1;
      \u0003 obj = \u0005\u007F.\u007E\u0012\u0088((object) this.\u0001) as \u0003;
      \u008E\u007F.\u007E\u0013\u0088((object) this.\u0001, (object) null);
      \u0011\u001F.\u007E\u0083\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), index1);
      \u008C\u0080.\u007E\u0081\u0088((object) \u0019\u0082.\u007E\u0011\u0088((object) this.\u0001), index2, (object) obj);
      this.\u0001.ToonTownAccounts.RemoveAt(index1);
      this.\u0001.ToonTownAccounts.Insert(index2, obj);
      \u0011\u001F.\u007E\u000E\u0088((object) this.\u0001, index2);
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      this.\u001D\u0005(false);
    }

    private void \u0083\u0005(object sender, EventArgs e)
    {
      this.\u001D\u0005(true);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    private void \u001F\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u001C)));
      this.\u0001 = new \u001A.\u0082();
      this.\u0001 = new TextBox();
      this.\u0002 = new TextBox();
      this.\u0003 = new TextBox();
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      this.\u0003 = new Button();
      this.\u0004 = new Button();
      this.\u0005 = new Button();
      this.\u0001 = new RadioButton();
      this.\u0002 = new RadioButton();
      this.\u0001 = new \u001C();
      this.\u0006 = new Button();
      this.\u0007 = new Button();
      this.\u0006 = new Label();
      this.\u0002 = new Label();
      this.\u0003 = new Label();
      this.\u0004 = new Label();
      this.\u0005 = new Label();
      this.\u0001 = new Label();
      this.\u0001 = new ToolTip(this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u001C.\u0001(5730), 9.75f));
      \u0099\u001F.\u007E\u0007\u0088((object) this.\u0001, true);
      \u0011\u001F.\u007E\u0010\u0088((object) this.\u0001, 16);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(323, 41));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001C.\u0001(6650));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(237, 116));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 5);
      \u0087\u007F.\u007E\u0016\u0088((object) this.\u0001, new EventHandler(this.\u0080\u0005));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u001C.\u0001(5730), 9.75f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(161, 41));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001C.\u0001(6667));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(156, 22));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u001C.\u0001(5730), 9.75f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(161, 72));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001C.\u0001(6688));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(156, 22));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u001C.\u0001(5730), 9.75f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(161, 103));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u001C.\u0001(6705));
      \u0090\u001E.\u007E\u0087\u008A((object) this.\u0003, '*');
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(156, 22));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 2);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(323, 160));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001C.\u0001(6722));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(26, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 6);
      \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this.\u0001, \u001C.\u0001(6743));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u007F\u0005));
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(355, 160));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001C.\u0001(6768));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(26, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 7);
      \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this.\u0002, \u001C.\u0001(6793));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001F\u0005));
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0003, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(387, 160));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u001C.\u0001(6814));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(26, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 8);
      \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this.\u0003, \u001C.\u0001(6839));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0003, new EventHandler(this.\u001E\u0005));
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0004, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(419, 160));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u001C.\u0001(6876));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(26, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 9);
      \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this.\u0004, \u001C.\u0001(6901));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0004, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0004, new EventHandler(this.\u001D\u0005));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0005, new Font(\u001C.\u0001(4151), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(451, 160));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u001C.\u0001(6938));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(26, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 10);
      \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this.\u0005, \u001C.\u0001(6951));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0005, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0005, new EventHandler(this.\u0081\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u001C.\u0001(5730), 8.25f));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(218, 132));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001C.\u0001(6960));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(49, 18));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 4);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001C.\u0001(6981));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, false);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0099\u001F.\u007E\u0091\u008E((object) this.\u0002, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u001C.\u0001(5730), 8.25f));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(157, 132));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001C.\u0001(6990));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(55, 18));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 3);
      \u0099\u001F.\u007E\u0092\u008E((object) this.\u0002, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001C.\u0001(7011));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, false);
      this.\u0001.CenterColor = \u008E\u001D.\u0017\u007F(224, 224, 224);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Fill);
      this.\u0001.HeaderHeight = 30;
      this.\u0001.ImageBounds = new Rectangle(0, 0, 0, 0);
      this.\u0001.ImageLocation = new Point(0, 0);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(4, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001C.\u0001(7020));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(565, 191));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 12);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0006, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(502, 160));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u001C.\u0001(7037));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(26, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 11);
      \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this.\u0006, \u001C.\u0001(7058));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0006, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0006, new EventHandler(this.\u0082\u0005));
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0007, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(534, 160));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u001C.\u0001(7099));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(26, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 12);
      \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this.\u0007, \u001C.\u0001(7116));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0007, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0007, new EventHandler(this.\u0083\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0006, AnchorStyles.Bottom | AnchorStyles.Left);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0006, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0006, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0006, new Font(\u001C.\u0001(4151), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0006, \u009A\u0080.\u0092\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(3, 176));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u001C.\u0001(6514));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(105, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 25);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0006, \u001C.\u0001(6539));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u001C.\u0001(5730), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(47, 40));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001C.\u0001(7157));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(104, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001C.\u0001(7166));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u001C.\u0001(5730), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0003, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(7, 71));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u001C.\u0001(7187));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(144, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u001C.\u0001(7196));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0004, new Font(\u001C.\u0001(5730), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0004, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(98, 132));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u001C.\u0001(4544));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(53, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u001C.\u0001(7221));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0005, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0005, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0005, new Font(\u001C.\u0001(5730), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0005, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(80, 102));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u001C.\u0001(7234));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(71, 16));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u001C.\u0001(7243));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u001C.\u0001(7256), 12f, FontStyle.Bold));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(95, 95, 95));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(4, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001C.\u0001(7269));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(206, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 13);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001C.\u0001(7278));
      \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) this.\u0005);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u008E\u001D.\u0017\u007F(218, 228, 246));
      \u000E\u001F.\u0010\u008B((object) this, new Size(573, 199));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001C.\u0001(5273)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u001C.\u0001(7311));
      \u0001\u001F.\u0089\u0084((object) this, new Padding(4));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterParent);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u001C.\u0001(7332));
      \u009E\u001C.\u0087\u0084((object) this, new HelpEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
    }
  }
}
