using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PBKPPEAPBOMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PBKPPEAPBOMReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFQQktQUEVBUEJPTS5wcm90byqBAQoLUEJLUFBFQVBCT00SGwoXUEJLUFBF";
		buffer[1] = "QVBCT01fQk5KTVBDSEZJTkEQABIbChdQQktQUEVBUEJPTV9PREZOUENKTkRJ";
		buffer[2] = "RBABEhsKF1BCS1BQRUFQQk9NX0NDSkNGTUlBRkNNEAISGwoXUEJLUFBFQVBC";
		buffer[3] = "T01fTEFERVBCQkhIR08QA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(PBKPPEAPBOM) }, null, null));
	}
}
