// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using System;
using System.Net;
using System.Net.Security;
using System.Threading;

namespace \u0017
{
  internal static class \u0006
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static IWebProxy \u0001;
    private static ICredentials \u0001;
    private static bool \u0001;
    private static int \u0001;

    static \u0006()
    {
      // ISSUE: type reference
      \u0004.\u001D\u0005(\u009C\u0082.\u0016\u0097(__typeref (\u0006)));
      \u0006.\u0001 = \u0006.\u0001(27502);
      \u0006.\u0001 = \u009D\u0082.\u0095\u0002\u0002();
      \u0006.\u0001 = (ICredentials) null;
      \u0006.\u0001 = false;
      \u0006.\u0001 = 10000;
      \u001E\u001E.\u0007\u0003\u0002(int.MaxValue);
      \u001E\u001E.\u0008\u0003\u0002(-1);
      \u0088\u0084.\u000E\u0003\u0002((RemoteCertificateValidationCallback) ((obj, certificate, chain, sslPolicyErrors) => true));
    }

    public static DateTime \u001D\u0005(this WebRequest request)
    {
      HttpWebResponse httpWebResponse = \u000E\u0083.\u007E\u0093\u0002\u0002((object) request) as HttpWebResponse;
      try
      {
        return \u0008\u007F.\u007E\u009E\u0002\u0002((object) httpWebResponse).ToUniversalTime();
      }
      finally
      {
        if (httpWebResponse != null)
          \u001A\u001E.\u007E\u0094\u0092((object) httpWebResponse);
      }
    }

    public static HttpWebRequest \u001D\u0005(this Uri requestUri)
    {
      HttpWebRequest httpWebRequest = \u008F\u001E.\u008E\u0002\u0002(requestUri) as HttpWebRequest;
      int num = \u0005\u0081.\u007E\u0006\u0003\u0002((object) \u009F\u0080.\u007E\u009B\u0002\u0002((object) httpWebRequest));
      \u008F\u0083.\u007E\u008F\u0002\u0002((object) httpWebRequest, \u0006.\u0001);
      \u0099\u001F.\u007E\u0091\u0002\u0002((object) httpWebRequest, \u0006.\u0001);
      \u0099\u001F.\u007E\u0099\u0002\u0002((object) httpWebRequest, true);
      if (!\u008F\u0084.\u009E\u0092(\u0006.\u0001))
        \u0092\u0081.\u007E\u009C\u0002\u0002((object) httpWebRequest, \u0006.\u0001);
      \u0011\u001F.\u007E\u009A\u0002\u0002((object) httpWebRequest, 40000);
      \u0011\u001F.\u007E\u0092\u0002\u0002((object) httpWebRequest, \u0006.\u0001);
      \u0097\u0083.\u007E\u0090\u0002\u0002((object) httpWebRequest, \u0006.\u0001);
      return httpWebRequest;
    }

    public static void \u001D\u0005(this Uri requestUri, Action<Uri, long> desti)
    {
      int num = \u001E\u001F.\u0098\u0098(new WaitCallback(\u0006.\u001D\u0005), (object) new object[2]{ (object) requestUri, (object) desti }) ? 1 : 0;
    }

    private static void \u001D\u0005(object data)
    {
      // ISSUE: unable to decompile the method.
    }

    public static long \u001D\u0005(this Uri requestUri)
    {
      HttpWebRequest httpWebRequest = (HttpWebRequest) null;
      try
      {
        httpWebRequest = \u0006.\u001D\u0005(requestUri);
        HttpWebResponse httpWebResponse = \u000E\u0083.\u007E\u0093\u0002\u0002((object) httpWebRequest) as HttpWebResponse;
        try
        {
          try
          {
            return \u001F\u001E.\u007E\u0097\u0002\u0002((object) httpWebResponse);
          }
          catch (NotSupportedException ex)
          {
            return 0;
          }
          finally
          {
            \u001A\u001E.\u007E\u0094\u0002\u0002((object) httpWebRequest);
            \u001A\u001E.\u007E\u0096\u0002\u0002((object) httpWebResponse);
          }
        }
        finally
        {
          if (httpWebResponse != null)
            \u001A\u001E.\u007E\u0094\u0092((object) httpWebResponse);
        }
      }
      finally
      {
        if (httpWebRequest != null)
          \u001A\u001E.\u007E\u0094\u0002\u0002((object) httpWebRequest);
      }
    }
  }
}
