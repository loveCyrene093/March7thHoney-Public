using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CLJDMLFMFHAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CLJDMLFMFHAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTEpETUxGTUZIQS5wcm90byI4CgtDTEpETUxGTUZIQRIUCgxkaWNlX3Ns" + "b3RfaWQYAyABKA0SEwoLQ0NPR0ZLTE9GS0wYCiABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CLJDMLFMFHA), CLJDMLFMFHA.Parser, new string[2] { "DiceSlotId", "CCOGFKLOFKL" }, null, null, null, null)
		}));
	}
}
