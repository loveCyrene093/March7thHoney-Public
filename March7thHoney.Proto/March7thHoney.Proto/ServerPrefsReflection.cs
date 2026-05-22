using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ServerPrefsReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ServerPrefsReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFTZXJ2ZXJQcmVmcy5wcm90byI0CgtTZXJ2ZXJQcmVmcxIXCg9zZXJ2ZXJf" + "cHJlZnNfaWQYCCABKA0SDAoEZGF0YRgKIAEoDEIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ServerPrefs), ServerPrefs.Parser, new string[2] { "ServerPrefsId", "Data" }, null, null, null, null)
		}));
	}
}
