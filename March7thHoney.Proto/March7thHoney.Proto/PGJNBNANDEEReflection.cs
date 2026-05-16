using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PGJNBNANDEEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PGJNBNANDEEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQR0pOQk5BTkRFRS5wcm90byJ1CgtQR0pOQk5BTkRFRRIyCgtHSk9PTE9Q" + "QUNBRRgHIAMoCzIdLlBHSk5CTkFOREVFLkdKT09MT1BBQ0FFRW50cnkaMgoQ" + "R0pPT0xPUEFDQUVFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06" + "AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PGJNBNANDEE), PGJNBNANDEE.Parser, new string[1] { "GJOOLOPACAE" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
