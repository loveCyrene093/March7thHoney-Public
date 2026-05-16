using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JGAJKCNIGPDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JGAJKCNIGPDReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFKR0FKS0NOSUdQRC5wcm90bxoRTUxPRkpGQkhHTEcucHJvdG8ifwoLSkdB";
		buffer[1] = "SktDTklHUEQSIQoLQklDQkpNUEFBQU4YASABKA4yDC5NTE9GSkZCSEdMRxIT";
		buffer[2] = "CgtPTUZLSUZBREZPQxgFIAEoCBITCgtKS1BHQUNMS0VFQxgIIAEoBBITCgtC";
		buffer[3] = "SU9EQUpMTElOTxgLIAEoCBIOCgZkYW1hZ2UYDyABKA1CFqoCE01hcmNoN3Ro";
		buffer[4] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MLOFJFBHGLGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JGAJKCNIGPD), JGAJKCNIGPD.Parser, new string[5] { "BICBJMPAAAN", "OMFKIFADFOC", "JKPGACLKEEC", "BIODAJLLINO", "Damage" }, null, null, null, null)
		}));
	}
}
