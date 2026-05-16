using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRndOptionTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRndOptionTypeReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChZDbWRSbmRPcHRpb25UeXBlLnByb3RvKpQBChBDbWRSbmRPcHRpb25UeXBl";
		buffer[1] = "EhsKF0VET09LRUpIUEFEX1BDUERIRUxQS0VNEAASHgoZQ21kRGFpbHlGaXJz";
		buffer[2] = "dE1lZXRQYW1Dc1JlcRCmGxIZChRDbWRHZXRSbmRPcHRpb25Dc1JlcRCjGxIT";
		buffer[3] = "Cg5DbWRFRUFNQk1ER0lIRhDSGhITCg5DbWRDQkVGRk5BRlBFTBCnG0IWqgIT";
		buffer[4] = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRndOptionType) }, null, null));
	}
}
