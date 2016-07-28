// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0016;
using \u0017;
using \u0018;
using \u001A;
using \u001B;
using \u001C;
using \u0080;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace \u0014
{
  internal sealed class \u001E : \u0019
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private int \u0001;
    private IContainer \u0001;
    private \u001E \u0001;
    private CheckBox \u0001;
    private Label \u0001;
    private Label \u0002;
    private Label \u0003;
    private Label \u0004;
    private Label \u0005;
    private Label \u0006;
    private Label \u0007;
    private Label \u0008;
    private Label \u000E;
    private Label \u000F;
    private Label \u0010;
    private Label \u0011;
    private Label \u0012;
    private Label \u0013;
    private \u001E \u0002;
    private Button \u0001;
    private Label \u0014;
    private Panel \u0001;
    private Label \u0015;
    private Label \u0016;
    private Label \u0017;
    private CheckBox \u0002;
    private \u000E \u0001;
    private CheckBox \u0003;
    private ToolTip \u0001;
    private Label \u0018;

    static \u001E()
    {
      \u0004.\u001D\u0005(typeof (\u001E));
    }

    public \u001E()
    {
      this.\u007F\u0005();
      this.\u0001.BackgroundPaint = (\u0018.\u001B) new \u007F.\u0001();
      \u0099\u001F.\u007E\u0003\u0088((object) this.\u0002, \u0081.\u0080.Instance.GagAMaticSettings.TopMost);
      \u0099\u001F.\u007E\u0003\u0088((object) this.\u0003, \u0081.\u0080.Instance.GagAMaticSettings.ShowToolTips);
    }

    private void \u001E\u0005()
    {
      if (this.\u001D\u0005(\u0019.\u0003) != 0)
        return;
      this.\u0080\u0005(true);
    }

    private void \u0080\u0005(bool select)
    {
      if (select && this.\u0001 >= 4)
        return;
      IEnumerator<\u001E.\u0001> enumerator = this.\u0001.Buttons.Union<\u001E.\u0001>((IEnumerable<\u001E.\u0001>) this.\u0002.Buttons).GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          \u001E.\u0001 current = enumerator.Current;
          if ((\u0019) current.ButtonType == \u0019.\u0003)
            current.Selected = select;
        }
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
      if (select)
        ++this.\u0001;
      else
        --this.\u0001;
    }

    private void \u001D\u0005(object sender, \u001D e)
    {
      switch ((\u0019) ((\u0018.\u001C) e).ButtonBoardButton.ButtonType)
      {
        case \u0019.\u0002:
          if (((\u0018.\u001C) e).ButtonBoardButton.Selected)
          {
            if (e.MouseButton == MouseButtons.Left)
            {
              \u001C.\u007F gag = ((\u0018.\u001C) e).ButtonBoardButton.Overlay as \u001C.\u007F;
              if (gag.NormalQuantity == 0)
              {
                this.\u001D\u0005(((\u0018.\u001C) e).ButtonBoardButton, gag);
                this.\u0001 += gag.NormalQuantity = 1;
                ((\u0018.\u001C) e).ButtonBoardButton.Selected = true;
                this.\u001E\u0005();
                break;
              }
              this.\u001D\u0005(((\u0018.\u001C) e).ButtonBoardButton, gag);
              break;
            }
            // ISSUE: type reference
            if (\u0091\u001F.\u001A\u0097(\u009C\u0083.\u007E\u008B\u0091((object) ((\u0018.\u001C) e).ButtonBoardButton.Overlay), \u009C\u0082.\u0016\u0097(__typeref (\u001C.\u0080))))
            {
              \u001C.\u0080 gag = ((\u0018.\u001C) e).ButtonBoardButton.Overlay as \u001C.\u0080;
              if (gag.OrganicQuantity == 0)
              {
                this.\u001D\u0005(((\u0018.\u001C) e).ButtonBoardButton, gag);
                this.\u0001 += gag.OrganicQuantity = 1;
                ((\u0018.\u001C) e).ButtonBoardButton.Selected = true;
                this.\u001E\u0005();
                break;
              }
              this.\u001D\u0005(((\u0018.\u001C) e).ButtonBoardButton, gag);
              break;
            }
            break;
          }
          IEnumerator<\u001E.\u0001> enumerator = this.\u0001.Buttons.Union<\u001E.\u0001>((IEnumerable<\u001E.\u0001>) this.\u0002.Buttons).GetEnumerator();
          try
          {
            while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
            {
              \u001E.\u0001 current = enumerator.Current;
              if ((\u0019) current.ButtonType == \u0019.\u0002)
                this.\u001D\u0005(current, current.Overlay as \u001C.\u007F);
            }
            goto default;
          }
          finally
          {
            if (enumerator != null)
              \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
          }
        case \u0019.\u0003:
          if (!((\u0018.\u001C) e).ButtonBoardButton.Selected)
          {
            if (this.\u0001 < 4)
            {
              this.\u0080\u0005(true);
              break;
            }
            this.\u0001.\u001E\u0005();
            break;
          }
          this.\u0080\u0005(false);
          break;
        default:
          if (((\u0018.\u001C) e).ButtonBoardButton.Selected)
          {
            if (this.\u0001 < 4)
            {
              if (e.MouseButton == MouseButtons.Left)
              {
                ++(((\u0018.\u001C) e).ButtonBoardButton.Overlay as \u001C.\u007F).NormalQuantity;
                ++this.\u0001;
                break;
              }
              // ISSUE: type reference
              if (\u0091\u001F.\u001A\u0097(\u009C\u0083.\u007E\u008B\u0091((object) ((\u0018.\u001C) e).ButtonBoardButton.Overlay), \u009C\u0082.\u0016\u0097(__typeref (\u001C.\u0080))))
              {
                ++(((\u0018.\u001C) e).ButtonBoardButton.Overlay as \u001C.\u0080).OrganicQuantity;
                ++this.\u0001;
                break;
              }
              break;
            }
            if (e.MouseButton == MouseButtons.Left)
            {
              \u001C.\u007F obj = ((\u0018.\u001C) e).ButtonBoardButton.Overlay as \u001C.\u007F;
              if (obj.NormalQuantity == 0)
              {
                this.\u0001.\u001E\u0005();
                break;
              }
              this.\u0001 -= obj.NormalQuantity;
              obj.NormalQuantity = 0;
              // ISSUE: type reference
              ((\u0018.\u001C) e).ButtonBoardButton.Selected = obj.NormalQuantity != 0 || \u0091\u001F.\u001A\u0097(\u009C\u0083.\u007E\u008B\u0091((object) obj), \u009C\u0082.\u0016\u0097(__typeref (\u001C.\u0080))) && (obj as \u001C.\u0080).OrganicQuantity != 0;
              break;
            }
            // ISSUE: type reference
            if (\u0091\u001F.\u001A\u0097(\u009C\u0083.\u007E\u008B\u0091((object) ((\u0018.\u001C) e).ButtonBoardButton.Overlay), \u009C\u0082.\u0016\u0097(__typeref (\u001C.\u0080))))
            {
              \u001C.\u0080 obj = ((\u0018.\u001C) e).ButtonBoardButton.Overlay as \u001C.\u0080;
              if (obj.OrganicQuantity == 0)
              {
                this.\u0001.\u001E\u0005();
                break;
              }
              this.\u0001 -= obj.OrganicQuantity;
              obj.OrganicQuantity = 0;
              ((\u0018.\u001C) e).ButtonBoardButton.Selected = obj.NormalQuantity != 0 || obj.OrganicQuantity != 0;
              break;
            }
            break;
          }
          if (this.\u0001 < 4)
          {
            if (e.MouseButton == MouseButtons.Left)
            {
              ++(((\u0018.\u001C) e).ButtonBoardButton.Overlay as \u001C.\u007F).NormalQuantity;
              ++this.\u0001;
              ((\u0018.\u001C) e).ButtonBoardButton.Selected = true;
              if ((\u0019) ((\u0018.\u001C) e).ButtonBoardButton.ButtonType == \u0019.\u0002)
              {
                this.\u001E\u0005();
                break;
              }
              break;
            }
            // ISSUE: type reference
            if (\u0091\u001F.\u001A\u0097(\u009C\u0083.\u007E\u008B\u0091((object) ((\u0018.\u001C) e).ButtonBoardButton.Overlay), \u009C\u0082.\u0016\u0097(__typeref (\u001C.\u0080))))
            {
              ++(((\u0018.\u001C) e).ButtonBoardButton.Overlay as \u001C.\u0080).OrganicQuantity;
              ++this.\u0001;
              ((\u0018.\u001C) e).ButtonBoardButton.Selected = true;
              if ((\u0019) ((\u0018.\u001C) e).ButtonBoardButton.ButtonType == \u0019.\u0002)
              {
                this.\u001E\u0005();
                break;
              }
              break;
            }
            break;
          }
          this.\u0001.\u001E\u0005();
          break;
      }
      this.\u001F\u0005();
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      bool flag = false;
      IEnumerator<\u001E.\u0001> enumerator = this.\u0001.Buttons.Union<\u001E.\u0001>((IEnumerable<\u001E.\u0001>) this.\u0002.Buttons).Where<\u001E.\u0001>((Func<\u001E.\u0001, bool>) (item => item.Selected)).GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          \u001E.\u0001 current = enumerator.Current;
          if ((\u0019) current.ButtonType == \u0019.\u0003)
            flag = true;
          else
            this.\u001D\u0005(current, current.Overlay as \u001C.\u007F);
          current.Selected = false;
        }
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
      if (flag)
        --this.\u0001;
      if (\u0099\u0082.\u007E\u0002\u0088((object) this.\u0001))
        \u0099\u001F.\u007E\u0003\u0088((object) this.\u0001, false);
      else
        this.\u001F\u0005();
      this.\u0001.\u001F\u0005();
    }

    private int \u001D\u0005(\u0019 type)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return this.\u0001.Buttons.Union<\u001E.\u0001>((IEnumerable<\u001E.\u0001>) this.\u0002.Buttons).Where<\u001E.\u0001>(new Func<\u001E.\u0001, bool>(new \u001E.\u0001() { \u0001 = type }.\u001D\u0005)).Count<\u001E.\u0001>();
    }

    private void \u001D\u0005(\u001E.\u0001 btn, \u001C.\u007F gag)
    {
      // ISSUE: type reference
      if (\u0091\u001F.\u001A\u0097(\u009C\u0083.\u007E\u008B\u0091((object) gag), \u009C\u0082.\u0016\u0097(__typeref (\u001C.\u0080))))
      {
        this.\u001D\u0005(btn, gag as \u001C.\u0080);
      }
      else
      {
        if (gag.NormalQuantity > 0)
        {
          this.\u0001 -= gag.NormalQuantity;
          gag.NormalQuantity = 0;
        }
        btn.Selected = false;
      }
    }

    private void \u001D\u0005(\u001E.\u0001 btn, \u001C.\u0080 gag)
    {
      if (gag.NormalQuantity > 0)
      {
        this.\u0001 -= gag.NormalQuantity;
        gag.NormalQuantity = 0;
      }
      if (gag.OrganicQuantity > 0)
      {
        this.\u0001 -= gag.OrganicQuantity;
        gag.OrganicQuantity = 0;
      }
      btn.Selected = false;
    }

    private void \u001F\u0005()
    {
      bool flag = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0001);
      int damage1 = 0;
      int quantity1 = 0;
      if (!flag && this.\u001D\u0005(\u0019.\u0003) > 0)
        goto label_37;
