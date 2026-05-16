using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JILAPGBHFJIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JILAPGBHFJIReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFKSUxBUEdCSEZKSS5wcm90byqBAQoLSklMQVBHQkhGSkkSGwoXSklMQVBH";
		buffer[1] = "QkhGSklfTE1KTERHRkpGTEMQABIbChdKSUxBUEdCSEZKSV9GSU9MSkdORUtL";
		buffer[2] = "SRABEhsKF0pJTEFQR0JIRkpJX0RQTEVJR1BPTUNBEAISGwoXSklMQVBHQkhG";
		buffer[3] = "SklfTk1HTEVQRExFREgQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(JILAPGBHFJI) }, null, null));
	}
}
