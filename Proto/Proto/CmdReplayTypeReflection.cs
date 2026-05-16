using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdReplayTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdReplayTypeReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChNDbWRSZXBsYXlUeXBlLnByb3RvKpEBCg1DbWRSZXBsYXlUeXBlEhsKF0VE";
		buffer[1] = "RktFRUtNRklCX1BDUERIRUxQS0VNEAASGwoWQ21kR2V0UmVwbGF5VG9rZW5D";
		buffer[2] = "c1JlcRCHHBITCg5DbWRBSENBSEZGTkhMRBCLHBIcChdFREZLRUVLTUZJQl9N";
		buffer[3] = "TEpNREZETk9PRRCKHBITCg5DbWRFS0dBTU5DTU9FShC2G0IWqgITTWFyY2g3";
		buffer[4] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdReplayType) }, null, null));
	}
}
