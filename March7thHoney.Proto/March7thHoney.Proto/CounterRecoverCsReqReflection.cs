using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CounterRecoverCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CounterRecoverCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlDb3VudGVyUmVjb3ZlckNzUmVxLnByb3RvIj8KE0NvdW50ZXJSZWNvdmVy" + "Q3NSZXESEwoLSUFQRkJHRURHQU0YCyABKA0SEwoLSE5MQURDTU1KSkEYDiAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CounterRecoverCsReq), CounterRecoverCsReq.Parser, new string[2] { "IAPFBGEDGAM", "HNLADCMMJJA" }, null, null, null, null)
		}));
	}
}
