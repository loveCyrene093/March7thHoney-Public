using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KCBDEHICICKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KCBDEHICICKReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFLQ0JERUhJQ0lDSy5wcm90byqBAQoLS0NCREVISUNJQ0sSGwoXS0NCREVI";
		buffer[1] = "SUNJQ0tfUENQREhFTFBLRU0QABIbChdLQ0JERUhJQ0lDS19PQ0xMSkFFTFBE";
		buffer[2] = "TRABEhsKF0tDQkRFSElDSUNLX09NTkxNUEFGSEJCEAISGwoXS0NCREVISUNJ";
		buffer[3] = "Q0tfTUJPSkdJSE1QRE0QA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(KCBDEHICICK) }, null, null));
	}
}
