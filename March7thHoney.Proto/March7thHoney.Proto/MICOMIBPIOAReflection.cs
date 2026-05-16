using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MICOMIBPIOAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MICOMIBPIOAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNSUNPTUlCUElPQS5wcm90bxoRQ0FMSVBJS0ZERUoucHJvdG8aEkl0ZW1D" + "b3N0RGF0YS5wcm90byJUCgtNSUNPTUlCUElPQRIhCgtCQUdGQU9KTVBIRRgD" + "IAMoCzIMLkNBTElQSUtGREVKEiIKC0VCTUtCREpNQUFGGAggASgLMg0uSXRl" + "bUNvc3REYXRhQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[2]
		{
			CALIPIKFDEJReflection.Descriptor,
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MICOMIBPIOA), MICOMIBPIOA.Parser, new string[2] { "BAGFAOJMPHE", "EBMKBDJMAAF" }, null, null, null, null)
		}));
	}
}
