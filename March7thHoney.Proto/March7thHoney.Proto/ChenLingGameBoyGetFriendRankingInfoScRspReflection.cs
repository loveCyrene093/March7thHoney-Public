using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingGameBoyGetFriendRankingInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingGameBoyGetFriendRankingInfoScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "Ci5DaGVuTGluZ0dhbWVCb3lHZXRGcmllbmRSYW5raW5nSW5mb1NjUnNwLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "b3RvGhFQQ01ITUNMQUNOSy5wcm90byKIAQooQ2hlbkxpbmdHYW1lQm95R2V0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "RnJpZW5kUmFua2luZ0luZm9TY1JzcBIhCgtKUE5BTEtFRkhPSBgIIAMoCzIM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "LlBDTUhNQ0xBQ05LEhMKC0tFUE1KS0dKTE5KGAwgASgIEg8KB3JldGNvZGUY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "DSABKA0SEwoLR1BKSEpPT0lKSkMYDyABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { PCMHMCLACNKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingGameBoyGetFriendRankingInfoScRsp), ChenLingGameBoyGetFriendRankingInfoScRsp.Parser, new string[4] { "JPNALKEFHOH", "KEPMJKGJLNJ", "Retcode", "GPJHJOOIJJC" }, null, null, null, null)
		}));
	}
}
