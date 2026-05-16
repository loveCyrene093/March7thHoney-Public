using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AddRelicFilterPlanScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AddRelicFilterPlanScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1BZGRSZWxpY0ZpbHRlclBsYW5TY1JzcC5wcm90bxoRRUVDSk1JT0FGRkcu" + "cHJvdG8iTAoXQWRkUmVsaWNGaWx0ZXJQbGFuU2NSc3ASIAoKcmVsaWNfcGxh" + "bhgGIAEoCzIMLkVFQ0pNSU9BRkZHEg8KB3JldGNvZGUYDSABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { EECJMIOAFFGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AddRelicFilterPlanScRsp), AddRelicFilterPlanScRsp.Parser, new string[2] { "RelicPlan", "Retcode" }, null, null, null, null)
		}));
	}
}
