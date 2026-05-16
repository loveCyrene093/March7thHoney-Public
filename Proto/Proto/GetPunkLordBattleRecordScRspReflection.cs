using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPunkLordBattleRecordScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPunkLordBattleRecordScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "CiJHZXRQdW5rTG9yZEJhdHRsZVJlY29yZFNjUnNwLnByb3RvGhFKTExJRERJ";
		buffer[1] = "Qk9ISS5wcm90bxoRUEhPQ0VDSk9CSEgucHJvdG8aF1RyeURvd25Mb2FkUmVw";
		buffer[2] = "bGF5LnByb3RvIp4BChxHZXRQdW5rTG9yZEJhdHRsZVJlY29yZFNjUnNwEicK";
		buffer[3] = "C1BBQ0lPRE9OSEdKGAMgAygLMhIuVHJ5RG93bkxvYWRSZXBsYXkSIQoLSklQ";
		buffer[4] = "QUxCTE9QRkkYBCABKAsyDC5KTExJRERJQk9ISRIhCgtERklEUEpFSUJKSxgI";
		buffer[5] = "IAMoCzIMLlBIT0NFQ0pPQkhIEg8KB3JldGNvZGUYDCABKA1CFqoCE01hcmNo";
		buffer[6] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			JLLIDDIBOHIReflection.Descriptor,
			PHOCECJOBHHReflection.Descriptor,
			TryDownLoadReplayReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPunkLordBattleRecordScRsp), GetPunkLordBattleRecordScRsp.Parser, new string[4] { "PACIODONHGJ", "JIPALBLOPFI", "DFIDPJEIBJK", "Retcode" }, null, null, null, null)
		}));
	}
}
