using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ParkourEndLevelScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ParkourEndLevelScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChpQYXJrb3VyRW5kTGV2ZWxTY1JzcC5wcm90bxoRTE5HSkNKTktQS0UucHJv";
		buffer[1] = "dG8aEU5PTU5FSENOR0xILnByb3RvIrYBChRQYXJrb3VyRW5kTGV2ZWxTY1Jz";
		buffer[2] = "cBITCgtCQ0JPSEZHREVNRhgEIAEoCBIMCgR0aW1lGAUgASgNEg8KB3JldGNv";
		buffer[3] = "ZGUYCCABKA0SEwoLSURPUE5DS0FBRE8YCSABKAgSIQoLRUZBQURDSUdNREsY";
		buffer[4] = "CiABKAsyDC5MTkdKQ0pOS1BLRRIQCghsZXZlbF9pZBgLIAEoDRIgCgplbmRf";
		buffer[5] = "cmVhc29uGA8gASgOMgwuTk9NTkVIQ05HTEhCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[6] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			LNGJCJNKPKEReflection.Descriptor,
			NOMNEHCNGLHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ParkourEndLevelScRsp), ParkourEndLevelScRsp.Parser, new string[7] { "BCBOHFGDEMF", "Time", "Retcode", "IDOPNCKAADO", "EFAADCIGMDK", "LevelId", "EndReason" }, null, null, null, null)
		}));
	}
}
