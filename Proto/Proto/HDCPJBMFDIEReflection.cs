using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HDCPJBMFDIEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HDCPJBMFDIEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIRENQSkJNRkRJRS5wcm90byIlCgtIRENQSkJNRkRJRRIWCg5jbGllbnRf" + "dGltZV9tcxgFIAEoBEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HDCPJBMFDIE), HDCPJBMFDIE.Parser, new string[1] { "ClientTimeMs" }, null, null, null, null)
		}));
	}
}
