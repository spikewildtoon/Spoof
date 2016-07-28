// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0014;
using \u001D;
using \u0081;
using \u0083;
using System;
using System.IO;

namespace \u001C
{
  internal sealed class \u0082 : \u0080, IDisposable
  {
    protected override int? Version
    {
      get
      {
        return new int?(1);
      }
    }

    protected override int MaximumVersion
    {
      get
      {
        return 1;
      }
    }

    protected override int MinimumVersion
    {
      get
      {
        return 1;
      }
    }

    protected override byte[] Header
    {
      get
      {
        return new byte[4]{ (byte) 74, (byte) 67, (byte) 70, (byte) 83 };
      }
    }

    public \u0013 CastBounds { get; set; }

    public \u0018 CastCapture { get; set; }

    public \u0013 ExitFishingBounds { get; set; }

    public \u0018 ExitFishingCapture { get; set; }

    public \u0013 FishCaughtDuringBingoBounds { get; set; }

    public \u0018 FishCaughtDuringBingoCapture { get; set; }

    public \u0013 FishCaughtBounds { get; set; }

    public \u0018 FishCaughtCapture { get; set; }

    public \u0013 BootCaughtBounds { get; set; }

    public \u0018 BootCaughtCapture { get; set; }

    public \u0013 BucketFullBounds { get; set; }

    public \u0018 BucketFullCapture { get; set; }

    public \u0013 SellFishBounds { get; set; }

    public \u0018 SellFishCapture { get; set; }

    public \u0013 NoBeansBounds { get; set; }

    public \u0018 NoBeansCapture { get; set; }

    public \u0013 EstateSellFishBounds { get; set; }

    public \u0018 EstateSellFishCapture { get; set; }

    public \u0013 NewSpeciesBounds { get; set; }

    public \u0018 NewSpeciesCapture { get; set; }

    public \u0013 NewSpeciesDuringBingoBounds { get; set; }

    public \u0018 NewSpeciesDuringBingoCapture { get; set; }

    public \u0082()
    {
    }

    public \u0082(string filePath)
      : base(filePath)
    {
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.CastBounds = reader.\u001D\u0005();
      this.CastCapture = reader.\u001D\u0005();
      this.ExitFishingBounds = reader.\u001D\u0005();
      this.ExitFishingCapture = reader.\u001D\u0005();
      this.FishCaughtBounds = reader.\u001D\u0005();
      this.FishCaughtCapture = reader.\u001D\u0005();
      this.FishCaughtDuringBingoBounds = reader.\u001D\u0005();
      this.FishCaughtDuringBingoCapture = reader.\u001D\u0005();
      this.BootCaughtBounds = reader.\u001D\u0005();
      this.BootCaughtCapture = reader.\u001D\u0005();
      this.BucketFullBounds = reader.\u001D\u0005();
      this.BucketFullCapture = reader.\u001D\u0005();
      this.SellFishBounds = reader.\u001D\u0005();
      this.SellFishCapture = reader.\u001D\u0005();
      this.NoBeansBounds = reader.\u001D\u0005();
      this.NoBeansCapture = reader.\u001D\u0005();
      this.EstateSellFishBounds = reader.\u001D\u0005();
      this.EstateSellFishCapture = reader.\u001D\u0005();
      this.NewSpeciesBounds = reader.\u001D\u0005();
      this.NewSpeciesCapture = reader.\u001D\u0005();
      this.NewSpeciesDuringBingoBounds = reader.\u001D\u0005();
      this.NewSpeciesDuringBingoCapture = reader.\u001D\u0005();
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      writer.\u001D\u0005(this.CastBounds);
      writer.\u001D\u0005(this.CastCapture);
      writer.\u001D\u0005(this.ExitFishingBounds);
      writer.\u001D\u0005(this.ExitFishingCapture);
      writer.\u001D\u0005(this.FishCaughtBounds);
      writer.\u001D\u0005(this.FishCaughtCapture);
      writer.\u001D\u0005(this.FishCaughtDuringBingoBounds);
      writer.\u001D\u0005(this.FishCaughtDuringBingoCapture);
      writer.\u001D\u0005(this.BootCaughtBounds);
      writer.\u001D\u0005(this.BootCaughtCapture);
      writer.\u001D\u0005(this.BucketFullBounds);
      writer.\u001D\u0005(this.BucketFullCapture);
      writer.\u001D\u0005(this.SellFishBounds);
      writer.\u001D\u0005(this.SellFishCapture);
      writer.\u001D\u0005(this.NoBeansBounds);
      writer.\u001D\u0005(this.NoBeansCapture);
      writer.\u001D\u0005(this.EstateSellFishBounds);
      writer.\u001D\u0005(this.EstateSellFishCapture);
      writer.\u001D\u0005(this.NewSpeciesBounds);
      writer.\u001D\u0005(this.NewSpeciesCapture);
      writer.\u001D\u0005(this.NewSpeciesDuringBingoBounds);
      writer.\u001D\u0005(this.NewSpeciesDuringBingoCapture);
    }

    public void \u001D\u0005()
    {
      if (this.BootCaughtCapture != null)
        this.BootCaughtCapture.\u0081\u0005();
      if (this.BucketFullCapture != null)
        goto label_22;
label_2:
      if (this.CastCapture != null)
        this.CastCapture.\u0081\u0005();
      if (this.EstateSellFishCapture != null)
        this.EstateSellFishCapture.\u0081\u0005();
      if (this.ExitFishingCapture != null)
        this.ExitFishingCapture.\u0081\u0005();
      if (this.FishCaughtCapture != null)
        this.FishCaughtCapture.\u0081\u0005();
      if (this.FishCaughtDuringBingoCapture != null)
        this.FishCaughtDuringBingoCapture.\u0081\u0005();
      if (this.NewSpeciesCapture != null)
        this.NewSpeciesCapture.\u0081\u0005();
      if (this.NewSpeciesDuringBingoCapture != null)
        this.NewSpeciesDuringBingoCapture.\u0081\u0005();
      if (this.NoBeansCapture != null)
        this.NoBeansCapture.\u0081\u0005();
      if (this.SellFishCapture == null)
        return;
      this.SellFishCapture.\u0081\u0005();
      return;
label_22:
      this.BucketFullCapture.\u0081\u0005();
      goto label_2;
    }

    public void Dispose()
    {
      if (this.BootCaughtCapture != null)
        this.BootCaughtCapture.Dispose();
      if (this.BucketFullCapture != null)
        goto label_22;
label_2:
      if (this.CastCapture != null)
        this.CastCapture.Dispose();
      if (this.EstateSellFishCapture != null)
        this.EstateSellFishCapture.Dispose();
      if (this.ExitFishingCapture != null)
        this.ExitFishingCapture.Dispose();
      if (this.FishCaughtCapture != null)
        this.FishCaughtCapture.Dispose();
      if (this.FishCaughtDuringBingoCapture != null)
        this.FishCaughtDuringBingoCapture.Dispose();
      if (this.NewSpeciesCapture != null)
        this.NewSpeciesCapture.Dispose();
      if (this.NewSpeciesDuringBingoCapture != null)
        this.NewSpeciesDuringBingoCapture.Dispose();
      if (this.NoBeansCapture != null)
        this.NoBeansCapture.Dispose();
      if (this.SellFishCapture == null)
        return;
      this.SellFishCapture.Dispose();
      return;
label_22:
      this.BucketFullCapture.Dispose();
      goto label_2;
    }
  }
}
