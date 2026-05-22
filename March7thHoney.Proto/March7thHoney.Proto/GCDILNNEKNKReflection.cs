using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GCDILNNEKNKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GCDILNNEKNKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHQ0RJTE5ORUtOSy5wcm90byIzCgtHQ0RJTE5ORUtOSxITCgtMUEpERU1P" + "TURJRRgBIAMoDRIPCgdhcmVhX2lkGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GCDILNNEKNK), GCDILNNEKNK.Parser, new string[2] { "LPJDEMOMDIE", "AreaId" }, null, null, null, null)
		}));
	}
}
