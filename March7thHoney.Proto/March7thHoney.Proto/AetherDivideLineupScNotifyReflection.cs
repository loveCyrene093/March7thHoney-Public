using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AetherDivideLineupScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AetherDivideLineupScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBBZXRoZXJEaXZpZGVMaW5ldXBTY05vdGlmeS5wcm90bxoRRExHRlBNS1BM" + "RU8ucHJvdG8iOgoaQWV0aGVyRGl2aWRlTGluZXVwU2NOb3RpZnkSHAoGbGlu" + "ZXVwGAcgASgLMgwuRExHRlBNS1BMRU9CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[1] { DLGFPMKPLEOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AetherDivideLineupScNotify), AetherDivideLineupScNotify.Parser, new string[1] { "Lineup" }, null, null, null, null)
		}));
	}
}
