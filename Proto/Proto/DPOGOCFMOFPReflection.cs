using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DPOGOCFMOFPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DPOGOCFMOFPReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFEUE9HT0NGTU9GUC5wcm90bxoRQ0xIRElMS0FLRVAucHJvdG8ieQoLRFBP";
		buffer[1] = "R09DRk1PRlASEwoLQ09GRUxDS0RCSkUYBCABKA0SKwoVZnJpZW5kX3JlY29t";
		buffer[2] = "bWVuZF9saXN0GAYgAygLMgwuQ0xIRElMS0FLRVASEwoLRUROSUFDTk9QTU4Y";
		buffer[3] = "ByABKA0SEwoLT0RERkVBRUVKSkQYDCABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		buffer[4] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { CLHDILKAKEPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DPOGOCFMOFP), DPOGOCFMOFP.Parser, new string[4] { "COFELCKDBJE", "FriendRecommendList", "EDNIACNOPMN", "ODDFEAEEJJD" }, null, null, null, null)
		}));
	}
}
