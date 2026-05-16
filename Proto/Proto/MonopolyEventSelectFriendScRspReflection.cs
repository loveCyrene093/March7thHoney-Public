using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyEventSelectFriendScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyEventSelectFriendScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiRNb25vcG9seUV2ZW50U2VsZWN0RnJpZW5kU2NSc3AucHJvdG8aEUFBSEJF";
		buffer[1] = "Q0lDT0VOLnByb3RvIn4KHk1vbm9wb2x5RXZlbnRTZWxlY3RGcmllbmRTY1Jz";
		buffer[2] = "cBITCgtESExES0xNUEhORxgCIAEoDRIPCgdyZXRjb2RlGAggASgNEiEKC0xK";
		buffer[3] = "SERPRkJGTkpIGAsgASgLMgwuQUFIQkVDSUNPRU4SEwoLTE1JSUNFTk1PQkkY";
		buffer[4] = "DSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { AAHBECICOENReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyEventSelectFriendScRsp), MonopolyEventSelectFriendScRsp.Parser, new string[4] { "DHLDKLMPHNG", "Retcode", "LJHDOFBFNJH", "LMIICENMOBI" }, null, null, null, null)
		}));
	}
}
