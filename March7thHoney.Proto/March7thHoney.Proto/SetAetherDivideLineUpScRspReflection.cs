using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetAetherDivideLineUpScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetAetherDivideLineUpScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBTZXRBZXRoZXJEaXZpZGVMaW5lVXBTY1JzcC5wcm90bxoRRExHRlBNS1BM" + "RU8ucHJvdG8iSwoaU2V0QWV0aGVyRGl2aWRlTGluZVVwU2NSc3ASHAoGbGlu" + "ZXVwGAogASgLMgwuRExHRlBNS1BMRU8SDwoHcmV0Y29kZRgMIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DLGFPMKPLEOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetAetherDivideLineUpScRsp), SetAetherDivideLineUpScRsp.Parser, new string[2] { "Lineup", "Retcode" }, null, null, null, null)
		}));
	}
}
