// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001F;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace \u001F
{
  internal sealed class \u0005 : TaskScheduler
  {
    private readonly LinkedList<Task> \u0001 = new LinkedList<Task>();
    [NonSerialized]
    internal static \u0002 \u0001;
    [ThreadStatic]
    private static bool \u0001;
    private readonly int \u0001;
    private int \u0002;

    public override sealed int MaximumConcurrencyLevel
    {
      get
      {
        return this.\u0001;
      }
    }

    static \u0005()
    {
      \u0004.\u001D\u0005(typeof (\u0005));
    }

    public \u0005(int maxDegreeOfParallelism)
    {
      if (maxDegreeOfParallelism < 1)
        throw new ArgumentOutOfRangeException(\u0005.\u0001(68459));
      this.\u0001 = maxDegreeOfParallelism;
    }

    protected override sealed void QueueTask(Task task)
    {
      bool flag = false;
      LinkedList<Task> linkedList;
      try
      {
        \u0098\u0082.\u0081\u0098((object) (linkedList = this.\u0001), ref flag);
        this.\u0001.AddLast(task);
        if (this.\u0002 >= this.\u0001)
          return;
        ++this.\u0002;
        this.\u001D\u0005();
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098((object) linkedList);
      }
    }

    private void \u001D\u0005()
    {
      // ISSUE: method pointer
      int num = \u001E\u001F.\u009A\u0098(new WaitCallback((object) this, __methodptr(\u001D\u0005)), (object) null) ? 1 : 0;
    }

    protected override sealed bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
    {
      if (!\u0005.\u0001)
        return false;
      if (taskWasPreviouslyQueued)
      {
        int num = \u0099\u0080.\u007E\u0081\u0099((object) this, task) ? 1 : 0;
      }
      return \u0099\u0080.\u0083\u0099((object) this, task);
    }

    protected override sealed bool TryDequeue(Task task)
    {
      bool flag = false;
      LinkedList<Task> linkedList;
      try
      {
        \u0098\u0082.\u0081\u0098((object) (linkedList = this.\u0001), ref flag);
        return this.\u0001.Remove(task);
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098((object) linkedList);
      }
    }

    protected override sealed IEnumerable<Task> GetScheduledTasks()
    {
      bool flag = false;
      try
      {
        \u0098\u0082.\u0083\u0098((object) this.\u0001, ref flag);
        if (flag)
          return (IEnumerable<Task>) this.\u0001.ToArray<Task>();
        throw new NotSupportedException();
      }
      finally
      {
        if (flag)
          \u001A\u001E.\u0082\u0098((object) this.\u0001);
      }
    }
  }
}
