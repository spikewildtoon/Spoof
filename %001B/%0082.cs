// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0019;
using \u001A;
using \u001B;
using \u001F;
using \u007F;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u001B
{
  internal sealed class \u0082 : UserControl
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u0007 \u0001;
    private \u001E \u0001;
    private \u001E \u0002;
    private readonly \u000F<\u001B.\u0082.\u0001> \u0001;
    private readonly Dictionary<string, \u001B.\u0082.\u0001> \u0001;
    private \u0003 \u0001;
    private \u001B.\u0082.\u0001 \u0001;
    private int \u0001;

    static \u0082()
    {
      \u0004.\u001D\u0005(typeof (\u001B.\u0082));
    }

    public \u0082()
    {
      this.\u001D\u0005();
      this.\u0001 = -1;
      this.\u0001 = new Dictionary<string, \u001B.\u0082.\u0001>((IEqualityComparer<string>) \u0093\u001B.\u0092\u0093());
      this.\u0001 = new \u000F<\u001B.\u0082.\u0001>(50);
      this.\u0001.GroupCreated += new EventHandler<\u000F>(this.\u001E\u0005);
      this.\u0001.GroupDestroyed += new EventHandler<\u000F>(this.\u001D\u0005);
      this.\u0001.ItemAdded += new EventHandler<\u0005<\u001B.\u0082.\u0001>>(this.\u001D\u0005);
      this.\u0001.ItemMoved += new EventHandler<\u0010<\u001B.\u0082.\u0001>>(this.\u001D\u0005);
      this.\u0001.ItemRemoved += new EventHandler<\u0082.\u001F<\u001B.\u0082.\u0001>>(this.\u001D\u0005);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
        goto label_8;
label_7:
      \u0099\u001F.\u009A\u0086((object) this, disposing);
      return;
label_8:
      foreach (KeyValuePair<string, \u001B.\u0082.\u0001> keyValuePair in this.\u0001)
        keyValuePair.Value.Dispose();
      if (this.\u0001 != null)
      {
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
        goto label_7;
      }
      else
        goto label_7;
    }

    private void \u001D\u0005()
    {
      this.\u0002 = new \u001E();
      this.\u0001 = new \u001E();
      this.\u0001 = new \u0007();
      \u001A\u001E.\u0084\u0086((object) this);
      \u0081\u001C.\u007E\u0088\u0083((object) this.\u0002, \u009B\u0086.\u0008\u008A());
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0002, false);
      this.\u0002.HoverEndColor = \u009A\u0080.\u0096\u001F();
      this.\u0002.HoverStartColor = \u009A\u0080.\u000E\u007F();
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(3, 76));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001B.\u0082.\u0001(57890));
      this.\u0002.NormalEndColor = \u009A\u0080.\u0092\u001F();
      this.\u0002.NormalStartColor = \u009A\u0080.\u000E\u007F();
      this.\u0002.Rotation = 270;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(34, 34));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 3);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0002, false);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001B.\u0082.\u0001(57911));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Right);
      \u0081\u001C.\u007E\u0088\u0083((object) this.\u0001, \u009B\u0086.\u0008\u008A());
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      this.\u0001.HoverEndColor = \u009A\u0080.\u0096\u001F();
      this.\u0001.HoverStartColor = \u009A\u0080.\u000E\u007F();
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(563, 76));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u0082.\u0001(57928));
      this.\u0001.NormalEndColor = \u009A\u0080.\u0092\u001F();
      this.\u0001.NormalStartColor = \u009A\u0080.\u000E\u007F();
      this.\u0001.Rotation = 90;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(34, 34));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0001, false);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001B.\u0082.\u0001(47133));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
      \u0099\u001F.\u007E\u0093\u0086((object) this.\u0001, true);
      \u0012\u0082.\u007E\u009C\u008A((object) this.\u0001, BorderStyle.Fixed3D);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(40, 3));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u0082.\u0001(57941));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(520, 180));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0099\u001F.\u007E\u009E\u008A((object) this.\u0001, false);
      \u0086\u001D.\u007E\u0098\u0084((object) this.\u0001, new PreviewKeyDownEventHandler(this.\u001D\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0092\u0081.\u0010\u0084((object) this, \u001B.\u0082.\u0001(57962));
      \u000E\u001F.\u0018\u0084((object) this, new Size(600, 186));
      \u0099\u001F.\u007F\u0086((object) this, false);
    }

    private void \u001D\u0005(object sender, \u0082.\u001F<\u001B.\u0082.\u0001> e)
    {
      this.\u0001.Remove(((\u000F<\u001B.\u0082.\u0001>) e).Item.\u0001.FileName);
      if (this.\u0001 == e.GroupIndex)
        \u009B\u0081.\u007E\u008F\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) ((\u000F<\u001B.\u0082.\u0001>) e).Item.\u0001);
      if (((\u000F<\u001B.\u0082.\u0001>) e).Item == this.\u0001)
      {
        \u001B.\u0082.\u0001 thumb = e.RemovedIndex != this.\u0001.Elements ? this.\u0001.\u001D\u0005(e.RemovedIndex) : (this.\u0001.Elements <= 0 ? (\u001B.\u0082.\u0001) null : this.\u0001.\u001D\u0005(this.\u0001.Elements - 1));
        if (thumb != null)
        {
          int groupIndex = this.\u0001.\u001D\u0005(thumb);
          if (this.\u0001 != groupIndex)
            this.\u001D\u0005(groupIndex, false);
          thumb.\u0001.Selected = true;
          if (this.\u0001 != null)
            this.\u001D\u0005(thumb);
        }
      }
      ((\u000F<\u001B.\u0082.\u0001>) e).Item.Dispose();
    }

    private void \u001D\u0005(object sender, \u0010<\u001B.\u0082.\u0001> e)
    {
      if (e.NewGroup == this.\u0001)
      {
        \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) ((\u000F<\u001B.\u0082.\u0001>) e).Item.\u0001);
      }
      else
      {
        if (e.PreviousGroup != this.\u0001)
          return;
        \u009B\u0081.\u007E\u008F\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) ((\u000F<\u001B.\u0082.\u0001>) e).Item.\u0001);
      }
    }

    private void \u001D\u0005(object sender, \u0005<\u001B.\u0082.\u0001> e)
    {
      if (this.\u0001 != e.Group)
        return;
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) ((\u000F<\u001B.\u0082.\u0001>) e).Item.\u0001);
    }

    private void \u001D\u0005(object sender, \u000F e)
    {
      if (this.\u0001 == this.\u0001.Groups && this.\u0001 > 0)
        this.\u001D\u0005(this.\u0001 - 1, true);
      \u0099\u001F obj1 = \u0099\u001F.\u007E\u008F\u0083;
      \u001E obj2 = this.\u0002;
      bool flag;
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, flag = this.\u0001.Groups > 1);
      int num = flag ? 1 : 0;
      obj1((object) obj2, num != 0);
    }

    private void \u001E\u0005(object sender, \u000F e)
    {
      if (this.\u0001 == -1)
        goto label_2;
label_1:
      \u0099\u001F obj1 = \u0099\u001F.\u007E\u008F\u0083;
      \u001E obj2 = this.\u0002;
      bool flag;
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, flag = this.\u0001.Groups > 1);
      int num = flag ? 1 : 0;
      obj1((object) obj2, num != 0);
      return;
