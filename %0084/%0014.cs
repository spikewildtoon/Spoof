// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0084;
using System.Drawing;

namespace \u0084
{
  internal struct \u0014
  {
    private static readonly int \u0001 = 6;
    private static readonly int \u0002 = \u0014.\u0001 << 1;

    public Rectangle ClientRectangle { get; private set; }

    public Rectangle Bottom
    {
      get
      {
        Rectangle clientRectangle = this.ClientRectangle;
        clientRectangle.Y = clientRectangle.Bottom - \u0014.\u0001 + 1;
        clientRectangle.Height = \u0014.\u0001;
        return clientRectangle;
      }
    }

    public Rectangle BottomRight
    {
      get
      {
        Rectangle clientRectangle = this.ClientRectangle;
        clientRectangle.Y = clientRectangle.Bottom - \u0014.\u0002 + 1;
        clientRectangle.Height = \u0014.\u0002;
        clientRectangle.X = clientRectangle.Width - \u0014.\u0002 + 1;
        clientRectangle.Width = \u0014.\u0002;
        return clientRectangle;
      }
    }

    public Rectangle Top
    {
      get
      {
        Rectangle clientRectangle = this.ClientRectangle;
        clientRectangle.Height = \u0014.\u0001;
        return clientRectangle;
      }
    }

    public Rectangle TopRight
    {
      get
      {
        Rectangle clientRectangle = this.ClientRectangle;
        clientRectangle.Height = \u0014.\u0002;
        clientRectangle.X = clientRectangle.Width - \u0014.\u0002 + 1;
        clientRectangle.Width = \u0014.\u0002;
        return clientRectangle;
      }
    }

    public Rectangle Left
    {
      get
      {
        Rectangle clientRectangle = this.ClientRectangle;
        clientRectangle.Width = \u0014.\u0001;
        return clientRectangle;
      }
    }

    public Rectangle BottomLeft
    {
      get
      {
        Rectangle clientRectangle = this.ClientRectangle;
        clientRectangle.Width = \u0014.\u0002;
        clientRectangle.Y = clientRectangle.Height - \u0014.\u0002 + 1;
        clientRectangle.Height = \u0014.\u0002;
        return clientRectangle;
      }
    }

    public Rectangle Right
    {
      get
      {
        Rectangle clientRectangle = this.ClientRectangle;
        clientRectangle.X = clientRectangle.Right - \u0014.\u0001 + 1;
        clientRectangle.Width = \u0014.\u0001;
        return clientRectangle;
      }
    }

    public Rectangle TopLeft
    {
      get
      {
        Rectangle clientRectangle = this.ClientRectangle;
        clientRectangle.Width = \u0014.\u0002;
        clientRectangle.Height = \u0014.\u0002;
        return clientRectangle;
      }
    }

    public \u0014(Rectangle clientRectangle)
    {
      this = new \u0014();
      this.ClientRectangle = clientRectangle;
    }
  }
}
