using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishItemIdCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishItemIdCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdGaW5pc2hJdGVtSWRDc1JlcS5wcm90byI1ChFGaW5pc2hJdGVtSWRDc1Jl" + "cRIPCgdpdGVtX2lkGA0gASgNEg8KB3RleHRfaWQYDyABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishItemIdCsReq), FinishItemIdCsReq.Parser, new string[2] { "ItemId", "TextId" }, null, null, null, null)
		}));
	}
}
