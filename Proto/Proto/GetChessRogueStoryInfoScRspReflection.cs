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
		buffer[0] = "CiFHZXRDaGVzc1JvZ3VlU3RvcnlJbmZvU2NSc3AucHJvdG8aEUFETUtJQ0hM";
		buffer[1] = "R0JQLnByb3RvGhFMS0NFQkVESE5CSi5wcm90byJ0ChtHZXRDaGVzc1JvZ3Vl";
		buffer[2] = "U3RvcnlJbmZvU2NSc3ASIQoLRE9LSERPR0FQS0QYASADKAsyDC5BRE1LSUNI";
		buffer[3] = "TEdCUBIPCgdyZXRjb2RlGAMgASgNEiEKC09MSE5CRVBISEZHGAwgAygLMgwu";
		buffer[4] = "TEtDRUJFREhOQkpCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ADMKICHLGBPReflection.Descriptor,
			LKCEBEDHNBJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetChessRogueStoryInfoScRsp), GetChessRogueStoryInfoScRsp.Parser, new string[3] { "DOKHDOGAPKD", "Retcode", "OLHNBEPHHFG" }, null, null, null, null)
		}));
	}
}
