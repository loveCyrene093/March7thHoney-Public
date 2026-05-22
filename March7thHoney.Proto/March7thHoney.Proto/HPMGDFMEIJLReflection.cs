using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HPMGDFMEIJLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HPMGDFMEIJLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIUE1HREZNRUlKTC5wcm90byIjCgtIUE1HREZNRUlKTBIUCgxkaWNlX3Ns" + "b3RfaWQYBiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HPMGDFMEIJL), HPMGDFMEIJL.Parser, new string[1] { "DiceSlotId" }, null, null, null, null)
		}));
	}
}
