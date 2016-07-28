// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u001A;
using \u001E;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Schema;

namespace \u001B
{
  internal sealed class \u0018
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    public readonly SortedList<DateTime, KeyValuePair<Version, string[]>> \u0001;

    static \u0018()
    {
      \u0004.\u001D\u0005(typeof (\u001B.\u0018));
      \u001B.\u0018.\u0001 = \u001B.\u0018.\u0001(55395);
      \u001B.\u0018.\u0002 = \u001B.\u0018.\u0001(55408);
      \u001B.\u0018.\u0003 = \u001B.\u0018.\u0001(55457);
      \u001B.\u0018.\u0004 = \u001B.\u0018.\u0001(55470);
      \u001B.\u0018.\u0005 = \u001B.\u0018.\u0001(55479);
    }

    public \u0018()
    {
      this.\u0001 = \u001B.\u0018.\u001D\u0005(\u007F.\u0018);
    }

    private static SortedList<DateTime, KeyValuePair<Version, string[]>> \u001D\u0005(string filePath)
    {
      XmlDocument xmlDocument = \u001B.\u0018.\u001D\u0005(filePath);
      XmlElement xmlElement = \u0080\u001C.\u007E\u0096\u0004\u0002((object) xmlDocument, \u001B.\u0018.\u0003);
      if (xmlDocument == null || xmlElement == null || \u0005\u0081.\u007E\u0098\u0004\u0002((object) \u0010\u0084.\u007E\u0092\u0004\u0002((object) xmlElement)) == 0)
        return (SortedList<DateTime, KeyValuePair<Version, string[]>>) null;
      XmlNode xmlNode1 = (XmlNode) null;
      SortedList<DateTime, KeyValuePair<Version, string[]>> sortedList = (SortedList<DateTime, KeyValuePair<Version, string[]>>) null;
      try
      {
        sortedList = new SortedList<DateTime, KeyValuePair<Version, string[]>>((IComparer<DateTime>) new \u0007<DateTime>());
        for (int index1 = 0; index1 < \u0005\u0081.\u007E\u0098\u0004\u0002((object) \u0010\u0084.\u007E\u0092\u0004\u0002((object) xmlElement)); ++index1)
        {
          XmlNode xmlNode2 = \u0086\u0081.\u007E\u0099\u0004\u0002((object) \u0010\u0084.\u007E\u0092\u0004\u0002((object) xmlElement), index1);
          if (\u0005\u0081.\u007E\u0098\u0004\u0002((object) \u0010\u0084.\u007E\u0092\u0004\u0002((object) xmlNode2)) > 0)
          {
            string str1 = \u0002\u007F.\u007E\u0091\u0004\u0002((object) \u0096\u001F.\u007E\u0097\u0004\u0002((object) \u0012\u001C.\u007E\u0093\u0004\u0002((object) xmlNode2), \u001B.\u0018.\u0004));
            string str2 = \u0002\u007F.\u007E\u0091\u0004\u0002((object) \u0096\u001F.\u007E\u0097\u0004\u0002((object) \u0012\u001C.\u007E\u0093\u0004\u0002((object) xmlNode2), \u001B.\u0018.\u0001));
            DateTime key1;
            Version key2;
            if (\u009F\u0081.\u001C\u0094(str1, ref key1) && \u0095\u001B.\u0012\u0098(str2, ref key2) && !sortedList.ContainsKey(key1))
            {
              string[] strArray = new string[\u0005\u0081.\u007E\u0098\u0004\u0002((object) \u0010\u0084.\u007E\u0092\u0004\u0002((object) xmlNode2))];
              for (int index2 = 0; index2 < \u0005\u0081.\u007E\u0098\u0004\u0002((object) \u0010\u0084.\u007E\u0092\u0004\u0002((object) xmlNode2)); ++index2)
              {
                XmlNode xmlNode3 = \u0086\u0081.\u007E\u0099\u0004\u0002((object) \u0010\u0084.\u007E\u0092\u0004\u0002((object) xmlNode2), index2);
                if (\u0008\u001F.\u009A\u0092(\u0002\u007F.\u007E\u0090\u0004\u0002((object) xmlNode3), \u001B.\u0018.\u0005) && \u0099\u0082.\u007E\u0095\u0004\u0002((object) xmlNode3))
                  strArray[index2] = \u0002\u007F.\u007E\u0091\u0004\u0002((object) \u0086\u0082.\u007E\u0094\u0004\u0002((object) xmlNode3));
              }
              string[] array = ((IEnumerable<string>) strArray).Where<string>((Func<string, bool>) (t => !\u008F\u0084.\u009E\u0092(t))).ToArray<string>();
              if (array.Length > 0)
                sortedList.Add(key1, new KeyValuePair<Version, string[]>(key2, array));
            }
          }
        }
        return sortedList;
      }
      catch (Exception ex)
      {
        if (sortedList != null)
          sortedList.Clear();
        ex.\u001D\u0005();
        return (SortedList<DateTime, KeyValuePair<Version, string[]>>) null;
      }
      finally
      {
        xmlNode1 = (XmlNode) null;
      }
    }

    private static XmlDocument \u001D\u0005(string filePath)
    {
      if (\u008F\u0084.\u009E\u0092(filePath))
        throw new ArgumentNullException(\u001B.\u0018.\u0001(55382));
      if (!\u008F\u0084.\u0092\u009E(filePath))
        throw new FileNotFoundException(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u001B.\u0018.\u0002, new object[1]{ (object) filePath }));
      try
      {
        Stream stream = (Stream) \u008F\u001C.\u0093\u009E(filePath, FileMode.Open, FileAccess.Read, FileShare.None);
        try
        {
          XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
          \u007F\u001E.\u007E\u008D\u0004\u0002((object) xmlReaderSettings, DtdProcessing.Parse);
          \u0088\u001E.\u007E\u008E\u0004\u0002((object) xmlReaderSettings, ValidationType.DTD);
          xmlReaderSettings.ValidationEventHandler += (ValidationEventHandler) ((obj, e) => \u0092\u0086.\u007E\u009C\u0004\u0002((object) e).\u001D\u0005());
          XmlReader xmlReader = \u008E\u0080.\u008B\u0004\u0002(stream, xmlReaderSettings);
          try
          {
            XmlDocument xmlDocument = new XmlDocument();
            \u0004\u0087.\u007E\u009B\u0004\u0002((object) xmlDocument, xmlReader);
            return xmlDocument;
          }
          finally
          {
            if (xmlReader != null)
              \u001A\u001E.\u007E\u0094\u0092((object) xmlReader);
          }
        }
        finally
        {
          if (stream != null)
            \u001A\u001E.\u007E\u0094\u0092((object) stream);
        }
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005();
        return (XmlDocument) null;
      }
    }
  }
}
