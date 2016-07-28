// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001C;
using \u001E;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TSN.Controls;

namespace \u001E
{
  internal sealed class \u0005 : ListView
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private ListViewGroup \u0001;
    private ListViewGroup \u0002;
    private ListViewGroup \u0003;
    private ListViewGroup \u0004;
    private ListViewGroup \u0005;
    private ListViewGroup \u0006;
    private ListViewGroup \u0007;
    private ListViewGroup \u0008;
    private ColumnHeader \u0001;
    private Dictionary<\u0018, ListViewItem> \u0001;
    private IContainer \u0001;

    public int MainColumnWidth
    {
      get
      {
        return \u0005\u0081.\u007E\u008F\u0088((object) this.\u0001);
      }
      set
      {
        \u0011\u001F.\u007E\u0090\u0088((object) this.\u0001, value);
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new ListView.ListViewItemCollection Items
    {
      get
      {
        return \u0081\u001F.\u008D\u008C((object) this);
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new ListView.ColumnHeaderCollection Columns
    {
      get
      {
        return \u009B\u0082.\u0088\u008C((object) this);
      }
    }

    static \u0005()
    {
      \u0004.\u001D\u0005(typeof (\u0005));
    }

    public \u0005()
    {
      this.\u001D\u0005();
      this.\u0001 = new Dictionary<\u0018, ListViewItem>();
      this.\u0001 = new ColumnHeader();
      \u0006\u0084.\u007E\u0001\u008D((object) this.Columns, new ColumnHeader[1]
      {
        this.\u0001
      });
      \u0092\u0081.\u007E\u008E\u0088((object) this.\u0001, \u0005.\u0001(64973));
      \u0011\u001F.\u007E\u0090\u0088((object) this.\u0001, 380);
      \u001A\u001E.\u0096\u008C((object) this);
      this.\u0001 = new ListViewGroup(\u0005.\u0001(9183), HorizontalAlignment.Left);
      this.\u0002 = new ListViewGroup(\u0005.\u0001(9192), HorizontalAlignment.Left);
      this.\u0003 = new ListViewGroup(\u0005.\u0001(9205), HorizontalAlignment.Left);
      this.\u0004 = new ListViewGroup(\u0005.\u0001(9218), HorizontalAlignment.Left);
      this.\u0005 = new ListViewGroup(\u0005.\u0001(9231), HorizontalAlignment.Left);
      this.\u0006 = new ListViewGroup(\u0005.\u0001(9244), HorizontalAlignment.Left);
      this.\u0007 = new ListViewGroup(\u0005.\u0001(9257), HorizontalAlignment.Left);
      this.\u0008 = new ListViewGroup(\u0005.\u0001(9270), HorizontalAlignment.Left);
      IEnumerator<\u0018> enumerator = \u0018.\u0001.GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          \u0018 current = enumerator.Current;
          ListViewItem listViewItem1 = (ListViewItem) new ListViewItemState<\u0018>(current, \u0002\u007F.\u007E\u0087\u0091((object) current));
          switch (current.CombinationSize)
          {
            case 1:
              \u001E\u001D.\u007E\u001B\u008D((object) listViewItem1, this.\u0001);
              break;
            case 2:
              \u001E\u001D.\u007E\u001B\u008D((object) listViewItem1, this.\u0002);
              break;
            case 3:
              \u001E\u001D.\u007E\u001B\u008D((object) listViewItem1, this.\u0003);
              break;
            case 4:
              \u001E\u001D.\u007E\u001B\u008D((object) listViewItem1, this.\u0004);
              break;
            case 5:
              \u001E\u001D.\u007E\u001B\u008D((object) listViewItem1, this.\u0005);
              break;
            case 6:
              \u001E\u001D.\u007E\u001B\u008D((object) listViewItem1, this.\u0006);
              break;
            case 7:
              \u001E\u001D.\u007E\u001B\u008D((object) listViewItem1, this.\u0007);
              break;
            case 8:
              \u001E\u001D.\u007E\u001B\u008D((object) listViewItem1, this.\u0008);
              break;
          }
          ListViewItem listViewItem2 = \u009C\u0081.\u007E\u0004\u008D((object) this.Items, listViewItem1);
          this.\u0001.Add(current, listViewItem1);
        }
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
      \u0092\u0081.\u007E\u0012\u008D((object) this.\u0001, \u0005.\u0001(9183));
      \u0092\u0081.\u007E\u0013\u008D((object) this.\u0001, \u0005.\u0001(9713));
      \u0092\u0081.\u007E\u0012\u008D((object) this.\u0002, \u0005.\u0001(9192));
      \u0092\u0081.\u007E\u0013\u008D((object) this.\u0002, \u0005.\u0001(9726));
      \u0092\u0081.\u007E\u0012\u008D((object) this.\u0003, \u0005.\u0001(9205));
      \u0092\u0081.\u007E\u0013\u008D((object) this.\u0003, \u0005.\u0001(9739));
      \u0092\u0081.\u007E\u0012\u008D((object) this.\u0004, \u0005.\u0001(9218));
      \u0092\u0081.\u007E\u0013\u008D((object) this.\u0004, \u0005.\u0001(9752));
      \u0092\u0081.\u007E\u0012\u008D((object) this.\u0005, \u0005.\u0001(9231));
      \u0092\u0081.\u007E\u0013\u008D((object) this.\u0005, \u0005.\u0001(9765));
      \u0092\u0081.\u007E\u0012\u008D((object) this.\u0006, \u0005.\u0001(9244));
      \u0092\u0081.\u007E\u0013\u008D((object) this.\u0006, \u0005.\u0001(9778));
      \u0092\u0081.\u007E\u0012\u008D((object) this.\u0007, \u0005.\u0001(9257));
      \u0092\u0081.\u007E\u0013\u008D((object) this.\u0007, \u0005.\u0001(9791));
      \u0092\u0081.\u007E\u0012\u008D((object) this.\u0008, \u0005.\u0001(9270));
      \u0092\u0081.\u007E\u0013\u008D((object) this.\u0008, \u0005.\u0001(9791));
      \u0014\u001C.\u007E\u0014\u008D((object) \u001B\u007F.\u008A\u008C((object) this), new ListViewGroup[8]
      {
        this.\u0001,
        this.\u0002,
        this.\u0003,
        this.\u0004,
        this.\u0005,
        this.\u0006,
        this.\u0007,
        this.\u0008
      });
      \u001A\u001E.\u0098\u008C((object) this);
      \u0080\u0082.\u008B\u008C((object) this, ColumnHeaderStyle.Nonclickable);
    }

    public void \u001D\u0005(\u0018 combo)
    {
      \u001A\u001E.\u007E\u009E\u008C((object) \u0010\u0082.\u0091\u008C((object) this));
      if (combo == null)
        return;
      ListViewItem listViewItem = this.\u0001[combo];
      \u0099\u001F.\u007E\u001E\u008D((object) listViewItem, true);
      \u001A\u001E.\u0080\u0086((object) this);
    }

    public void \u001E\u0005(int group)
    {
      switch (group + 1)
      {
        case 1:
          this.\u001D\u0005(this.\u0001);
          break;
        case 2:
          this.\u001D\u0005(this.\u0002);
          break;
        case 3:
          this.\u001D\u0005(this.\u0003);
          break;
        case 4:
          this.\u001D\u0005(this.\u0004);
          break;
        case 5:
          this.\u001D\u0005(this.\u0005);
          break;
        case 6:
          this.\u001D\u0005(this.\u0006);
          break;
        case 7:
          this.\u001D\u0005(this.\u0007);
          break;
        case 8:
          this.\u001D\u0005(this.\u0008);
          break;
      }
    }

    private void \u001D\u0005(ListViewGroup grp)
    {
      \u001A\u001E.\u0096\u008C((object) this);
      IEnumerator enumerator = \u0015\u0082.\u007E\u0008\u008D((object) this.Items);
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          ListViewItem listViewItem = (ListViewItem) \u0005\u007F.\u007E\u0092\u0092((object) enumerator);
          \u0099\u001F.\u007E\u0018\u008D((object) listViewItem, \u008E\u001F.\u007E\u001A\u008D((object) listViewItem) == grp);
        }
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        if (disposable != null)
          \u001A\u001E.\u007E\u0094\u0092((object) disposable);
      }
      \u001A\u001E.\u0098\u008C((object) this);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0097\u008C((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = (IContainer) new Container();
    }
  }
}
