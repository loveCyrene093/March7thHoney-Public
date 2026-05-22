using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartySettleNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartySettleNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxUcmFpblBhcnR5U2V0dGxlTm90aWZ5LnByb3RvGhFNQUdGS0ZDTUxKTS5w" + "cm90byJQChZUcmFpblBhcnR5U2V0dGxlTm90aWZ5EhMKC0dERlBCSE1NRkVB" + "GAUgASgNEiEKC09GQ0tIR0xJTkFHGAggASgLMgwuTUFHRktGQ01MSk1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { MAGFKFCMLJMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartySettleNotify), TrainPartySettleNotify.Parser, new string[2] { "GDFPBHMMFEA", "OFCKHGLINAG" }, null, null, null, null)
		}));
	}
}
