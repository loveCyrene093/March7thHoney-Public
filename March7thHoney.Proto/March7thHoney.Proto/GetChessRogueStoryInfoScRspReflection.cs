using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetChessRogueStoryInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetChessRogueStoryInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiFHZXRDaGVzc1JvZ3VlU3RvcnlJbmZvU2NSc3AucHJvdG8aEUFETUtJQ0hM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "R0JQLnByb3RvGhFMS0NFQkVESE5CSi5wcm90byJ0ChtHZXRDaGVzc1JvZ3Vl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "U3RvcnlJbmZvU2NSc3ASIQoLRE9LSERPR0FQS0QYASADKAsyDC5BRE1LSUNI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "TEdCUBIPCgdyZXRjb2RlGAMgASgNEiEKC09MSE5CRVBISEZHGAwgAygLMgwu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "TEtDRUJFREhOQkpCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			ADMKICHLGBPReflection.Descriptor,
			LKCEBEDHNBJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetChessRogueStoryInfoScRsp), GetChessRogueStoryInfoScRsp.Parser, new string[3] { "DOKHDOGAPKD", "Retcode", "OLHNBEPHHFG" }, null, null, null, null)
		}));
	}
}
