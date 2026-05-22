using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SecretKeyInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SecretKeyInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNTZWNyZXRLZXlJbmZvLnByb3RvGhNTZWNyZXRLZXlUeXBlLnByb3RvIkEK" + "DVNlY3JldEtleUluZm8SEgoKc2VjcmV0X2tleRgNIAEoCRIcCgR0eXBlGA8g" + "ASgOMg4uU2VjcmV0S2V5VHlwZUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { SecretKeyTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SecretKeyInfo), SecretKeyInfo.Parser, new string[2] { "SecretKey", "Type" }, null, null, null, null)
		}));
	}
}