label_1:
      int damage2 = 0;
      int quantity2 = 0;
      this.\u001D\u0005(\u0019.\u0004, out damage2, out quantity2);
      int num1 = quantity2 <= 1 ? 0 : \u001E.\u001D\u0005(damage2);
      if (quantity2 > 0)
        flag = false;
      int damage3 = 0;
      int quantity3 = 0;
      this.\u001D\u0005(\u0019.\u0005, out damage3, out quantity3);
      int num2 = !flag || quantity3 <= 0 ? 0 : \u001E.\u001E\u0005(damage3);
      int num3 = quantity3 <= 1 ? 0 : \u001E.\u001D\u0005(damage3);
      if (quantity3 > 0)
        flag = false;
      int damage4 = 0;
      int quantity4 = 0;
      this.\u001D\u0005(\u0019.\u0006, out damage4, out quantity4);
      int num4 = !flag || quantity4 <= 0 ? 0 : \u001E.\u001E\u0005(damage4);
      int num5 = quantity4 <= 1 ? 0 : \u001E.\u001D\u0005(damage4);
      if (quantity4 > 0)
        flag = false;
      int damage5 = 0;
      int quantity5 = 0;
      int num6 = 0;
      if (!flag)
      {
        this.\u001D\u0005(\u0019.\u0007, out damage5, out quantity5);
        if (quantity5 > 1)
          num6 = \u001E.\u001D\u0005(damage5);
      }
      int num7 = damage1 + damage2 + num1 + damage3 + num2 + num3 + damage4 + num4 + num5 + damage5 + num6;
      if (num7 >= 200)
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0016, \u001E.\u0001(7766));
      else if (num7 >= 156)
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0016, \u001E.\u0001(7779));
      else if (num7 >= 132)
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0016, \u001E.\u0001(7792));
      else if (num7 >= 110)
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0016, \u001E.\u0001(7805));
      else if (num7 >= 90)
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0016, \u001E.\u0001(7818));
      else if (num7 >= 72)
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0016, \u001E.\u0001(7831));
      else if (num7 >= 56)
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0016, \u001E.\u0001(7844));
      else if (num7 >= 42)
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0016, \u001E.\u0001(7857));
      else if (num7 >= 30)
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0016, \u001E.\u0001(7870));
      else if (num7 >= 20)
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0016, \u001E.\u0001(7883));
      else if (num7 >= 12)
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0016, \u001E.\u0001(7896));
      else if (num7 >= 6)
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0016, \u001E.\u0001(7909));
      else if (num7 >= 0)
        \u0092\u0081.\u007E\u001D\u0084((object) this.\u0016, \u001E.\u0001(7922));
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0017, \u0081\u0086.\u0086\u0093(num7.ToString(), \u001E.\u0001(7935)));
      return;
