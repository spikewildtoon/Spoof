// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.Collections.Generic;

namespace \u0084
{
  internal sealed class \u0008
  {
    public string ModelPath { get; private set; }

    public HashSet<string> ImagePaths { get; private set; }

    public HashSet<string> Directories { get; private set; }

    public \u0008(string modelpath, HashSet<string> imagePaths, HashSet<string> directories)
    {
      this.ModelPath = modelpath;
      this.ImagePaths = imagePaths;
      this.Directories = directories;
    }
  }
}
