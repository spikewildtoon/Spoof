// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u001B;
using \u001D;
using \u001E;
using \u007F;
using \u0080;
using \u0081;
using \u0084;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace \u0080
{
  internal sealed class \u001F : \u0016.\u001A
  {
    [NonSerialized]
    internal new static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    private static readonly string \u0006;
    private static readonly string \u0007;
    private static readonly string \u0008;
    private static readonly string \u000E;
    private static readonly string \u000F;
    private static readonly string \u0010;
    private static readonly string \u0011;
    private static readonly string \u0012;
    private static readonly string \u0013;
    private static readonly string \u0014;
    private static readonly string \u0015;
    private static readonly string \u0016;
    private static readonly string \u0017;
    private static readonly string \u0018;
    private static readonly string \u0019;
    private static readonly string \u001A;
    private static readonly string \u001B;
    private static readonly string \u001C;
    private static readonly string \u001D;
    private static readonly string \u001E;
    private static readonly string \u001F;
    private static readonly string \u007F;
    private static readonly string \u0080;
    private static readonly string \u0081;
    private static readonly string \u0082;
    private static readonly string \u0083;
    private static readonly string \u0084;
    private static readonly string \u0086;
    private static readonly string \u0087;
    private static readonly string \u0088;
    private static readonly string \u0089;
    private static readonly string \u008A;
    private static readonly string \u008B;
    private static readonly string \u008C;
    private static readonly string \u008D;
    private static readonly string \u008E;
    private static readonly string \u008F;
    private static readonly string \u0090;
    private static readonly string \u0091;
    private static readonly string \u0092;
    private static readonly string \u0093;
    private static readonly string \u0094;
    private static readonly string \u0095;
    private static readonly string \u0096;
    private static readonly string \u0097;
    private static readonly string \u0098;
    private static readonly string \u0099;
    private static readonly string \u009A;
    private static readonly string \u009B;
    private static readonly string \u009C;
    private static readonly string \u009D;
    private static readonly string \u009E;
    private static readonly string \u009F;
    private static readonly string \u0001\u0002;
    private static readonly string \u0002\u0002;
    private static readonly string \u0003\u0002;
    private static readonly string \u0004\u0002;
    private static readonly string \u0005\u0002;
    private static readonly string \u0006\u0002;
    private static readonly string \u0007\u0002;
    private static readonly string \u0008\u0002;
    private static readonly string \u000E\u0002;
    private static readonly string \u000F\u0002;
    private static readonly string \u0010\u0002;
    private static readonly string \u0011\u0002;
    private static readonly string \u0012\u0002;
    private static readonly string \u0013\u0002;
    private \u001C.\u0082 \u0001;
    private \u0004 \u0001;
    private \u0019.\u0081 \u0001;
    private \u0003 \u0001;
    private \u001F.\u0001 \u0001;
    private \u0081.\u0081 \u0001;
    private \u0080.\u001F.\u0001 \u0001;
    private readonly \u0017 \u0001;
    private readonly \u0017 \u0002;
    private readonly \u0017 \u0003;
    private readonly \u0013 \u0001;
    private readonly Size \u0001;
    private DateTime \u0001;
    private DateTime \u0002;
    private uint \u0001;
    private uint \u0002;
    private uint \u0003;
    private uint \u0004;
    private Task \u0001;
    private IContainer \u0001;
    private Label \u0001;

    private \u0080.\u001F.\u0001 State
    {
      get
      {
        return this.\u0001;
      }
      set
      {
        this.\u0001 = value;
        this.\u001E\u0005(new MethodInvoker((object) this, __methodptr(\u0092\u0005)));
      }
    }

    public DateTime StartTime
    {
      get
      {
        return this.\u0001;
      }
    }

    public DateTime EndTime
    {
      get
      {
        return this.\u0002;
      }
    }

    public uint BucketsSold
    {
      get
      {
        return this.\u0001;
      }
    }

    public uint FishCaught
    {
      get
      {
        return this.\u0002;
      }
    }

    public uint BootsCaught
    {
      get
      {
        return this.\u0003;
      }
    }

    public uint Casts
    {
      get
      {
        return this.\u0004;
      }
    }

    static \u001F()
    {
      \u0004.\u001D\u0005(typeof (\u0080.\u001F));
      \u0080.\u001F.\u0001 = \u0080.\u001F.\u0001(89324);
      \u0080.\u001F.\u0002 = \u0080.\u001F.\u0001(89353);
      \u0080.\u001F.\u0003 = \u0080.\u001F.\u0001(89398);
      \u0080.\u001F.\u0004 = \u0080.\u001F.\u0001(89419);
      \u0080.\u001F.\u0005 = \u0080.\u001F.\u0001(89448);
      \u0080.\u001F.\u0006 = \u0080.\u001F.\u0001(89477);
      \u0080.\u001F.\u0007 = \u0080.\u001F.\u0001(89506);
      \u0080.\u001F.\u0008 = \u0080.\u001F.\u0001(89535);
      \u0080.\u001F.\u000E = \u0080.\u001F.\u0001(89572);
      \u0080.\u001F.\u000F = \u0080.\u001F.\u0001(89593);
      \u0080.\u001F.\u0010 = \u0080.\u001F.\u0001(89622);
      \u0080.\u001F.\u0011 = \u0080.\u001F.\u0001(89643);
      \u0080.\u001F.\u0012 = \u0080.\u001F.\u0001(89668);
      \u0080.\u001F.\u0013 = \u0080.\u001F.\u0001(89701);
      \u0080.\u001F.\u0014 = \u0080.\u001F.\u0001(89766);
      \u0080.\u001F.\u0015 = \u0080.\u001F.\u0001(89783);
      \u0080.\u001F.\u0016 = \u0080.\u001F.\u0001(89804);
      \u0080.\u001F.\u0017 = \u0080.\u001F.\u0001(89869);
      \u0080.\u001F.\u0018 = \u0080.\u001F.\u0001(89890);
      \u0080.\u001F.\u0019 = \u0080.\u001F.\u0001(89943);
      \u0080.\u001F.\u001A = \u0080.\u001F.\u0001(89968);
      \u0080.\u001F.\u001B = \u0080.\u001F.\u0001(90013);
      \u0080.\u001F.\u001C = \u0080.\u001F.\u0001(90026);
      \u0080.\u001F.\u001D = \u0080.\u001F.\u0001(90059);
      \u0080.\u001F.\u001E = \u0080.\u001F.\u0001(90092);
      \u0080.\u001F.\u001F = \u0080.\u001F.\u0001(90129);
      \u0080.\u001F.\u007F = \u0080.\u001F.\u0001(90174);
      \u0080.\u001F.\u0080 = \u0080.\u001F.\u0001(90211);
      \u0080.\u001F.\u0081 = \u0080.\u001F.\u0001(90256);
      \u0080.\u001F.\u0082 = \u0080.\u001F.\u0001(90281);
      \u0080.\u001F.\u0083 = \u0080.\u001F.\u0001(90310);
      \u0080.\u001F.\u0084 = \u0080.\u001F.\u0001(90343);
      \u0080.\u001F.\u0086 = \u0080.\u001F.\u0001(90380);
      \u0080.\u001F.\u0087 = \u0080.\u001F.\u0001(90401);
      \u0080.\u001F.\u0088 = \u0080.\u001F.\u0001(90426);
      \u0080.\u001F.\u0089 = \u0080.\u001F.\u0001(90451);
      \u0080.\u001F.\u008A = \u0080.\u001F.\u0001(90484);
      \u0080.\u001F.\u008B = \u0080.\u001F.\u0001(90549);
      \u0080.\u001F.\u008C = \u0080.\u001F.\u0001(90566);
      \u0080.\u001F.\u008D = \u0080.\u001F.\u0001(91028);
      \u0080.\u001F.\u008E = \u0080.\u001F.\u0001(91061);
      \u0080.\u001F.\u008F = \u0080.\u001F.\u0001(91142);
      \u0080.\u001F.\u0090 = \u0080.\u001F.\u0001(91163);
      \u0080.\u001F.\u0091 = \u0080.\u001F.\u0001(91240);
      \u0080.\u001F.\u0092 = \u0080.\u001F.\u0001(91265);
      \u0080.\u001F.\u0093 = \u0080.\u001F.\u0001(91435);
      \u0080.\u001F.\u0094 = \u0080.\u001F.\u0001(91468);
      \u0080.\u001F.\u0095 = \u0080.\u001F.\u0001(91618);
      \u0080.\u001F.\u0096 = \u0080.\u001F.\u0001(91647);
      \u0080.\u001F.\u0097 = \u0080.\u001F.\u0001(91724);
      \u0080.\u001F.\u0098 = \u0080.\u001F.\u0001(91741);
      \u0080.\u001F.\u0099 = \u0080.\u001F.\u0001(91834);
      \u0080.\u001F.\u009A = \u0080.\u001F.\u0001(91855);
      \u0080.\u001F.\u009B = \u0080.\u001F.\u0001(16513);
      \u0080.\u001F.\u009C = \u0080.\u001F.\u0001(28940);
      \u0080.\u001F.\u009D = \u0080.\u001F.\u0001(29041);
      \u0080.\u001F.\u009E = \u0080.\u001F.\u0001(92041);
      \u0080.\u001F.\u009F = \u0080.\u001F.\u0001(92215);
      \u0080.\u001F.\u0001\u0002 = \u0080.\u001F.\u0001(92244);
      \u0080.\u001F.\u0002\u0002 = \u0080.\u001F.\u0001(92333);
      \u0080.\u001F.\u0003\u0002 = \u0080.\u001F.\u0001(92366);
      \u0080.\u001F.\u0004\u0002 = \u0080.\u001F.\u0001(92407);
      \u0080.\u001F.\u0005\u0002 = \u0080.\u001F.\u0001(92436);
      \u0080.\u001F.\u0006\u0002 = \u0080.\u001F.\u0001(92477);
      \u0080.\u001F.\u0007\u0002 = \u0080.\u001F.\u0001(92518);
      \u0080.\u001F.\u0008\u0002 = \u0080.\u001F.\u0001(92543);
      \u0080.\u001F.\u000E\u0002 = \u0080.\u001F.\u0001(92592);
      \u0080.\u001F.\u000F\u0002 = \u0080.\u001F.\u0001(92621);
      \u0080.\u001F.\u0010\u0002 = \u0080.\u001F.\u0001(92879);
      \u0080.\u001F.\u0011\u0002 = \u0080.\u001F.\u0001(92900);
      \u0080.\u001F.\u0012\u0002 = \u0080.\u001F.\u0001(92925);
      \u0080.\u001F.\u0013\u0002 = \u0080.\u001F.\u0001(92994);
    }

    public \u001F(IntPtr hWnd, \u0019.\u0081 operation, \u001C.\u0082 captures, \u0004 docks, \u001F.\u0001 wayPoints)
      : base(hWnd)
    {
      this.\u0091\u0005();
      this.\u0001 = new Size(576, 432);
      this.\u0001 = \u0017.\u001D\u0005(new Size(32, 16), new Size(800, 600));
      this.\u0002 = \u0017.\u001D\u0005(new Size(90, 60), new Size(800, 600));
      this.\u0003 = \u0017.\u001D\u0005(new Size(12, 8), new Size(1024, 768));
      this.\u0001 = \u0013.\u001D\u0005(new Rectangle(Point.Empty, new Size(1024, 544)), new Rectangle(Point.Empty, new Size(1024, 768)));
      this.\u0001 = \u0081.\u0080.Instance.JoeFishSettings;
      this.\u0001 = operation;
      this.\u0001 = captures;
      this.\u0001 = docks;
      this.\u0001 = wayPoints;
      this.State = \u0080.\u001F.\u0001.\u0001;
    }

    private void \u0083\u0005()
    {
      this.\u001D\u0005((MethodInvoker) (() => \u0017.\u001D\u0005(\u0080.\u001F.\u008A, \u0080.\u001F.\u008B)));
    }

    private void \u0084\u0005()
    {
      this.\u001D\u0005((MethodInvoker) (() => \u0017.\u001D\u0005(\u0080.\u001F.\u0001\u0002, \u0080.\u001F.\u0002\u0002)));
    }

    private void \u0086\u0005()
    {
      this.\u001D\u0005((MethodInvoker) (() => \u0017.\u001D\u0005(\u0080.\u001F.\u009E, \u0080.\u001F.\u009F)));
    }

    private void \u0087\u0005()
    {
      this.\u001D\u0005((MethodInvoker) (() => \u0017.\u001E\u0005(\u0080.\u001F.\u009C, \u0080.\u001F.\u009D)));
    }

    private void \u0088\u0005()
    {
      this.\u001D\u0005((MethodInvoker) (() => \u0017.\u001E\u0005(\u0080.\u001F.\u009A, \u0080.\u001F.\u009B)));
    }

    private void \u0089\u0005()
    {
      this.\u001D\u0005((MethodInvoker) (() => \u0017.\u001D\u0005(\u0080.\u001F.\u0098, \u0080.\u001F.\u0099)));
    }

    private void \u008A\u0005()
    {
      this.\u001D\u0005((MethodInvoker) (() => \u0017.\u001D\u0005(\u0080.\u001F.\u0096, \u0080.\u001F.\u0097)));
    }

    private void \u008B\u0005()
    {
      this.\u001D\u0005((MethodInvoker) (() => \u0017.\u001E\u0005(\u0080.\u001F.\u0094, \u0080.\u001F.\u0095)));
    }

    private void \u008C\u0005()
    {
      this.\u001D\u0005((MethodInvoker) (() => \u0017.\u001E\u0005(\u0080.\u001F.\u0092, \u0080.\u001F.\u0093)));
    }

    private void \u008D\u0005()
    {
      this.\u001D\u0005((MethodInvoker) (() => \u0017.\u001D\u0005(\u0080.\u001F.\u0090, \u0080.\u001F.\u0091)));
    }

    private void \u008E\u0005()
    {
      this.\u001D\u0005((MethodInvoker) (() => \u0017.\u001D\u0005(\u0080.\u001F.\u008E, \u0080.\u001F.\u008F)));
    }

    private void \u008F\u0005()
    {
      this.\u001D\u0005((MethodInvoker) (() => \u0017.\u001D\u0005(\u0080.\u001F.\u008C, \u0080.\u001F.\u008D)));
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      if (base.\u0001.Playground != \u001A.\u0019.\u0002 && (!this.\u0001.WayPoints.ContainsKey(base.\u0001.Playground) || this.\u0001.WayPoints[base.\u0001.Playground].Count<KeyValuePair<PointF, \u007F.\u007F>>((Func<KeyValuePair<PointF, \u007F.\u007F>, bool>) (item => item.Value == \u007F.\u007F.\u0002)) == 0))
      {
        \u001A\u001E.\u0001\u0086((object) this);
        \u0017.\u001D\u0005(\u0080.\u001F.\u000F\u0002, \u0080.\u001F.\u0010\u0002);
        this.\u001D\u0005(DialogResult.Abort);
      }
      else
      {
        this.\u0001 = new Task((Action) (() =>
        {
          try
          {
            switch (this.\u0001)
            {
              case \u0019.\u0081.\u0001:
                if (!this.\u0082\u0005() || !this.\u0086\u0005())
                {
                  this.\u001D\u0005(DialogResult.Cancel);
                  break;
                }
                this.State = \u0080.\u001F.\u0001.\u0004;
                this.\u0001 = \u001D\u0082.\u0011\u0094();
                this.\u0090\u0005();
                this.\u001D\u0005(DialogResult.OK);
                break;
              case \u0019.\u0081.\u0002:
                if (this.\u0082\u0005() && this.\u0087\u0005())
                {
                  this.\u008D\u0005();
                  this.\u001D\u0005(DialogResult.OK);
                  break;
                }
                this.\u001D\u0005(DialogResult.Cancel);
                break;
              default:
                this.\u001D\u0005(DialogResult.None);
                break;
            }
          }
          catch (Exception ex)
          {
            ex.\u001D\u0005((object) \u009E\u0081.\u001F\u0093(\u0080.\u001F.\u0011\u0002, (object) this.\u0001.\u001D\u0005()));
            this.\u0087\u0005();
            this.\u001D\u0005(DialogResult.None);
          }
        }));
        \u001A\u001E.\u007E\u0017\u0099((object) this.\u0001);
      }
    }

    private void \u0090\u0005()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0080.\u001F.\u0003 obj1 = new \u0080.\u001F.\u0003();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = new DateTime?();
      List<PointF> reversePath = (List<PointF>) null;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = false;
      try
      {
        while (!\u0099\u0082.\u007E\u009E\u0098((object) base.\u0001))
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          \u0080.\u001F.\u0004 obj2 = new \u0080.\u001F.\u0004();
          switch (this.State)
          {
            case \u0080.\u001F.\u0001.\u0004:
              \u0013.\u001D\u0005(\u0080.\u001F.\u0081, true);
              if (this.\u001D\u0005(reversePath))
              {
                \u0013.\u001D\u0005(\u0080.\u001F.\u0080, true);
                if (this.\u0082\u0005())
                {
                  \u0013.\u001D\u0005(\u0080.\u001F.\u007F, true);
                  this.State = \u0080.\u001F.\u0001.\u0005;
                  continue;
                }
                \u0013.\u001D\u0005(\u0080.\u001F.\u001F, true);
                return;
              }
              \u0013.\u001D\u0005(\u0080.\u001F.\u001E, \u0099\u0082.\u007E\u009E\u0098((object) base.\u0001));
              // ISSUE: reference to a compiler-generated field
              obj1.\u0001 = new DateTime?(\u001D\u0082.\u0011\u0094());
              if (\u0099\u0082.\u007E\u009E\u0098((object) base.\u0001))
                return;
              this.\u008B\u0005();
              return;
            case \u0080.\u001F.\u0001.\u0005:
              \u0013.\u001D\u0005(\u0080.\u001F.\u0019, true);
              // ISSUE: reference to a compiler-generated field
              obj2.\u0001 = 0;
              // ISSUE: reference to a compiler-generated field
              obj2.\u0001 = false;
              while (!\u0099\u0082.\u007E\u009E\u0098((object) base.\u0001))
              {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                \u0080.\u001F.\u0005 obj3 = new \u0080.\u001F.\u0005();
                if (!base.\u0001.ToonTownProcess.ProcessOpen)
                {
                  // ISSUE: reference to a compiler-generated field
                  obj1.\u0001 = new DateTime?(\u001D\u0082.\u0011\u0094());
                  this.\u0089\u0005();
                  return;
                }
                // ISSUE: reference to a compiler-generated field
                obj3.\u0001 = \u0080.\u001F.\u0002.\u0001;
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                \u0080.\u001F.\u0006 obj4 = new \u0080.\u001F.\u0006();
                // ISSUE: reference to a compiler-generated field
                obj4.\u0001 = new CancellationTokenSource();
                try
                {
                  // ISSUE: object of a compiler-generated type is created
                  // ISSUE: variable of a compiler-generated type
                  \u0080.\u001F.\u0007 obj5 = new \u0080.\u001F.\u0007();
                  // ISSUE: reference to a compiler-generated field
                  obj5.\u0001 = obj4;
                  // ISSUE: reference to a compiler-generated field
                  obj5.\u0001 = obj3;
                  // ISSUE: reference to a compiler-generated field
                  obj5.\u0001 = obj2;
                  // ISSUE: reference to a compiler-generated field
                  obj5.\u0001 = obj1;
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  obj5.\u0001 = new Task<Point[]>(new Func<object, Point[]>(this.\u001D\u0005), (object) \u0092\u001D.\u007E\u000E\u0099((object) obj4.\u0001), \u0092\u001D.\u007E\u000E\u0099((object) obj4.\u0001));
                  try
                  {
                    // ISSUE: reference to a compiler-generated method
                    if (!new Func<bool>(obj5.\u001D\u0005)())
                      return;
                  }
                  finally
                  {
                    // ISSUE: reference to a compiler-generated field
                    if (obj5.\u0001 != null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      \u001A\u001E.\u007E\u0094\u0092((object) obj5.\u0001);
                    }
                  }
                }
                finally
                {
                  // ISSUE: reference to a compiler-generated field
                  if (obj4.\u0001 != null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    \u001A\u001E.\u007E\u0094\u0092((object) obj4.\u0001);
                  }
                }
                // ISSUE: reference to a compiler-generated field
                if (obj2.\u0001)
                  break;
              }
              continue;
            case \u0080.\u001F.\u0001.\u0006:
              \u0013.\u001D\u0005(\u0080.\u001F.\u001D, true);
              if (this.\u001D\u0005(out reversePath))
              {
                \u0013.\u001D\u0005(\u0080.\u001F.\u001C, true);
                this.\u001D\u0005(this.\u0001.SellFishBounds, (\u0005) this.\u0001);
                ++this.\u0001;
                // ISSUE: reference to a compiler-generated field
                obj1.\u0001 = true;
                \u0013.\u001D\u0005(\u0080.\u001F.\u001B, true);
                this.State = \u0080.\u001F.\u0001.\u0004;
                continue;
              }
              \u0013.\u001D\u0005(\u0080.\u001F.\u001A, \u0099\u0082.\u007E\u009E\u0098((object) base.\u0001));
              // ISSUE: reference to a compiler-generated field
              obj1.\u0001 = new DateTime?(\u001D\u0082.\u0011\u0094());
              if (\u0099\u0082.\u007E\u009E\u0098((object) base.\u0001))
                return;
              this.\u008C\u0005();
              return;
            default:
              continue;
          }
        }
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.\u0002 = !obj1.\u0001.HasValue ? \u001D\u0082.\u0011\u0094() : obj1.\u0001.Value;
      }
    }

    private Point[] \u001D\u0005(object state)
    {
      IntPtr mainWindowHandle = base.\u0001.ToonTownProcess.MainWindowHandle;
      if (!base.\u0001.ToonTownProcess.ProcessOpen)
        return (Point[]) null;
      CancellationToken token = (CancellationToken) state;
      token.ThrowIfCancellationRequested();
      Size size = this.\u0003.\u001D\u0005(\u0013.\u001E\u0005(mainWindowHandle).Size);
      WaitHandle[] waitHandleArray = new WaitHandle[2]{ \u001B\u001F.\u007E\u009D\u0098((object) base.\u0001), token.WaitHandle };
      Point[] pointArray1 = (Point[]) null;
      List<Point> pointList = new List<Point>();
      DateTime dateTime = \u001D\u0082.\u0011\u0094();
      TimeSpan timeSpan = new TimeSpan(0, 0, 45);
      while (!\u0099\u0082.\u007E\u009E\u0098((object) base.\u0001))
      {
        \u0013.\u001D\u0005(\u0080.\u001F.\u0087, true);
        Rectangle[] rectangleArray = this.\u001D\u0005(token);
        if (rectangleArray != null)
        {
          Point[] pointArray2 = new Point[rectangleArray.Length];
          for (int index = 0; index < rectangleArray.Length; ++index)
            pointArray2[index] = \u0080.\u0015.\u001D\u0005(rectangleArray[index]);
          \u0013.\u001D\u0005(\u0080.\u001F.\u0086, new object[1]
          {
            (object) pointArray2
          });
          if (this.\u0001.RequireStableTarget)
          {
            if (pointArray1 != null && pointArray1.Length > 0)
            {
              \u0013.\u001D\u0005(\u0080.\u001F.\u0084, new object[1]
              {
                (object) pointArray1
              });
              foreach (Point point1 in pointArray2)
              {
                foreach (Point point2 in pointArray1)
                {
                  if (\u000F\u0081.\u009B\u0096(point1.X - point2.X) <= size.Width && \u000F\u0081.\u009B\u0096(point1.Y - point2.Y) <= size.Height)
                  {
                    pointList.Add(point1);
                    break;
                  }
                }
              }
              if (pointList.Count > 0)
              {
                Point[] array = pointList.ToArray();
                \u0013.\u001D\u0005(\u0080.\u001F.\u0082, new object[1]
                {
                  (object) array
                });
                return array;
              }
              \u0013.\u001D\u0005(\u0080.\u001F.\u0083, true);
            }
            pointArray1 = pointArray2;
          }
          else if (pointArray2.Length > 0)
            return pointArray2;
        }
        else
          \u0013.\u001D\u0005(\u0080.\u001F.\u0088, true);
        int num = \u0008\u001E.\u001C\u0098(waitHandleArray, 1000);
        token.ThrowIfCancellationRequested();
        if (\u0002\u001F.\u0091\u0097(\u001B\u0082.\u001F\u0094(\u001D\u0082.\u0011\u0094(), dateTime), timeSpan))
        {
          \u0013.\u001D\u0005(\u0080.\u001F.\u0089, true);
          return (Point[]) null;
        }
      }
      return (Point[]) null;
    }

    private Rectangle[] \u001D\u0005(CancellationToken token)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0080.\u001F.\u0008 obj = new \u0080.\u001F.\u0008();
      if (!base.\u0001.ToonTownProcess.ProcessOpen)
        return (Rectangle[]) null;
      Size minimum_size = this.\u0001.\u001D\u0005(this.\u0001.WindowClientSize);
      Size maximum_size = this.\u0002.\u001D\u0005(this.\u0001.WindowClientSize);
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = this.\u0001.CastBounds.\u001D\u0005(this.\u0001.WindowClientSize);
      base.\u001F\u0005();
      Bitmap bmp = \u0012.\u001D\u0005(base.\u0001, this.\u0001.PondCapture.Bounds);
      Rectangle[] rectangleArray;
      try
      {
        rectangleArray = this.\u0001.PondCapture.\u001D\u0005(bmp, minimum_size, maximum_size, token);
      }
      finally
      {
        if (bmp != null)
          \u001A\u001E.\u007E\u0094\u0092((object) bmp);
      }
      if (rectangleArray == null)
        return (Rectangle[]) null;
      // ISSUE: reference to a compiler-generated method
      return ((IEnumerable<Rectangle>) rectangleArray).Where<Rectangle>(new Func<Rectangle, bool>(obj.\u001D\u0005)).ToArray<Rectangle>();
    }

    public static double \u001D\u0005(Point castButton, Point fishTarget)
    {
      Point point1 = castButton;
      Point point2 = fishTarget;
      Point point3 = new Point(point2.X, point1.Y);
      float num1 = \u0082.\u0001.\u001D\u0005(\u001C\u0086.\u001E\u0080(point1), \u001C\u0086.\u001E\u0080(point2));
      float num2 = \u0082.\u0001.\u001D\u0005(\u001C\u0086.\u001E\u0080(point3), \u001C\u0086.\u001E\u0080(point2));
      double angleB = 90.0;
      return \u0082.\u0001.\u001D\u0005((double) num2, (double) num1, angleB);
    }

    private static Point? \u001D\u0005(Point castButton, Point[] targets)
    {
      double[] numArray = new double[targets.Length];
      for (int index = 0; index < targets.Length; ++index)
        numArray[index] = \u0080.\u001F.\u001D\u0005(castButton, targets[index]);
      double num = double.MinValue;
      int index1 = -1;
      for (int index2 = 0; index2 < targets.Length; ++index2)
      {
        if (!\u0094\u007F.\u008E\u0095(numArray[index2]) && numArray[index2] > num)
        {
          num = numArray[index2];
          index1 = index2;
        }
      }
      if (index1 == -1)
        return new Point?();
      return new Point?(targets[index1]);
    }

    private void \u001D\u0005(out float min_castratio, out float max_castratio)
    {
      switch (this.\u0001.Playground)
      {
        case \u001A.\u0019.\u0002:
          min_castratio = 1.3f;
          max_castratio = 1.37f;
          break;
        case \u001A.\u0019.\u0003:
          min_castratio = 1.3f;
          max_castratio = 1.365f;
          break;
        case \u001A.\u0019.\u0004:
          min_castratio = 1.3f;
          max_castratio = 1.365f;
          break;
        case \u001A.\u0019.\u0005:
          min_castratio = 1.3f;
          max_castratio = 1.365f;
          break;
        case \u001A.\u0019.\u0006:
          min_castratio = 1.3f;
          max_castratio = 1.37f;
          break;
        case \u001A.\u0019.\u000F:
          min_castratio = 1.3f;
          max_castratio = 1.37f;
          break;
        case \u001A.\u0019.\u0010:
          min_castratio = 1.3f;
          max_castratio = 1.38f;
          break;
        case \u001A.\u0019.\u0011:
          min_castratio = 1.3f;
          max_castratio = 1.37f;
          break;
        case \u001A.\u0019.\u0012:
          min_castratio = 1.3f;
          max_castratio = 1.37f;
          break;
        case \u001A.\u0019.\u0013:
          min_castratio = 1.3f;
          max_castratio = 1.39f;
          break;
        case \u001A.\u0019.\u0014:
          min_castratio = 1.3f;
          max_castratio = 1.39f;
          break;
        case \u001A.\u0019.\u0015:
          min_castratio = 1.3f;
          max_castratio = 1.38f;
          break;
        case \u001A.\u0019.\u0016:
          min_castratio = 1.3f;
          max_castratio = 1.38f;
          break;
        case \u001A.\u0019.\u0017:
          min_castratio = 1.3f;
          max_castratio = 1.39f;
          break;
        case \u001A.\u0019.\u0018:
          min_castratio = 1.3f;
          max_castratio = 1.382f;
          break;
        case \u001A.\u0019.\u0019:
          min_castratio = 1.3f;
          max_castratio = 1.382f;
          break;
        case \u001A.\u0019.\u001A:
          min_castratio = 1.3f;
          max_castratio = 1.382f;
          break;
        case \u001A.\u0019.\u001B:
          min_castratio = 1.3f;
          max_castratio = 1.32f;
          break;
        case \u001A.\u0019.\u001C:
          min_castratio = 1.3f;
          max_castratio = 1.382f;
          break;
        case \u001A.\u0019.\u001D:
          min_castratio = 1.3f;
          max_castratio = 1.382f;
          break;
        case \u001A.\u0019.\u001E:
          min_castratio = 1.3f;
          max_castratio = 1.382f;
          break;
        case \u001A.\u0019.\u001F:
          min_castratio = 1.3f;
          max_castratio = 1.38f;
          break;
        case \u001A.\u0019.\u007F:
          min_castratio = 1.3f;
          max_castratio = 1.38f;
          break;
        case \u001A.\u0019.\u0080:
          min_castratio = 1.3f;
          max_castratio = 1.38f;
          break;
        default:
          min_castratio = 1.3f;
          max_castratio = 1.34f;
          break;
      }
    }

    private Point \u001D\u0005(Point castButton, Point fishTarget)
    {
      Point point1 = castButton;
      Point point2 = fishTarget;
      Point point3 = new Point(point2.X, point1.Y);
      float num1 = \u0082.\u0001.\u001D\u0005(\u001C\u0086.\u001E\u0080(point1), \u001C\u0086.\u001E\u0080(point2));
      float num2 = \u0082.\u0001.\u001D\u0005(\u001C\u0086.\u001E\u0080(point3), \u001C\u0086.\u001E\u0080(point2));
      float num3 = \u0082.\u0001.\u001D\u0005(\u001C\u0086.\u001E\u0080(point3), \u001C\u0086.\u001E\u0080(point1));
      double angleB = 90.0;
      double num4 = \u0082.\u0001.\u001D\u0005((double) num2, (double) num1, angleB);
      float min_castratio;
      float max_castratio;
      this.\u001D\u0005(out min_castratio, out max_castratio);
      double num5;
      double num6 = num5 = num4 / 90.0 * ((double) max_castratio - (double) min_castratio) + (double) min_castratio;
      double num7 = (double) num2 * num6;
      double num8 = (double) num3 * num6;
      Point point4 = point2.X <= point1.X ? new Point((int) ((double) point2.X + num8), (int) ((double) point2.Y + num7)) : new Point((int) ((double) point2.X - num8), (int) ((double) point2.Y + num7));
      if (\u0094\u007F.\u008E\u0095(num4) || num4 == 0.0)
        return point4;
      double degrees = (90.0 - num4) / 90.0 * 12.0 + 0.0;
      if (point2.X > point1.X)
        degrees *= -1.0;
      double num9 = \u0082.\u0001.\u001D\u0005(degrees);
      Point point5 = Point.Empty;
      point5.X = (int) (\u0007\u0081.\u0092\u0096(num9) * (double) (point4.X - point1.X) - \u0007\u0081.\u0095\u0096(num9) * (double) (point4.Y - point1.Y) + (double) point1.X);
      point5.Y = (int) (\u0007\u0081.\u0095\u0096(num9) * (double) (point4.X - point1.X) + \u0007\u0081.\u0092\u0096(num9) * (double) (point4.Y - point1.Y) + (double) point1.Y);
      return point5;
    }

    private bool \u0082\u0005()
    {
      switch (this.\u001D\u0005(1000, this.\u0001.ExitFishingCapture, this.\u0001.ExitFishingBounds, (\u0005) this.\u0001, (ManualResetEventSlim) null))
      {
        case \u0080.\u001B.\u0001:
          return true;
        case \u0080.\u001B.\u0003:
          if (this.\u0001 == \u0080.\u001F.\u0001.\u0004)
            this.\u0002 = \u001D\u0082.\u0011\u0094();
          this.\u0088\u0005();
          return false;
        default:
          return false;
      }
    }

    private bool \u001D\u0005(List<PointF> path)
    {
      base.\u0001.\u0081\u0005();
      try
      {
        if (path != null)
          return \u001A.\u001A.\u001D\u0005(base.\u0001, base.\u0001, path, (\u0005) this.\u0001);
        return \u001A.\u001A.\u001D\u0005(base.\u0001, base.\u0001, this.\u0001, this.\u0001, (\u0005) this.\u0001);
      }
      finally
      {
        base.\u0001.\u0082\u0005();
      }
    }

    private bool \u001D\u0005(out List<PointF> reversePath)
    {
      reversePath = (List<PointF>) null;
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u0080.\u001F.\u000E obj1 = new \u0080.\u001F.\u000E();
        base.\u0001.\u0081\u0005();
        \u0006? coords = \u001A.\u001A.\u001D\u0005(base.\u0001, base.\u0001, -1);
        if (!coords.HasValue)
          return false;
        \u001A.\u0019 playground = base.\u0001.Playground;
        Dictionary<PointF, \u007F.\u007F> points_dic = !this.\u0001.WayPoints.ContainsKey(playground) ? (Dictionary<PointF, \u007F.\u007F>) null : this.\u0001.WayPoints[playground];
        PointF? nullable = new PointF?();
        foreach (KeyValuePair<PointF, \u007F.\u007F> keyValuePair in points_dic)
        {
          if (keyValuePair.Value == \u007F.\u007F.\u0002)
          {
            nullable = new PointF?(keyValuePair.Key);
            break;
          }
        }
        if (!nullable.HasValue || coords.Value.IsDock && !this.\u001D\u0005(out coords))
          return false;
        List<PointF> path = \u001A.\u001A.\u001D\u0005(points_dic, coords.Value.Location, nullable.Value);
        reversePath = new List<PointF>((IEnumerable<PointF>) path);
        reversePath.Reverse();
        reversePath.RemoveAt(0);
        reversePath.Add(coords.Value.Location);
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = false;
        if (!base.\u0001.ToonTownProcess.ProcessOpen)
          return false;
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = new \u0080.\u001B?();
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u0080.\u001F.\u000F obj2 = new \u0080.\u001F.\u000F();
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = obj1;
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = new ManualResetEventSlim(false);
        try
        {
          try
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            \u0080.\u001F.\u0010 obj3 = new \u0080.\u001F.\u0010();
            // ISSUE: reference to a compiler-generated method
            base.\u0001.ToonTownProcess.ProcessExited += new EventHandler(obj2.\u001D\u0005);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            obj3.\u0001 = new WaitHandle[2]
            {
              \u001B\u001F.\u007E\u009D\u0098((object) base.\u0001),
              \u001B\u001F.\u007E\u009D\u0098((object) obj2.\u0001)
            };
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            \u0080.\u001F.\u0011 obj4 = new \u0080.\u001F.\u0011();
            // ISSUE: reference to a compiler-generated field
            obj4.\u0001 = obj3;
            // ISSUE: reference to a compiler-generated field
            obj4.\u0001 = obj2;
            // ISSUE: reference to a compiler-generated field
            obj4.\u0001 = obj1;
            // ISSUE: reference to a compiler-generated field
            obj4.\u0001 = this;
            // ISSUE: reference to a compiler-generated field
            obj4.\u0001 = new CancellationTokenSource();
            try
            {
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated field
              Task task = new Task(new Action<object>(obj4.\u001D\u0005), (object) \u0092\u001D.\u007E\u000E\u0099((object) obj4.\u0001));
              try
              {
                try
                {
                  \u001A\u001E.\u007E\u0017\u0099((object) task);
                  // ISSUE: reference to a compiler-generated field
                  \u001A.\u001A.\u001D\u0005(base.\u0001, base.\u0001, obj2.\u0001, path, (\u0005) this.\u0001, true);
                  // ISSUE: reference to a compiler-generated field
                  int num = \u0008\u001E.\u001C\u0098(obj3.\u0001, 2000);
                  // ISSUE: reference to a compiler-generated field
                  \u001A\u001E.\u007E\u0002\u0099((object) obj2.\u0001);
                  if (!base.\u0001.ToonTownProcess.ProcessOpen)
                    return false;
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  return obj1.\u0001.HasValue && obj1.\u0001.Value == \u0080.\u001B.\u0001;
                }
                finally
                {
                  // ISSUE: reference to a compiler-generated field
                  \u001A\u001E.\u007E\u0010\u0099((object) obj4.\u0001);
                  try
                  {
                    \u001A\u001E.\u007E\u001B\u0099((object) task);
                  }
                  catch (AggregateException ex)
                  {
                  }
                }
              }
              finally
              {
                if (task != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) task);
              }
            }
            finally
            {
              // ISSUE: reference to a compiler-generated field
              if (obj4.\u0001 != null)
              {
                // ISSUE: reference to a compiler-generated field
                \u001A\u001E.\u007E\u0094\u0092((object) obj4.\u0001);
              }
            }
          }
          finally
          {
            // ISSUE: reference to a compiler-generated field
            obj1.\u0001 = true;
          }
        }
        finally
        {
          // ISSUE: reference to a compiler-generated field
          if (obj2.\u0001 != null)
          {
            // ISSUE: reference to a compiler-generated field
            \u001A\u001E.\u007E\u0094\u0092((object) obj2.\u0001);
          }
        }
      }
      finally
      {
        base.\u0001.\u0082\u0005();
      }
    }

    private bool \u001D\u0005(out \u0006? coords)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0080.\u001F.\u0012 obj1 = new \u0080.\u001F.\u0012();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = false;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0080.\u001F.\u0013 obj2 = new \u0080.\u001F.\u0013();
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = obj1;
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = new ManualResetEventSlim(false);
      try
      {
        try
        {
          // ISSUE: reference to a compiler-generated method
          Task task = new Task(new Action(obj2.\u001D\u0005));
          try
          {
            \u001A\u001E.\u007E\u0017\u0099((object) task);
            try
            {
              return this.\u001E\u0005(out coords);
            }
            finally
            {
              // ISSUE: reference to a compiler-generated field
              \u001A\u001E.\u007E\u0002\u0099((object) obj2.\u0001);
              \u001A\u001E.\u007E\u001B\u0099((object) task);
            }
          }
          finally
          {
            if (task != null)
              \u001A\u001E.\u007E\u0094\u0092((object) task);
          }
        }
        finally
        {
          // ISSUE: reference to a compiler-generated field
          obj1.\u0001 = true;
        }
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        if (obj2.\u0001 != null)
        {
          // ISSUE: reference to a compiler-generated field
          \u001A\u001E.\u007E\u0094\u0092((object) obj2.\u0001);
        }
      }
    }

    private bool \u0083\u0005()
    {
      \u0006? coords;
      return this.\u001E\u0005(out coords);
    }

    private bool \u001E\u0005(out \u0006? coords)
    {
      coords = new \u0006?();
      try
      {
        base.\u0001.\u0081\u0005();
        coords = \u001A.\u001A.\u001D\u0005(base.\u0001, base.\u0001, base.\u0001);
      }
      finally
      {
        base.\u0001.\u0082\u0005();
      }
      return coords.HasValue;
    }

    private bool \u001D\u0005(out \u0003 dock)
    {
      this.State = \u0080.\u001F.\u0001.\u0003;
      dock = (\u0003) null;
      base.\u001F\u0005();
      \u0080.\u001B obj1 = \u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.CastCapture, this.\u0001.CastBounds, (\u0005) this.\u0001);
      Bitmap[] bitmaps = new Bitmap[14];
      Bitmap bmp1 = (Bitmap) null;
      try
      {
        if (obj1 == \u0080.\u001B.\u0001)
        {
          Rectangle rectangle1 = \u0013.\u001E\u0005(base.\u0001);
          bmp1 = this.\u001E\u0005();
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          \u0080.\u001F.\u0014 obj2 = new \u0080.\u001F.\u0014();
          // ISSUE: reference to a compiler-generated field
          obj2.\u0001 = new System.Timers.Timer();
          try
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            \u0080.\u001F.\u0015 obj3 = new \u0080.\u001F.\u0015();
            // ISSUE: reference to a compiler-generated field
            obj3.\u0001 = obj2;
            // ISSUE: reference to a compiler-generated field
            obj3.\u0001 = this;
            Rectangle rectangle2 = \u0013.\u001D\u0005(base.\u0001);
            // ISSUE: reference to a compiler-generated field
            obj3.\u0001 = false;
            // ISSUE: reference to a compiler-generated field
            obj3.\u0002 = true;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            \u0010\u0081.\u007E\u0097\u0003\u0002((object) obj2.\u0001, new ElapsedEventHandler(obj3.\u001D\u0005));
            // ISSUE: reference to a compiler-generated field
            \u0002\u001D.\u007E\u0096\u0003\u0002((object) obj2.\u0001, 5000.0);
            // ISSUE: reference to a compiler-generated field
            \u0099\u001F.\u007E\u0095\u0003\u0002((object) obj2.\u0001, true);
            for (int index = 0; index < 14 && !\u0099\u0082.\u007E\u009E\u0098((object) base.\u0001); ++index)
            {
              if (\u0013.\u001D\u0005(base.\u0001, rectangle2.Size, true))
              {
                this.\u001D\u0005(base.\u0001);
                if (\u0099\u0082.\u007E\u009E\u0098((object) base.\u0001))
                  break;
              }
              bitmaps[index] = this.\u001D\u0005();
              int num = \u0095\u0081.\u007E\u0006\u0099((object) base.\u0001, 4000) ? 1 : 0;
            }
            // ISSUE: reference to a compiler-generated field
            obj3.\u0002 = false;
            // ISSUE: reference to a compiler-generated field
            \u0099\u001F.\u007E\u0095\u0003\u0002((object) obj2.\u0001, false);
          }
          finally
          {
            // ISSUE: reference to a compiler-generated field
            if (obj2.\u0001 != null)
            {
              // ISSUE: reference to a compiler-generated field
              \u001A\u001E.\u007E\u0094\u0092((object) obj2.\u0001);
            }
          }
          if (\u0099\u0082.\u007E\u009E\u0098((object) base.\u0001))
            return false;
          string text;
          string caption;
          \u0018.\u0016[] objArray;
          do
          {
            base.\u001F\u0005();
            switch (\u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.ExitFishingCapture, this.\u0001.ExitFishingBounds, (\u0005) this.\u0001))
            {
              case \u0080.\u001B.\u0001:
                goto label_18;
              case \u0080.\u001B.\u0002:
                text = \u0080.\u001F.\u0012\u0002;
                caption = \u0080.\u001F.\u0013\u0002;
                objArray = new \u0018.\u0016[2]
                {
                  \u0018.\u0016.\u0004,
                  \u0018.\u0016.\u0002
                };
                continue;
              default:
                goto label_17;
            }
          }
          while (\u0017.\u001E\u0005(text, caption, objArray) == DialogResult.Retry);
          return false;
