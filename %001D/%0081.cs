// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

namespace \u001D
{
  internal sealed class \u0081
  {
    public string AudioFile { get; private set; }

    public byte[] UserAudioData { get; private set; }

    public byte[] ToonTownAudioData { get; private set; }

    public \u0081(string audioFile, byte[] userAudioData, byte[] toonTownAudioData)
    {
      this.AudioFile = audioFile;
      this.UserAudioData = userAudioData;
      this.ToonTownAudioData = toonTownAudioData;
    }
  }
}
