// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0019;
using \u007F;
using System;
using System.Collections;
using System.Collections.Generic;
using TSN.Controls;

namespace \u0019
{
  internal sealed class \u0016 : IComparer, IComparer<ListViewItemState<string>>
  {
    private static readonly Lazy<\u0016> \u0001 = new Lazy<\u0016>((Func<\u0016>) (() => new \u0016()));
    private static readonly Lazy<\u0016> \u0002 = new Lazy<\u0016>((Func<\u0016>) (() => new \u0016(true)));
    private bool \u0001;

    internal static \u0016 Default
    {
      get
      {
        return \u0016.\u0001.Value;
      }
    }

    internal static \u0016 DefaultZeroesFirst
    {
      get
      {
        return \u0016.\u0002.Value;
      }
    }

    private \u0016()
    {
    }

    private \u0016(bool zeroesFirst)
    {
      this.\u0001 = zeroesFirst;
    }

    int IComparer.\u001D\u0005(object x, object y)
    {
      if (x == null && y == null)
        return 0;
      if (x == null)
        return -1;
      if (y == null)
        return 1;
      ListViewItemState<string> listViewItemState1 = x as ListViewItemState<string>;
      ListViewItemState<string> listViewItemState2 = y as ListViewItemState<string>;
      if (listViewItemState1 == null || listViewItemState2 == null)
        return \u0086\u0086.\u007E\u0091\u0099((object) Comparer.Default, x, y);
      if (this.\u0001)
        return \u0003.DefaultZeroesFirst.Compare(listViewItemState1.State, listViewItemState2.State);
      return \u0003.Default.Compare(listViewItemState1.State, listViewItemState2.State);
    }

    public int Compare(ListViewItemState<string> x, ListViewItemState<string> y)
    {
      if (x == null && y == null)
        return 0;
      if (x == null)
        return -1;
      if (y == null)
        return 1;
      if (!this.\u0001)
        return \u0003.Default.Compare(x.State, y.State);
      return \u0003.DefaultZeroesFirst.Compare(x.State, y.State);
    }
  }
}
