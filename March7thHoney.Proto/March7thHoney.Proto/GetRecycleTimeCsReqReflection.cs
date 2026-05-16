using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRecycleTimeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRecycleTimeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRSZWN5Y2xlVGltZUNzUmVxLnByb3RvIioKE0dldFJlY3ljbGVUaW1l" + "Q3NSZXESEwoLRkdMS01ETkZGRUcYBCADKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRecycleTimeCsReq), GetRecycleTimeCsReq.Parser, new string[1] { "FGLKMDNFFEG" }, null, null, null, null)
		}));
	}
}