label_17:
          this.\u0088\u0005();
          return false;
label_18:
          \u0006? coords;
          if (!this.\u001D\u0005(out coords))
            return false;
          \u0005<\u0002> pondCapture = (\u0005<\u0002>) null;
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          \u0080.\u001F.\u0016 obj4 = new \u0080.\u001F.\u0016();
          // ISSUE: reference to a compiler-generated field
          obj4.\u0001 = \u0015.\u0082.\u001D\u0005(bitmaps);
          try
          {
            // ISSUE: reference to a compiler-generated method
            pondCapture = this.\u001D\u0005<\u0005<\u0002>>(new Func<\u0005<\u0002>>(obj4.\u001D\u0005));
          }
          finally
          {
            // ISSUE: reference to a compiler-generated field
            if (obj4.\u0001 != null)
            {
              // ISSUE: reference to a compiler-generated field
              \u001A\u001E.\u007E\u0094\u0092((object) obj4.\u0001);
            }
          }
          if (pondCapture == null)
          {
            this.\u0084\u0005();
            dock = (\u0003) null;
            return false;
          }
          Bitmap bmp2 = (Bitmap) null;
          try
          {
            bmp2 = this.\u001D\u0005(bmp1);
            dock = new \u0003(base.\u0001.Playground, coords.Value.Location, rectangle1.Size, pondCapture, new \u0083.\u0018(bmp2, true));
            return true;
          }
          catch
          {
            if (bmp2 != null)
              \u001A\u001E.\u007E\u001D\u001F((object) bmp2);
            throw;
          }
        }
        else
        {
          this.\u0086\u0005();
          dock = (\u0003) null;
          return false;
        }
      }
      finally
      {
        ((IEnumerable<Bitmap>) bitmaps).\u001D\u0005<Bitmap>();
        if (bmp1 != null)
          \u001A\u001E.\u007E\u001D\u001F((object) bmp1);
      }
    }

    private bool \u0084\u0005()
    {
      switch (this.\u001D\u0005())
      {
        case \u0080.\u001F.\u0002.\u0002:
          this.\u001D\u0005(this.\u0001.FishCaughtBounds, (\u0005) this.\u0001);
          return true;
        case \u0080.\u001F.\u0002.\u0003:
          this.\u001D\u0005(this.\u0001.BootCaughtBounds, (\u0005) this.\u0001);
          return true;
        case \u0080.\u001F.\u0002.\u0004:
          this.\u001D\u0005(this.\u0001.FishCaughtDuringBingoBounds, (\u0005) this.\u0001);
          return true;
        case \u0080.\u001F.\u0002.\u000F:
        case \u0080.\u001F.\u0002.\u0010:
          return true;
        default:
          return false;
      }
    }

    private bool \u0086\u0005()
    {
      if (!this.\u0084\u0005())
        return false;
      \u0003 dock1 = (\u0003) null;
      if (!this.\u001E\u0005(out dock1))
      {
        \u0003 dock2;
        if (!this.\u001D\u0005(out dock2))
          return false;
        if (dock1 != null)
        {
          dock1.Dispose();
          this.\u0001.Docks.Remove(dock1);
        }
        this.\u0001.Docks.Add(dock2);
        this.\u0001 = dock2;
        return true;
      }
      Size size = \u0013.\u001D\u0005(base.\u0001);
      if (\u0010\u007F.\u0006\u0081(size, dock1.WindowClientSize) && \u0013.\u001D\u0005(base.\u0001, dock1.WindowClientSize))
        this.\u001D\u0005(base.\u0001);
      this.\u0001 = dock1;
      return true;
    }

    private bool \u001E\u0005(out \u0003 dock)
    {
      this.State = \u0080.\u001F.\u0001.\u0002;
      Bitmap fullPond = this.\u001E\u0005();
      try
      {
        if (this.\u001D\u0005(fullPond, out dock))
          return true;
      }
      finally
      {
        if (fullPond != null)
          \u001A\u001E.\u007E\u0094\u0092((object) fullPond);
      }
      return false;
    }

    private bool \u001D\u0005(Bitmap fullPond, out \u0003 result)
    {
      Bitmap bmp = this.\u001D\u0005(fullPond);
      try
      {
        \u0083.\u0018 left = new \u0083.\u0018(bmp, false);
        try
        {
          foreach (\u0003 dock in this.\u0001.Docks)
          {
            if (dock.Playground == base.\u0001.Playground && \u0083.\u0018.\u001D\u0005(left, dock.DockReferenceCapture, 0, 0) < 20)
            {
              result = dock;
              return true;
            }
          }
        }
        finally
        {
          if (left != null)
            \u001A\u001E.\u007E\u0094\u0092((object) left);
        }
      }
      finally
      {
        if (bmp != null)
          \u001A\u001E.\u007E\u0094\u0092((object) bmp);
      }
      result = (\u0003) null;
      return false;
    }

    private bool \u0087\u0005()
    {
      \u0003 dock1;
      if (!this.\u001D\u0005(out dock1))
        return false;
      List<\u0003> docks = this.\u0001.Docks;
      \u0003 dock2;
      if (this.\u001E\u0005(out dock2))
        goto label_9;
label_1:
      for (int index = docks.Count - 1; index >= 0; --index)
      {
        dock2 = docks[index];
        if (dock2.Playground == dock1.Playground && (double) \u0082.\u0001.\u001D\u0005(dock2.DockLocation, dock1.DockLocation) <= 1.0)
          docks.Remove(dock2);
      }
      docks.Add(dock1);
      return true;
label_9:
      dock2.Dispose();
      docks.Remove(dock2);
      goto label_1;
    }

    private Bitmap \u001D\u0005(Bitmap bmp, Size full_size)
    {
      Bitmap bitmap1 = (Bitmap) null;
      Bitmap bitmap2 = (Bitmap) null;
      try
      {
        if (!\u0010\u007F.\u0005\u0081(\u0083\u001E.\u007E\u001F\u001F((object) bmp), full_size))
        {
          bitmap1 = new Bitmap(full_size.Width, full_size.Height);
          Graphics graphics = \u0005\u0087.\u001D\u007F((Image) bitmap1);
          try
          {
            \u0094\u0081.\u007E\u0083\u007F((object) graphics, InterpolationMode.High);
            \u0015\u0083.\u007E\u0081\u007F((object) graphics, SmoothingMode.AntiAlias);
            \u0004\u001F.\u007E\u009E\u007F((object) graphics, (Image) bmp, new Rectangle(Point.Empty, full_size));
          }
          finally
          {
            if (graphics != null)
              \u001A\u001E.\u007E\u0094\u0092((object) graphics);
          }
        }
        else
          goto label_13;
label_7:
        Rectangle rectangle = this.\u0001.\u001D\u0005(full_size);
        bitmap2 = new Bitmap(rectangle.Width, rectangle.Height);
        Graphics graphics1 = \u0005\u0087.\u001D\u007F((Image) bitmap2);
        try
        {
          \u0094\u0081.\u007E\u0083\u007F((object) graphics1, InterpolationMode.High);
          \u0015\u0083.\u007E\u0081\u007F((object) graphics1, SmoothingMode.AntiAlias);
          \u008C\u0082.\u007E\u0002\u0080((object) graphics1, (Image) bitmap1, rectangle, rectangle, GraphicsUnit.Pixel);
        }
        finally
        {
          if (graphics1 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) graphics1);
        }
        return bitmap2;
label_13:
        bitmap1 = bmp;
        goto label_7;
      }
      catch
      {
        if (bitmap2 != null)
          \u001A\u001E.\u007E\u001D\u001F((object) bitmap2);
        throw;
      }
      finally
      {
        if (bitmap1 != null && !\u0013\u0080.\u0089\u0091((object) bmp, (object) bitmap1))
          \u001A\u001E.\u007E\u001D\u001F((object) bitmap1);
      }
    }

    private Bitmap \u001D\u0005(Bitmap bmp)
    {
      Bitmap bitmap = (Bitmap) null;
      try
      {
        bitmap = new Bitmap(this.\u0001.Width, this.\u0001.Height);
        Graphics graphics = \u0005\u0087.\u001D\u007F((Image) bitmap);
        try
        {
          \u0094\u0081.\u007E\u0083\u007F((object) graphics, InterpolationMode.High);
          \u0015\u0083.\u007E\u0081\u007F((object) graphics, SmoothingMode.AntiAlias);
          \u0004\u001F.\u007E\u009E\u007F((object) graphics, (Image) bmp, new Rectangle(Point.Empty, this.\u0001));
        }
        finally
        {
          if (graphics != null)
            \u001A\u001E.\u007E\u0094\u0092((object) graphics);
        }
        return bitmap;
      }
      catch
      {
        if (bitmap != null)
          \u001A\u001E.\u007E\u001D\u001F((object) bitmap);
        throw;
      }
    }

    private \u0080.\u001F.\u0002 \u001D\u0005()
    {
      base.\u001F\u0005();
      if (\u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.FishCaughtCapture, this.\u0001.FishCaughtBounds, (\u0005) this.\u0001) == \u0080.\u001B.\u0001)
        return this.\u0001.StopWhenNewSpecies && \u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.NewSpeciesCapture, this.\u0001.NewSpeciesBounds, (\u0005) this.\u0001) == \u0080.\u001B.\u0001 ? \u0080.\u001F.\u0002.\u0006 : \u0080.\u001F.\u0002.\u0002;
      if (\u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.BootCaughtCapture, this.\u0001.BootCaughtBounds, (\u0005) this.\u0001) == \u0080.\u001B.\u0001)
        return \u0080.\u001F.\u0002.\u0003;
      if (\u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.FishCaughtDuringBingoCapture, this.\u0001.FishCaughtDuringBingoBounds, (\u0005) this.\u0001) == \u0080.\u001B.\u0001)
        return this.\u0001.StopWhenNewSpecies && \u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.NewSpeciesDuringBingoCapture, this.\u0001.NewSpeciesDuringBingoBounds, (\u0005) this.\u0001) == \u0080.\u001B.\u0001 ? \u0080.\u001F.\u0002.\u0007 : \u0080.\u001F.\u0002.\u0004;
      if (\u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.BucketFullCapture, this.\u0001.BucketFullBounds, (\u0005) this.\u0001) == \u0080.\u001B.\u0001)
        return \u0080.\u001F.\u0002.\u0005;
      if (base.\u0001.Playground == \u001A.\u0019.\u0002 && \u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.EstateSellFishCapture, this.\u0001.EstateSellFishBounds, (\u0005) this.\u0001) == \u0080.\u001B.\u0001)
        return \u0080.\u001F.\u0002.\u0008;
      if (\u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.NoBeansCapture, this.\u0001.NoBeansBounds, (\u0005) this.\u0001) == \u0080.\u001B.\u0001)
        return \u0080.\u001F.\u0002.\u000E;
      if (\u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.CastCapture, this.\u0001.CastBounds, (\u0005) this.\u0001) == \u0080.\u001B.\u0001)
        return \u0080.\u001F.\u0002.\u000F;
      return \u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.ExitFishingCapture, this.\u0001.ExitFishingBounds, (\u0005) this.\u0001) == \u0080.\u001B.\u0001 ? \u0080.\u001F.\u0002.\u0010 : \u0080.\u001F.\u0002.\u0001;
    }

    private Bitmap \u001D\u0005()
    {
      base.\u001F\u0005();
      return \u0012.\u001D\u0005(base.\u0001, this.\u0001.\u001D\u0005(\u0013.\u001E\u0005(base.\u0001).Size));
    }

    private Bitmap \u001E\u0005()
    {
      base.\u001F\u0005();
      Rectangle rectangle = \u0013.\u001E\u0005(base.\u0001);
      if (rectangle.Width < this.\u0001.Width || rectangle.Height < this.\u0001.Height)
      {
        Size size1 = this.\u0001;
        int width = \u0099\u0081.\u009E\u0096(size1.Width, rectangle.Width);
        Size size2 = this.\u0001;
        int height = \u0099\u0081.\u009E\u0096(size2.Height, rectangle.Height);
        \u0013.\u001D\u0005(base.\u0001, new Size(width, height));
        this.\u001D\u0005(base.\u0001);
      }
      return \u0012.\u001D\u0005(base.\u0001);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (this.\u0001 != null)
          \u001A\u001E.\u007E\u001A\u0099((object) this.\u0001);
        if (this.\u0001 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      }
      base.Dispose(disposing);
    }

    private void \u0091\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0080.\u001F)));
      this.\u0001 = new Label();
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 14));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0080.\u001F.\u0001(28788));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(102, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0080.\u001F.\u0001(89274));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(286, 40));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0080.\u001F.\u0001(9680)));
      \u0092\u0081.\u0010\u0084((object) this, \u0080.\u001F.\u0001(89303));
      this.OnStartRunning += new EventHandler(this.\u007F\u0005);
      \u0015\u0081.\u007E\u0091\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001, 0);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    private enum \u0001
    {
      \u0001,
      \u0002,
      \u0003,
      \u0004,
      \u0005,
      \u0006,
      \u0007,
    }

    private enum \u0002
    {
      \u0001,
      \u0002,
      \u0003,
      \u0004,
      \u0005,
      \u0006,
      \u0007,
      \u0008,
      \u000E,
      \u000F,
      \u0010,
    }
  }
}
