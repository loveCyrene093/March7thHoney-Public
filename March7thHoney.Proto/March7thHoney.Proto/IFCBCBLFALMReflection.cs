using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IFCBCBLFALMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IFCBCBLFALMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJRkNCQ0JMRkFMTS5wcm90bxoTRmlnaHRHYW1lTW9kZS5wcm90byJHCgtJ" + "RkNCQ0JMRkFMTRITCgtLRVBFTk5QSU5ERBgBIAEoBBIjCgtERUxHT0NEQkVL" + "RhgCIAEoDjIOLkZpZ2h0R2FtZU1vZGVCFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[1] { FightGameModeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IFCBCBLFALM), IFCBCBLFALM.Parser, new string[2] { "KEPENNPINDD", "DELGOCDBEKF" }, null, null, null, null)
		}));
	}
}
