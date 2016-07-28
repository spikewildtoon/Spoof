// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0015;
using \u001A;
using \u001E;
using \u001F;
using \u007F;
using \u0080;
using \u0081;
using \u0083;
using System;
using System.Drawing;

namespace \u0080
{
  internal static class \u0004
  {
    public static \u001B \u001D\u0005(\u001C toontownWindow, \u0018 original_capture, \u0013 bounds, \u0005 settings)
    {
      if (original_capture == null || bounds.IsSizeEmpty)
        return \u001B.\u0003;
      IntPtr mainWindowHandle = toontownWindow.MainWindowHandle;
      if (!toontownWindow.ProcessOpen || original_capture == null || \u0013.\u001D\u0005(bounds, \u0013.\u0001))
        return \u001B.\u0003;
      Rectangle rectangle = \u0013.\u001E\u0005(mainWindowHandle);
      Rectangle rec = bounds.\u001D\u0005(rectangle.Size);
      Bitmap source = \u0012.\u001D\u0005(mainWindowHandle, rec);
      try
      {
        \u0082 bmp = new \u0082(source);
        try
        {
          \u0018 left = new \u0018(bmp);
          try
          {
            return \u0018.\u001D\u0005(left, original_capture, settings.MaxColorRange) ? \u001B.\u0001 : \u001B.\u0002;
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
      }
      finally
      {
        if (source != null)
          \u001A\u001E.\u007E\u0094\u0092((object) source);
      }
    }

    public static \u001B \u001D\u0005(\u001C toontownWindow, \u0018 original_capture, Rectangle capture_bounds, \u0005 settings)
    {
      if (original_capture == null)
        return \u001B.\u0003;
      IntPtr mainWindowHandle = toontownWindow.MainWindowHandle;
      if (!toontownWindow.ProcessOpen || original_capture == null || !capture_bounds.Size.\u001D\u0005())
        return \u001B.\u0003;
      Bitmap source = \u0012.\u001D\u0005(mainWindowHandle, capture_bounds);
      try
      {
        \u0082 bmp = new \u0082(source);
        try
        {
          \u0018 left = new \u0018(bmp);
          try
          {
            return \u0018.\u001D\u0005(left, original_capture, settings.MaxColorRange) ? \u001B.\u0001 : \u001B.\u0002;
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
      }
      finally
      {
        if (source != null)
          \u001A\u001E.\u007E\u0094\u0092((object) source);
      }
    }
  }
}
