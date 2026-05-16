using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IFBLMCNFIEOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IFBLMCNFIEOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJRkJMTUNORklFTy5wcm90bxoRRVBOQ0RGQkFIRUEucHJvdG8iQwoLSUZC" + "TE1DTkZJRU8SCgoCaWQYBCABKA0SKAoRY3VzdG9tX3ZhbHVlX2xpc3QY/A0g" + "ASgLMgwuRVBOQ0RGQkFIRUFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[1] { EPNCDFBAHEAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IFBLMCNFIEO), IFBLMCNFIEO.Parser, new string[2] { "Id", "CustomValueList" }, null, null, null, null)
		}));
	}
}
