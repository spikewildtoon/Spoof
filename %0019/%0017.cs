// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0019;
using \u001E;
using \u0082;
using System.Drawing;

namespace \u0019
{
  internal static class \u0017
  {
    public static float? \u001D\u0005(PointF sphereCenter, float sphereRadius, PointF rayPosition, float rayAngle)
    {
      double num = \u0001.\u001D\u0005((double) rayAngle);
      PointF rayDirection = new PointF((float) -\u0007\u0081.\u0095\u0096(num), (float) \u0007\u0081.\u0092\u0096(num));
      rayDirection.\u001D\u0005();
      return \u0017.\u001D\u0005(sphereCenter, sphereRadius, rayPosition, rayDirection);
    }

    public static float? \u001D\u0005(PointF sphereCenter, float sphereRadius, PointF rayPosition, PointF rayDirection)
    {
      float num1 = sphereCenter.X - rayPosition.X;
      float num2 = sphereCenter.Y - rayPosition.Y;
      float num3 = (float) ((double) num1 * (double) num1 + (double) num2 * (double) num2);
      float num4 = sphereRadius * sphereRadius;
      if ((double) num3 <= (double) num4)
        return new float?(0.0f);
      float num5 = (float) ((double) num1 * (double) rayDirection.X + (double) num2 * (double) rayDirection.Y);
      if ((double) num5 < 0.0)
        return new float?();
      float num6 = num3 - num5 * num5;
      if ((double) num6 > (double) num4)
        return new float?();
      float num7 = (float) \u0007\u0081.\u0099\u0096((double) num4 - (double) num6);
      return new float?(num5 - num7);
    }
  }
}
