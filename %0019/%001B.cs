// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u0019;
using \u001C;
using \u001D;
using \u001E;
using \u0081;
using \u0084;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TSN.Controls;

namespace \u0019
{
  internal sealed class \u001B : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private Button \u0001;
    private ListView \u0001;
    private ColumnHeader \u0001;
    private Label \u0001;
    private Button \u0002;
    private Label \u0002;
    private SaveFileDialog \u0001;
    private Dictionary<ListViewItemState<string>, \u001B> \u0001;

    static \u001B()
    {
      \u0004.\u001D\u0005(typeof (\u001B));
    }

    public \u001B(Dictionary<ListViewItemState<string>, \u001B> data)
    {
      if (data == null)
        throw new ArgumentNullException(\u001B.\u0001(45514));
      this.\u0001 = data;
      this.\u001D\u0005();
      ListViewItem listViewItem;
      this.\u0001.Keys.\u001D\u0005<ListViewItemState<string>>((Action<ListViewItemState<string>>) (item => listViewItem = \u009C\u0081.\u007E\u0004\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0001), (ListViewItem) item)));
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u001B)));
      this.\u0001 = new Button();
      this.\u0001 = new ListView();
      this.\u0001 = new ColumnHeader();
      this.\u0001 = new Label();
      this.\u0002 = new Button();
      this.\u0002 = new Label();
      this.\u0001 = new SaveFileDialog();
      \u001A\u001E.\u0084\u0086((object) this);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Right);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(263, 344));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u0001(8011));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001B.\u0001(8020));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
      \u0006\u0084.\u007E\u0001\u008D((object) \u009B\u0082.\u007E\u0088\u008C((object) this.\u0001), new ColumnHeader[1]
      {
        this.\u0001
      });
      \u0080\u0082.\u007E\u008B\u008C((object) this.\u0001, ColumnHeaderStyle.Nonclickable);
      \u0099\u001F.\u007E\u008C\u008C((object) this.\u0001, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 74));
      \u0099\u001F.\u007E\u008F\u008C((object) this.\u0001, false);
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u0001(45112));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(326, 264));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0099\u001F.\u007E\u0093\u008C((object) this.\u0001, false);
      \u0017\u0080.\u007E\u0094\u008C((object) this.\u0001, View.Details);
      \u0087\u007F.\u007E\u0095\u008C((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      \u0092\u0081.\u007E\u008E\u0088((object) this.\u0001, \u001B.\u0001(4004));
      \u0011\u001F.\u007E\u0090\u0088((object) this.\u0001, 301);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u001B.\u0001(8947), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(7, 7));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u0001(45125));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(237, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 14);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001B.\u0001(45162));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Top | AnchorStyles.Right);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(182, 344));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001B.\u0001(45199));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001B.\u0001(45212));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(9, 33));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001B.\u0001(6235));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(329, 38));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 17);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001B.\u0001(45221));
      \u0092\u0081.\u007E\u0099\u008A((object) this.\u0001, \u001B.\u0001(45375));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(350, 374));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001B.\u0001(6964)));
      \u000E\u001F.\u007E\u0005\u0084((object) this, new Size(1200, 412));
      \u000E\u001F.\u007E\u0007\u0084((object) this, new Size(366, 412));
      \u0092\u0081.\u0010\u0084((object) this, \u001B.\u0001(45424));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterParent);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u001B.\u0001(45461));
      \u0098\u001C.\u008B\u008B((object) this, new FormClosingEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      if (\u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001)) <= 0)
        return;
      ListViewItemState<string> index = \u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001), 0) as ListViewItemState<string>;
      \u0017 type = \u007F.\u001D\u0005(index.State);
      if (type == \u0017.\u0001)
        return;
      \u0092\u0081.\u007E\u0093\u008A((object) this.\u0001, \u009C\u0080.\u0008\u009F(index.State));
      \u0092\u0081.\u007E\u0095\u008A((object) this.\u0001, type.\u001D\u0005(false));
      if (\u0097\u001E.\u007E\u0088\u0088((object) this.\u0001) != DialogResult.OK)
        return;
      this.\u0001[index].\u001D\u0005(\u0002\u007F.\u007E\u0092\u008A((object) this.\u0001));
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, \u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001)) > 0);
    }

    private void \u001D\u0005(object sender, FormClosingEventArgs e)
    {
      \u0099\u001F.\u007E\u0087\u0001\u0002((object) e, (\u0017.\u001E\u0005(\u001B.\u0001(45523), \u001B.\u0001(45689), \u0016.\u0006, \u0016.\u0007) != DialogResult.Yes ? 1 : 0) != 0);
    }
  }
}
