using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetAetherDivideLineUpCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetAetherDivideLineUpCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBTZXRBZXRoZXJEaXZpZGVMaW5lVXBDc1JlcS5wcm90bxoRRExHRlBNS1BM" + "RU8ucHJvdG8iOgoaU2V0QWV0aGVyRGl2aWRlTGluZVVwQ3NSZXESHAoGbGlu" + "ZXVwGA4gASgLMgwuRExHRlBNS1BMRU9CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[1] { DLGFPMKPLEOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetAetherDivideLineUpCsReq), SetAetherDivideLineUpCsReq.Parser, new string[1] { "Lineup" }, null, null, null, null)
		}));
	}
}
