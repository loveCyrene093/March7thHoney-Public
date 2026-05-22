using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JPPHKCHDIJDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JPPHKCHDIJDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKUFBIS0NIRElKRC5wcm90byJdCgtKUFBIS0NIRElKRBITCgtHSEtKQlBJ" + "RkJBSRgIIAEoDRIPCgdhcmVhX2lkGAogASgNEhMKC05CQUNHR09GT05OGAsg" + "ASgNEhMKC05NTEFFTUxLQktKGAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JPPHKCHDIJD), JPPHKCHDIJD.Parser, new string[4] { "GHKJBPIFBAI", "AreaId", "NBACGGOFONN", "NMLAEMLKBKJ" }, null, null, null, null)
		}));
	}
}
