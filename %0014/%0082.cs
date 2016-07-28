// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0014;
using \u001D;
using \u0081;
using \u0083;
using System;
using System.IO;

namespace \u0014
{
  internal sealed class \u0082 : \u0080, IDisposable
  {
    public static readonly byte[] \u0001 = new byte[4]{ (byte) 71, (byte) 70, (byte) 67, (byte) 83 };

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
        return \u0082.\u0001;
      }
    }

    public \u0013 PlantFlowerBounds { get; set; }

    public \u0018 PlantFlowerCapture { get; set; }

    public \u0013 WaterPlantBounds { get; set; }

    public \u0018 WaterPlantCapture { get; set; }

    public \u0013 PickFlowerBounds { get; set; }

    public \u0018 PickFlowerCapture { get; set; }

    public \u0013 FinalPlantBounds { get; set; }

    public \u0018 FinalPlantCapture { get; set; }

    public \u0013 PlantFailedBounds { get; set; }

    public \u0018 PlantFailedCapture { get; set; }

    public \u0013 PlantSuccessBounds { get; set; }

    public \u0018 PlantSuccessCapture { get; set; }

    public \u0013 NoWaterBounds { get; set; }

    public \u0018 NoWaterCapture { get; set; }

    public \u0013 BasketFullBounds { get; set; }

    public \u0018 BasketFullCapture { get; set; }

    public \u0013 SellFlowersBounds { get; set; }

    public \u0018 SellFlowersCapture { get; set; }

    public \u0013 DisabledBeanSlotBounds { get; set; }

    public \u0018 DisabledBeanSlotCapture { get; set; }

    public \u0013 FinalPickBounds { get; set; }

    public \u0018 FinalPickCapture { get; set; }

    public \u0013 CancelPlantBounds { get; set; }

    public \u0018 CancelPlantCapture { get; set; }

    public \u0013 NoRemoveBounds { get; set; }

    public \u0018 NoRemoveCapture { get; set; }

    public \u0082()
    {
    }

    public \u0082(string filePath)
      : base(filePath)
    {
    }

    protected override void \u001D\u0005(BinaryReader reader, int version)
    {
      this.PlantFlowerBounds = reader.\u001D\u0005();
      this.PlantFlowerCapture = reader.\u001D\u0005();
      this.WaterPlantBounds = reader.\u001D\u0005();
      this.WaterPlantCapture = reader.\u001D\u0005();
      this.PickFlowerBounds = reader.\u001D\u0005();
      this.PickFlowerCapture = reader.\u001D\u0005();
      this.FinalPlantBounds = reader.\u001D\u0005();
      this.FinalPlantCapture = reader.\u001D\u0005();
      this.PlantFailedBounds = reader.\u001D\u0005();
      this.PlantFailedCapture = reader.\u001D\u0005();
      this.PlantSuccessBounds = reader.\u001D\u0005();
      this.PlantSuccessCapture = reader.\u001D\u0005();
      this.NoWaterBounds = reader.\u001D\u0005();
      this.NoWaterCapture = reader.\u001D\u0005();
      this.BasketFullBounds = reader.\u001D\u0005();
      this.BasketFullCapture = reader.\u001D\u0005();
      this.SellFlowersBounds = reader.\u001D\u0005();
      this.SellFlowersCapture = reader.\u001D\u0005();
      this.DisabledBeanSlotBounds = reader.\u001D\u0005();
      this.DisabledBeanSlotCapture = reader.\u001D\u0005();
      this.FinalPickBounds = reader.\u001D\u0005();
      this.FinalPickCapture = reader.\u001D\u0005();
      this.CancelPlantBounds = reader.\u001D\u0005();
      this.CancelPlantCapture = reader.\u001D\u0005();
      this.NoRemoveBounds = reader.\u001D\u0005();
      this.NoRemoveCapture = reader.\u001D\u0005();
    }

    protected override void \u001D\u0005(BinaryWriter writer)
    {
      writer.\u001D\u0005(this.PlantFlowerBounds);
      writer.\u001D\u0005(this.PlantFlowerCapture);
      writer.\u001D\u0005(this.WaterPlantBounds);
      writer.\u001D\u0005(this.WaterPlantCapture);
      writer.\u001D\u0005(this.PickFlowerBounds);
      writer.\u001D\u0005(this.PickFlowerCapture);
      writer.\u001D\u0005(this.FinalPlantBounds);
      writer.\u001D\u0005(this.FinalPlantCapture);
      writer.\u001D\u0005(this.PlantFailedBounds);
      writer.\u001D\u0005(this.PlantFailedCapture);
      writer.\u001D\u0005(this.PlantSuccessBounds);
      writer.\u001D\u0005(this.PlantSuccessCapture);
      writer.\u001D\u0005(this.NoWaterBounds);
      writer.\u001D\u0005(this.NoWaterCapture);
      writer.\u001D\u0005(this.BasketFullBounds);
      writer.\u001D\u0005(this.BasketFullCapture);
      writer.\u001D\u0005(this.SellFlowersBounds);
      writer.\u001D\u0005(this.SellFlowersCapture);
      writer.\u001D\u0005(this.DisabledBeanSlotBounds);
      writer.\u001D\u0005(this.DisabledBeanSlotCapture);
      writer.\u001D\u0005(this.FinalPickBounds);
      writer.\u001D\u0005(this.FinalPickCapture);
      writer.\u001D\u0005(this.CancelPlantBounds);
      writer.\u001D\u0005(this.CancelPlantCapture);
      writer.\u001D\u0005(this.NoRemoveBounds);
      writer.\u001D\u0005(this.NoRemoveCapture);
    }

    public void \u001D\u0005()
    {
      if (this.PlantFlowerCapture != null)
        this.PlantFlowerCapture.\u0081\u0005();
      if (this.WaterPlantCapture != null)
        goto label_26;
label_2:
      if (this.PickFlowerCapture != null)
        this.PickFlowerCapture.\u0081\u0005();
      if (this.FinalPlantCapture != null)
        this.FinalPlantCapture.\u0081\u0005();
      if (this.PlantFailedCapture != null)
        this.PlantFailedCapture.\u0081\u0005();
      if (this.PlantSuccessCapture != null)
        this.PlantSuccessCapture.\u0081\u0005();
      if (this.NoWaterCapture != null)
        this.NoWaterCapture.\u0081\u0005();
      if (this.BasketFullCapture != null)
        this.BasketFullCapture.\u0081\u0005();
      if (this.SellFlowersCapture != null)
        this.SellFlowersCapture.\u0081\u0005();
      if (this.DisabledBeanSlotCapture != null)
        this.DisabledBeanSlotCapture.\u0081\u0005();
      if (this.FinalPickCapture != null)
        this.FinalPickCapture.\u0081\u0005();
      if (this.CancelPlantCapture != null)
        this.CancelPlantCapture.\u0081\u0005();
      if (this.NoRemoveCapture == null)
        return;
      this.NoRemoveCapture.\u0081\u0005();
      return;
label_26:
      this.WaterPlantCapture.\u0081\u0005();
      goto label_2;
    }

    public void Dispose()
    {
      if (this.PlantFlowerCapture != null)
        this.PlantFlowerCapture.Dispose();
      if (this.WaterPlantCapture != null)
        goto label_26;
label_2:
      if (this.PickFlowerCapture != null)
        this.PickFlowerCapture.Dispose();
      if (this.FinalPlantCapture != null)
        this.FinalPlantCapture.Dispose();
      if (this.PlantFailedCapture != null)
        this.PlantFailedCapture.Dispose();
      if (this.PlantSuccessCapture != null)
        this.PlantSuccessCapture.Dispose();
      if (this.NoWaterCapture != null)
        this.NoWaterCapture.Dispose();
      if (this.BasketFullCapture != null)
        this.BasketFullCapture.Dispose();
      if (this.SellFlowersCapture != null)
        this.SellFlowersCapture.Dispose();
      if (this.DisabledBeanSlotCapture != null)
        this.DisabledBeanSlotCapture.Dispose();
      if (this.FinalPickCapture != null)
        this.FinalPickCapture.Dispose();
      if (this.CancelPlantCapture != null)
        this.CancelPlantCapture.Dispose();
      if (this.NoRemoveCapture == null)
        return;
      this.NoRemoveCapture.Dispose();
      return;
label_26:
      this.WaterPlantCapture.Dispose();
      goto label_2;
    }
  }
}
