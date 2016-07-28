// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u007F;
using System;
using System.Collections;
using System.Collections.Generic;
using TSN.Controls;

namespace \u007F
{
  internal sealed class \u001A : IEqualityComparer, IComparer<ListViewItemState<string>>, IComparer, IEqualityComparer<ListViewItemState<string>>
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    public static readonly \u001A \u0001;
    public static readonly \u001A \u0002;
    private bool \u0001;

    static \u001A()
    {
      \u0004.\u001D\u0005(typeof (\u001A));
      \u001A.\u0001 = \u001A.\u0001(76455);
      \u001A.\u0002 = \u001A.\u0001(76496);
      \u001A.\u0003 = \u001A.\u0001(76533);
      \u001A.\u0001 = new \u001A(true);
      \u001A.\u0002 = new \u001A(false);
    }

    private \u001A(bool ignoreCase)
    {
      this.\u0001 = ignoreCase;
    }

    int IComparer.\u001D\u0005(object x, object y)
    {
      if (\u0013\u0080.\u0089\u0091(x, y))
        return 0;
      if (x == null)
        return -1;
      if (y == null)
        return 1;
      ListViewItemState<string> listViewItemState1 = x as ListViewItemState<string>;
      ListViewItemState<string> listViewItemState2 = y as ListViewItemState<string>;
      if (listViewItemState1 == null)
        throw new ArgumentException(\u001A.\u0003);
      if (listViewItemState2 == null)
        throw new ArgumentException(\u001A.\u0002);
      if (this.\u0001)
        return \u0089\u0082.\u007E\u0094\u0093((object) \u0093\u001B.\u0092\u0093(), listViewItemState1.State, listViewItemState2.State);
      return \u0089\u0082.\u007E\u0094\u0093((object) \u0093\u001B.\u0091\u0093(), listViewItemState1.State, listViewItemState2.State);
    }

    int IComparer<ListViewItemState<string>>.\u001D\u0005(ListViewItemState<string> x, ListViewItemState<string> y)
    {
      if (\u0013\u0080.\u0089\u0091((object) x, (object) y))
        return 0;
      if (x == null)
        return -1;
      if (y == null)
        return 1;
      if (this.\u0001)
        return \u0089\u0082.\u007E\u0094\u0093((object) \u0093\u001B.\u0092\u0093(), x.State, y.State);
      return \u0089\u0082.\u007E\u0094\u0093((object) \u0093\u001B.\u0091\u0093(), x.State, y.State);
    }

    bool IEqualityComparer<ListViewItemState<string>>.\u001D\u0005(ListViewItemState<string> x, ListViewItemState<string> y)
    {
      if (\u0013\u0080.\u0089\u0091((object) x, (object) y))
        return true;
      if (x == null || y == null)
        return false;
      if (this.\u0001)
        return \u007F\u0084.\u007E\u0095\u0093((object) \u0093\u001B.\u0092\u0093(), x.State, y.State);
      return \u007F\u0084.\u007E\u0095\u0093((object) \u0093\u001B.\u0091\u0093(), x.State, y.State);
    }

    bool IEqualityComparer.\u001D\u0005(object x, object y)
    {
      if (\u0013\u0080.\u0089\u0091(x, y))
        return true;
      if (x == null || y == null)
        return false;
      ListViewItemState<string> listViewItemState1 = x as ListViewItemState<string>;
      ListViewItemState<string> listViewItemState2 = y as ListViewItemState<string>;
      if (listViewItemState1 == null || listViewItemState2 == null)
        return false;
      if (this.\u0001)
        return \u007F\u0084.\u007E\u0095\u0093((object) \u0093\u001B.\u0092\u0093(), listViewItemState1.State, listViewItemState2.State);
      return \u007F\u0084.\u007E\u0095\u0093((object) \u0093\u001B.\u0091\u0093(), listViewItemState1.State, listViewItemState2.State);
    }

    int IEqualityComparer<ListViewItemState<string>>.\u001D\u0005(ListViewItemState<string> obj)
    {
      if (obj == null)
        throw new ArgumentNullException(\u001A.\u0001(76450));
      if (this.\u0001)
        return \u0089\u0086.\u007E\u0096\u0093((object) \u0093\u001B.\u0092\u0093(), obj.State);
      return \u0089\u0086.\u007E\u0096\u0093((object) \u0093\u001B.\u0091\u0093(), obj.State);
    }

    int IEqualityComparer.\u001D\u0005(object obj)
    {
      if (obj == null)
        throw new ArgumentNullException(\u001A.\u0001(76450));
      ListViewItemState<string> listViewItemState = obj as ListViewItemState<string>;
      if (listViewItemState == null)
        throw new ArgumentException(\u001A.\u0001);
      if (this.\u0001)
        return \u0089\u0086.\u007E\u0096\u0093((object) \u0093\u001B.\u0092\u0093(), listViewItemState.State);
      return \u0089\u0086.\u007E\u0096\u0093((object) \u0093\u001B.\u0091\u0093(), listViewItemState.State);
    }
  }
}
