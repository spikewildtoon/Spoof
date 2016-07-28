// Decompiled with JetBrains decompiler
// Type: TSN.Controls.ListViewItemState`1
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace TSN.Controls
{
  [Serializable]
  public sealed class ListViewItemState<T> : ListViewItem
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    public readonly T State;

    static ListViewItemState()
    {
      \u0004.\u001D\u0005(typeof (ListViewItemState<>));
    }

    public ListViewItemState(T state)
    {
      this.State = state;
      \u0092\u0081.\u0080\u008D((object) this, state.ToString());
    }

    public ListViewItemState(T state, string text)
    {
      this.State = state;
      \u0092\u0081.\u0080\u008D((object) this, text);
    }

    private ListViewItemState(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      // ISSUE: type reference
      this.State = (T) \u001C\u001C.\u007E\u000E\u009C((object) info, \u0006.\u001D\u0005(100194), \u009C\u0082.\u0016\u0097(__typeref (T)));
    }

    protected override void Serialize(SerializationInfo info, StreamingContext context)
    {
      \u008B\u0083.\u007E\u0007\u009C((object) info, \u0006.\u001D\u0005(100194), (object) this.State);
      \u0001\u0083.\u0081\u008D((object) this, info, context);
    }
  }
}
