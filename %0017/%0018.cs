// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0017;
using System.Drawing;

namespace \u0017
{
  internal static class \u0018
  {
    public static Color \u001D\u0005(Color baseColor, Color blendColor, int opacity)
    {
      return \u008E\u001D.\u0017\u007F((int) ((double) blendColor.R * ((double) opacity / 100.0) + (double) baseColor.R * (1.0 - (double) opacity / 100.0)), (int) ((double) blendColor.G * ((double) opacity / 100.0) + (double) baseColor.G * (1.0 - (double) opacity / 100.0)), (int) ((double) blendColor.B * ((double) opacity / 100.0) + (double) baseColor.B * (1.0 - (double) opacity / 100.0)));
    }

    public static Color \u001E\u0005(Color baseColor, Color blendColor, int opacity)
    {
      return \u0018.\u001D\u0005(baseColor, \u008E\u001D.\u0017\u007F(\u0018.\u001D\u0005((int) baseColor.R, (int) blendColor.R), \u0018.\u001D\u0005((int) baseColor.G, (int) blendColor.G), \u0018.\u001D\u0005((int) baseColor.B, (int) blendColor.B)), opacity);
    }

    public static Color \u001F\u0005(Color baseColor, Color blendColor, int opacity)
    {
      return \u0018.\u001D\u0005(baseColor, \u008E\u001D.\u0017\u007F(\u0018.\u001E\u0005((int) baseColor.R, (int) blendColor.R), \u0018.\u001E\u0005((int) baseColor.G, (int) blendColor.G), \u0018.\u001E\u0005((int) baseColor.B, (int) blendColor.B)), opacity);
    }

    private static int \u001D\u0005(int ibase, int blend)
    {
      float num1 = (float) ibase / (float) byte.MaxValue;
      float num2 = (float) blend / (float) byte.MaxValue;
      if ((double) num2 < 0.5)
        return (int) ((2.0 * (double) num1 * (double) num2 + \u0090\u007F.\u009A\u0096((double) num1, 2.0) * (1.0 - 2.0 * (double) num2)) * (double) byte.MaxValue);
      return (int) ((\u0007\u0081.\u0099\u0096((double) num1) * (2.0 * (double) num2 - 1.0) + 2.0 * (double) num1 * (1.0 - (double) num2)) * (double) byte.MaxValue);
    }

    private static int \u001E\u0005(int ibase, int blend)
    {
      double num1 = (double) ibase / (double) byte.MaxValue;
      double num2 = (double) blend / (double) byte.MaxValue;
      if (num1 < 0.5)
        return (int) (2.0 * num1 * num2 * (double) byte.MaxValue);
      return (int) ((1.0 - 2.0 * (1.0 - num1) * (1.0 - num2)) * (double) byte.MaxValue);
    }
  }
}
