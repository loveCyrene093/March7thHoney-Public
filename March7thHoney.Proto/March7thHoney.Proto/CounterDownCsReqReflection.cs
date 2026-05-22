using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CounterDownCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CounterDownCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZDb3VudGVyRG93bkNzUmVxLnByb3RvIjwKEENvdW50ZXJEb3duQ3NSZXES" + "EwoLTUVBSkFFQkRBT0kYASABKA0SEwoLSUFQRkJHRURHQU0YDiABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CounterDownCsReq), CounterDownCsReq.Parser, new string[2] { "MEAJAEBDAOI", "IAPFBGEDGAM" }, null, null, null, null)
		}));
	}
}
