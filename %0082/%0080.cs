// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0015;
using \u0016;
using \u007F;
using \u0082;
using System.Collections.Generic;
using System.IO;

namespace \u0082
{
  internal sealed class \u0080
  {
    public \u0010 Action { get; private set; }

    public \u001F.\u0015 UpdateStep { get; private set; }

    public List<string> ExtraData { get; private set; }

    public List<bool> ExtraDataIsRTF { get; private set; }

    public \u0080 ResponseType { get; private set; }

    public int Progress { get; private set; }

    public int ProcessID { get; private set; }

    public \u0080()
    {
      this.Progress = -1;
      this.ResponseType = \u0080.\u0002;
      this.ExtraDataIsRTF = new List<bool>();
      this.ExtraData = new List<string>();
    }

    public \u0080(\u0010 action)
      : this()
    {
      this.Action = action;
    }

    public \u0080(\u001F.\u0015 step)
      : this()
    {
      this.Action = \u0010.\u0001;
      this.UpdateStep = step;
    }

    public \u0080(\u0080 responseType, \u001F.\u0015 step, string messageTitle, string messageBody)
      : this(step)
    {
      this.ResponseType = responseType;
      this.ExtraData.Add(messageTitle);
      this.ExtraData.Add(messageBody);
      this.ExtraDataIsRTF.Add(false);
      this.ExtraDataIsRTF.Add(false);
    }

    public byte[] \u001D\u0005()
    {
      MemoryStream memoryStream = new MemoryStream();
      try
      {
        \u0013.\u001D\u0005((Stream) memoryStream, (byte) 1, (int) this.Action);
        \u0013.\u001D\u0005((Stream) memoryStream, (byte) 2, (int) this.UpdateStep);
        for (int index = 0; index < this.ExtraData.Count; ++index)
        {
          if (!\u008F\u0084.\u009E\u0092(this.ExtraData[index]))
          {
            if (this.ExtraDataIsRTF[index])
              \u0095\u001F.\u007E\u0090\u009D((object) memoryStream, (byte) 128);
            \u0013.\u001D\u0005((Stream) memoryStream, (byte) 3, this.ExtraData[index]);
          }
        }
        if (this.ProcessID != 0)
          \u0013.\u001D\u0005((Stream) memoryStream, (byte) 4, this.ProcessID);
        if (this.Progress > -1 && this.Progress <= 100)
          \u0013.\u001D\u0005((Stream) memoryStream, (byte) 5, this.Progress);
        if (this.ResponseType != \u0080.\u0002)
          \u0013.\u001D\u0005((Stream) memoryStream, (byte) 6, (int) this.ResponseType);
        \u0095\u001F.\u007E\u0090\u009D((object) memoryStream, byte.MaxValue);
        return \u0086\u0083.\u007E\u0003\u009F((object) memoryStream);
      }
      finally
      {
        if (memoryStream != null)
          \u001A\u001E.\u007E\u0094\u0092((object) memoryStream);
      }
    }

    public static \u0080 \u001D\u0005(byte[] data)
    {
      \u0080 obj = new \u0080();
      MemoryStream memoryStream = new MemoryStream(data);
      try
      {
        for (byte index = (byte) \u0005\u0081.\u007E\u008E\u009D((object) memoryStream); !\u0081.\u001D\u0005((Stream) memoryStream, index, byte.MaxValue); index = (byte) \u0005\u0081.\u007E\u008E\u009D((object) memoryStream))
        {
          switch (index)
          {
            case 1:
              obj.Action = (\u0010) \u0081.\u001D\u0005((Stream) memoryStream);
              break;
            case 2:
              obj.UpdateStep = (\u001F.\u0015) \u0081.\u001D\u0005((Stream) memoryStream);
              break;
            case 3:
              obj.ExtraData.Add(\u0081.\u001D\u0005((Stream) memoryStream));
              if (obj.ExtraDataIsRTF.Count != obj.ExtraData.Count)
              {
                obj.ExtraDataIsRTF.Add(false);
                break;
              }
              break;
            case 4:
              obj.ProcessID = \u0081.\u001D\u0005((Stream) memoryStream);
              break;
            case 5:
              obj.Progress = \u0081.\u001D\u0005((Stream) memoryStream);
              break;
            case 6:
              obj.ResponseType = (\u0080) \u0081.\u001D\u0005((Stream) memoryStream);
              break;
            case 128:
              obj.ExtraDataIsRTF.Add(true);
              break;
            default:
              \u0081.\u001D\u0005((Stream) memoryStream, index);
              break;
          }
        }
      }
      finally
      {
        if (memoryStream != null)
          \u001A\u001E.\u007E\u0094\u0092((object) memoryStream);
      }
      return obj;
    }
  }
}
