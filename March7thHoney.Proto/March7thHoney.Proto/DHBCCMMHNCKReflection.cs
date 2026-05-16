using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DHBCCMMHNCKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DHBCCMMHNCKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFESEJDQ01NSE5DSy5wcm90byI1CgtESEJDQ01NSE5DSxIRCglzY3JpcHRf" + "aWQYByABKA0SEwoLRERNT0ZIR0lCTEQYCiADKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DHBCCMMHNCK), DHBCCMMHNCK.Parser, new string[2] { "ScriptId", "DDMOFHGIBLD" }, null, null, null, null)
		}));
	}
}
