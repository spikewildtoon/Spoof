// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace \u0001
{
  internal static class \u0003
  {
    private static ModuleHandle \u0001;
    private static char[] \u0001;

    static \u0003()
    {
      // ISSUE: unable to decompile the method.
    }

    public static void \u001D\u0005([In] int obj0)
    {
      Type typeFromHandle;
      try
      {
        typeFromHandle = Type.GetTypeFromHandle(\u0003.\u0001.ResolveTypeHandle(33554433 + obj0));
      }
      catch
      {
        return;
      }
      foreach (FieldInfo field in typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField))
      {
        string name = field.Name;
        bool flag = false;
        int num = 0;
        for (int index1 = name.Length - 1; index1 >= 0; --index1)
        {
          char ch = name[index1];
          if ((int) ch == 126)
          {
            flag = true;
            break;
          }
          for (int index2 = 0; index2 < 58; ++index2)
          {
            if ((int) \u0003.\u0001[index2] == (int) ch)
            {
              num = num * 58 + index2;
              break;
            }
          }
        }
        MethodInfo methodInfo;
        try
        {
          methodInfo = (MethodInfo) MethodBase.GetMethodFromHandle(\u0003.\u0001.ResolveMethodHandle(num + 167772161));
        }
        catch
        {
          continue;
        }
        Delegate @delegate;
        if (methodInfo.IsStatic)
        {
          try
          {
            @delegate = Delegate.CreateDelegate(field.FieldType, methodInfo);
          }
          catch (Exception ex)
          {
            continue;
          }
        }
        else
        {
          ParameterInfo[] parameters = methodInfo.GetParameters();
          int length = parameters.Length + 1;
          Type[] parameterTypes = new Type[length];
          parameterTypes[0] = typeof (object);
          for (int index = 1; index < length; ++index)
            parameterTypes[index] = parameters[index - 1].ParameterType;
          DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, parameterTypes, typeFromHandle, true);
          ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
          ilGenerator.Emit(OpCodes.Ldarg_0);
          if (length > 1)
            ilGenerator.Emit(OpCodes.Ldarg_1);
          if (length > 2)
            ilGenerator.Emit(OpCodes.Ldarg_2);
          if (length > 3)
            ilGenerator.Emit(OpCodes.Ldarg_3);
          if (length > 4)
          {
            for (int index = 4; index < length; ++index)
              ilGenerator.Emit(OpCodes.Ldarg_S, index);
          }
          ilGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
          ilGenerator.Emit(OpCodes.Ret);
          try
          {
            @delegate = dynamicMethod.CreateDelegate(typeFromHandle);
          }
          catch
          {
            continue;
          }
        }
        try
        {
          field.SetValue((object) null, (object) @delegate);
        }
        catch
        {
        }
      }
    }
  }
}
