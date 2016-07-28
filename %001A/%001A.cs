// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0019;
using \u001F;
using \u007F;
using \u0080;
using \u0081;
using \u0082;
using \u0083;
using \u0084;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace \u001A
{
  internal static class \u001A
  {
    public static \u0006? \u001D\u0005(\u0018 toontownWindow, ManualResetEventSlim waitHandle, int timeOut = -1)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001A.\u001A.\u0002 obj1 = new \u001A.\u001A.\u0002();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = new \u0006?();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = false;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001A.\u001A.\u0003 obj2 = new \u001A.\u001A.\u0003();
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = obj1;
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = new ManualResetEventSlim(false);
      try
      {
        try
        {
          // ISSUE: reference to a compiler-generated method
          toontownWindow.LogMonitor.CoordinatesChanged += new EventHandler<\u0018>(obj2.\u001D\u0005);
          // ISSUE: reference to a compiler-generated method
          toontownWindow.ToonTownProcess.ProcessExited += new EventHandler(obj2.\u001D\u0005);
          IntPtr mainWindowHandle = toontownWindow.ToonTownProcess.MainWindowHandle;
          if (!toontownWindow.ToonTownProcess.ProcessOpen)
            return new \u0006?();
          // ISSUE: reference to a compiler-generated field
          \u001A.\u001A.\u001D\u0005(mainWindowHandle, obj2.\u0001);
          // ISSUE: reference to a compiler-generated field
          WaitHandle[] waitHandleArray = new WaitHandle[2]{ \u001B\u001F.\u007E\u009D\u0098((object) waitHandle), \u001B\u001F.\u007E\u009D\u0098((object) obj2.\u0001) };
          int num = \u0008\u001E.\u001C\u0098(waitHandleArray, timeOut);
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
      // ISSUE: reference to a compiler-generated field
      return obj1.\u0001;
    }

    public static \u0006? \u001D\u0005(\u0018 toontownWindow, ManualResetEventSlim waitHandle, \u0014 coordinatePoll)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001A.\u001A.\u0004 obj1 = new \u001A.\u001A.\u0004();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = new \u0006?();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = false;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001A.\u001A.\u0005 obj2 = new \u001A.\u001A.\u0005();
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = obj1;
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = new ManualResetEventSlim(false);
      try
      {
        try
        {
          // ISSUE: reference to a compiler-generated method
          toontownWindow.LogMonitor.CoordinatesChanged += new EventHandler<\u0018>(obj2.\u001D\u0005);
          // ISSUE: reference to a compiler-generated method
          toontownWindow.ToonTownProcess.ProcessExited += new EventHandler(obj2.\u001D\u0005);
          if (!toontownWindow.ToonTownProcess.ProcessOpen)
            return new \u0006?();
          coordinatePoll.\u0081\u0005();
          // ISSUE: reference to a compiler-generated field
          WaitHandle[] waitHandleArray = new WaitHandle[2]{ \u001B\u001F.\u007E\u009D\u0098((object) waitHandle), \u001B\u001F.\u007E\u009D\u0098((object) obj2.\u0001) };
          int num = \u0099\u001B.\u001B\u0098(waitHandleArray);
          coordinatePoll.\u0082\u0005();
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
      // ISSUE: reference to a compiler-generated field
      return obj1.\u0001;
    }

    public static bool \u001D\u0005(\u0018 toontownWindow, ManualResetEventSlim waitHandle, ManualResetEventSlim navigateWaitHandle, List<PointF> path, \u0005 settings, bool jump = true)
    {
      for (int index = 0; index < path.Count; ++index)
      {
        if (!\u001A.\u001A.\u001D\u0005(toontownWindow, waitHandle, navigateWaitHandle, settings, path[index], jump, index == path.Count - 1))
          return false;
      }
      return true;
    }

    public static bool \u001D\u0005(\u0018 toontownWindow, ManualResetEventSlim waitHandle, List<PointF> path, \u0005 settings, bool jump = true)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001A.\u001A.\u0006 obj1 = new \u001A.\u001A.\u0006();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = false;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001A.\u001A.\u0007 obj2 = new \u001A.\u001A.\u0007();
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = obj1;
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = new ManualResetEventSlim(false);
      try
      {
        try
        {
          // ISSUE: reference to a compiler-generated method
          toontownWindow.ToonTownProcess.ProcessExited += new EventHandler(obj2.\u001D\u0005);
          // ISSUE: reference to a compiler-generated field
          return \u001A.\u001A.\u001D\u0005(toontownWindow, waitHandle, obj2.\u0001, path, settings, jump);
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

    public static bool \u001D\u0005(\u0018 toontownWindow, ManualResetEventSlim waitHandle, \u0005 settings, PointF target, bool jump, bool finalTarget)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001A.\u001A.\u0008 obj1 = new \u001A.\u001A.\u0008();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = false;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001A.\u001A.\u000E obj2 = new \u001A.\u001A.\u000E();
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = obj1;
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = new ManualResetEventSlim(false);
      try
      {
        try
        {
          // ISSUE: reference to a compiler-generated method
          toontownWindow.ToonTownProcess.ProcessExited += new EventHandler(obj2.\u001D\u0005);
          // ISSUE: reference to a compiler-generated field
          return \u001A.\u001A.\u001D\u0005(toontownWindow, waitHandle, obj2.\u0001, settings, target, jump, finalTarget);
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

    public static bool \u001D\u0005(\u0018 toontownWindow, ManualResetEventSlim waitHandle, ManualResetEventSlim navigateWaitHandle, \u0005 settings, PointF target, bool jump, bool finalTarget)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001A.\u001A.\u000F obj1 = new \u001A.\u001A.\u000F();
      IntPtr mainWindowHandle = toontownWindow.ToonTownProcess.MainWindowHandle;
      if (!toontownWindow.ToonTownProcess.ProcessOpen)
        return false;
      \u001A.\u001A.\u0001 direction = \u001A.\u001A.\u0001.\u0001;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = \u0006.\u0001;
      \u0006 a = \u0006.\u0001;
      DateTime dateTime1 = \u001D\u0082.\u0011\u0094().AddMilliseconds(2000.0);
      float num1 = finalTarget ? settings.TargetRange : settings.IntermediateTargetRange;
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = false;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001A.\u001A.\u0010 obj2 = new \u001A.\u001A.\u0010();
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = obj1;
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = new ManualResetEventSlim(false);
      try
      {
        try
        {
          // ISSUE: reference to a compiler-generated method
          toontownWindow.LogMonitor.CoordinatesChanged += new EventHandler<\u0018>(obj2.\u001D\u0005);
          // ISSUE: reference to a compiler-generated field
          WaitHandle[] waitHandleArray = new WaitHandle[3]{ \u001B\u001F.\u007E\u009D\u0098((object) waitHandle), \u001B\u001F.\u007E\u009D\u0098((object) obj2.\u0001), \u001B\u001F.\u007E\u009D\u0098((object) navigateWaitHandle) };
          int num2 = \u0099\u001B.\u001B\u0098(waitHandleArray);
          WaitHandle[] waitHandles = new WaitHandle[2]{ \u001B\u001F.\u007E\u009D\u0098((object) waitHandle), \u001B\u001F.\u007E\u009D\u0098((object) navigateWaitHandle) };
          DateTime dateTime2 = \u001D\u0082.\u0011\u0094().AddMilliseconds(2000.0);
          try
          {
            while (!\u0099\u0082.\u007E\u009E\u0098((object) waitHandle))
            {
              if (!\u0099\u0082.\u007E\u009E\u0098((object) navigateWaitHandle))
              {
                // ISSUE: reference to a compiler-generated field
                \u0006 b = obj1.\u0001;
                PointF location = b.Location;
                if (\u0001.\u001D\u0005(target, num1, location))
                  return true;
                float num3 = b.\u001D\u0005(target);
                float minimum_h = \u009D\u0084.\u009C\u0096(num3 - b.\u0004);
                float num4 = \u0001.\u001D\u0005(target, b.Location);
                if (\u0017\u0084.\u0080\u0094(dateTime1, \u001D\u0082.\u0011\u0094()))
                {
                  if (\u0006.\u001D\u0005(a, b))
                  {
                    \u001A.\u001A.\u001F\u0005(mainWindowHandle, ref direction);
                    \u001A.\u001A.\u001E\u0005(mainWindowHandle, ref direction);
                    \u001A.\u001A.\u001D\u0005(mainWindowHandle, ref direction);
                    \u001A.\u001A.\u001D\u0005(mainWindowHandle);
                  }
                  dateTime1 = \u001D\u0082.\u0011\u0094().AddMilliseconds(2000.0);
                }
                bool flag1;
                if ((double) num4 > 20.0 && (double) minimum_h > 20.0 || (double) num4 <= 20.0 && !\u0017.\u001D\u0005(target, num1, location, b.\u0004).HasValue)
                {
                  \u001A.\u001A.\u001F\u0005(mainWindowHandle, ref direction);
                  bool flag2 = (double) minimum_h > 180.0;
                  flag1 = (double) num3 >= (double) b.\u0004 ? (!flag2 ? \u001A.\u001A.\u001D\u0005(mainWindowHandle, ref direction, waitHandles, minimum_h) : \u001A.\u001A.\u001E\u0005(mainWindowHandle, ref direction, waitHandles, minimum_h)) : (!flag2 ? \u001A.\u001A.\u001E\u0005(mainWindowHandle, ref direction, waitHandles, minimum_h) : \u001A.\u001A.\u001D\u0005(mainWindowHandle, ref direction, waitHandles, minimum_h));
                }
                else
                {
                  \u001A.\u001A.\u001E\u0005(mainWindowHandle, ref direction);
                  \u001A.\u001A.\u001D\u0005(mainWindowHandle, ref direction);
                  if (jump && \u0017\u0084.\u0080\u0094(dateTime2, \u001D\u0082.\u0011\u0094()))
                  {
                    \u001A.\u001A.\u001D\u0005(mainWindowHandle, waitHandles);
                    dateTime2 = \u001D\u0082.\u0011\u0094().AddMilliseconds(2000.0);
                  }
                  flag1 = \u001A.\u001A.\u001F\u0005(mainWindowHandle, ref direction, waitHandles, num4 - settings.TargetRange);
                }
                if (!flag1)
                {
                  // ISSUE: reference to a compiler-generated field
                  \u001A\u001E.\u007E\u0003\u0099((object) obj2.\u0001);
                  int num5 = \u0099\u001B.\u001B\u0098(waitHandleArray);
                }
                // ISSUE: reference to a compiler-generated field
                if (\u0001.\u001D\u0005(target, num1, obj1.\u0001.Location))
                  return true;
                int num6 = \u0008\u001E.\u001C\u0098(waitHandles, 25);
                a = b;
              }
              else
                break;
            }
          }
          finally
          {
            \u001A.\u001A.\u001F\u0005(mainWindowHandle, ref direction);
            \u001A.\u001A.\u001E\u0005(mainWindowHandle, ref direction);
            \u001A.\u001A.\u001D\u0005(mainWindowHandle, ref direction);
            \u001A.\u001A.\u001D\u0005(mainWindowHandle);
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
      return false;
    }

    public static bool \u001D\u0005(\u0018 toontownWindow, ManualResetEventSlim waitHandle, \u0001 wayPointsSettings, \u0003 dock, \u0005 settings)
    {
      \u0006? nullable = \u001A.\u001A.\u001D\u0005(toontownWindow, waitHandle, -1);
      if (!nullable.HasValue)
        return false;
      if (nullable.Value.IsDock)
        return true;
      \u001A.\u0019 playground = toontownWindow.Playground;
      List<PointF> path = \u001A.\u001A.\u001D\u0005(!wayPointsSettings.WayPoints.ContainsKey(playground) ? (Dictionary<PointF, \u007F.\u007F>) null : wayPointsSettings.WayPoints[playground], nullable.Value.Location, dock.DockLocation);
      return \u001A.\u001A.\u001D\u0005(toontownWindow, waitHandle, path, settings);
    }

    public static bool \u001D\u0005(\u0018 toontownWindow, ManualResetEventSlim waitHandle, List<PointF> path, \u0005 settings)
    {
      for (int index = 0; index < path.Count; ++index)
      {
        if (index == path.Count - 1)
          return \u001A.\u001A.\u001D\u0005(toontownWindow, waitHandle, settings, path[index], true);
        if (!\u001A.\u001A.\u001D\u0005(toontownWindow, waitHandle, settings, path[index], true, false))
          return false;
      }
      return false;
    }

    public static bool \u001D\u0005(\u0018 toontownWindow, ManualResetEventSlim waitHandle, \u0005 settings, PointF target, bool jump)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001A.\u001A.\u0011 obj1 = new \u001A.\u001A.\u0011();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = false;
      IntPtr mainWindowHandle = toontownWindow.ToonTownProcess.MainWindowHandle;
      if (!toontownWindow.ToonTownProcess.ProcessOpen)
        return false;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u001A.\u001A.\u0012 obj2 = new \u001A.\u001A.\u0012();
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = obj1;
      // ISSUE: reference to a compiler-generated field
      obj2.\u0001 = new ManualResetEventSlim(false);
      try
      {
        try
        {
          // ISSUE: reference to a compiler-generated method
          toontownWindow.ToonTownProcess.ProcessExited += new EventHandler(obj2.\u001D\u0005);
          // ISSUE: reference to a compiler-generated method
          toontownWindow.LogMonitor.CoordinatesChanged += new EventHandler<\u0018>(obj2.\u001D\u0005);
          // ISSUE: reference to a compiler-generated field
          while (!\u0099\u0082.\u007E\u009E\u0098((object) obj2.\u0001) && !\u0099\u0082.\u007E\u009E\u0098((object) waitHandle))
          {
            if (jump)
            {
              // ISSUE: reference to a compiler-generated field
              \u001A.\u001A.\u001D\u0005(mainWindowHandle, new WaitHandle[2]
              {
                \u001B\u001F.\u007E\u009D\u0098((object) waitHandle),
                \u001B\u001F.\u007E\u009D\u0098((object) obj2.\u0001)
              });
            }
            // ISSUE: reference to a compiler-generated field
            if (!\u001A.\u001A.\u001D\u0005(toontownWindow, waitHandle, obj2.\u0001, settings, target, jump, true))
            {
              // ISSUE: reference to a compiler-generated field
              int num = \u0095\u0081.\u007E\u0006\u0099((object) obj2.\u0001, 100) ? 1 : 0;
            }
          }
          // ISSUE: reference to a compiler-generated field
          return \u0099\u0082.\u007E\u009E\u0098((object) obj2.\u0001) && !\u0099\u0082.\u007E\u009E\u0098((object) waitHandle);
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

    private static bool \u001D\u0005(IntPtr hWnd, ref \u001A.\u001A.\u0001 direction, WaitHandle[] waitHandles, float minimum_h)
    {
      \u001A.\u001A.\u001E\u0005(hWnd, ref direction);
      if ((double) minimum_h < 1.3)
      {
        \u001A.\u001A.\u001D\u0005(hWnd, waitHandles, 15);
        return false;
      }
      if ((double) minimum_h >= 2.6)
      {
        if ((double) minimum_h < 5.2)
        {
          \u001A.\u001A.\u001D\u0005(hWnd, waitHandles, 60);
          return false;
        }
        if ((double) minimum_h < 10.4)
        {
          \u001A.\u001A.\u001D\u0005(hWnd, waitHandles, 120);
          return false;
        }
        \u000E.\u001E\u0005(hWnd, Keys.Left);
        direction |= \u001A.\u001A.\u0001.\u0002;
        return true;
      }
      \u001A.\u001A.\u001D\u0005(hWnd, waitHandles, 30);
      return false;
    }

    private static bool \u001E\u0005(IntPtr hWnd, ref \u001A.\u001A.\u0001 direction, WaitHandle[] waitHandles, float minimum_h)
    {
      \u001A.\u001A.\u001D\u0005(hWnd, ref direction);
      if ((double) minimum_h < 1.3)
      {
        \u001A.\u001A.\u001E\u0005(hWnd, waitHandles, 15);
        return false;
      }
      if ((double) minimum_h >= 2.6)
      {
        if ((double) minimum_h < 5.2)
        {
          \u001A.\u001A.\u001E\u0005(hWnd, waitHandles, 60);
          return false;
        }
        if ((double) minimum_h < 10.4)
        {
          \u001A.\u001A.\u001E\u0005(hWnd, waitHandles, 120);
          return false;
        }
        \u000E.\u001E\u0005(hWnd, Keys.Right);
        direction |= \u001A.\u001A.\u0001.\u0003;
        return true;
      }
      \u001A.\u001A.\u001E\u0005(hWnd, waitHandles, 30);
      return false;
    }

    private static bool \u001F\u0005(IntPtr hWnd, ref \u001A.\u001A.\u0001 direction, WaitHandle[] waitHandles, float minimum_distance)
    {
      if ((double) minimum_distance < 0.25)
      {
        \u001A.\u001A.\u001D\u0005(hWnd, ref direction, waitHandles, 20);
        return false;
      }
      if ((double) minimum_distance >= 1.0)
      {
        if ((double) minimum_distance < 2.0)
        {
          \u001A.\u001A.\u001D\u0005(hWnd, ref direction, waitHandles, 80);
          return false;
        }
        \u000E.\u001E\u0005(hWnd, Keys.Up);
        direction |= \u001A.\u001A.\u0001.\u0004;
        return true;
      }
      \u001A.\u001A.\u001D\u0005(hWnd, ref direction, waitHandles, 40);
      return false;
    }

    private static void \u001D\u0005(IntPtr hWnd, WaitHandle[] waitHandles, int time)
    {
      \u000E.\u001D\u0005(hWnd, Keys.Left, waitHandles, time);
    }

    private static void \u001E\u0005(IntPtr hWnd, WaitHandle[] waitHandles, int time)
    {
      \u000E.\u001D\u0005(hWnd, Keys.Right, waitHandles, time);
    }

    private static void \u001D\u0005(IntPtr hWnd, ref \u001A.\u001A.\u0001 direction)
    {
      if (!\u0095\u001C.\u0099\u0091((object) direction, (Enum) \u001A.\u001A.\u0001.\u0002))
        return;
      \u000E.\u001F\u0005(hWnd, Keys.Left);
      direction &= ~\u001A.\u001A.\u0001.\u0002;
    }

    private static void \u001E\u0005(IntPtr hWnd, ref \u001A.\u001A.\u0001 direction)
    {
      if (!\u0095\u001C.\u0099\u0091((object) direction, (Enum) \u001A.\u001A.\u0001.\u0003))
        return;
      \u000E.\u001F\u0005(hWnd, Keys.Right);
      direction &= ~\u001A.\u001A.\u0001.\u0003;
    }

    private static void \u001F\u0005(IntPtr hWnd, ref \u001A.\u001A.\u0001 direction)
    {
      if (!\u0095\u001C.\u0099\u0091((object) direction, (Enum) \u001A.\u001A.\u0001.\u0004))
        return;
      \u000E.\u001F\u0005(hWnd, Keys.Up);
      direction &= ~\u001A.\u001A.\u0001.\u0004;
    }

    private static void \u001D\u0005(IntPtr hWnd, ref \u001A.\u001A.\u0001 direction, WaitHandle[] waitHandles, int time)
    {
      \u000E.\u001D\u0005(hWnd, Keys.Up, waitHandles, time);
    }

    private static void \u001D\u0005(IntPtr hWnd, WaitHandle[] waitHandles)
    {
      \u000E.\u001D\u0005(hWnd, Keys.ControlKey, waitHandles, 10);
    }

    private static void \u001D\u0005(IntPtr hWnd)
    {
      \u000E.\u001F\u0005(hWnd, Keys.ControlKey);
    }

    public static void \u001D\u0005(IntPtr hWnd, ManualResetEventSlim waitHandle)
    {
      \u000E.\u001E\u0005(hWnd, Keys.ShiftKey);
      \u000E.\u001D\u0005(hWnd, Keys.F1, waitHandle, 10);
      \u000E.\u001F\u0005(hWnd, Keys.ShiftKey);
    }

    public static List<PointF> \u001D\u0005(Dictionary<PointF, \u007F.\u007F> points_dic, PointF initial_location, PointF end_location)
    {
      HashSet<PointF> points = (HashSet<PointF>) null;
      if (points_dic != null)
        goto label_7;
label_6:
      return \u001A.\u001A.\u001D\u0005(points, initial_location, end_location);
label_7:
      points = new HashSet<PointF>();
      using (Dictionary<PointF, \u007F.\u007F>.Enumerator enumerator = points_dic.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          KeyValuePair<PointF, \u007F.\u007F> current = enumerator.Current;
          if (current.Value == \u007F.\u007F.\u0001)
            points.Add(current.Key);
        }
        goto label_6;
      }
    }

    public static List<PointF> \u001D\u0005(HashSet<PointF> points, PointF initial_location, PointF end_location)
    {
      List<PointF> pointFList = new List<PointF>();
      float num1 = \u0001.\u001D\u0005(initial_location, end_location);
      PointF p1 = initial_location;
      if (points != null)
      {
        while (true)
        {
          PointF? nullable = new PointF?();
          float num2 = num1;
          float num3 = num1;
          foreach (PointF point in points)
          {
            float num4 = \u0001.\u001D\u0005(point, end_location);
            if ((double) num4 < (double) num1)
            {
              float num5 = \u0001.\u001D\u0005(p1, point);
              if ((double) num5 < (double) num3 && \u0007\u0080.\u0086\u0082(point, initial_location) && \u0007\u0080.\u0086\u0082(point, end_location))
              {
                num3 = num5;
                num2 = num4;
                nullable = new PointF?(point);
              }
            }
          }
          if (nullable.HasValue)
          {
            num1 = num2;
            PointF pointF = nullable.Value;
            pointFList.Add(pointF);
            points.Remove(pointF);
            p1 = pointF;
          }
          else
            break;
        }
      }
      pointFList.Add(end_location);
      return pointFList;
    }

    [System.Flags]
    private enum \u0001
    {
      \u0001 = 0,
      \u0002 = 1,
      \u0003 = 2,
      \u0004 = 4,
    }
  }
}
