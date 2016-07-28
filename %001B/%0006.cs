// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001B;
using \u001C;
using \u001E;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TSN.Controls;

namespace \u001B
{
  internal sealed class \u0006 : UserControl
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u0005 \u0001;
    private RadioButton \u0001;
    private RadioButton \u0002;
    private Button \u0001;
    private \u0018 \u0001;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [Browsable(false)]
    public \u0018 BeanCombination
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
          \u0099\u001F.\u007E\u0091\u008E((object) this.\u0001, true);
          \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
        }
        else
        {
          \u0099\u001F.\u007E\u0091\u008E((object) this.\u0002, true);
          \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, true);
        }
        this.\u0001.\u001D\u0005(this.\u0001);
      }
    }

    public event EventHandler ClosePopup;

    static \u0006()
    {
      \u0004.\u001D\u0005(typeof (\u0006));
    }

    public \u0006()
    {
      this.\u001D\u0005();
      \u0099\u001F.\u007E\u0087\u008C((object) this.\u0001, false);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009A\u0086((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      ListViewGroup listViewGroup1 = new ListViewGroup(\u0006.\u0001(7997), HorizontalAlignment.Left);
      ListViewGroup listViewGroup2 = new ListViewGroup(\u0006.\u0001(8006), HorizontalAlignment.Left);
      ListViewGroup listViewGroup3 = new ListViewGroup(\u0006.\u0001(8019), HorizontalAlignment.Left);
      ListViewGroup listViewGroup4 = new ListViewGroup(\u0006.\u0001(8032), HorizontalAlignment.Left);
      ListViewGroup listViewGroup5 = new ListViewGroup(\u0006.\u0001(8045), HorizontalAlignment.Left);
      ListViewGroup listViewGroup6 = new ListViewGroup(\u0006.\u0001(8058), HorizontalAlignment.Left);
      ListViewGroup listViewGroup7 = new ListViewGroup(\u0006.\u0001(8071), HorizontalAlignment.Left);
      ListViewGroup listViewGroup8 = new ListViewGroup(\u0006.\u0001(8084), HorizontalAlignment.Left);
      this.\u0001 = new RadioButton();
      this.\u0002 = new RadioButton();
      this.\u0001 = new Button();
      this.\u0001 = new \u0005();
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0099\u001F.\u007E\u0091\u008E((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(8, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0006.\u0001(54379));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(54, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0099\u001F.\u007E\u0092\u008E((object) this.\u0001, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0006.\u0001(54400));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(68, 4));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0006.\u0001(54413));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(60, 17));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0006.\u0001(54430));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0006.\u0001(6288), 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(187, 3));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0006.\u0001(16054));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(18, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0006.\u0001(16067));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u007F\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u0008\u007F());
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup1, \u0006.\u0001(7997));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup1, \u0006.\u0001(8527));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup2, \u0006.\u0001(8006));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup2, \u0006.\u0001(8540));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup3, \u0006.\u0001(8019));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup3, \u0006.\u0001(8553));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup4, \u0006.\u0001(8032));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup4, \u0006.\u0001(8566));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup5, \u0006.\u0001(8045));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup5, \u0006.\u0001(8579));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup6, \u0006.\u0001(8058));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup6, \u0006.\u0001(8592));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup7, \u0006.\u0001(8071));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup7, \u0006.\u0001(8605));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup8, \u0006.\u0001(8084));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup8, \u0006.\u0001(8605));
      \u0014\u001C.\u007E\u0014\u008D((object) \u001B\u007F.\u007E\u008A\u008C((object) this.\u0001), new ListViewGroup[8]
      {
        listViewGroup1,
        listViewGroup2,
        listViewGroup3,
        listViewGroup4,
        listViewGroup5,
        listViewGroup6,
        listViewGroup7,
        listViewGroup8
      });
      \u0080\u0082.\u007E\u008B\u008C((object) this.\u0001, ColumnHeaderStyle.Nonclickable);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(5, 23));
      this.\u0001.MainColumnWidth = 176;
      \u0099\u001F.\u007E\u008F\u008C((object) this.\u0001, false);
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0006.\u0001(54439));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(200, 182));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0099\u001F.\u007E\u0093\u008C((object) this.\u0001, false);
      \u0017\u0080.\u007E\u0094\u008C((object) this.\u0001, View.Details);
      \u0087\u007F.\u007E\u0095\u008C((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      \u000F\u0086.\u007E\u0091\u0084((object) this.\u0001, new MouseEventHandler(this.\u001D\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u009A\u0080.\u0016\u0081());
      \u0012\u0082.\u009D\u0090((object) this, BorderStyle.FixedSingle);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0092\u0081.\u0010\u0084((object) this, \u0006.\u0001(54464));
      \u000E\u001F.\u0018\u0084((object) this, new Size(210, 210));
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      if (this.BeanCombination == null || !\u0099\u0082.\u007E\u0090\u008E((object) this.\u0001))
        return;
      this.BeanCombination = (\u0018) null;
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      if (this.BeanCombination != null || !\u0099\u0082.\u007E\u0090\u008E((object) this.\u0002))
        return;
      this.BeanCombination = \u0018.\u0001[0];
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      if (\u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001)) > 0)
        this.\u0001 = ((ListViewItemState<\u0018>) \u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001), 0)).State;
      else
        this.\u0001 = (\u0018) null;
    }

    private void \u001D\u0005(object sender, MouseEventArgs e)
    {
      if (\u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001)) <= 0)
        return;
      this.\u001E\u0005();
    }

    private void \u001E\u0005()
    {
      if (this.\u0001 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005();
    }
  }
}
