using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OFHPKJDHOMFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OFHPKJDHOMFReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFPRkhQS0pESE9NRi5wcm90byqBAQoLT0ZIUEtKREhPTUYSGwoXT0ZIUEtK";
		buffer[1] = "REhPTUZfUENQREhFTFBLRU0QABIbChdPRkhQS0pESE9NRl9GQ0VITk1KSkFC";
		buffer[2] = "RRABEhsKF09GSFBLSkRIT01GX0lPSEZGR0hKT1BGEAISGwoXT0ZIUEtKREhP";
		buffer[3] = "TUZfT01KSUNHTkNPSUQQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(OFHPKJDHOMF) }, null, null));
	}
}
