using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DCIFPICPJMKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DCIFPICPJMKReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFEQ0lGUElDUEpNSy5wcm90byqBAQoLRENJRlBJQ1BKTUsSGwoXRENJRlBJ";
		buffer[1] = "Q1BKTUtfUENQREhFTFBLRU0QABIbChdEQ0lGUElDUEpNS19GQ0VITk1KSkFC";
		buffer[2] = "RRABEhsKF0RDSUZQSUNQSk1LX0ZOS0RJRUJLT0hBEAISGwoXRENJRlBJQ1BK";
		buffer[3] = "TUtfREtQRkVFQklETVAQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(DCIFPICPJMK) }, null, null));
	}
}