label_2:
      this.\u0001 = e.Group;
      goto label_1;
    }

    public void \u001D\u0005(IEnumerable<\u0006> items)
    {
      List<\u0006> objList = new List<\u0006>(items);
      objList.Sort((Comparison<\u0006>) ((x, y) => x.DateCreated.CompareTo(y.DateCreated)));
      foreach (\u0006 data in objList)
        this.\u001D\u0005(data);
    }

    public void \u001D\u0005(\u0006 data)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001B.\u0082.\u0002 obj = new \u001B.\u0082.\u0002();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = this;
      \u0003 control = (\u0003) null;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = (\u001B.\u0082.\u0001) null;
      try
      {
        control = new \u0003();
        \u000E\u001F.\u007E\u0018\u0084((object) control, new Size(178, 146));
        control.FileName = data.FileName;
        control.Image = data.\u0001;
        // ISSUE: reference to a compiler-generated field
        obj.\u0001 = new \u001B.\u0082.\u0001(data, control);
        // ISSUE: reference to a compiler-generated method
        control.ButtonSelected += new EventHandler(obj.\u001D\u0005);
        // ISSUE: reference to a compiler-generated method
        control.ShowScreenshot += new EventHandler(obj.\u001E\u0005);
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.\u0001.Add(obj.\u0001.\u0001.FileName, obj.\u0001);
        // ISSUE: reference to a compiler-generated field
        this.\u0001.\u001D\u0005(obj.\u0001);
      }
      catch
      {
        if (control != null)
          \u001A\u001E.\u007E\u007F\u0001\u0002((object) control);
        // ISSUE: reference to a compiler-generated field
        if (obj.\u0001 != null)
        {
          // ISSUE: reference to a compiler-generated field
          obj.\u0001.Dispose();
        }
        throw;
      }
    }

    public bool \u001D\u0005(string fileName)
    {
      if (!this.\u0001.ContainsKey(fileName))
        return false;
      this.\u0001.\u001E\u0005(this.\u0001[fileName]);
      return true;
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      if (this.\u0001 < this.\u0001.Groups - 1)
        this.\u001D\u0005(this.\u0001 + 1, false);
      else
        this.\u001D\u0005(0, false);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      if (this.\u0001 > 0)
        this.\u001D\u0005(this.\u0001 - 1, true);
      else
        this.\u001D\u0005(this.\u0001.Groups - 1, true);
    }

    private void \u001D\u0005(int groupIndex, bool scrollToEnd = false)
    {
      if (this.\u0001 == groupIndex)
        return;
      this.\u0001 = groupIndex;
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0090\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001));
      \u001B.\u0082.\u0001 obj = (\u001B.\u0082.\u0001) null;
      IEnumerator<\u001B.\u0082.\u0001> enumerator = this.\u0001[groupIndex].GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          \u001B.\u0082.\u0001 current = enumerator.Current;
          if (!scrollToEnd && obj == null)
            obj = current;
          \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) current.\u0001);
          if (scrollToEnd)
            obj = current;
        }
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
      \u001A\u001E.\u007E\u001F\u0086((object) this.\u0001);
      if (obj == null)
        return;
      this.\u0001.\u001D\u0005((Control) obj.\u0001);
    }

    public void \u001E\u0005()
    {
      if (this.\u0001 == null)
        return;
      int num = this.\u0001.\u001E\u0005(this.\u0001);
      \u001B.\u0082.\u0001 thumb = this.\u0001.\u001D\u0005(num != this.\u0001.Elements - 1 ? num + 1 : 0);
      this.\u001D\u0005(this.\u0001.\u001D\u0005(thumb), false);
      thumb.\u0001.Selected = true;
      if (this.\u0001 == null)
        return;
      this.\u001D\u0005(thumb);
    }

    public void \u001F\u0005()
    {
      if (this.\u0001 == null)
        return;
      int num = this.\u0001.\u001E\u0005(this.\u0001);
      \u001B.\u0082.\u0001 thumb = this.\u0001.\u001D\u0005(num != 0 ? num - 1 : this.\u0001.Elements - 1);
      this.\u001D\u0005(this.\u0001.\u001D\u0005(thumb), false);
      thumb.\u0001.Selected = true;
      if (this.\u0001 == null)
        return;
      this.\u001D\u0005(thumb);
    }

    protected override void OnLoad(EventArgs args)
    {
      if (!\u0099\u0082.\u0081\u0001\u0002((object) this) && \u008E\u0086.\u0099\u0086((object) this) != null)
      {
        \u008E\u0086.\u0099\u0086((object) this).Resize += (EventHandler) ((sender, e) =>
        {
          if (this.\u0001 == null)
            return;
          \u0097\u001C.\u007E\u0088\u008B((object) this.\u0001, \u0098\u001E.\u007E\u0087\u008B((object) \u008E\u0086.\u0099\u0086((object) this)));
        });
        \u008E\u0086.\u0099\u0086((object) this).Activated += (EventHandler) ((sender, e) =>
        {
          if (this.\u0001 == null)
            return;
          \u0013.\u001D\u0005((Control) \u008E\u0086.\u0099\u0086((object) this), (Control) this.\u0001);
        });
        \u008E\u0086.\u0099\u0086((object) this).FormClosing += (FormClosingEventHandler) ((sender, e) =>
        {
          if (this.\u0001 == null)
            return;
          \u001A\u001E.\u007E\u0092\u008B((object) this.\u0001);
        });
      }
      \u0088\u001C.\u009E\u0090((object) this, args);
    }

    private void \u001D\u0005(\u001B.\u0082.\u0001 thumb)
    {
      if (this.\u0001 == null)
        goto label_2;
label_1:
      this.\u0001.\u001D\u0005(thumb.\u0001.FilePath);
      return;
label_2:
      this.\u0001 = new \u0003();
      this.\u0001.FormClosed += (FormClosedEventHandler) ((obj, arg) =>
      {
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
        this.\u0001 = (\u0003) null;
      });
      this.\u0001.Resize += (EventHandler) ((obj, arg) =>
      {
        switch (\u0098\u001E.\u007E\u0087\u008B((object) this.\u0001))
        {
          case FormWindowState.Normal:
          case FormWindowState.Minimized:
            \u0097\u001C.\u007E\u0088\u008B((object) \u008E\u0086.\u0099\u0086((object) this), \u0098\u001E.\u007E\u0087\u008B((object) this.\u0001));
            break;
        }
      });
      this.\u0001.Activated += (EventHandler) ((obj, arg) => \u0013.\u001D\u0005((Control) this.\u0001, (Control) \u008E\u0086.\u0099\u0086((object) this)));
      this.\u0001.ShowNextImage += (EventHandler) ((obj, arg) => this.\u001E\u0005());
      this.\u0001.ShowPreviousImage += (EventHandler) ((obj, arg) => this.\u001F\u0005());
      \u001A\u001E.\u007E\u0083\u0086((object) this.\u0001);
      goto label_1;
    }

    private void \u001D\u0005(object sender, PreviewKeyDownEventArgs e)
    {
      if (\u007F\u0081.\u007E\u0082\u008E((object) e) != Keys.Tab)
        return;
      \u0099\u001F.\u007E\u0083\u008E((object) e, true);
    }

    private sealed class \u0001 : \u0016
    {
      public \u0006 \u0001;
      public \u0003 \u0001;

      public \u0001(\u0006 data, \u0003 control)
      {
        this.\u0001 = data;
        this.\u0001 = control;
      }

      protected override void \u001D\u0005()
      {
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
        base.\u001D\u0005();
      }
    }
  }
}
