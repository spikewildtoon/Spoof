// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001A;
using \u001B;
using \u001E;
using \u001F;
using \u007F;
using \u0080;
using \u0081;
using \u0083;
using \u0084;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace \u0016
{
  internal sealed class \u001B : \u0016.\u001A
  {
    [NonSerialized]
    internal new static \u0002 \u0001;
    private IContainer \u0001;
    private Label \u0001;
    private readonly \u0013 \u0001;
    private readonly \u0013 \u0002;
    private readonly \u0002 \u0001;
    private readonly \u0083.\u0016 \u0001;
    private readonly \u0014.\u0082 \u0001;
    private readonly \u0017.\u0080 \u0001;
    private readonly Dictionary<\u0008, Dictionary<\u007F.\u007F, HashSet<PointF>>> \u0001;
    private readonly List<\u007F.\u007F> \u0001;
    private readonly List<\u007F.\u007F> \u0002;
    private readonly \u0006 \u0001;
    private PointF \u0001;

    static \u001B()
    {
      \u0004.\u001D\u0005(typeof (\u0016.\u001B));
    }

    public \u001B(IntPtr hWnd, \u0083.\u0016 settings, \u0014.\u0082 captures, \u0017.\u0080 wayPoints)
      : base(hWnd)
    {
      this.\u0083\u0005();
      this.\u0001 = settings;
      this.\u0001 = captures;
      this.\u0001 = wayPoints;
      this.\u0001 = \u0081.\u0080.Instance.GardenerFloraSettings;
      this.\u0001 = new List<\u007F.\u007F>((IEnumerable<\u007F.\u007F>) new \u007F.\u007F[8]
      {
        \u007F.\u007F.\u0015,
        \u007F.\u007F.\u0016,
        \u007F.\u007F.\u0017,
        \u007F.\u007F.\u0018,
        \u007F.\u007F.\u0019,
        \u007F.\u007F.\u001A,
        \u007F.\u007F.\u001B,
        \u007F.\u007F.\u001C
      });
      this.\u0002 = new List<\u007F.\u007F>((IEnumerable<\u007F.\u007F>) new \u007F.\u007F[10]
      {
        \u007F.\u007F.\u0006,
        \u007F.\u007F.\u0007,
        \u007F.\u007F.\u0008,
        \u007F.\u007F.\u000E,
        \u007F.\u007F.\u000F,
        \u007F.\u007F.\u0010,
        \u007F.\u007F.\u0011,
        \u007F.\u007F.\u0012,
        \u007F.\u007F.\u0013,
        \u007F.\u007F.\u0014
      });
      this.\u0001 = new Dictionary<\u0008, Dictionary<\u007F.\u007F, HashSet<PointF>>>();
      Rectangle max_bounds = new Rectangle(Point.Empty, new Size(1024, 768));
      this.\u0001 = \u0013.\u001D\u0005(new Rectangle(335, 327, 359, 39), max_bounds);
      this.\u0002 = \u0013.\u001D\u0005(new Rectangle(358, 423, 309, 38), max_bounds);
      this.\u0001 = \u0002.\u001D\u0005(16, max_bounds.Height);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u0083\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0016.\u001B)));
      this.\u0001 = new Label();
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 14));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0016.\u001B.\u0001(25157));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(132, 13));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0016.\u001B.\u0001(25178));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(286, 40));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0016.\u001B.\u0001(6049)));
      \u0092\u0081.\u0010\u0084((object) this, \u0016.\u001B.\u0001(25215));
      this.OnStartRunning += new EventHandler(this.\u007F\u0005);
      \u0015\u0081.\u007E\u0091\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001, 0);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    private void \u0084\u0005()
    {
      this.\u001D\u0005((MethodInvoker) (() => \u0018.\u0017.\u001E\u0005(\u0016.\u001B.\u0001(25309), \u0016.\u001B.\u0001(25410))));
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      if (base.\u0001.Playground != \u0019.\u0002)
      {
        \u001A\u001E.\u0001\u0086((object) this);
        \u0018.\u0017.\u001D\u0005(\u0016.\u001B.\u0001(25244), \u0016.\u001B.\u0001(25091));
        this.\u001D\u0005(DialogResult.Abort);
      }
      else
      {
        int num = \u001E\u0086.\u0099\u0098((WaitCallback) (obj =>
        {
          try
          {
            this.\u0086\u0005();
          }
          catch (Exception ex)
          {
            ex.\u001D\u0005();
            this.\u0084\u0005();
          }
          finally
          {
            this.\u001D\u0005(DialogResult.None);
          }
        })) ? 1 : 0;
      }
    }

    private void \u0086\u0005()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0016.\u001B.\u0004 obj1 = new \u0016.\u001B.\u0004();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      this.\u0087\u0005();
      List<\u0016.\u001B.\u0001> estates = this.\u001D\u0005();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = new List<\u0016.\u001B.\u0001>((IEnumerable<\u0016.\u001B.\u0001>) estates);
      while (estates.Count > 0 && base.CanContinue)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u0016.\u001B.\u0005 obj2 = new \u0016.\u001B.\u0005();
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = obj1;
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = true;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        if (!this.\u001D\u0005(estates, out obj2.\u0001, out obj2.\u0001, true, new \u0006?()))
          break;
        // ISSUE: reference to a compiler-generated field
        if (obj2.\u0001.Customized)
        {
          // ISSUE: reference to a compiler-generated method
          Func<bool> func1 = new Func<bool>(obj2.\u001D\u0005);
          // ISSUE: reference to a compiler-generated method
          Func<bool> func2 = new Func<bool>(obj2.\u001E\u0005);
          // ISSUE: reference to a compiler-generated field
          if (\u0095\u001C.\u0099\u0091((object) obj2.\u0001, (Enum) \u007F.\u007F.\u0004))
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            obj2.\u0001.Flowers.\u001D\u0005<KeyValuePair<\u007F.\u007F, \u001E.\u0001>>(-obj2.\u0001.Flowers.FindIndex(new Predicate<KeyValuePair<\u007F.\u007F, \u001E.\u0001>>(obj2.\u001D\u0005)));
            if (!func1() || !func2())
              break;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (\u0095\u001C.\u0099\u0091((object) obj2.\u0001, (Enum) \u007F.\u007F.\u0005))
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              obj2.\u0001.Trees.\u001D\u0005<KeyValuePair<\u007F.\u007F, \u0080.\u001E>>(-obj2.\u0001.Trees.FindIndex(new Predicate<KeyValuePair<\u007F.\u007F, \u0080.\u001E>>(obj2.\u001D\u0005)));
              if (!func2() || !func1())
                break;
            }
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated method
          Func<bool> func1 = new Func<bool>(obj2.\u001F\u0005);
          // ISSUE: reference to a compiler-generated method
          Func<bool> func2 = new Func<bool>(obj2.\u007F\u0005);
          // ISSUE: reference to a compiler-generated field
          if (\u0095\u001C.\u0099\u0091((object) obj2.\u0001, (Enum) \u007F.\u007F.\u0004))
          {
            // ISSUE: reference to a compiler-generated field
            this.\u0002.\u001D\u0005<\u007F.\u007F>(-this.\u0002.IndexOf(obj2.\u0001));
            if (!func1() || !func2())
              break;
          }
          else
          {
            // ISSUE: reference to a compiler-generated field
            if (\u0095\u001C.\u0099\u0091((object) obj2.\u0001, (Enum) \u007F.\u007F.\u0005))
            {
              // ISSUE: reference to a compiler-generated field
              this.\u0001.\u001D\u0005<\u007F.\u007F>(-this.\u0001.IndexOf(obj2.\u0001));
              if (!func2() || !func1())
                break;
            }
          }
        }
        // ISSUE: reference to a compiler-generated field
        estates.Remove(obj2.\u0001);
      }
    }

    private bool \u001D\u0005(\u0016.\u001B.\u0001 estate, \u001E.\u0001 flower = null)
    {
      if (!base.CanContinue || this.\u007F\u0005() != \u0080.\u001B.\u0001 || this.\u001F\u0005() != \u0080.\u001B.\u0001)
        return false;
      this.\u001D\u0005(this.\u0001.PlantFlowerBounds, (\u0005) this.\u0001);
      int num1 = \u0095\u0081.\u007E\u0006\u0099((object) base.\u0001, 500) ? 1 : 0;
      bool flag = false;
      if (flower == null || flower.BeanCombination == null)
      {
        switch (this.\u0001.PlantMethod)
        {
          case \u0081.\u001E.\u0001:
            int beanSlotsCount;
            if (this.\u001D\u0005(out beanSlotsCount))
            {
              int num2 = beanSlotsCount * 5;
              int index;
              if (estate.LastBeanCombinationIndex.HasValue && estate.LastBeanCombinationIndex.Value >= num2)
              {
                index = estate.LastBeanCombinationIndex.Value + 1;
                if (index >= num2 + 5)
                  index = num2;
              }
              else
                index = num2;
              if (flag = this.\u001D\u0005(\u001C.\u0018.\u0001[index]))
              {
                estate.LastBeanCombinationIndex = new int?(index);
                break;
              }
              break;
            }
            break;
          case \u0081.\u001E.\u0002:
            if (this.\u0001.BeanCombinations.Count > 0)
            {
              flag = this.\u001D\u0005(this.\u0001.BeanCombinations[\u0015.\u0017.Instance.\u001D\u0005(0, this.\u0001.BeanCombinations.Count)]);
              break;
            }
            break;
          case \u0081.\u001E.\u0003:
            if (this.\u0001.BeanCombinations.Count > 0)
            {
              int index;
              if (estate.LastBeanCombinationIndex.HasValue)
              {
                index = estate.LastBeanCombinationIndex.Value + 1;
                if (index >= this.\u0001.BeanCombinations.Count)
                  index = 0;
              }
              else
                index = 0;
              if (flag = this.\u001D\u0005(this.\u0001.BeanCombinations[index]))
              {
                estate.LastBeanCombinationIndex = new int?(index);
                break;
              }
              break;
            }
            break;
        }
      }
      else
        flag = this.\u001D\u0005(flower.BeanCombination);
      if (flag && this.\u0082\u0005() == \u0080.\u001B.\u0001)
      {
        this.\u001D\u0005(this.\u0001.FinalPlantBounds, (\u0005) this.\u0001);
        if (this.\u001D\u0005() == \u0080.\u001B.\u0001)
          return true;
      }
      int num3 = \u0095\u0081.\u007E\u0006\u0099((object) base.\u0001, 500) ? 1 : 0;
      if (this.\u0080\u0005() == \u0080.\u001B.\u0001)
        this.\u001D\u0005(this.\u0001.PlantFailedBounds, (\u0005) this.\u0001);
      int num4 = \u0095\u0081.\u007E\u0006\u0099((object) base.\u0001, 500) ? 1 : 0;
      if (this.\u0081\u0005() == \u0080.\u001B.\u0001)
        this.\u001D\u0005(this.\u0001.CancelPlantBounds, (\u0005) this.\u0001);
      return false;
    }

    private \u0080.\u001B \u001D\u0005()
    {
      int num1 = 0;
      while (num1 < 15000 && !\u0099\u0082.\u007E\u009E\u0098((object) base.\u0001))
      {
        switch (this.\u0080\u0005())
        {
          case \u0080.\u001B.\u0001:
            this.\u001D\u0005(this.\u0001.PlantFailedBounds, (\u0005) this.\u0001);
            return \u0080.\u001B.\u0002;
          case \u0080.\u001B.\u0003:
            return \u0080.\u001B.\u0003;
          default:
            switch (this.\u001E\u0005())
            {
              case \u0080.\u001B.\u0001:
                return \u0080.\u001B.\u0001;
              case \u0080.\u001B.\u0003:
                return \u0080.\u001B.\u0003;
              default:
                int num2 = \u0095\u0081.\u007E\u0006\u0099((object) base.\u0001, 1000) ? 1 : 0;
                num1 += 1000;
                continue;
            }
        }
      }
      return \u0080.\u001B.\u0002;
    }

    private \u0080.\u001B \u001E\u0005()
    {
      if (!base.\u0001.ToonTownProcess.ProcessOpen)
        return \u0080.\u001B.\u0003;
      Rectangle window_bounds = \u0013.\u001E\u0005(base.\u0001);
      Rectangle rectangle = this.\u0001.PlantSuccessBounds.\u001D\u0005(window_bounds.Size);
      int num1 = this.\u0001.\u001D\u0005(window_bounds.Height);
      int num2 = rectangle.Y + num1;
      rectangle.Y -= num1;
      for (; rectangle.Y < num2 && !\u0099\u0082.\u007E\u009E\u0098((object) base.\u0001); ++rectangle.Y)
      {
        base.\u001F\u0005();
        switch (\u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.PlantSuccessCapture, rectangle, (\u0005) this.\u0001))
        {
          case \u0080.\u001B.\u0001:
            this.\u001D\u0005(window_bounds, rectangle);
            int num3 = \u0095\u0081.\u007E\u0006\u0099((object) base.\u0001, this.\u0001.AfterMoveBeforeClickDelay) ? 1 : 0;
            this.\u001D\u0005((\u0005) this.\u0001);
            return \u0080.\u001B.\u0001;
          case \u0080.\u001B.\u0003:
            return \u0080.\u001B.\u0003;
          default:
            goto default;
        }
      }
      return \u0080.\u001B.\u0002;
    }

    private bool \u001D\u0005(\u001C.\u0018 combination)
    {
      if (!base.\u0001.ToonTownProcess.ProcessOpen)
        return false;
      Rectangle window_bounds = \u0013.\u001E\u0005(base.\u0001);
      Rectangle rectangle = this.\u0001.\u001D\u0005(window_bounds.Size);
      rectangle.Width = rectangle.Width / 9;
      base.\u001F\u0005();
      foreach (int bean in combination.Beans)
      {
        Rectangle bounds = rectangle;
        bounds.X += bounds.Width * (bean - 1);
        this.\u001D\u0005(window_bounds, bounds);
        int num1 = \u0095\u0081.\u007E\u0006\u0099((object) base.\u0001, this.\u0001.AfterMoveBeforeClickDelay) ? 1 : 0;
        this.\u001D\u0005((\u0005) this.\u0001);
        int num2 = \u0095\u0081.\u007E\u0006\u0099((object) base.\u0001, 200) ? 1 : 0;
      }
      return true;
    }

    private bool \u001D\u0005(out int beanSlotsCount)
    {
      beanSlotsCount = 0;
      if (!base.\u0001.ToonTownProcess.ProcessOpen)
        return false;
      Rectangle rectangle1 = \u0013.\u001E\u0005(base.\u0001);
      Rectangle rectangle2 = this.\u0002.\u001D\u0005(rectangle1.Size);
      Rectangle capture_bounds = this.\u0001.DisabledBeanSlotBounds.\u001D\u0005(rectangle1.Size);
      int num = rectangle2.Width / 8;
      capture_bounds.X = rectangle2.X + (capture_bounds.X - rectangle2.X) % num;
      for (int index = 1; index < 8; ++index)
      {
        capture_bounds.X += num;
        switch (\u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.DisabledBeanSlotCapture, capture_bounds, (\u0005) this.\u0001))
        {
          case \u0080.\u001B.\u0001:
            return true;
          case \u0080.\u001B.\u0003:
            return false;
          default:
            ++beanSlotsCount;
            continue;
        }
      }
      return true;
    }

    private \u0080.\u001B \u001F\u0005()
    {
      return \u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.PlantFlowerCapture, this.\u0001.PlantFlowerBounds, (\u0005) this.\u0001);
    }

    private \u0080.\u001B \u007F\u0005()
    {
      return \u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.NoWaterCapture, this.\u0001.NoWaterBounds, (\u0005) this.\u0001);
    }

    private \u0080.\u001B \u0080\u0005()
    {
      return \u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.PlantFailedCapture, this.\u0001.PlantFailedBounds, (\u0005) this.\u0001);
    }

    private \u0080.\u001B \u0081\u0005()
    {
      return \u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.CancelPlantCapture, this.\u0001.CancelPlantBounds, (\u0005) this.\u0001);
    }

    private \u0080.\u001B \u0082\u0005()
    {
      return \u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.FinalPlantCapture, this.\u0001.FinalPlantBounds, (\u0005) this.\u0001);
    }

    private \u0016.\u001B.\u0002 \u001D\u0005(List<\u0016.\u001B.\u0001> estates, bool allowWater, int numberOfWaters)
    {
      if (!base.CanContinue)
        return \u0016.\u001B.\u0002.\u0001;
      \u0016.\u001B.\u0002 obj = \u0016.\u001B.\u0002.\u0001;
      bool flag = true;
      while (flag)
      {
        switch (this.\u001D\u0005(estates))
        {
          case \u0016.\u001B.\u0003.\u0001:
            flag = false;
            continue;
          case \u0016.\u001B.\u0003.\u0002:
            obj |= \u0016.\u001B.\u0002.\u0002;
            flag = false;
            continue;
          case \u0016.\u001B.\u0003.\u0003:
            if (!\u0095\u001C.\u0099\u0091((object) obj, (Enum) \u0016.\u001B.\u0002.\u0003) && allowWater && this.\u001E\u0005(numberOfWaters))
            {
              obj |= \u0016.\u001B.\u0002.\u0003;
              continue;
            }
            flag = false;
            continue;
          default:
            continue;
        }
      }
      return obj;
    }

    private \u0016.\u001B.\u0003 \u001D\u0005(List<\u0016.\u001B.\u0001> estates)
    {
      if (!base.CanContinue)
        return \u0016.\u001B.\u0003.\u0001;
      switch (this.\u0083\u0005())
      {
        case \u0080.\u001B.\u0001:
          this.\u001D\u0005(this.\u0001.PickFlowerBounds, (\u0005) this.\u0001);
          int num1 = \u0095\u0081.\u007E\u0006\u0099((object) base.\u0001, 500) ? 1 : 0;
          Point mouseTarget;
          switch (this.\u001D\u0005(out mouseTarget))
          {
            case \u0080.\u001B.\u0001:
              this.\u001D\u0005(mouseTarget, (\u0005) this.\u0001);
              int num2 = \u0095\u0081.\u007E\u0006\u0099((object) base.\u0001, 500) ? 1 : 0;
              return this.\u0087\u0005() == \u0080.\u001B.\u0003 ? \u0016.\u001B.\u0003.\u0001 : \u0016.\u001B.\u0003.\u0002;
            case \u0080.\u001B.\u0002:
              if (this.\u0086\u0005() == \u0080.\u001B.\u0001)
              {
                this.\u001D\u0005(this.\u0001.BasketFullBounds, (\u0005) this.\u0001);
                int num3 = \u0095\u0081.\u007E\u0006\u0099((object) base.\u0001, 500) ? 1 : 0;
                return !this.\u001D\u0005(estates) ? \u0016.\u001B.\u0003.\u0001 : \u0016.\u001B.\u0003.\u0004;
              }
              break;
          }
        case \u0080.\u001B.\u0002:
          return \u0016.\u001B.\u0003.\u0003;
      }
      return \u0016.\u001B.\u0003.\u0001;
    }

    private \u0080.\u001B \u0083\u0005()
    {
      return \u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.PickFlowerCapture, this.\u0001.PickFlowerBounds, (\u0005) this.\u0001);
    }

    private \u0080.\u001B \u0084\u0005()
    {
      return this.\u001D\u0005(500, 2000, this.\u0001.FinalPickCapture, this.\u0001.FinalPickBounds, (\u0005) this.\u0001);
    }

    private \u0080.\u001B \u001D\u0005(out Point mouseTarget)
    {
      \u0002 obj1 = \u0002.\u001D\u0005(504, 768);
      \u0002 obj2 = \u0002.\u001D\u0005(546, 768);
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0016.\u001B.\u0006 obj3 = new \u0016.\u001B.\u0006();
      // ISSUE: reference to a compiler-generated field
      obj3.\u0001 = new ManualResetEventSlim(false);
      try
      {
        // ISSUE: reference to a compiler-generated method
        Task task = new Task(new Action(obj3.\u001D\u0005));
        try
        {
          try
          {
            \u001A\u001E.\u007E\u0017\u0099((object) task);
            // ISSUE: reference to a compiler-generated field
            while (!\u0099\u0082.\u007E\u009E\u0098((object) base.\u0001) && !\u0099\u0082.\u007E\u009E\u0098((object) obj3.\u0001))
            {
              base.\u001F\u0005();
              IntPtr mainWindowHandle = base.\u0001.ToonTownProcess.MainWindowHandle;
              if (!base.\u0001.ToonTownProcess.ProcessOpen)
              {
                mouseTarget = Point.Empty;
                return \u0080.\u001B.\u0003;
              }
              Rectangle max_bounds = \u0013.\u001E\u0005(mainWindowHandle);
              Rectangle rectangle1 = this.\u0001.FinalPickBounds.\u001D\u0005(max_bounds.Size);
              int y = obj1.\u001D\u0005(max_bounds.Height) - rectangle1.Height / 2;
              Rectangle rectangle2 = new Rectangle(rectangle1.Left - 1, y, rectangle1.Width + 2, obj2.\u001D\u0005(max_bounds.Height) + rectangle1.Height / 2 - y);
              \u0013 sourceRatio = \u0013.\u001D\u0005(rectangle2, max_bounds);
              Bitmap bmp = \u0012.\u001D\u0005(mainWindowHandle, rectangle2);
              try
              {
                \u0083.\u0018 source = new \u0083.\u0018(bmp, false);
                try
                {
                  Point location;
                  if (\u0083.\u0018.\u001D\u0005(source, sourceRatio, this.\u0001.FinalPickCapture, this.\u0001.FinalPickBounds, this.\u0001.MaxColorRange, out location))
                  {
                    mouseTarget = new Point(rectangle2.X + location.X + rectangle1.Width / 2, rectangle2.Y + location.Y + rectangle1.Height / 2);
                    return \u0080.\u001B.\u0001;
                  }
                }
                finally
                {
                  if (source != null)
                    \u001A\u001E.\u007E\u0094\u0092((object) source);
                }
              }
              finally
              {
                if (bmp != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) bmp);
              }
              // ISSUE: reference to a compiler-generated field
              WaitHandle[] waitHandleArray = new WaitHandle[2]{ \u001B\u001F.\u007E\u009D\u0098((object) base.\u0001), \u001B\u001F.\u007E\u009D\u0098((object) obj3.\u0001) };
              int num = \u0008\u001E.\u001C\u0098(waitHandleArray, 500);
            }
            mouseTarget = Point.Empty;
            return \u0080.\u001B.\u0002;
          }
          finally
          {
            // ISSUE: reference to a compiler-generated field
            \u001A\u001E.\u007E\u0002\u0099((object) obj3.\u0001);
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
        if (obj3.\u0001 != null)
        {
          // ISSUE: reference to a compiler-generated field
          \u001A\u001E.\u007E\u0094\u0092((object) obj3.\u0001);
        }
      }
    }

    private \u0080.\u001B \u0086\u0005()
    {
      return \u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.BasketFullCapture, this.\u0001.BasketFullBounds, (\u0005) this.\u0001);
    }

    private \u0080.\u001B \u0087\u0005()
    {
      return this.\u001D\u0005(500, 20000, this.\u0001.NoWaterCapture, this.\u0001.NoWaterBounds, (\u0005) this.\u0001);
    }

    private bool \u001E\u0005(int numberOfWaters)
    {
      if (!base.CanContinue || this.\u0088\u0005() != \u0080.\u001B.\u0001)
        return false;
      for (int index = 0; index < numberOfWaters; ++index)
      {
        if (!base.CanContinue)
          return false;
        this.\u001D\u0005(this.\u0001.WaterPlantBounds, (\u0005) this.\u0001);
        base.\u0080\u0005();
        if (this.\u001D\u0005(500, 10000, this.\u0001.WaterPlantCapture, this.\u0001.WaterPlantBounds, (\u0005) this.\u0001) != \u0080.\u001B.\u0001)
          return false;
      }
      return true;
    }

    private \u0080.\u001B \u0088\u0005()
    {
      return \u0004.\u001D\u0005(base.\u0001.ToonTownProcess, this.\u0001.WaterPlantCapture, this.\u0001.WaterPlantBounds, (\u0005) this.\u0001);
    }

    private List<\u0016.\u001B.\u0001> \u001D\u0005()
    {
      List<\u0016.\u001B.\u0001> objList = new List<\u0016.\u001B.\u0001>();
      foreach (KeyValuePair<\u0014.\u007F, \u000E> estatePlantSetting in this.\u0001.EstatePlantSettings)
      {
        \u000E obj1 = estatePlantSetting.Value;
        if (obj1.Enabled)
        {
          \u0016.\u001B.\u0001 obj2 = new \u0016.\u001B.\u0001(obj1.State, ((\u0004) obj1).GardeningActions, (int) obj1.WaterCount, obj1.HouseColor);
          bool flag = false;
          if (obj2.Customized)
          {
            foreach (KeyValuePair<\u007F.\u007F, \u001E.\u0001> orderedFlower in obj1.OrderedFlowers)
            {
              \u0017.\u007F gardeningActions = ((\u0004) orderedFlower.Value).GardeningActions;
              if (\u0095\u001C.\u0099\u0091((object) gardeningActions, (Enum) \u0017.\u007F.\u0002) && (\u0095\u001C.\u0099\u0091((object) gardeningActions, (Enum) \u0017.\u007F.\u0003) || \u0095\u001C.\u0099\u0091((object) gardeningActions, (Enum) \u0017.\u007F.\u0004) || \u0095\u001C.\u0099\u0091((object) gardeningActions, (Enum) \u0017.\u007F.\u0005)))
              {
                obj2.Flowers.Add(orderedFlower);
                flag = true;
              }
            }
            foreach (KeyValuePair<\u007F.\u007F, \u0080.\u001E> orderedTree in obj1.OrderedTrees)
            {
              \u0080.\u001E obj3 = orderedTree.Value;
              \u0017.\u007F gardeningActions = obj3.GardeningActions;
              if (\u0095\u001C.\u0099\u0091((object) gardeningActions, (Enum) (\u0017.\u007F.\u0002 | \u0017.\u007F.\u0005)) && obj3.WaterCount > 0)
              {
                obj2.Trees.Add(orderedTree);
                flag = true;
              }
            }
          }
          else
            flag = obj1.GardenFlowers && (obj1.Water && (int) obj1.WaterCount > 0 || (((\u0004) obj1).Pick || ((\u0004) obj1).Plant)) || obj1.GardenTrees && (obj1.Water && (int) obj1.WaterCount > 0);
          if (flag)
            objList.Add(obj2);
        }
      }
      return objList;
    }

    private void \u0087\u0005()
    {
      IEnumerator<KeyValuePair<\u0008, \u001F.\u0001>> enumerator = ((IEnumerable<KeyValuePair<\u0008, \u001F.\u0001>>) this.\u0001.WayPoints).GetEnumerator();
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator))
        {
          KeyValuePair<\u0008, \u001F.\u0001> current = enumerator.Current;
          Dictionary<\u007F.\u007F, HashSet<PointF>> dictionary;
          this.\u0001.Add(current.Key, dictionary = new Dictionary<\u007F.\u007F, HashSet<PointF>>());
          foreach (KeyValuePair<PointF, \u007F.\u007F> keyValuePair in current.Value.WayPoints[\u0019.\u0002])
          {
            if (\u0095\u001C.\u0099\u0091((object) keyValuePair.Value, (Enum) \u007F.\u007F.\u0003) || keyValuePair.Value == \u007F.\u007F.\u0001)
            {
              HashSet<PointF> pointFSet;
              if (dictionary.ContainsKey(keyValuePair.Value))
                pointFSet = dictionary[keyValuePair.Value];
              else
                dictionary.Add(keyValuePair.Value, pointFSet = new HashSet<PointF>());
              pointFSet.Add(keyValuePair.Key);
            }
            else if (keyValuePair.Value == \u007F.\u007F.\u001D)
              this.\u0001 = keyValuePair.Key;
          }
        }
      }
      finally
      {
        if (enumerator != null)
          \u001A\u001E.\u007E\u0094\u0092((object) enumerator);
      }
    }

    private bool \u001D\u0005(List<\u0016.\u001B.\u0001> estates)
    {
      \u0006? coords = \u001A.\u001A.\u001D\u0005(base.\u0001, base.\u0001, -1);
      if (!coords.HasValue)
        return false;
      base.\u0001.\u0081\u0005();
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u0016.\u001B.\u0007 obj1 = new \u0016.\u001B.\u0007();
        PointF pointF = coords.Value.Location;
        List<PointF> path = new List<PointF>();
        \u0016.\u001B.\u0001 estateGardenData;
        if (this.\u001D\u0005(estates, out estateGardenData, false, coords))
        {
          PointF end_location = \u0016.\u001B.\u001D\u0005(this.\u0001[\u0008.\u0007], \u007F.\u007F.\u0001, pointF);
          path.AddRange((IEnumerable<PointF>) \u001A.\u001A.\u001D\u0005(this.\u0001[(\u0008) estateGardenData.HouseColor][\u007F.\u007F.\u0001], pointF, end_location));
          pointF = path[path.Count - 1];
        }
        path.AddRange((IEnumerable<PointF>) \u0016.\u001B.\u001D\u0005(this.\u0001[\u0008.\u0007], pointF, this.\u0001));
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = false;
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = new \u0080.\u001B?();
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        \u0016.\u001B.\u0008 obj2 = new \u0016.\u001B.\u0008();
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = obj1;
        // ISSUE: reference to a compiler-generated field
        obj2.\u0001 = new ManualResetEventSlim(false);
        bool flag;
        try
        {
          try
          {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            \u0016.\u001B.\u000E obj3 = new \u0016.\u001B.\u000E();
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
            \u0016.\u001B.\u000F obj4 = new \u0016.\u001B.\u000F();
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
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                flag = obj1.\u0001.HasValue && obj1.\u0001.Value == \u0080.\u001B.\u0001;
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
        if (!flag)
          return false;
        this.\u001D\u0005(this.\u0001.SellFlowersBounds, (\u0005) this.\u0001);
        int num1 = \u0095\u0081.\u007E\u0006\u0099((object) base.\u0001, 1000) ? 1 : 0;
        path.RemoveAt(path.Count - 1);
        path.Reverse();
        path.Add(coords.Value.Location);
        return \u001A.\u001A.\u001D\u0005(base.\u0001, base.\u0001, path, (\u0005) this.\u0001, false);
      }
      finally
      {
        base.\u0001.\u0082\u0005();
      }
    }

    private bool \u001D\u0005(\u007F.\u007F type, bool jump, \u0016.\u001B.\u0001 currentEstate, List<\u0016.\u001B.\u0001> estates, bool startingPath = false)
    {
      \u0006? coords = \u001A.\u001A.\u001D\u0005(base.\u0001, base.\u0001, -1);
      if (!coords.HasValue)
        return false;
      base.\u0001.\u0081\u0005();
      try
      {
        Dictionary<\u007F.\u007F, HashSet<PointF>> wayPointDestinations = this.\u0001[(\u0008) currentEstate.HouseColor];
        PointF pointF1 = coords.Value.Location;
        PointF pointF2 = \u0016.\u001B.\u001D\u0005(wayPointDestinations, type, pointF1);
        List<PointF> path = new List<PointF>();
        \u0016.\u001B.\u0001 estateGardenData;
        if (startingPath && this.\u0001[\u0008.\u0007].ContainsKey(\u007F.\u007F.\u0001) && this.\u001D\u0005(estates, out estateGardenData, false, coords))
        {
          if (currentEstate.HouseColor != estateGardenData.HouseColor && this.\u0001[(\u0008) estateGardenData.HouseColor].ContainsKey(\u007F.\u007F.\u0001))
          {
            PointF end_location = \u0016.\u001B.\u001D\u0005(this.\u0001[\u0008.\u0007], \u007F.\u007F.\u0001, pointF1);
            path.AddRange((IEnumerable<PointF>) \u001A.\u001A.\u001D\u0005(this.\u0001[(\u0008) estateGardenData.HouseColor][\u007F.\u007F.\u0001], pointF1, end_location));
            pointF1 = path[path.Count - 1];
          }
          path.AddRange((IEnumerable<PointF>) \u001A.\u001A.\u001D\u0005(this.\u0001[\u0008.\u0007][\u007F.\u007F.\u0001], pointF1, pointF2));
          path.RemoveAt(path.Count - 1);
          if (path.Count > 0)
            pointF1 = path[path.Count - 1];
        }
        path.AddRange((IEnumerable<PointF>) \u0016.\u001B.\u001D\u0005(wayPointDestinations, pointF1, pointF2));
        return \u001A.\u001A.\u001D\u0005(base.\u0001, base.\u0001, path, (\u0005) this.\u0001, jump);
      }
      finally
      {
        base.\u0001.\u0082\u0005();
      }
    }

    private static List<PointF> \u001D\u0005(Dictionary<\u007F.\u007F, HashSet<PointF>> wayPointDestinations, PointF coords, PointF target)
    {
      return !wayPointDestinations.ContainsKey(\u007F.\u007F.\u0001) ? \u001A.\u001A.\u001D\u0005((HashSet<PointF>) null, coords, target) : \u001A.\u001A.\u001D\u0005(wayPointDestinations[\u007F.\u007F.\u0001], coords, target);
    }

    private bool \u001D\u0005(List<\u0016.\u001B.\u0001> estates, out \u0016.\u001B.\u0001 estateGardenData, bool allowCustom = true, \u0006? coords = null)
    {
      \u007F.\u007F nearType;
      return this.\u001D\u0005(estates, out estateGardenData, out nearType, allowCustom, coords);
    }

    private bool \u001D\u0005(List<\u0016.\u001B.\u0001> estates, out \u0016.\u001B.\u0001 estateGardenData, out \u007F.\u007F nearType, bool allowCustom = true, \u0006? coords = null)
    {
      estateGardenData = (\u0016.\u001B.\u0001) null;
      nearType = \u007F.\u007F.\u0001;
      if (!coords.HasValue)
        goto label_9;
label_2:
      float num1 = float.MaxValue;
      PointF location = coords.Value.Location;
      foreach (\u0016.\u001B.\u0001 estate in estates)
      {
        float num2 = this.\u001D\u0005(estate, location, allowCustom, out nearType);
        if ((double) num1 > (double) num2)
        {
          num1 = num2;
          estateGardenData = estate;
        }
      }
      return estateGardenData != null;
label_9:
      coords = \u001A.\u001A.\u001D\u0005(base.\u0001, base.\u0001, -1);
      if (!coords.HasValue)
        return false;
      goto label_2;
    }

    private float \u001D\u0005(\u0016.\u001B.\u0001 estate, PointF currentPos, bool allowCustom, out \u007F.\u007F nearType)
    {
      float num1 = float.MaxValue;
      Dictionary<\u007F.\u007F, HashSet<PointF>> wayPoints = this.\u0001[(\u0008) estate.HouseColor];
      nearType = \u007F.\u007F.\u0001;
      if (estate.Customized && allowCustom)
      {
        foreach (KeyValuePair<\u007F.\u007F, \u001E.\u0001> flower in estate.Flowers)
        {
          float num2 = \u0016.\u001B.\u001D\u0005(wayPoints, flower.Key, currentPos);
          if ((double) num1 > (double) num2)
          {
            num1 = num2;
            nearType = flower.Key;
          }
        }
        foreach (KeyValuePair<\u007F.\u007F, \u0080.\u001E> tree in estate.Trees)
        {
          float num2 = \u0016.\u001B.\u001D\u0005(wayPoints, tree.Key, currentPos);
          if ((double) num1 > (double) num2)
          {
            num1 = num2;
            nearType = tree.Key;
          }
        }
      }
      else
      {
        foreach (\u007F.\u007F target in this.\u0002)
        {
          float num2 = \u0016.\u001B.\u001D\u0005(wayPoints, target, currentPos);
          if ((double) num1 > (double) num2)
          {
            num1 = num2;
            nearType = target;
          }
        }
        foreach (\u007F.\u007F target in this.\u0001)
        {
          float num2 = \u0016.\u001B.\u001D\u0005(wayPoints, target, currentPos);
          if ((double) num1 > (double) num2)
          {
            num1 = num2;
            nearType = target;
          }
        }
      }
      return num1;
    }

    private static float \u001D\u0005(Dictionary<\u007F.\u007F, HashSet<PointF>> wayPoints, \u007F.\u007F target, PointF currentPos)
    {
      float num1 = float.MaxValue;
      foreach (PointF p2 in wayPoints[target])
      {
        float num2 = \u0082.\u0001.\u001D\u0005(currentPos, p2);
        if ((double) num1 > (double) num2)
          num1 = num2;
      }
      return num1;
    }

    private static PointF \u001D\u0005(Dictionary<\u007F.\u007F, HashSet<PointF>> wayPointDestinations, \u007F.\u007F type, PointF currentPos)
    {
      float num1 = float.MaxValue;
      PointF? nullable = new PointF?();
      foreach (PointF p2 in wayPointDestinations[type])
      {
        float num2 = \u0082.\u0001.\u001D\u0005(currentPos, p2);
        if ((double) num1 > (double) num2 || !nullable.HasValue)
        {
          num1 = num2;
          nullable = new PointF?(p2);
        }
      }
      return nullable.Value;
    }

    private sealed class \u0001
    {
      private \u0013 \u0001;
      private \u0017.\u007F \u0001;
      private int \u0001;

      public List<KeyValuePair<\u007F.\u007F, \u0080.\u001E>> Trees { get; private set; }

      public List<KeyValuePair<\u007F.\u007F, \u001E.\u0001>> Flowers { get; private set; }

      public \u0014.\u007F HouseColor { get; private set; }

      public int? LastBeanCombinationIndex { get; set; }

      public bool Customized
      {
        get
        {
          return \u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) \u0013.\u0002);
        }
      }

      public bool GardenTrees
      {
        get
        {
          return \u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) \u0013.\u0003);
        }
      }

      public int WaterCount
      {
        get
        {
          return this.\u0001;
        }
      }

      public bool GardenFlowers
      {
        get
        {
          return \u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) \u0013.\u0004);
        }
      }

      public bool Water
      {
        get
        {
          return \u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) \u0017.\u007F.\u0005);
        }
      }

      public bool Plant
      {
        get
        {
          return \u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) \u0017.\u007F.\u0004);
        }
      }

      public bool Pick
      {
        get
        {
          return \u0095\u001C.\u0099\u0091((object) this.\u0001, (Enum) \u0017.\u007F.\u0003);
        }
      }

      public \u0001(\u0013 targets, \u0017.\u007F actions, int waterCount, \u0014.\u007F houseColor)
      {
        this.\u0001 = targets;
        this.\u0001 = actions;
        this.\u0001 = waterCount;
        this.HouseColor = houseColor;
        this.Trees = new List<KeyValuePair<\u007F.\u007F, \u0080.\u001E>>();
        this.Flowers = new List<KeyValuePair<\u007F.\u007F, \u001E.\u0001>>();
      }
    }

    [System.Flags]
    private enum \u0002
    {
      \u0001 = 0,
      \u0002 = 1,
      \u0003 = 2,
    }

    private enum \u0003
    {
      \u0001,
      \u0002,
      \u0003,
      \u0004,
    }
  }
}
