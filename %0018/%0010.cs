// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

namespace \u0018
{
  internal static class \u0010
  {
    public static unsafe char* \u001D\u0005(char* buf, char c, int length)
    {
      while (length-- > 0)
      {
        if ((int) *buf == (int) c)
          return buf;
        char* chPtr = buf++;
      }
      return (char*) null;
    }

    public static unsafe int \u001D\u0005(char* buf1, char* buf2, int length)
    {
      while (length-- > 0)
      {
        if ((int) *buf1 != (int) *buf2)
          return (int) *buf1 <= (int) *buf2 ? -1 : 1;
        char* chPtr1 = buf1++;
        char* chPtr2 = buf2++;
      }
      return 0;
    }

    public static unsafe void \u001D\u0005(char* dest, char* src, int length)
    {
      while (length >= 8)
      {
        *(int*) dest = *(int*) src;
        *(int*) (dest + 2) = *(int*) (src + 2);
        *(int*) (dest + 4) = *(int*) (src + 4);
        *(int*) (dest + 6) = *(int*) (src + 6);
        dest += 8;
        src += 8;
        length -= 8;
      }
      if ((length & 4) != 0)
      {
        *(int*) dest = *(int*) src;
        *(int*) (dest + 2) = *(int*) (src + 2);
        dest += 4;
        src += 4;
      }
      if ((length & 2) != 0)
      {
        *(int*) dest = *(int*) src;
        dest += 2;
        src += 2;
      }
      if ((length & 1) == 0)
        return;
      *dest = *src;
    }

    public static unsafe void \u001E\u0005(char* dest, char* src, int length)
    {
      if (((int) dest & 2) != 0)
        goto label_9;
label_2:
      while (length >= 8)
      {
        *(int*) dest = *(int*) src;
        *(int*) (dest + 2) = *(int*) (src + 2);
        *(int*) (dest + 4) = *(int*) (src + 4);
        *(int*) (dest + 6) = *(int*) (src + 6);
        dest += 8;
        src += 8;
        length -= 8;
      }
      if ((length & 4) != 0)
      {
        *(int*) dest = *(int*) src;
        *(int*) (dest + 2) = *(int*) (src + 2);
        dest += 4;
        src += 4;
      }
      if ((length & 2) != 0)
      {
        *(int*) dest = *(int*) src;
        dest += 2;
        src += 2;
      }
      if ((length & 1) == 0)
        return;
      *dest = *src;
      return;
label_9:
      *dest = *src;
      char* chPtr1 = dest++;
      char* chPtr2 = src++;
      int num = length--;
      goto label_2;
    }
  }
}
