using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetArchiveDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetArchiveDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRBcmNoaXZlRGF0YVNjUnNwLnByb3RvGhFBcmNoaXZlRGF0YS5wcm90" + "byJKChNHZXRBcmNoaXZlRGF0YVNjUnNwEg8KB3JldGNvZGUYAyABKA0SIgoM" + "YXJjaGl2ZV9kYXRhGAwgASgLMgwuQXJjaGl2ZURhdGFCFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ArchiveDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetArchiveDataScRsp), GetArchiveDataScRsp.Parser, new string[2] { "Retcode", "ArchiveData" }, null, null, null, null)
		}));
	}
}
