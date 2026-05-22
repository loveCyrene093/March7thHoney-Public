using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LHDMBIMGKCFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LHDMBIMGKCFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMSERNQklNR0tDRi5wcm90byIzCgtMSERNQklNR0tDRhITCgtGTElDUE1H" + "RktPSxgIIAEoDRIPCgdyb2xlX2lkGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LHDMBIMGKCF), LHDMBIMGKCF.Parser, new string[2] { "FLICPMGFKOK", "RoleId" }, null, null, null, null)
		}));
	}
}
