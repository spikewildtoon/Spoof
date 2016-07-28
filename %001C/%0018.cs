// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001C;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TSN.Collections;

namespace \u001C
{
  internal sealed class \u0018
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    public static readonly ReadOnlyDictionary<int, \u0018> \u0001;
    public static readonly ReadOnlyCollection<\u0018> \u0001;

    public int[] Beans
    {
      get
      {
        int[] numArray = new int[(int) this.CombinationSize];
        int numericCombination = this.NumericCombination;
        for (int index = 0; index < (int) this.CombinationSize; ++index)
        {
          numArray[index] = numericCombination % 10;
          numericCombination /= 10;
        }
        \u0096\u001B.\u008E\u0092((Array) numArray);
        return numArray;
      }
    }

    public char[] Combination { get; private set; }

    public string PlantName { get; private set; }

    public int NumericCombination { get; private set; }

    public byte CombinationSize { get; private set; }

    static \u0018()
    {
      // ISSUE: type reference
      \u0004.\u001D\u0005(\u009C\u0082.\u0016\u0097(__typeref (\u0018)));
      Dictionary<int, \u0018> dictionary = new Dictionary<int, \u0018>();
      dictionary.Add(2, new \u0018(\u0018.\u0001(59928), 2));
      dictionary.Add(3, new \u0018(\u0018.\u0001(59945), 3));
      dictionary.Add(6, new \u0018(\u0018.\u0001(59962), 6));
      dictionary.Add(7, new \u0018(\u0018.\u0001(59987), 7));
      dictionary.Add(8, new \u0018(\u0018.\u0001(60004), 8));
      dictionary.Add(28, new \u0018(\u0018.\u0001(60029), 28));
      dictionary.Add(38, new \u0018(\u0018.\u0001(60046), 38));
      dictionary.Add(67, new \u0018(\u0018.\u0001(60063), 67));
      dictionary.Add(71, new \u0018(\u0018.\u0001(60088), 71));
      dictionary.Add(82, new \u0018(\u0018.\u0001(60105), 82));
      dictionary.Add(111, new \u0018(\u0018.\u0001(60118), 111));
      dictionary.Add(311, new \u0018(\u0018.\u0001(60143), 311));
      dictionary.Add(611, new \u0018(\u0018.\u0001(60160), 611));
      dictionary.Add(712, new \u0018(\u0018.\u0001(60185), 712));
      dictionary.Add(833, new \u0018(\u0018.\u0001(60206), 833));
      dictionary.Add(1737, new \u0018(\u0018.\u0001(60223), 1737));
      dictionary.Add(2677, new \u0018(\u0018.\u0001(60236), 2677));
      dictionary.Add(3771, new \u0018(\u0018.\u0001(60253), 3771));
      dictionary.Add(7183, new \u0018(\u0018.\u0001(60270), 7183));
      dictionary.Add(8336, new \u0018(\u0018.\u0001(60291), 8336));
      dictionary.Add(26566, new \u0018(\u0018.\u0001(60308), 26566));
      dictionary.Add(41544, new \u0018(\u0018.\u0001(60337), 41544));
      dictionary.Add(61251, new \u0018(\u0018.\u0001(60346), 61251));
      dictionary.Add(71333, new \u0018(\u0018.\u0001(60367), 71333));
      dictionary.Add(81111, new \u0018(\u0018.\u0001(60388), 81111));
      dictionary.Add(163136, new \u0018(\u0018.\u0001(60405), 163136));
      dictionary.Add(366356, new \u0018(\u0018.\u0001(60422), 366356));
      dictionary.Add(411144, new \u0018(\u0018.\u0001(60439), 411144));
      dictionary.Add(758455, new \u0018(\u0018.\u0001(60448), 758455));
      dictionary.Add(814444, new \u0018(\u0018.\u0001(60465), 814444));
      dictionary.Add(6222272, new \u0018(\u0018.\u0001(60482), 6222272));
      dictionary.Add(7213222, new \u0018(\u0018.\u0001(60503), 7213222));
      dictionary.Add(8485855, new \u0018(\u0018.\u0001(60520), 8485855));
      dictionary.Add(5454855, new \u0018(\u0018.\u0001(60541), 5454855));
      dictionary.Add(1836488, new \u0018(\u0018.\u0001(60558), 1836488));
      dictionary.Add(75484134, new \u0018(\u0018.\u0001(60579), 75484134));
      dictionary.Add(85778577, new \u0018(\u0018.\u0001(60596), 85778577));
      dictionary.Add(56651377, new \u0018(\u0018.\u0001(60613), 56651377));
      dictionary.Add(15445565, new \u0018(\u0018.\u0001(60626), 15445565));
      dictionary.Add(47747347, new \u0018(\u0018.\u0001(60643), 47747347));
      \u0018.\u0001 = new ReadOnlyCollection<\u0018>((IList<\u0018>) dictionary.Values.ToList<\u0018>());
      \u0018.\u0001 = new ReadOnlyDictionary<int, \u0018>((IDictionary<int, \u0018>) dictionary);
    }

    private \u0018(string plantName)
    {
      if (\u008F\u0084.\u009E\u0092(plantName))
        throw new ArgumentNullException(\u0018.\u0001(60656));
      this.PlantName = plantName;
    }

    private \u0018(string plantName, int combination)
      : this(plantName)
    {
      string @string = combination.ToString();
      if (\u0005\u0081.\u007E\u0001\u0093((object) @string) > 8)
        throw new ArgumentException(\u0018.\u0001(60669));
      this.Combination = \u0084\u001E.\u007E\u009D\u0092((object) @string);
      this.NumericCombination = combination;
      this.CombinationSize = (byte) this.Combination.Length;
    }

    public override string ToString()
    {
      return \u0014\u0084.\u007F\u0093(\u0018.\u0001(60706), (object) this.PlantName, (object) this.\u001E\u0005());
    }

    private string \u001E\u0005()
    {
      string str = string.Empty;
      int length = this.Combination.Length;
      for (int index = 0; index < length; ++index)
      {
        switch (this.Combination[index])
        {
          case '1':
            str = \u0081\u0086.\u0086\u0093(str, \u0018.\u0001(60719));
            break;
          case '2':
            str = \u0081\u0086.\u0086\u0093(str, \u0018.\u0001(60724));
            break;
          case '3':
            str = \u0081\u0086.\u0086\u0093(str, \u0018.\u0001(60733));
            break;
          case '4':
            str = \u0081\u0086.\u0086\u0093(str, \u0018.\u0001(60742));
            break;
          case '5':
            str = \u0081\u0086.\u0086\u0093(str, \u0018.\u0001(60751));
            break;
          case '6':
            str = \u0081\u0086.\u0086\u0093(str, \u0018.\u0001(60760));
            break;
          case '7':
            str = \u0081\u0086.\u0086\u0093(str, \u0018.\u0001(60769));
            break;
          case '8':
            str = \u0081\u0086.\u0086\u0093(str, \u0018.\u0001(60778));
            break;
          case '9':
            str = \u0081\u0086.\u0086\u0093(str, \u0018.\u0001(60787));
            break;
        }
        if (index < length - 1)
          str = \u0081\u0086.\u0086\u0093(str, \u0018.\u0001(29199));
      }
      return str;
    }
  }
}
