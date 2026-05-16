using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ExchangeGachaCeilingCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ExchangeGachaCeilingCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9FeGNoYW5nZUdhY2hhQ2VpbGluZ0NzUmVxLnByb3RvIkIKGUV4Y2hhbmdl" + "R2FjaGFDZWlsaW5nQ3NSZXESEQoJYXZhdGFyX2lkGAIgASgNEhIKCmdhY2hh" + "X3R5cGUYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ExchangeGachaCeilingCsReq), ExchangeGachaCeilingCsReq.Parser, new string[2] { "AvatarId", "GachaType" }, null, null, null, null)
		}));
	}
}
