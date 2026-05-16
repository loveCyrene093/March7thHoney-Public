using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NBBEHBNAAFIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NBBEHBNAAFIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQkJFSEJOQUFGSS5wcm90bxoRQUtHTEFFS0NGTk8ucHJvdG8aEU1HTE1F" + "TVBKRUxELnByb3RvIlMKC05CQkVIQk5BQUZJEiEKC0JQRkNFSktOQ0RQGAYg" + "ASgLMgwuQUtHTEFFS0NGTk8SIQoLR0JISkdJTElKTVAYCyABKAsyDC5NR0xN" + "RU1QSkVMREIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[2]
		{
			AKGLAEKCFNOReflection.Descriptor,
			MGLMEMPJELDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NBBEHBNAAFI), NBBEHBNAAFI.Parser, new string[2] { "BPFCEJKNCDP", "GBHJGILIJMP" }, null, null, null, null)
		}));
	}
}
