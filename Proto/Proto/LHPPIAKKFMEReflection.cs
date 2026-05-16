using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LHPPIAKKFMEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LHPPIAKKFMEReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMSFBQSUFLS0ZNRS5wcm90bxoXR3JpZEZpZ2h0RHJvcFR5cGUucHJvdG8a";
		buffer[1] = "EVBLQkJERk9PRkpOLnByb3RvIn0KC0xIUFBJQUtLRk1FEicKC0JHS0RBTURG";
		buffer[2] = "RktIGAEgASgOMhIuR3JpZEZpZ2h0RHJvcFR5cGUSEwoLSkpGRkxNQ0NDTU0Y";
		buffer[3] = "AiABKA0SCwoDbnVtGAMgASgNEiMKDWRpc3BsYXlfdmFsdWUYBSABKAsyDC5Q";
		buffer[4] = "S0JCREZPT0ZKTkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GridFightDropTypeReflection.Descriptor,
			PKBBDFOOFJNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LHPPIAKKFME), LHPPIAKKFME.Parser, new string[4] { "BGKDAMDFFKH", "JJFFLMCCCMM", "Num", "DisplayValue" }, null, null, null, null)
		}));
	}
}
