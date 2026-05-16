using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartRogueCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartRogueCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChVTdGFydFJvZ3VlQ3NSZXEucHJvdG8ikAEKD1N0YXJ0Um9ndWVDc1JlcRIT";
		buffer[1] = "CgtMR0hPT0tNTk1DTBgCIAEoDRITCgtLT0xCTEtFRE9HQxgDIAMoDRIPCgdh";
		buffer[2] = "cmVhX2lkGAUgASgNEiUKHXVuZmluaXNoZWRfc3RvcnlfbGluZV9pZF9saXN0";
		buffer[3] = "GAsgAygNEhsKE2Jhc2VfYXZhdGFyX2lkX2xpc3QYDiADKA1CFqoCE01hcmNo";
		buffer[4] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartRogueCsReq), StartRogueCsReq.Parser, new string[5] { "LGHOOKMNMCL", "KOLBLKEDOGC", "AreaId", "UnfinishedStoryLineIdList", "BaseAvatarIdList" }, null, null, null, null)
		}));
	}
}
