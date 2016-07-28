// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001B;
using \u001F;
using System.Drawing;

namespace \u007F
{
  internal sealed class \u0001 : \u0018.\u001B
  {
    public void \u0001(\u0082 e)
    {
      Rectangle bounds = e.Bounds;
      int num1 = bounds.Height / 7;
      bounds.Height = bounds.Height / 7;
      bounds.Width -= num1 + 2;
      bounds.X += bounds.Height / 2 + 1;
      Rectangle rectangle1 = new Rectangle(bounds.Right - num1 / 2, bounds.Y, num1, num1);
      Rectangle rectangle2 = new Rectangle(bounds.Left - num1 / 2, bounds.Y, bounds.Height, bounds.Height);
      SolidBrush solidBrush = new SolidBrush(\u0001.\u0001);
      try
      {
        \u0001\u0080.\u007E\u0093\u007F((object) e.Graphics, (Brush) solidBrush, bounds);
        \u0001\u0080.\u007E\u0097\u007F((object) e.Graphics, (Brush) solidBrush, rectangle2);
        \u0001\u0080.\u007E\u0097\u007F((object) e.Graphics, (Brush) solidBrush, rectangle1);
        \u0081\u0082.\u007E\u0012\u0081((object) solidBrush, \u0001.\u0002);
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Rectangle& local1 = @rectangle2;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Rectangle& local2 = @rectangle1;
        int num2 = bounds.Y += bounds.Height;
        int num3;
        int num4 = num3 = num2;
        // ISSUE: explicit reference operation
        (^local2).Y = num3;
        int num5 = num4;
        // ISSUE: explicit reference operation
        (^local1).Y = num5;
        \u0001\u0080.\u007E\u0093\u007F((object) e.Graphics, (Brush) solidBrush, bounds);
        \u0001\u0080.\u007E\u0097\u007F((object) e.Graphics, (Brush) solidBrush, rectangle2);
        \u0001\u0080.\u007E\u0097\u007F((object) e.Graphics, (Brush) solidBrush, rectangle1);
        \u0081\u0082.\u007E\u0012\u0081((object) solidBrush, \u0001.\u0003);
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Rectangle& local3 = @rectangle2;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Rectangle& local4 = @rectangle1;
        int num6 = bounds.Y += bounds.Height;
        int num7;
        int num8 = num7 = num6;
        // ISSUE: explicit reference operation
        (^local4).Y = num7;
        int num9 = num8;
        // ISSUE: explicit reference operation
        (^local3).Y = num9;
        \u0001\u0080.\u007E\u0093\u007F((object) e.Graphics, (Brush) solidBrush, bounds);
        \u0001\u0080.\u007E\u0097\u007F((object) e.Graphics, (Brush) solidBrush, rectangle2);
        \u0001\u0080.\u007E\u0097\u007F((object) e.Graphics, (Brush) solidBrush, rectangle1);
        \u0081\u0082.\u007E\u0012\u0081((object) solidBrush, \u0001.\u0004);
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Rectangle& local5 = @rectangle2;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Rectangle& local6 = @rectangle1;
        int num10 = bounds.Y += bounds.Height;
        int num11;
        int num12 = num11 = num10;
        // ISSUE: explicit reference operation
        (^local6).Y = num11;
        int num13 = num12;
        // ISSUE: explicit reference operation
        (^local5).Y = num13;
        \u0001\u0080.\u007E\u0093\u007F((object) e.Graphics, (Brush) solidBrush, bounds);
        \u0001\u0080.\u007E\u0097\u007F((object) e.Graphics, (Brush) solidBrush, rectangle2);
        \u0001\u0080.\u007E\u0097\u007F((object) e.Graphics, (Brush) solidBrush, rectangle1);
        \u0081\u0082.\u007E\u0012\u0081((object) solidBrush, \u0001.\u0005);
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Rectangle& local7 = @rectangle2;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Rectangle& local8 = @rectangle1;
        int num14 = bounds.Y += bounds.Height;
        int num15;
        int num16 = num15 = num14;
        // ISSUE: explicit reference operation
        (^local8).Y = num15;
        int num17 = num16;
        // ISSUE: explicit reference operation
        (^local7).Y = num17;
        \u0001\u0080.\u007E\u0093\u007F((object) e.Graphics, (Brush) solidBrush, bounds);
        \u0001\u0080.\u007E\u0097\u007F((object) e.Graphics, (Brush) solidBrush, rectangle2);
        \u0001\u0080.\u007E\u0097\u007F((object) e.Graphics, (Brush) solidBrush, rectangle1);
        \u0081\u0082.\u007E\u0012\u0081((object) solidBrush, \u0001.\u0006);
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Rectangle& local9 = @rectangle2;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Rectangle& local10 = @rectangle1;
        int num18 = bounds.Y += bounds.Height;
        int num19;
        int num20 = num19 = num18;
        // ISSUE: explicit reference operation
        (^local10).Y = num19;
        int num21 = num20;
        // ISSUE: explicit reference operation
        (^local9).Y = num21;
        \u0001\u0080.\u007E\u0093\u007F((object) e.Graphics, (Brush) solidBrush, bounds);
        \u0001\u0080.\u007E\u0097\u007F((object) e.Graphics, (Brush) solidBrush, rectangle2);
        \u0001\u0080.\u007E\u0097\u007F((object) e.Graphics, (Brush) solidBrush, rectangle1);
        \u0081\u0082.\u007E\u0012\u0081((object) solidBrush, \u0001.\u0007);
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Rectangle& local11 = @rectangle2;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Rectangle& local12 = @rectangle1;
        int num22 = bounds.Y += bounds.Height;
        int num23;
        int num24 = num23 = num22;
        // ISSUE: explicit reference operation
        (^local12).Y = num23;
        int num25 = num24;
        // ISSUE: explicit reference operation
        (^local11).Y = num25;
        \u0001\u0080.\u007E\u0093\u007F((object) e.Graphics, (Brush) solidBrush, bounds);
        \u0001\u0080.\u007E\u0097\u007F((object) e.Graphics, (Brush) solidBrush, rectangle2);
        \u0001\u0080.\u007E\u0097\u007F((object) e.Graphics, (Brush) solidBrush, rectangle1);
      }
      finally
      {
        if (solidBrush != null)
          \u001A\u001E.\u007E\u0094\u0092((object) solidBrush);
      }
    }
  }
}
