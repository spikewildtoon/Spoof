// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0015;
using \u0017;
using \u0018;
using \u001A;
using \u001C;
using \u0081;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace \u0018
{
  internal sealed class \u0004 : Component
  {
    private \u0012 \u0001;
    private readonly Dictionary<\u0012, Dictionary<IntPtr, \u0004.\u0001>> \u0001;
    private \u0082.\u0018 \u0001;

    public \u0004(IContainer container)
    {
      \u0007\u0083.\u007E\u008B\u0001\u0002((object) container, (IComponent) this);
      this.\u0001 = new Dictionary<\u0012, Dictionary<IntPtr, \u0004.\u0001>>();
      this.\u0001 = new \u0012();
      // ISSUE: method pointer
      this.\u0001.HotkeyActivated += new EventHandler<\u0018.\u0014>((object) this, __methodptr(\u001D\u0005));
      this.\u0001 = \u0080.Instance.ApplicationSettings;
    }

    public void \u001D\u0005()
    {
      if (\u0001.DesignMode)
        return;
      bool flag = false;
      Dictionary<\u0012, Dictionary<IntPtr, \u0004.\u0001>> dictionary;
      try
      {
        \u0098\u0082.\u0081\u0098((object) (dictionary = this.\u0001), ref flag);
        foreach (\u0012 key in this.\u0001.Hotkeys.Keys)
          this.\u0001.\u001D\u0005(key, true, (object) null, (EventHandler<\u0018.\u0014>) null);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098((object) dictionary);
      }
    }

    public void \u001E\u0005()
    {
      if (\u0001.DesignMode)
        return;
      bool flag = false;
      Dictionary<\u0012, Dictionary<IntPtr, \u0004.\u0001>> dictionary;
      try
      {
        \u0098\u0082.\u0081\u0098((object) (dictionary = this.\u0001), ref flag);
        foreach (\u0012 key in this.\u0001.Hotkeys.Keys)
          this.\u0001.\u001E\u0005(key);
        foreach (KeyValuePair<\u0012, Dictionary<IntPtr, \u0004.\u0001>> keyValuePair in this.\u0001)
        {
          foreach (\u0004.\u0001 obj in keyValuePair.Value.Values)
          {
            obj.\u0080\u0005(true);
            obj.Dispose();
          }
          keyValuePair.Value.Clear();
        }
        this.\u0001.Clear();
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098((object) dictionary);
      }
    }

    private void \u001D\u0005(\u0004.\u0001 hotkey, bool processEndEvents)
    {
      hotkey.\u0080\u0005(processEndEvents);
      hotkey.Dispose();
      if (!this.\u0001.ContainsKey(hotkey.\u0001.Hotkey))
        return;
      Dictionary<IntPtr, \u0004.\u0001> dictionary = this.\u0001[hotkey.\u0001.Hotkey];
      dictionary.Remove(hotkey.\u0001);
      if (dictionary.Count != 0)
        return;
      this.\u0001.Remove(hotkey.\u0001.Hotkey);
    }

    private void \u001D\u0005(object sender, \u0018.\u0014 e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      int num = \u001E\u001F.\u009A\u0098(new WaitCallback((object) new \u0004.\u0002() { \u0001 = e, \u0001 = this }, __methodptr(\u001D\u0005)), (object) null) ? 1 : 0;
    }

    protected override void Dispose(bool disposing)
    {
      this.\u001E\u0005();
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u0080\u0001\u0002((object) this, disposing);
    }

    private sealed class \u0001 : \u0016
    {
      private static \u0004.\u0001 \u0001;
      public readonly \u0014.\u0081 \u0001;
      public readonly IntPtr \u0001;
      private readonly Process \u0001;
      private bool \u0001;
      private readonly System.Timers.Timer \u0001;
      private readonly System.Timers.Timer \u0002;
      private Point \u0001;

      public event EventHandler Terminated;

      public \u0001(IntPtr toonTownHandle, Process toontownProcess, \u0014.\u0081 hotkeySettings)
      {
        this.\u0001 = toonTownHandle;
        this.\u0001 = toontownProcess;
        this.\u0001 = hotkeySettings;
        if (this.\u0001.RepeatKeyPress || this.\u0001.ReleaseKey)
        {
          this.\u0001 = new System.Timers.Timer();
          \u0010\u0081.\u007E\u0097\u0003\u0002((object) this.\u0001, new ElapsedEventHandler(this.\u001D\u0005));
        }
        if (!this.\u0001.MoveMouse)
          return;
        this.\u0002 = new System.Timers.Timer();
        \u0010\u0081.\u007E\u0097\u0003\u0002((object) this.\u0002, new ElapsedEventHandler(this.\u001E\u0005));
        \u0002\u001D.\u007E\u0096\u0003\u0002((object) this.\u0002, (double) this.\u0001.MoveMouseRate);
      }

      private void \u001D\u0005(object sender, EventArgs e)
      {
        this.\u0081\u0005();
      }

      private void \u0081\u0005()
      {
        if (!this.\u0001 || !this.\u0001.ReleaseKey)
        {
          this.\u0001 = true;
          this.\u0083\u0005();
          if (!this.\u0001.ReleaseKey)
            return;
          \u0002\u001D.\u007E\u0096\u0003\u0002((object) this.\u0001, (double) this.\u0001.KeyReleaseDelay);
        }
        else
        {
          this.\u0001 = false;
          this.\u0084\u0005();
          if (this.\u0001.RepeatKeyPress)
          {
            \u0002\u001D.\u007E\u0096\u0003\u0002((object) this.\u0001, (double) this.\u0001.KeyPressRepeatRate);
          }
          else
          {
            \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, false);
            if (this.\u0001 == null)
              return;
            \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
          }
        }
      }

      private void \u001E\u0005(object sender, EventArgs e)
      {
        \u0004.\u0001 obj = Interlocked.CompareExchange<\u0004.\u0001>(ref \u0004.\u0001.\u0001, this, (\u0004.\u0001) null);
        Point point = \u0098\u0080.\u009F\u0089();
        if (obj == this && \u001D\u0081.\u001F\u0080(point, this.\u0001))
        {
          int num = \u0015.\u0017.Instance.\u001D\u0005(0, 4);
          Rectangle rectangle = \u008D\u0084.\u007E\u0015\u008F((object) \u0092\u0082.\u0016\u008F(point));
          switch (num)
          {
            case 0:
              if (point.X != rectangle.Left)
              {
                \u000E.\u001D\u0005(new Point(point.X - 1, point.Y));
                break;
              }
              goto case 1;
            case 1:
              if (point.X != rectangle.Right)
              {
                \u000E.\u001D\u0005(new Point(point.X + 1, point.Y));
                break;
              }
              goto case 0;
            case 2:
              if (point.Y != rectangle.Top)
              {
                \u000E.\u001D\u0005(new Point(point.X, point.Y - 1));
                break;
              }
              goto case 3;
            case 3:
              if (point.Y != rectangle.Bottom)
              {
                \u000E.\u001D\u0005(new Point(point.X, point.Y + 1));
                break;
              }
              goto case 2;
          }
        }
        this.\u0001 = \u0098\u0080.\u009F\u0089();
      }

      public void \u0082\u0005()
      {
        this.\u0081\u0005();
        bool flag = this.\u0001.RepeatKeyPress || this.\u0001.ReleaseKey;
        if (flag || this.\u0001.MoveMouse)
        {
          if (flag)
            \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, true);
          if (!this.\u0001.MoveMouse)
            return;
          Interlocked.CompareExchange<\u0004.\u0001>(ref \u0004.\u0001.\u0001, this, (\u0004.\u0001) null);
          this.\u0001 = \u0098\u0080.\u009F\u0089();
          \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0002, true);
        }
        else
        {
          if (this.\u0001 == null)
            return;
          \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, EventArgs.Empty);
        }
      }

      public void \u0080\u0005(bool processEndEvents)
      {
        if (this.\u0001.RepeatKeyPress || this.\u0001.ReleaseKey)
        {
          \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, false);
          if (processEndEvents && this.\u0001)
            this.\u0084\u0005();
        }
        if (!this.\u0001.MoveMouse)
          return;
        \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0002, false);
        Interlocked.CompareExchange<\u0004.\u0001>(ref \u0004.\u0001.\u0001, (\u0004.\u0001) null, this);
      }

      private void \u0083\u0005()
      {
        if (this.\u0001.KeyToPress == Keys.Control)
        {
          \u000E.\u001D\u0005(this.\u0001, \u001B.\u0083\u0002, 17, 0);
        }
        else
        {
          if (this.\u0001.KeyToPress == Keys.None)
            return;
          \u000E.\u001E\u0005(this.\u0001, this.\u0001.KeyToPress);
        }
      }

      private void \u0084\u0005()
      {
        if (this.\u0001.KeyToPress == Keys.Control)
        {
          \u000E.\u001D\u0005(this.\u0001, \u001B.\u0084\u0002, 17, 0);
        }
        else
        {
          if (this.\u0001.KeyToPress == Keys.None)
            return;
          \u000E.\u001F\u0005(this.\u0001, this.\u0001.KeyToPress);
        }
      }

      protected override void \u001D\u0005()
      {
        if (this.\u0001 != null)
        {
          \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0001, false);
          \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
        }
        if (this.\u0002 != null)
        {
          \u0099\u001F.\u007E\u0095\u0003\u0002((object) this.\u0002, false);
          \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0002);
        }
        if (this.\u0001 != null)
          \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0001);
        base.\u001D\u0005();
      }
    }
  }
}
