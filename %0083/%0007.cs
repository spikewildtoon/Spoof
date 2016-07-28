// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0083;
using System;
using System.Windows.Forms;

namespace \u0083
{
  internal sealed class \u0007 : IDisposable
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private DialogResult? \u0001;
    private bool \u0001;

    public Form Owner { get; private set; }

    public Form ShowingForm { get; private set; }

    public Form ClosingForm { get; private set; }

    static \u0007()
    {
      \u0004.\u001D\u0005(typeof (\u0007));
    }

    public \u0007(Form frm, bool showWhenDisposed)
      : this(frm)
    {
      this.\u0001 = showWhenDisposed;
    }

    public \u0007(Form frm)
    {
      if (frm == null)
        throw new NullReferenceException(\u0007.\u0001(100355));
      if (\u0099\u0082.\u007E\u008A\u0083((object) frm))
        throw new ObjectDisposedException(\u0007.\u0001(100355));
      this.Owner = frm;
    }

    public void \u007F\u0005(Form frm)
    {
      this.\u001D\u0005(frm, true, new DialogResult?());
    }

    public void \u001D\u0005(Form frm, DialogResult nonShowResult)
    {
      this.\u001D\u0005(frm, true, new DialogResult?(nonShowResult));
    }

    public void \u001D\u0005(Form frm, bool autoDisplay)
    {
      this.\u001D\u0005(frm, autoDisplay, new DialogResult?());
    }

    public void \u001D\u0005(Form frm, bool autoDisplay, DialogResult? nonShowResult)
    {
      if (frm == null)
        throw new ArgumentNullException(\u0007.\u0001(100355));
      if (this.ShowingForm != null)
        throw new ArgumentException(\u0007.\u0001(100360));
      this.ShowingForm = frm;
      \u0087\u007F.\u007E\u008F\u008B((object) this.ShowingForm, new EventHandler(this.\u001D\u0005));
      if (!autoDisplay)
        return;
      this.\u001D\u0005(this.ShowingForm, nonShowResult);
    }

    public void \u001D\u0005()
    {
      if (this.ShowingForm == null)
        return;
      // ISSUE: method pointer
      \u0087\u007F.\u007E\u0090\u008B((object) this.ShowingForm, new EventHandler((object) this, __methodptr(\u001D\u0005)));
      if (this.ClosingForm == this.ShowingForm)
        this.\u001E\u0005();
      this.ShowingForm = (Form) null;
    }

    public void \u001D\u0005(Form frm, DialogResult? nonShowResult)
    {
      if (frm == null)
        throw new ArgumentNullException(\u0007.\u0001(100355));
      if (this.ClosingForm != null)
        throw new ArgumentException(\u0007.\u0001(100453));
      this.\u0001 = nonShowResult;
      this.ClosingForm = frm;
      \u0098\u001C.\u007E\u008B\u008B((object) this.ClosingForm, new FormClosingEventHandler(this.\u001D\u0005));
    }

    public void \u001E\u0005()
    {
      if (this.ClosingForm == null)
        return;
      this.\u0001 = new DialogResult?();
      // ISSUE: method pointer
      \u0098\u001C.\u007E\u008C\u008B((object) this.ClosingForm, new FormClosingEventHandler((object) this, __methodptr(\u001D\u0005)));
      this.ClosingForm = (Form) null;
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      \u001A\u001E.\u007E\u0001\u0086((object) this.Owner);
    }

    private void \u001D\u0005(object sender, FormClosingEventArgs e)
    {
      if (\u0099\u0082.\u007E\u0086\u0001\u0002((object) e))
        return;
      if (this.\u0001.HasValue)
      {
        DialogResult dialogResult = \u0097\u001E.\u007E\u0014\u008B((object) (Form) sender);
        DialogResult? nullable = this.\u0001;
        if ((dialogResult != nullable.GetValueOrDefault() ? 1 : (!nullable.HasValue ? 1 : 0)) == 0)
          return;
      }
      \u001A\u001E.\u007E\u0083\u0086((object) this.Owner);
      \u001A\u001E.\u007E\u001E\u0086((object) this.Owner);
    }

    public void Dispose()
    {
      if (!\u0099\u0082.\u007E\u008A\u0083((object) this.Owner))
        goto label_4;
label_3:
      this.\u001D\u0005();
      this.\u001E\u0005();
      this.Owner = (Form) null;
      return;
label_4:
      if (this.\u0001)
        \u001A\u001E.\u007E\u0083\u0086((object) this.Owner);
      \u001A\u001E.\u007E\u009B\u0084((object) this.Owner);
      \u001A\u001E.\u007E\u0091\u008B((object) this.Owner);
      goto label_3;
    }
  }
}
