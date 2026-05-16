using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NGAIELABHPMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NGAIELABHPMReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFOR0FJRUxBQkhQTS5wcm90byqBAQoLTkdBSUVMQUJIUE0SGwoXTkdBSUVM";
		buffer[1] = "QUJIUE1fUENQREhFTFBLRU0QABIbChdOR0FJRUxBQkhQTV9MQ0VIS0JBTU9L";
		buffer[2] = "QRABEhsKF05HQUlFTEFCSFBNX05GRVBKTUVMUE9NEAISGwoXTkdBSUVMQUJI";
		buffer[3] = "UE1fQkZPSUpDSkpNSEgQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(NGAIELABHPM) }, null, null));
	}
}
