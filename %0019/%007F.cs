// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.Collections;
using System.Windows.Forms;

namespace \u0019
{
  internal sealed class \u007F : IComparer
  {
    private CaseInsensitiveComparer \u0001;

    public int SortColumn { get; set; }

    public SortOrder Order { get; set; }

    public \u007F()
    {
      this.SortColumn = 0;
      this.Order = SortOrder.None;
      this.\u0001 = new CaseInsensitiveComparer();
    }

    public int Compare(object x, object y)
    {
      ListViewItem listViewItem1 = y as ListViewItem;
      ListViewItem listViewItem2 = x as ListViewItem;
      int num = \u0086\u0086.\u007E\u0086\u0099((object) this.\u0001, (object) \u0002\u007F.\u007E\u0083\u008D((object) \u008B\u001F.\u007E\u0086\u008D((object) \u001D\u0080.\u007E\u001F\u008D((object) listViewItem2), this.SortColumn)), (object) \u0002\u007F.\u007E\u0083\u008D((object) \u008B\u001F.\u007E\u0086\u008D((object) \u001D\u0080.\u007E\u001F\u008D((object) listViewItem1), this.SortColumn)));
      if (this.Order == SortOrder.Ascending)
        return num;
      if (this.Order == SortOrder.Descending)
        return -num;
      return 0;
    }
  }
}