label_37:
      this.\u001D\u0005(\u0019.\u0002, out damage1, out quantity1);
      flag = quantity1 == 0;
      goto label_1;
    }

    private void \u001D\u0005(\u0019 type, out int damage, out int quantity)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001E.\u0002 obj1 = new \u001E.\u0002();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = type;
      damage = 0;
      quantity = 0;
      // ISSUE: reference to a compiler-generated method
      IEnumerator<\u001E.\u0001> enumerator = this.\u0001.Buttons.Union<\u001E.\u0001>((IEnumerable<\u001E.\u0001>) this.\u0002.Buttons).Where<\u001E.\u0001>(new Func<\u001E.\u0001, bool>(obj1.\u001D\u0005)).GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          \u001E.\u0001 current = enumerator.Current;
          // ISSUE: type reference
          if (\u0091\u001F.\u001A\u0097(\u009C\u0083.\u007E\u008B\u0091((object) current.Overlay), \u009C\u0082.\u0016\u0097(__typeref (\u001C.\u0080))))
          {
            \u001C.\u0080 obj2 = current.Overlay as \u001C.\u0080;
            damage += obj2.OrganicQuantity * obj2.OrganicDamage;
            quantity += obj2.OrganicQuantity;
          }
          \u001C.\u007F obj3 = current.Overlay as \u001C.\u007F;
          damage += obj3.NormalQuantity * obj3.Damage;
          quantity += obj3.NormalQuantity;
        }
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
    }

    private static int \u001D\u0005(int damage)
    {
      return (int) \u0007\u0081.\u0091\u0096((double) damage / 5.0);
    }

    private static int \u001E\u0005(int damage)
    {
      return (int) ((double) damage / 2.0);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      if (\u0099\u0082.\u007E\u0002\u0088((object) this.\u0001))
      {
        bool flag = false;
        IEnumerator<\u001E.\u0001> enumerator = this.\u0001.Buttons.Union<\u001E.\u0001>((IEnumerable<\u001E.\u0001>) this.\u0002.Buttons).GetEnumerator();
        try
        {
          while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          {
            \u001E.\u0001 current = enumerator.Current;
            switch ((\u0019) current.ButtonType)
            {
              case \u0019.\u0002:
                this.\u001D\u0005(current, current.Overlay as \u001C.\u007F);
                current.Enabled = false;
                continue;
              case \u0019.\u0003:
                if (current.Selected)
                {
                  flag = true;
                  current.Selected = false;
                }
                current.Enabled = false;
                continue;
              default:
                continue;
            }
          }
        }
        finally
        {
          if (enumerator != null)
            \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
        }
        if (flag)
          --this.\u0001;
      }
      else
      {
        IEnumerator<\u001E.\u0001> enumerator = this.\u0001.Buttons.Union<\u001E.\u0001>((IEnumerable<\u001E.\u0001>) this.\u0002.Buttons).GetEnumerator();
        try
        {
          while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
          {
            \u001E.\u0001 current = enumerator.Current;
            switch ((\u0019) current.ButtonType)
            {
              case \u0019.\u0002:
              case \u0019.\u0003:
                current.Enabled = true;
                continue;
              default:
                continue;
            }
          }
        }
        finally
        {
          if (enumerator != null)
            \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
        }
      }
      this.\u001F\u0005();
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      \u0099\u001F.\u0086\u008B((object) this, \u0099\u0082.\u007E\u0002\u0088((object) this.\u0002));
      \u0081.\u0080.Instance.GagAMaticSettings.TopMost = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0002);
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      this.\u0001.ToolTipsEnabled = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0003);
      this.\u0002.ToolTipsEnabled = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0003);
      \u0099\u001F.\u007E\u0097\u0090((object) this.\u0001, \u0099\u0082.\u007E\u0002\u0088((object) this.\u0003));
      \u0081.\u0080.Instance.GagAMaticSettings.ShowToolTips = \u0099\u0082.\u007E\u0002\u0088((object) this.\u0003);
    }

    private void \u001D\u0005(object sender, HelpEventArgs hlpevent)
    {
      \u0082.\u001D\u0005(\u0002.\u0012);
      \u0099\u001F.\u007E\u0003\u008C((object) hlpevent, true);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u007F\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      \u001E.\u0001 obj1 = new \u001E.\u0001();
      \u001C.\u007F obj2 = new \u001C.\u007F();
      \u001E.\u0001 obj3 = new \u001E.\u0001();
      \u001C.\u007F obj4 = new \u001C.\u007F();
      \u001E.\u0001 obj5 = new \u001E.\u0001();
      \u001C.\u007F obj6 = new \u001C.\u007F();
      \u001E.\u0001 obj7 = new \u001E.\u0001();
      \u001C.\u007F obj8 = new \u001C.\u007F();
      \u001E.\u0001 obj9 = new \u001E.\u0001();
      \u001C.\u007F obj10 = new \u001C.\u007F();
      \u001E.\u0001 obj11 = new \u001E.\u0001();
      \u001C.\u007F obj12 = new \u001C.\u007F();
      \u001E.\u0001 obj13 = new \u001E.\u0001();
      \u001C.\u007F obj14 = new \u001C.\u007F();
      \u001E.\u0001 obj15 = new \u001E.\u0001();
      \u001C.\u007F obj16 = new \u001C.\u007F();
      \u001E.\u0001 obj17 = new \u001E.\u0001();
      \u001C.\u007F obj18 = new \u001C.\u007F();
      \u001E.\u0001 obj19 = new \u001E.\u0001();
      \u001C.\u007F obj20 = new \u001C.\u007F();
      \u001E.\u0001 obj21 = new \u001E.\u0001();
      \u001C.\u007F obj22 = new \u001C.\u007F();
      \u001E.\u0001 obj23 = new \u001E.\u0001();
      \u001C.\u007F obj24 = new \u001C.\u007F();
      \u001E.\u0001 obj25 = new \u001E.\u0001();
      \u001C.\u007F obj26 = new \u001C.\u007F();
      \u001E.\u0001 obj27 = new \u001E.\u0001();
      \u001C.\u007F obj28 = new \u001C.\u007F();
      \u001E.\u0001 obj29 = new \u001E.\u0001();
      \u001C.\u007F obj30 = new \u001C.\u007F();
      \u001E.\u0001 obj31 = new \u001E.\u0001();
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u001E)));
      \u001E.\u0001 obj32 = new \u001E.\u0001();
      \u001E.\u0001 obj33 = new \u001E.\u0001();
      \u001E.\u0001 obj34 = new \u001E.\u0001();
      \u001C.\u007F obj35 = new \u001C.\u007F();
      \u001E.\u0001 obj36 = new \u001E.\u0001();
      \u001E.\u0001 obj37 = new \u001E.\u0001();
      \u001E.\u0001 obj38 = new \u001E.\u0001();
      \u001E.\u0001 obj39 = new \u001E.\u0001();
      \u001C.\u0080 obj40 = new \u001C.\u0080();
      \u001E.\u0001 obj41 = new \u001E.\u0001();
      \u001C.\u0080 obj42 = new \u001C.\u0080();
      \u001E.\u0001 obj43 = new \u001E.\u0001();
      \u001C.\u0080 obj44 = new \u001C.\u0080();
      \u001E.\u0001 obj45 = new \u001E.\u0001();
      \u001C.\u0080 obj46 = new \u001C.\u0080();
      \u001E.\u0001 obj47 = new \u001E.\u0001();
      \u001C.\u0080 obj48 = new \u001C.\u0080();
      \u001E.\u0001 obj49 = new \u001E.\u0001();
      \u001C.\u0080 obj50 = new \u001C.\u0080();
      \u001E.\u0001 obj51 = new \u001E.\u0001();
      \u001C.\u0080 obj52 = new \u001C.\u0080();
      \u001E.\u0001 obj53 = new \u001E.\u0001();
      \u001F obj54 = new \u001F();
      \u001E.\u0001 obj55 = new \u001E.\u0001();
      \u001F obj56 = new \u001F();
      \u001E.\u0001 obj57 = new \u001E.\u0001();
      \u001F obj58 = new \u001F();
      \u001E.\u0001 obj59 = new \u001E.\u0001();
      \u001F obj60 = new \u001F();
      \u001E.\u0001 obj61 = new \u001E.\u0001();
      \u001F obj62 = new \u001F();
      \u001E.\u0001 obj63 = new \u001E.\u0001();
      \u001F obj64 = new \u001F();
      \u001E.\u0001 obj65 = new \u001E.\u0001();
      \u001F obj66 = new \u001F();
      \u001E.\u0001 obj67 = new \u001E.\u0001();
      \u001C.\u0080 obj68 = new \u001C.\u0080();
      \u001E.\u0001 obj69 = new \u001E.\u0001();
      \u001C.\u0080 obj70 = new \u001C.\u0080();
      \u001E.\u0001 obj71 = new \u001E.\u0001();
      \u001C.\u0080 obj72 = new \u001C.\u0080();
      \u001E.\u0001 obj73 = new \u001E.\u0001();
      \u001C.\u0080 obj74 = new \u001C.\u0080();
      \u001E.\u0001 obj75 = new \u001E.\u0001();
      \u001C.\u0080 obj76 = new \u001C.\u0080();
      \u001E.\u0001 obj77 = new \u001E.\u0001();
      \u001C.\u0080 obj78 = new \u001C.\u0080();
      \u001E.\u0001 obj79 = new \u001E.\u0001();
      \u001C.\u0080 obj80 = new \u001C.\u0080();
      \u001E.\u0001 obj81 = new \u001E.\u0001();
      \u001C.\u0080 obj82 = new \u001C.\u0080();
      \u001E.\u0001 obj83 = new \u001E.\u0001();
      \u001C.\u0080 obj84 = new \u001C.\u0080();
      \u001E.\u0001 obj85 = new \u001E.\u0001();
      \u001C.\u0080 obj86 = new \u001C.\u0080();
      \u001E.\u0001 obj87 = new \u001E.\u0001();
      \u001C.\u0080 obj88 = new \u001C.\u0080();
      \u001E.\u0001 obj89 = new \u001E.\u0001();
      \u001C.\u0080 obj90 = new \u001C.\u0080();
      \u001E.\u0001 obj91 = new \u001E.\u0001();
      \u001C.\u0080 obj92 = new \u001C.\u0080();
      \u001E.\u0001 obj93 = new \u001E.\u0001();
      \u001C.\u0080 obj94 = new \u001C.\u0080();
      \u001E.\u0001 obj95 = new \u001E.\u0001();
      \u001C.\u0080 obj96 = new \u001C.\u0080();
      \u001E.\u0001 obj97 = new \u001E.\u0001();
      \u001C.\u0080 obj98 = new \u001C.\u0080();
      \u001E.\u0001 obj99 = new \u001E.\u0001();
      \u001C.\u0080 obj100 = new \u001C.\u0080();
      \u001E.\u0001 obj101 = new \u001E.\u0001();
      \u001C.\u0080 obj102 = new \u001C.\u0080();
      \u001E.\u0001 obj103 = new \u001E.\u0001();
      \u001C.\u0080 obj104 = new \u001C.\u0080();
      \u001E.\u0001 obj105 = new \u001E.\u0001();
      \u001C.\u0080 obj106 = new \u001C.\u0080();
      \u001E.\u0001 obj107 = new \u001E.\u0001();
      \u001C.\u0080 obj108 = new \u001C.\u0080();
      \u001E.\u0001 obj109 = new \u001E.\u0001();
      \u001C.\u0080 obj110 = new \u001C.\u0080();
      \u001E.\u0001 obj111 = new \u001E.\u0001();
      \u001C.\u0080 obj112 = new \u001C.\u0080();
      \u001E.\u0001 obj113 = new \u001E.\u0001();
      \u001C.\u0080 obj114 = new \u001C.\u0080();
      \u001E.\u0001 obj115 = new \u001E.\u0001();
      \u001C.\u0080 obj116 = new \u001C.\u0080();
      \u001E.\u0001 obj117 = new \u001E.\u0001();
      \u001C.\u0080 obj118 = new \u001C.\u0080();
      \u001E.\u0001 obj119 = new \u001E.\u0001();
      \u001C.\u0080 obj120 = new \u001C.\u0080();
      \u001E.\u0001 obj121 = new \u001E.\u0001();
      \u001C.\u0080 obj122 = new \u001C.\u0080();
      this.\u0001 = new CheckBox();
      this.\u0001 = new Label();
      this.\u0002 = new Label();
      this.\u0003 = new Label();
      this.\u0004 = new Label();
      this.\u0005 = new Label();
      this.\u0006 = new Label();
      this.\u0007 = new Label();
      this.\u0008 = new Label();
      this.\u000E = new Label();
      this.\u000F = new Label();
      this.\u0010 = new Label();
      this.\u0011 = new Label();
      this.\u0012 = new Label();
      this.\u0013 = new Label();
      this.\u0001 = new Button();
      this.\u0014 = new Label();
      this.\u0001 = new Panel();
      this.\u0015 = new Label();
      this.\u0016 = new Label();
      this.\u0017 = new Label();
      this.\u0002 = new CheckBox();
      this.\u0003 = new CheckBox();
      this.\u0001 = new ToolTip(this.\u0001);
      this.\u0001 = new \u000E();
      this.\u0002 = new \u001E();
      this.\u0001 = new \u001E();
      this.\u0018 = new Label();
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(109, 205, 117));
      \u0016\u001E.\u007E\u0001\u0088((object) this.\u0001, ContentAlignment.TopCenter);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u001E.\u0001(4184), 6.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(19, 158));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001E.\u0001(7940));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(82, 61));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001E.\u0001(7949));
      \u0016\u001E.\u007E\u008C\u0087((object) this.\u0001, ContentAlignment.MiddleCenter);
      \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this.\u0001, \u001E.\u0001(7994));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, false);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(194, 136, 237));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(129, 128));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001E.\u0001(8047));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(56, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001E.\u0001(8064));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u008E\u001D.\u0017\u007F(194, 136, 237));
      \u0012\u0082.\u007E\u001A\u008C((object) this.\u0002, BorderStyle.FixedSingle);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u001E.\u0001(2360), 6f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(129, 141));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001E.\u0001(4527));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(56, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001E.\u0001(8077));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0002, ContentAlignment.MiddleCenter);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u008E\u001D.\u0017\u007F(229, 235, 87));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(129, 158));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u001E.\u0001(4485));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(36, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u001E.\u0001(8094));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u008E\u001D.\u0017\u007F(229, 235, 87));
      \u0012\u0082.\u007E\u001A\u008C((object) this.\u0004, BorderStyle.FixedSingle);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0004, new Font(\u001E.\u0001(2360), 6f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(129, 171));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u001E.\u0001(7267));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(56, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u001E.\u0001(8077));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0004, ContentAlignment.MiddleCenter);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0005, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0005, \u008E\u001D.\u0017\u007F(74, 175, 71));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(129, 188));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u001E.\u0001(8103));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(36, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u001E.\u0001(8112));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0006, \u008E\u001D.\u0017\u007F(74, 175, 71));
      \u0012\u0082.\u007E\u001A\u008C((object) this.\u0006, BorderStyle.FixedSingle);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0006, new Font(\u001E.\u0001(2360), 6f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(129, 201));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u001E.\u0001(7302));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(56, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0006, \u001E.\u0001(8077));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0006, ContentAlignment.MiddleCenter);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0007, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0007, \u008E\u001D.\u0017\u007F(85, 100, 219));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(129, 218));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u001E.\u0001(7220));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(46, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0007, \u001E.\u0001(8121));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0008, \u008E\u001D.\u0017\u007F(85, 100, 219));
      \u0012\u0082.\u007E\u001A\u008C((object) this.\u0008, BorderStyle.FixedSingle);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0008, new Font(\u001E.\u0001(2360), 6f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(129, 231));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0008, \u001E.\u0001(7190));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0008, new Size(56, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0008, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0008, \u001E.\u0001(8077));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0008, ContentAlignment.MiddleCenter);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u000E, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000E, \u008E\u001D.\u0017\u007F(235, 135, 60));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000E, new Point(129, 248));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000E, \u001E.\u0001(8130));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000E, new Size(49, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000E, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000E, \u001E.\u0001(8139));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000F, \u008E\u001D.\u0017\u007F(235, 135, 60));
      \u0012\u0082.\u007E\u001A\u008C((object) this.\u000F, BorderStyle.FixedSingle);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u000F, new Font(\u001E.\u0001(2360), 6f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000F, new Point(129, 261));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000F, \u001E.\u0001(8148));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000F, new Size(56, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000F, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000F, \u001E.\u0001(8077));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u000F, ContentAlignment.MiddleCenter);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0010, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0010, \u008E\u001D.\u0017\u007F(234, 59, 184));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0010, new Point(129, 278));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0010, \u001E.\u0001(8161));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0010, new Size(48, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0010, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0010, \u001E.\u0001(8174));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0011, \u008E\u001D.\u0017\u007F(234, 59, 184));
      \u0012\u0082.\u007E\u001A\u008C((object) this.\u0011, BorderStyle.FixedSingle);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0011, new Font(\u001E.\u0001(2360), 6f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0011, new Point(129, 291));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0011, \u001E.\u0001(8183));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0011, new Size(56, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0011, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0011, \u001E.\u0001(8077));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0011, ContentAlignment.MiddleCenter);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0012, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0012, \u008E\u001D.\u0017\u007F(62, 224, 235));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0012, new Point(129, 308));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0012, \u001E.\u0001(8196));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0012, new Size(38, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0012, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0012, \u001E.\u0001(8209));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0013, \u008E\u001D.\u0017\u007F(62, 224, 235));
      \u0012\u0082.\u007E\u001A\u008C((object) this.\u0013, BorderStyle.FixedSingle);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0013, new Font(\u001E.\u0001(2360), 6f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0013, new Point(129, 321));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0013, \u001E.\u0001(8218));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0013, new Size(56, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0013, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0013, \u001E.\u0001(8077));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0013, ContentAlignment.MiddleCenter);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u001E.\u0001(2360), 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001E.\u0001(8231));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 44));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001E.\u0001(8244));
      \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this.\u0001, \u001E.\u0001(8253));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0014, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0014, \u008E\u001D.\u0017\u007F(109, 205, 117));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0014, new Point(192, 99));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0014, \u001E.\u0001(8306));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0014, new Size(300, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0014, 7);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0014, \u001E.\u0001(8319));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(109, 205, 117));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(116, 372));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001E.\u0001(8400));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 44));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 8);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0015, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0015, \u008E\u001D.\u0017\u007F(105, 245, (int) byte.MaxValue));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0015, new Font(\u001E.\u0001(4184), 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0015, new Point(587, 154));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0015, \u001E.\u0001(8425));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0015, new Size(71, 20));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0015, 9);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0015, \u001E.\u0001(8442));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0016, \u008E\u001D.\u0017\u007F(105, 245, (int) byte.MaxValue));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0016, new Font(\u001E.\u0001(4184), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0016, new Point(586, 185));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0016, \u001E.\u0001(8455));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0016, new Size(73, 56));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0016, 9);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0016, \u001E.\u0001(7922));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0016, ContentAlignment.MiddleCenter);
      \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this.\u0016, \u001E.\u0001(8464));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0017, \u008E\u001D.\u0017\u007F(253, 182, 94));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0017, new Font(\u001E.\u0001(4184), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0017, new Point(582, 292));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0017, \u001E.\u0001(8598));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0017, new Size(80, 46));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0017, 9);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0017, \u001E.\u0001(8611));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0017, ContentAlignment.MiddleCenter);
      \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this.\u0017, \u001E.\u0001(8628));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u008E\u001D.\u0017\u007F(109, 205, 117));
      \u0016\u001E.\u007E\u0001\u0088((object) this.\u0002, ContentAlignment.TopCenter);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u001E.\u0001(4184), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(19, 222));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001E.\u0001(8758));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(82, 73));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001E.\u0001(8771));
      \u0016\u001E.\u007E\u008C\u0087((object) this.\u0002, ContentAlignment.MiddleCenter);
      \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this.\u0002, \u001E.\u0001(8824));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, false);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0002, new EventHandler(this.\u001F\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u008E\u001D.\u0017\u007F(109, 205, 117));
      \u0016\u001E.\u007E\u0001\u0088((object) this.\u0003, ContentAlignment.TopCenter);
      \u0099\u001F.\u007E\u0003\u0088((object) this.\u0003, true);
      \u0014\u001D.\u007E\u0004\u0088((object) this.\u0003, CheckState.Checked);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u001E.\u0001(4184), 6.75f));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(19, 298));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u001E.\u0001(8921));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(82, 46));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u001E.\u0001(8938));
      \u0016\u001E.\u007E\u008C\u0087((object) this.\u0003, ContentAlignment.MiddleCenter);
      \u0019\u0083.\u007E\u009B\u0090((object) this.\u0001, (Control) this.\u0003, \u001E.\u0001(8971));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, false);
      \u0087\u007F.\u007E\u0005\u0088((object) this.\u0003, new EventHandler(this.\u007F\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      this.\u0001.FadeOutAlphaRate = 5;
      this.\u0001.FadeOutDelay = 3000;
      this.\u0001.FadeOutRate = 10;
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u001E.\u0001(4184), 12f, FontStyle.Bold));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0090\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(26, 452));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001E.\u0001(9040));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(152, 21));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001E.\u0001(9057));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u0008\u007F());
      this.\u0002.BackgroundPaint = (\u0018.\u001B) null;
      this.\u0002.ButtonOutline = \u001B\u001C.\u0015\u007F(200, 0, 0, 0);
      obj1.AcceptRightClick = false;
      obj1.Bounds = new Rectangle(2, 2, 80, 24);
      obj1.ButtonType = (Enum) \u0019.\u0002;
      obj1.Enabled = true;
      obj1.Name = \u001E.\u0001(9078);
      obj2.Damage = 50;
      obj2.NormalQuantity = 0;
      obj1.Overlay = (\u001E.\u0001.\u0001) obj2;
      obj1.Selected = false;
      obj1.Text = \u001E.\u0001(9078);
      obj3.AcceptRightClick = false;
      obj3.Bounds = new Rectangle(86, 2, 80, 24);
      obj3.ButtonType = (Enum) \u0019.\u0002;
      obj3.Enabled = true;
      obj3.Name = \u001E.\u0001(9095);
      obj4.Damage = 70;
      obj4.NormalQuantity = 0;
      obj3.Overlay = (\u001E.\u0001.\u0001) obj4;
      obj3.Selected = false;
      obj3.Text = \u001E.\u0001(9095);
      obj5.AcceptRightClick = false;
      obj5.Bounds = new Rectangle(170, 2, 80, 24);
      obj5.ButtonType = (Enum) \u0019.\u0002;
      obj5.Enabled = true;
      obj5.Name = \u001E.\u0001(9112);
      obj6.Damage = 180;
      obj6.NormalQuantity = 0;
      obj5.Overlay = (\u001E.\u0001.\u0001) obj6;
      obj5.Selected = false;
      obj5.Text = \u001E.\u0001(9112);
      obj7.AcceptRightClick = false;
      obj7.Bounds = new Rectangle(254, 2, 80, 24);
      obj7.ButtonType = (Enum) \u0019.\u0004;
      obj7.Enabled = true;
      obj7.Name = \u001E.\u0001(9129);
      obj8.Damage = 10;
      obj8.NormalQuantity = 0;
      obj7.Overlay = (\u001E.\u0001.\u0001) obj8;
      obj7.Selected = false;
      obj7.Text = \u001E.\u0001(9129);
      obj9.AcceptRightClick = false;
      obj9.Bounds = new Rectangle(338, 2, 80, 24);
      obj9.ButtonType = (Enum) \u0019.\u0004;
      obj9.Enabled = true;
      obj9.Name = \u001E.\u0001(9146);
      obj10.Damage = 20;
      obj10.NormalQuantity = 0;
      obj9.Overlay = (\u001E.\u0001.\u0001) obj10;
      obj9.Selected = false;
      obj9.Text = \u001E.\u0001(9146);
      obj11.AcceptRightClick = false;
      obj11.Bounds = new Rectangle(2, 30, 80, 24);
      obj11.ButtonType = (Enum) \u0019.\u0004;
      obj11.Enabled = true;
      obj11.Name = \u001E.\u0001(9159);
      obj12.Damage = 30;
      obj12.NormalQuantity = 0;
      obj11.Overlay = (\u001E.\u0001.\u0001) obj12;
      obj11.Selected = false;
      obj11.Text = \u001E.\u0001(9159);
      obj13.AcceptRightClick = false;
      obj13.Bounds = new Rectangle(86, 30, 80, 24);
      obj13.ButtonType = (Enum) \u0019.\u0004;
      obj13.Enabled = true;
      obj13.Name = \u001E.\u0001(9176);
      obj14.Damage = 40;
      obj14.NormalQuantity = 0;
      obj13.Overlay = (\u001E.\u0001.\u0001) obj14;
      obj13.Selected = false;
      obj13.Text = \u001E.\u0001(9197);
      obj15.AcceptRightClick = false;
      obj15.Bounds = new Rectangle(170, 30, 80, 24);
      obj15.ButtonType = (Enum) \u0019.\u0004;
      obj15.Enabled = true;
      obj15.Name = \u001E.\u0001(9222);
      obj16.Damage = 50;
      obj16.NormalQuantity = 0;
      obj15.Overlay = (\u001E.\u0001.\u0001) obj16;
      obj15.Selected = false;
      obj15.Text = \u001E.\u0001(9222);
      obj17.AcceptRightClick = false;
      obj17.Bounds = new Rectangle(254, 30, 80, 24);
      obj17.ButtonType = (Enum) \u0019.\u0004;
      obj17.Enabled = true;
      obj17.Name = \u001E.\u0001(9239);
      obj18.Damage = 80;
      obj18.NormalQuantity = 0;
      obj17.Overlay = (\u001E.\u0001.\u0001) obj18;
      obj17.Selected = false;
      obj17.Text = \u001E.\u0001(9239);
      obj19.AcceptRightClick = false;
      obj19.Bounds = new Rectangle(338, 30, 80, 24);
      obj19.ButtonType = (Enum) \u0019.\u0007;
      obj19.Enabled = true;
      obj19.Name = \u001E.\u0001(9252);
      obj20.Damage = 20;
      obj20.NormalQuantity = 0;
      obj19.Overlay = (\u001E.\u0001.\u0001) obj20;
      obj19.Selected = false;
      obj19.Text = \u001E.\u0001(9252);
      obj21.AcceptRightClick = false;
      obj21.Bounds = new Rectangle(2, 58, 80, 24);
      obj21.ButtonType = (Enum) \u0019.\u0007;
      obj21.Enabled = true;
      obj21.Name = \u001E.\u0001(9269);
      obj22.Damage = 35;
      obj22.NormalQuantity = 0;
      obj21.Overlay = (\u001E.\u0001.\u0001) obj22;
      obj21.Selected = false;
      obj21.Text = \u001E.\u0001(9290);
      obj23.AcceptRightClick = false;
      obj23.Bounds = new Rectangle(86, 58, 80, 24);
      obj23.ButtonType = (Enum) \u0019.\u0007;
      obj23.Enabled = true;
      obj23.Name = \u001E.\u0001(9311);
      obj24.Damage = 50;
      obj24.NormalQuantity = 0;
      obj23.Overlay = (\u001E.\u0001.\u0001) obj24;
      obj23.Selected = false;
      obj23.Text = \u001E.\u0001(9311);
      obj25.AcceptRightClick = false;
      obj25.Bounds = new Rectangle(170, 58, 80, 24);
      obj25.ButtonType = (Enum) \u0019.\u0007;
      obj25.Enabled = true;
      obj25.Name = \u001E.\u0001(9324);
      obj26.Damage = 60;
      obj26.NormalQuantity = 0;
      obj25.Overlay = (\u001E.\u0001.\u0001) obj26;
      obj25.Selected = false;
      obj25.Text = \u001E.\u0001(9324);
      obj27.AcceptRightClick = false;
      obj27.Bounds = new Rectangle(254, 58, 80, 24);
      obj27.ButtonType = (Enum) \u0019.\u0007;
      obj27.Enabled = true;
      obj27.Name = \u001E.\u0001(9341);
      obj28.Damage = 100;
      obj28.NormalQuantity = 0;
      obj27.Overlay = (\u001E.\u0001.\u0001) obj28;
      obj27.Selected = false;
      obj27.Text = \u001E.\u0001(9362);
      obj29.AcceptRightClick = false;
      obj29.Bounds = new Rectangle(338, 58, 80, 24);
      obj29.ButtonType = (Enum) \u0019.\u0007;
      obj29.Enabled = true;
      obj29.Name = \u001E.\u0001(9383);
      obj30.Damage = 170;
      obj30.NormalQuantity = 0;
      obj29.Overlay = (\u001E.\u0001.\u0001) obj30;
      obj29.Selected = false;
      obj29.Text = \u001E.\u0001(9404);
      this.\u0002.Buttons.Add(obj1);
      this.\u0002.Buttons.Add(obj3);
      this.\u0002.Buttons.Add(obj5);
      this.\u0002.Buttons.Add(obj7);
      this.\u0002.Buttons.Add(obj9);
      this.\u0002.Buttons.Add(obj11);
      this.\u0002.Buttons.Add(obj13);
      this.\u0002.Buttons.Add(obj15);
      this.\u0002.Buttons.Add(obj17);
      this.\u0002.Buttons.Add(obj19);
      this.\u0002.Buttons.Add(obj21);
      this.\u0002.Buttons.Add(obj23);
      this.\u0002.Buttons.Add(obj25);
      this.\u0002.Buttons.Add(obj27);
      this.\u0002.Buttons.Add(obj29);
      this.\u0002.DisabledEndColor = \u008E\u001D.\u0017\u007F(37, 37, 37);
      this.\u0002.DisabledStartColor = \u008E\u001D.\u0017\u007F(163, 163, 163);
      this.\u0002.DownEndColor = \u008E\u001D.\u0017\u007F(111, 2, 14);
      this.\u0002.DownStartColor = \u008E\u001D.\u0017\u007F(250, 102, 102);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u001E.\u0001(2360), 11.25f, FontStyle.Bold));
      this.\u0002.HoverEndColor = \u008E\u001D.\u0017\u007F(157, 0, 18);
      this.\u0002.HoverRadialCenterColor = \u001B\u001C.\u0015\u007F(200, (int) byte.MaxValue, 0, 0);
      this.\u0002.HoverRadialSurroundColor = \u001B\u001C.\u0015\u007F(0, (int) byte.MaxValue, 0, 0);
      this.\u0002.HoverStartColor = \u008E\u001D.\u0017\u007F(248, 152, 152);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(253, 392));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001E.\u0001(9429));
      this.\u0002.NormalEndColor = \u008E\u001D.\u0017\u007F(1, 137, 224);
      this.\u0002.NormalStartColor = \u008E\u001D.\u0017\u007F(76, 181, 248);
      this.\u0002.SelectedEndColor = \u008E\u001D.\u0017\u007F(0, 157, 0);
      this.\u0002.SelectedRadialCenterColor = \u001B\u001C.\u0015\u007F(200, 0, (int) byte.MaxValue, 0);
      this.\u0002.SelectedRadialSurroundColor = \u001B\u001C.\u0015\u007F(0, 0, (int) byte.MaxValue, 0);
      this.\u0002.SelectedStartColor = \u008E\u001D.\u0017\u007F(152, 248, 165);
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(420, 84));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001E.\u0001(9442));
      this.\u0002.TextFont = new Font(\u001E.\u0001(4184), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.\u0002.ToolTipsEnabled = true;
      this.\u0002.ButtonClicked += new EventHandler<\u001D>(this.\u001D\u0005);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(73, 193, 83));
      this.\u0001.BackgroundPaint = (\u0018.\u001B) null;
      this.\u0001.ButtonOutline = \u001B\u001C.\u0015\u007F(200, 0, 0, 0);
      obj31.AcceptRightClick = true;
      obj31.Bounds = new Rectangle(72, 2, 46, 26);
      obj31.ButtonType = (Enum) \u0019.\u0001;
      obj31.Enabled = false;
      obj31.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(9459));
      obj31.Name = \u001E.\u0001(9492);
      obj31.Overlay = (\u001E.\u0001.\u0001) null;
      obj31.Selected = false;
      obj31.Text = \u001E.\u0001(2346);
      obj32.AcceptRightClick = true;
      obj32.Bounds = new Rectangle(122, 2, 46, 26);
      obj32.ButtonType = (Enum) \u0019.\u0001;
      obj32.Enabled = false;
      obj32.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(9505));
      obj32.Name = \u001E.\u0001(9538);
      obj32.Overlay = (\u001E.\u0001.\u0001) null;
      obj32.Selected = false;
      obj32.Text = (string) null;
      obj33.AcceptRightClick = true;
      obj33.Bounds = new Rectangle(172, 2, 46, 26);
      obj33.ButtonType = (Enum) \u0019.\u0001;
      obj33.Enabled = false;
      obj33.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(9551));
      obj33.Name = \u001E.\u0001(9584);
      obj33.Overlay = (\u001E.\u0001.\u0001) null;
      obj33.Selected = false;
      obj33.Text = (string) null;
      obj34.AcceptRightClick = true;
      obj34.Bounds = new Rectangle(222, 2, 46, 26);
      obj34.ButtonType = (Enum) \u0019.\u0001;
      obj34.Enabled = false;
      obj34.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(9597));
      obj34.Name = \u001E.\u0001(9630);
      obj35.Damage = 0;
      obj35.NormalQuantity = 0;
      obj34.Overlay = (\u001E.\u0001.\u0001) obj35;
      obj34.Selected = false;
      obj34.Text = (string) null;
      obj36.AcceptRightClick = true;
      obj36.Bounds = new Rectangle(272, 2, 46, 26);
      obj36.ButtonType = (Enum) \u0019.\u0001;
      obj36.Enabled = false;
      obj36.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(9647));
      obj36.Name = \u001E.\u0001(9680);
      obj36.Overlay = (\u001E.\u0001.\u0001) null;
      obj36.Selected = false;
      obj36.Text = (string) null;
      obj37.AcceptRightClick = true;
      obj37.Bounds = new Rectangle(322, 2, 46, 26);
      obj37.ButtonType = (Enum) \u0019.\u0001;
      obj37.Enabled = false;
      obj37.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(9693));
      obj37.Name = \u001E.\u0001(9726);
      obj37.Overlay = (\u001E.\u0001.\u0001) null;
      obj37.Selected = false;
      obj37.Text = (string) null;
      obj38.AcceptRightClick = true;
      obj38.Bounds = new Rectangle(372, 2, 46, 26);
      obj38.ButtonType = (Enum) \u0019.\u0001;
      obj38.Enabled = false;
      obj38.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(9747));
      obj38.Name = \u001E.\u0001(9780);
      obj38.Overlay = (\u001E.\u0001.\u0001) null;
      obj38.Selected = false;
      obj38.Text = (string) null;
      obj39.AcceptRightClick = true;
      obj39.Bounds = new Rectangle(72, 32, 46, 26);
      obj39.ButtonType = (Enum) \u0019.\u0002;
      obj39.Enabled = true;
      obj39.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(9793));
      obj39.Name = \u001E.\u0001(9826);
      obj40.Damage = 12;
      obj40.NormalQuantity = 0;
      obj40.OrganicQuantity = 0;
      obj39.Overlay = (\u001E.\u0001.\u0001) obj40;
      obj39.Selected = false;
      obj39.Text = (string) null;
      obj41.AcceptRightClick = true;
      obj41.Bounds = new Rectangle(122, 32, 46, 26);
      obj41.ButtonType = (Enum) \u0019.\u0002;
      obj41.Enabled = true;
      obj41.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(9843));
      obj41.Name = \u001E.\u0001(9876);
      obj42.Damage = 20;
      obj42.NormalQuantity = 0;
      obj42.OrganicQuantity = 0;
      obj41.Overlay = (\u001E.\u0001.\u0001) obj42;
      obj41.Selected = false;
      obj41.Text = (string) null;
      obj43.AcceptRightClick = true;
      obj43.Bounds = new Rectangle(172, 32, 46, 26);
      obj43.ButtonType = (Enum) \u0019.\u0002;
      obj43.Enabled = true;
      obj43.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(9885));
      obj43.Name = \u001E.\u0001(9918);
      obj44.Damage = 35;
      obj44.NormalQuantity = 0;
      obj44.OrganicQuantity = 0;
      obj43.Overlay = (\u001E.\u0001.\u0001) obj44;
      obj43.Selected = false;
      obj43.Text = (string) null;
      obj45.AcceptRightClick = true;
      obj45.Bounds = new Rectangle(222, 32, 46, 26);
      obj45.ButtonType = (Enum) \u0019.\u0002;
      obj45.Enabled = true;
      obj45.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(9931));
      obj45.Name = \u001E.\u0001(9964);
      obj46.Damage = 50;
      obj46.NormalQuantity = 0;
      obj46.OrganicQuantity = 0;
      obj45.Overlay = (\u001E.\u0001.\u0001) obj46;
      obj45.Selected = false;
      obj45.Text = (string) null;
      obj47.AcceptRightClick = true;
      obj47.Bounds = new Rectangle(272, 32, 46, 26);
      obj47.ButtonType = (Enum) \u0019.\u0002;
      obj47.Enabled = true;
      obj47.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(9981));
      obj47.Name = \u001E.\u0001(10014);
      obj48.Damage = 70;
      obj48.NormalQuantity = 0;
      obj48.OrganicQuantity = 0;
      obj47.Overlay = (\u001E.\u0001.\u0001) obj48;
      obj47.Selected = false;
      obj47.Text = (string) null;
      obj49.AcceptRightClick = true;
      obj49.Bounds = new Rectangle(322, 32, 46, 26);
      obj49.ButtonType = (Enum) \u0019.\u0002;
      obj49.Enabled = true;
      obj49.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10027));
      obj49.Name = \u001E.\u0001(10060);
      obj50.Damage = 180;
      obj50.NormalQuantity = 0;
      obj50.OrganicQuantity = 0;
      obj49.Overlay = (\u001E.\u0001.\u0001) obj50;
      obj49.Selected = false;
      obj49.Text = (string) null;
      obj51.AcceptRightClick = true;
      obj51.Bounds = new Rectangle(372, 32, 46, 26);
      obj51.ButtonType = (Enum) \u0019.\u0002;
      obj51.Enabled = true;
      obj51.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10065));
      obj51.Name = \u001E.\u0001(10098);
      obj52.Damage = 195;
      obj52.NormalQuantity = 0;
      obj52.OrganicQuantity = 0;
      obj51.Overlay = (\u001E.\u0001.\u0001) obj52;
      obj51.Selected = false;
      obj51.Text = (string) null;
      obj53.AcceptRightClick = true;
      obj53.Bounds = new Rectangle(72, 62, 46, 26);
      obj53.ButtonType = (Enum) \u0019.\u0003;
      obj53.Enabled = true;
      obj53.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10111));
      obj53.Name = \u001E.\u0001(10144);
      obj53.Overlay = (\u001E.\u0001.\u0001) obj54;
      obj53.Selected = false;
      obj53.Text = (string) null;
      obj55.AcceptRightClick = true;
      obj55.Bounds = new Rectangle(122, 62, 46, 26);
      obj55.ButtonType = (Enum) \u0019.\u0003;
      obj55.Enabled = true;
      obj55.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10157));
      obj55.Name = \u001E.\u0001(10190);
      obj55.Overlay = (\u001E.\u0001.\u0001) obj56;
      obj55.Selected = false;
      obj55.Text = (string) null;
      obj57.AcceptRightClick = true;
      obj57.Bounds = new Rectangle(172, 62, 46, 26);
      obj57.ButtonType = (Enum) \u0019.\u0003;
      obj57.Enabled = true;
      obj57.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10207));
      obj57.Name = \u001E.\u0001(10240);
      obj57.Overlay = (\u001E.\u0001.\u0001) obj58;
      obj57.Selected = false;
      obj57.Text = (string) null;
      obj59.AcceptRightClick = true;
      obj59.Bounds = new Rectangle(222, 62, 46, 26);
      obj59.ButtonType = (Enum) \u0019.\u0003;
      obj59.Enabled = true;
      obj59.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10253));
      obj59.Name = \u001E.\u0001(10286);
      obj59.Overlay = (\u001E.\u0001.\u0001) obj60;
      obj59.Selected = false;
      obj59.Text = (string) null;
      obj61.AcceptRightClick = true;
      obj61.Bounds = new Rectangle(272, 62, 46, 26);
      obj61.ButtonType = (Enum) \u0019.\u0003;
      obj61.Enabled = true;
      obj61.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10303));
      obj61.Name = \u001E.\u0001(10336);
      obj61.Overlay = (\u001E.\u0001.\u0001) obj62;
      obj61.Selected = false;
      obj61.Text = (string) null;
      obj63.AcceptRightClick = true;
      obj63.Bounds = new Rectangle(322, 62, 46, 26);
      obj63.ButtonType = (Enum) \u0019.\u0003;
      obj63.Enabled = true;
      obj63.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10349));
      obj63.Name = \u001E.\u0001(10382);
      obj63.Overlay = (\u001E.\u0001.\u0001) obj64;
      obj63.Selected = false;
      obj63.Text = (string) null;
      obj65.AcceptRightClick = true;
      obj65.Bounds = new Rectangle(372, 62, 46, 26);
      obj65.ButtonType = (Enum) \u0019.\u0003;
      obj65.Enabled = true;
      obj65.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10403));
      obj65.Name = \u001E.\u0001(10436);
      obj65.Overlay = (\u001E.\u0001.\u0001) obj66;
      obj65.Selected = false;
      obj65.Text = (string) null;
      obj67.AcceptRightClick = true;
      obj67.Bounds = new Rectangle(72, 92, 46, 26);
      obj67.ButtonType = (Enum) \u0019.\u0004;
      obj67.Enabled = true;
      obj67.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10453));
      obj67.Name = \u001E.\u0001(10486);
      obj68.Damage = 4;
      obj68.NormalQuantity = 0;
      obj68.OrganicQuantity = 0;
      obj67.Overlay = (\u001E.\u0001.\u0001) obj68;
      obj67.Selected = false;
      obj67.Text = (string) null;
      obj69.AcceptRightClick = true;
      obj69.Bounds = new Rectangle(122, 92, 46, 26);
      obj69.ButtonType = (Enum) \u0019.\u0004;
      obj69.Enabled = true;
      obj69.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10499));
      obj69.Name = \u001E.\u0001(10532);
      obj70.Damage = 7;
      obj70.NormalQuantity = 0;
      obj70.OrganicQuantity = 0;
      obj69.Overlay = (\u001E.\u0001.\u0001) obj70;
      obj69.Selected = false;
      obj69.Text = (string) null;
      obj71.AcceptRightClick = true;
      obj71.Bounds = new Rectangle(172, 92, 46, 26);
      obj71.ButtonType = (Enum) \u0019.\u0004;
      obj71.Enabled = true;
      obj71.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10545));
      obj71.Name = \u001E.\u0001(10578);
      obj72.Damage = 11;
      obj72.NormalQuantity = 0;
      obj72.OrganicQuantity = 0;
      obj71.Overlay = (\u001E.\u0001.\u0001) obj72;
      obj71.Selected = false;
      obj71.Text = (string) null;
      obj73.AcceptRightClick = true;
      obj73.Bounds = new Rectangle(222, 92, 46, 26);
      obj73.ButtonType = (Enum) \u0019.\u0004;
      obj73.Enabled = true;
      obj73.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10587));
      obj73.Name = \u001E.\u0001(10620);
      obj74.Damage = 16;
      obj74.NormalQuantity = 0;
      obj74.OrganicQuantity = 0;
      obj73.Overlay = (\u001E.\u0001.\u0001) obj74;
      obj73.Selected = false;
      obj73.Text = (string) null;
      obj75.AcceptRightClick = true;
      obj75.Bounds = new Rectangle(272, 92, 46, 26);
      obj75.ButtonType = (Enum) \u0019.\u0004;
      obj75.Enabled = true;
      obj75.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10629));
      obj75.Name = \u001E.\u0001(10662);
      obj76.Damage = 21;
      obj76.NormalQuantity = 0;
      obj76.OrganicQuantity = 0;
      obj75.Overlay = (\u001E.\u0001.\u0001) obj76;
      obj75.Selected = false;
      obj75.Text = (string) null;
      obj77.AcceptRightClick = true;
      obj77.Bounds = new Rectangle(322, 92, 46, 26);
      obj77.ButtonType = (Enum) \u0019.\u0004;
      obj77.Enabled = true;
      obj77.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10683));
      obj77.Name = \u001E.\u0001(10716);
      obj78.Damage = 50;
      obj78.NormalQuantity = 0;
      obj78.OrganicQuantity = 0;
      obj77.Overlay = (\u001E.\u0001.\u0001) obj78;
      obj77.Selected = false;
      obj77.Text = (string) null;
      obj79.AcceptRightClick = true;
      obj79.Bounds = new Rectangle(372, 92, 46, 26);
      obj79.ButtonType = (Enum) \u0019.\u0004;
      obj79.Enabled = true;
      obj79.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10729));
      obj79.Name = \u001E.\u0001(10762);
      obj80.Damage = 90;
      obj80.NormalQuantity = 0;
      obj80.OrganicQuantity = 0;
      obj79.Overlay = (\u001E.\u0001.\u0001) obj80;
      obj79.Selected = false;
      obj79.Text = (string) null;
      obj81.AcceptRightClick = true;
      obj81.Bounds = new Rectangle(72, 122, 46, 26);
      obj81.ButtonType = (Enum) \u0019.\u0005;
      obj81.Enabled = true;
      obj81.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10779));
      obj81.Name = \u001E.\u0001(10812);
      obj82.Damage = 6;
      obj82.NormalQuantity = 0;
      obj82.OrganicQuantity = 0;
      obj81.Overlay = (\u001E.\u0001.\u0001) obj82;
      obj81.Selected = false;
      obj81.Text = (string) null;
      obj83.AcceptRightClick = true;
      obj83.Bounds = new Rectangle(122, 122, 46, 26);
      obj83.ButtonType = (Enum) \u0019.\u0005;
      obj83.Enabled = true;
      obj83.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10825));
      obj83.Name = \u001E.\u0001(10858);
      obj84.Damage = 10;
      obj84.NormalQuantity = 0;
      obj84.OrganicQuantity = 0;
      obj83.Overlay = (\u001E.\u0001.\u0001) obj84;
      obj83.Selected = false;
      obj83.Text = (string) null;
      obj85.AcceptRightClick = true;
      obj85.Bounds = new Rectangle(172, 122, 46, 26);
      obj85.ButtonType = (Enum) \u0019.\u0005;
      obj85.Enabled = true;
      obj85.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10879));
      obj85.Name = \u001E.\u0001(10912);
      obj86.Damage = 17;
      obj86.NormalQuantity = 0;
      obj86.OrganicQuantity = 0;
      obj85.Overlay = (\u001E.\u0001.\u0001) obj86;
      obj85.Selected = false;
      obj85.Text = (string) null;
      obj87.AcceptRightClick = true;
      obj87.Bounds = new Rectangle(222, 122, 46, 26);
      obj87.ButtonType = (Enum) \u0019.\u0005;
      obj87.Enabled = true;
      obj87.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10933));
      obj87.Name = \u001E.\u0001(10966);
      obj88.Damage = 27;
      obj88.NormalQuantity = 0;
      obj88.OrganicQuantity = 0;
      obj87.Overlay = (\u001E.\u0001.\u0001) obj88;
      obj87.Selected = false;
      obj87.Text = (string) null;
      obj89.AcceptRightClick = true;
      obj89.Bounds = new Rectangle(272, 122, 46, 26);
      obj89.ButtonType = (Enum) \u0019.\u0005;
      obj89.Enabled = true;
      obj89.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(10987));
      obj89.Name = \u001E.\u0001(11020);
      obj90.Damage = 40;
      obj90.NormalQuantity = 0;
      obj90.OrganicQuantity = 0;
      obj89.Overlay = (\u001E.\u0001.\u0001) obj90;
      obj89.Selected = false;
      obj89.Text = (string) null;
      obj91.AcceptRightClick = true;
      obj91.Bounds = new Rectangle(322, 122, 46, 26);
      obj91.ButtonType = (Enum) \u0019.\u0005;
      obj91.Enabled = true;
      obj91.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(11041));
      obj91.Name = \u001E.\u0001(11074);
      obj92.Damage = 100;
      obj92.NormalQuantity = 0;
      obj92.OrganicQuantity = 0;
      obj91.Overlay = (\u001E.\u0001.\u0001) obj92;
      obj91.Selected = false;
      obj91.Text = (string) null;
      obj93.AcceptRightClick = true;
      obj93.Bounds = new Rectangle(372, 122, 46, 26);
      obj93.ButtonType = (Enum) \u0019.\u0005;
      obj93.Enabled = true;
      obj93.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(11095));
      obj93.Name = \u001E.\u0001(11128);
      obj94.Damage = 120;
      obj94.NormalQuantity = 0;
      obj94.OrganicQuantity = 0;
      obj93.Overlay = (\u001E.\u0001.\u0001) obj94;
      obj93.Selected = false;
      obj93.Text = (string) null;
      obj95.AcceptRightClick = true;
      obj95.Bounds = new Rectangle(72, 152, 46, 26);
      obj95.ButtonType = (Enum) \u0019.\u0006;
      obj95.Enabled = true;
      obj95.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(11145));
      obj95.Name = \u001E.\u0001(11178);
      obj96.Damage = 4;
      obj96.NormalQuantity = 0;
      obj96.OrganicQuantity = 0;
      obj95.Overlay = (\u001E.\u0001.\u0001) obj96;
      obj95.Selected = false;
      obj95.Text = (string) null;
      obj97.AcceptRightClick = true;
      obj97.Bounds = new Rectangle(122, 152, 46, 26);
      obj97.ButtonType = (Enum) \u0019.\u0006;
      obj97.Enabled = true;
      obj97.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(11203));
      obj97.Name = \u001E.\u0001(11236);
      obj98.Damage = 8;
      obj98.NormalQuantity = 0;
      obj98.OrganicQuantity = 0;
      obj97.Overlay = (\u001E.\u0001.\u0001) obj98;
      obj97.Selected = false;
      obj97.Text = (string) null;
      obj99.AcceptRightClick = true;
      obj99.Bounds = new Rectangle(172, 152, 46, 26);
      obj99.ButtonType = (Enum) \u0019.\u0006;
      obj99.Enabled = true;
      obj99.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(11257));
      obj99.Name = \u001E.\u0001(11290);
      obj100.Damage = 12;
      obj100.NormalQuantity = 0;
      obj100.OrganicQuantity = 0;
      obj99.Overlay = (\u001E.\u0001.\u0001) obj100;
      obj99.Selected = false;
      obj99.Text = (string) null;
      obj101.AcceptRightClick = true;
      obj101.Bounds = new Rectangle(222, 152, 46, 26);
      obj101.ButtonType = (Enum) \u0019.\u0006;
      obj101.Enabled = true;
      obj101.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(11307));
      obj101.Name = \u001E.\u0001(11340);
      obj102.Damage = 21;
      obj102.NormalQuantity = 0;
      obj102.OrganicQuantity = 0;
      obj101.Overlay = (\u001E.\u0001.\u0001) obj102;
      obj101.Selected = false;
      obj101.Text = (string) null;
      obj103.AcceptRightClick = true;
      obj103.Bounds = new Rectangle(272, 152, 46, 26);
      obj103.ButtonType = (Enum) \u0019.\u0006;
      obj103.Enabled = true;
      obj103.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(11361));
      obj103.Name = \u001E.\u0001(11394);
      obj104.Damage = 30;
      obj104.NormalQuantity = 0;
      obj104.OrganicQuantity = 0;
      obj103.Overlay = (\u001E.\u0001.\u0001) obj104;
      obj103.Selected = false;
      obj103.Text = (string) null;
      obj105.AcceptRightClick = true;
      obj105.Bounds = new Rectangle(322, 152, 46, 26);
      obj105.ButtonType = (Enum) \u0019.\u0006;
      obj105.Enabled = true;
      obj105.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(11407));
      obj105.Name = \u001E.\u0001(11440);
      obj106.Damage = 80;
      obj106.NormalQuantity = 0;
      obj106.OrganicQuantity = 0;
      obj105.Overlay = (\u001E.\u0001.\u0001) obj106;
      obj105.Selected = false;
      obj105.Text = (string) null;
      obj107.AcceptRightClick = true;
      obj107.Bounds = new Rectangle(372, 152, 46, 26);
      obj107.ButtonType = (Enum) \u0019.\u0006;
      obj107.Enabled = true;
      obj107.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(11457));
      obj107.Name = \u001E.\u0001(11490);
      obj108.Damage = 105;
      obj108.NormalQuantity = 0;
      obj108.OrganicQuantity = 0;
      obj107.Overlay = (\u001E.\u0001.\u0001) obj108;
      obj107.Selected = false;
      obj107.Text = (string) null;
      obj109.AcceptRightClick = true;
      obj109.Bounds = new Rectangle(72, 182, 46, 26);
      obj109.ButtonType = (Enum) \u0019.\u0007;
      obj109.Enabled = true;
      obj109.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(11499));
      obj109.Name = \u001E.\u0001(11532);
      obj110.Damage = 10;
      obj110.NormalQuantity = 0;
      obj110.OrganicQuantity = 0;
      obj109.Overlay = (\u001E.\u0001.\u0001) obj110;
      obj109.Selected = false;
      obj109.Text = (string) null;
      obj111.AcceptRightClick = true;
      obj111.Bounds = new Rectangle(122, 182, 46, 26);
      obj111.ButtonType = (Enum) \u0019.\u0007;
      obj111.Enabled = true;
      obj111.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(11549));
      obj111.Name = \u001E.\u0001(11582);
      obj112.Damage = 18;
      obj112.NormalQuantity = 0;
      obj112.OrganicQuantity = 0;
      obj111.Overlay = (\u001E.\u0001.\u0001) obj112;
      obj111.Selected = false;
      obj111.Text = (string) null;
      obj113.AcceptRightClick = true;
      obj113.Bounds = new Rectangle(172, 182, 46, 26);
      obj113.ButtonType = (Enum) \u0019.\u0007;
      obj113.Enabled = true;
      obj113.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(11595));
      obj113.Name = \u001E.\u0001(11628);
      obj114.Damage = 30;
      obj114.NormalQuantity = 0;
      obj114.OrganicQuantity = 0;
      obj113.Overlay = (\u001E.\u0001.\u0001) obj114;
      obj113.Selected = false;
      obj113.Text = (string) null;
      obj115.AcceptRightClick = true;
      obj115.Bounds = new Rectangle(222, 182, 46, 26);
      obj115.ButtonType = (Enum) \u0019.\u0007;
      obj115.Enabled = true;
      obj115.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(11637));
      obj115.Name = \u001E.\u0001(11670);
      obj116.Damage = 45;
      obj116.NormalQuantity = 0;
      obj116.OrganicQuantity = 0;
      obj115.Overlay = (\u001E.\u0001.\u0001) obj116;
      obj115.Selected = false;
      obj115.Text = (string) null;
      obj117.AcceptRightClick = true;
      obj117.Bounds = new Rectangle(272, 182, 46, 26);
      obj117.ButtonType = (Enum) \u0019.\u0007;
      obj117.Enabled = true;
      obj117.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(11687));
      obj117.Name = \u001E.\u0001(11720);
      obj118.Damage = 60;
      obj118.NormalQuantity = 0;
      obj118.OrganicQuantity = 0;
      obj117.Overlay = (\u001E.\u0001.\u0001) obj118;
      obj117.Selected = false;
      obj117.Text = (string) null;
      obj119.AcceptRightClick = true;
      obj119.Bounds = new Rectangle(322, 182, 46, 26);
      obj119.ButtonType = (Enum) \u0019.\u0007;
      obj119.Enabled = true;
      obj119.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(11729));
      obj119.Name = \u001E.\u0001(11762);
      obj120.Damage = 170;
      obj120.NormalQuantity = 0;
      obj120.OrganicQuantity = 0;
      obj119.Overlay = (\u001E.\u0001.\u0001) obj120;
      obj119.Selected = false;
      obj119.Text = (string) null;
      obj121.AcceptRightClick = true;
      obj121.Bounds = new Rectangle(372, 182, 46, 26);
      obj121.ButtonType = (Enum) \u0019.\u0007;
      obj121.Enabled = true;
      obj121.Icon = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(11779));
      obj121.Name = \u001E.\u0001(11812);
      obj122.Damage = 180;
      obj122.NormalQuantity = 0;
      obj122.OrganicQuantity = 0;
      obj121.Overlay = (\u001E.\u0001.\u0001) obj122;
      obj121.Selected = false;
      obj121.Text = (string) null;
      this.\u0001.Buttons.Add(obj31);
      this.\u0001.Buttons.Add(obj32);
      this.\u0001.Buttons.Add(obj33);
      this.\u0001.Buttons.Add(obj34);
      this.\u0001.Buttons.Add(obj36);
      this.\u0001.Buttons.Add(obj37);
      this.\u0001.Buttons.Add(obj38);
      this.\u0001.Buttons.Add(obj39);
      this.\u0001.Buttons.Add(obj41);
      this.\u0001.Buttons.Add(obj43);
      this.\u0001.Buttons.Add(obj45);
      this.\u0001.Buttons.Add(obj47);
      this.\u0001.Buttons.Add(obj49);
      this.\u0001.Buttons.Add(obj51);
      this.\u0001.Buttons.Add(obj53);
      this.\u0001.Buttons.Add(obj55);
      this.\u0001.Buttons.Add(obj57);
      this.\u0001.Buttons.Add(obj59);
      this.\u0001.Buttons.Add(obj61);
      this.\u0001.Buttons.Add(obj63);
      this.\u0001.Buttons.Add(obj65);
      this.\u0001.Buttons.Add(obj67);
      this.\u0001.Buttons.Add(obj69);
      this.\u0001.Buttons.Add(obj71);
      this.\u0001.Buttons.Add(obj73);
      this.\u0001.Buttons.Add(obj75);
      this.\u0001.Buttons.Add(obj77);
      this.\u0001.Buttons.Add(obj79);
      this.\u0001.Buttons.Add(obj81);
      this.\u0001.Buttons.Add(obj83);
      this.\u0001.Buttons.Add(obj85);
      this.\u0001.Buttons.Add(obj87);
      this.\u0001.Buttons.Add(obj89);
      this.\u0001.Buttons.Add(obj91);
      this.\u0001.Buttons.Add(obj93);
      this.\u0001.Buttons.Add(obj95);
      this.\u0001.Buttons.Add(obj97);
      this.\u0001.Buttons.Add(obj99);
      this.\u0001.Buttons.Add(obj101);
      this.\u0001.Buttons.Add(obj103);
      this.\u0001.Buttons.Add(obj105);
      this.\u0001.Buttons.Add(obj107);
      this.\u0001.Buttons.Add(obj109);
      this.\u0001.Buttons.Add(obj111);
      this.\u0001.Buttons.Add(obj113);
      this.\u0001.Buttons.Add(obj115);
      this.\u0001.Buttons.Add(obj117);
      this.\u0001.Buttons.Add(obj119);
      this.\u0001.Buttons.Add(obj121);
      this.\u0001.DisabledEndColor = \u008E\u001D.\u0017\u007F(37, 37, 37);
      this.\u0001.DisabledStartColor = \u008E\u001D.\u0017\u007F(163, 163, 163);
      this.\u0001.DownEndColor = \u008E\u001D.\u0017\u007F(111, 2, 14);
      this.\u0001.DownStartColor = \u008E\u001D.\u0017\u007F(250, 102, 102);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u001E.\u0001(2360), 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0006\u007F());
      this.\u0001.HoverEndColor = \u008E\u001D.\u0017\u007F(157, 0, 18);
      this.\u0001.HoverRadialCenterColor = \u001B\u001C.\u0015\u007F(200, (int) byte.MaxValue, 0, 0);
      this.\u0001.HoverRadialSurroundColor = \u001B\u001C.\u0015\u007F(0, (int) byte.MaxValue, 0, 0);
      this.\u0001.HoverStartColor = \u008E\u001D.\u0017\u007F(248, 152, 152);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(118, 126));
      \u0001\u001F.\u007E\u0003\u0084((object) this.\u0001, new Padding(0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001E.\u0001(11825));
      this.\u0001.NormalEndColor = \u008E\u001D.\u0017\u007F(1, 137, 224);
      this.\u0001.NormalStartColor = \u008E\u001D.\u0017\u007F(76, 181, 248);
      this.\u0001.SelectedEndColor = \u008E\u001D.\u0017\u007F(0, 157, 0);
      this.\u0001.SelectedRadialCenterColor = \u001B\u001C.\u0015\u007F(200, 0, (int) byte.MaxValue, 0);
      this.\u0001.SelectedRadialSurroundColor = \u001B\u001C.\u0015\u007F(0, 0, (int) byte.MaxValue, 0);
      this.\u0001.SelectedStartColor = \u008E\u001D.\u0017\u007F(152, 248, 165);
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(426, 210));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001E.\u0001(9442));
      this.\u0001.TextFont = new Font(\u001E.\u0001(2360), 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.\u0001.ToolTipsEnabled = true;
      this.\u0001.ButtonClicked += new EventHandler<\u001D>(this.\u001D\u0005);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0018, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0018, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0018, new Font(\u001E.\u0001(4184), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0018, new Point(0, 486));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0018, \u001E.\u0001(6547));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0018, new Size(105, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0018, 21);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0018, \u001E.\u0001(6572));
      this.AllowFormDrag = true;
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0087\u0081.\u007E\u001E\u0083((object) this, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(11838)));
      \u000E\u001F.\u0010\u008B((object) this, new Size(700, 500));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0018);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0017);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0016);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0015);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0014);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0013);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0011);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u000F);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0008);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0012);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0010);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u000E);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0099\u001F.\u007E\u008D\u0083((object) this, true);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001E.\u0001(5306)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u001E.\u0001(11867));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u001E.\u0001(11880));
      \u009E\u001C.\u0087\u0084((object) this, new HelpEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }
  }
}
