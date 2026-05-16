using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KOKPDKOLBLEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KOKPDKOLBLEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLT0tQREtPTEJMRS5wcm90bxoRT0dKQlBIQkNNQkUucHJvdG8iQQoLS09L" + "UERLT0xCTEUSDwoHcmV0Y29kZRgIIAEoDRIhCgtNTkpORk1LSUtNSBgPIAMo" + "CzIMLk9HSkJQSEJDTUJFQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { OGJBPHBCMBEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KOKPDKOLBLE), KOKPDKOLBLE.Parser, new string[2] { "Retcode", "MNJNFMKIKMH" }, null, null, null, null)
		}));
	}
}
