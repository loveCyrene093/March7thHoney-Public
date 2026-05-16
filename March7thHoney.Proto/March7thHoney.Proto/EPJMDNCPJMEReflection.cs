using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EPJMDNCPJMEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EPJMDNCPJMEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFUEpNRE5DUEpNRS5wcm90bxoRTUNBRkdCUExGRUgucHJvdG8iUgoLRVBK" + "TUROQ1BKTUUSEwoLRklNTlBFQk9CSEwYAiABKA0SEAoIcHJvZ3Jlc3MYBCAB" + "KA0SHAoGc291cmNlGAcgASgLMgwuTUNBRkdCUExGRUhCFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { MCAFGBPLFEHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EPJMDNCPJME), EPJMDNCPJME.Parser, new string[3] { "FIMNPEBOBHL", "Progress", "Source" }, null, null, null, null)
		}));
	}
}
