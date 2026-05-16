using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NCFGENOFLHCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NCFGENOFLHCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQ0ZHRU5PRkxIQy5wcm90byIjCgtOQ0ZHRU5PRkxIQxIUCgxkaWNlX3Ns" + "b3RfaWQYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NCFGENOFLHC), NCFGENOFLHC.Parser, new string[1] { "DiceSlotId" }, null, null, null, null)
		}));
	}
}
