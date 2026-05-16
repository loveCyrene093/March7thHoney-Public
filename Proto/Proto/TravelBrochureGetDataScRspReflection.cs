using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TravelBrochureGetDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TravelBrochureGetDataScRspReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		buffer[0] = "CiBUcmF2ZWxCcm9jaHVyZUdldERhdGFTY1JzcC5wcm90bxoRUEJQSU9GR09E";
		buffer[1] = "SEMucHJvdG8ivwIKGlRyYXZlbEJyb2NodXJlR2V0RGF0YVNjUnNwEkEKC0xO";
		buffer[2] = "REJOSUhBSUNCGAMgAygLMiwuVHJhdmVsQnJvY2h1cmVHZXREYXRhU2NSc3Au";
		buffer[3] = "TE5EQk5JSEFJQ0JFbnRyeRIPCgdyZXRjb2RlGA0gASgNEhQKDGN1c3RvbV92";
		buffer[4] = "YWx1ZRgOIAEoDRJBCgtDSUJDQ09KTExJQRgPIAMoCzIsLlRyYXZlbEJyb2No";
		buffer[5] = "dXJlR2V0RGF0YVNjUnNwLkNJQkNDT0pMTElBRW50cnkaQAoQTE5EQk5JSEFJ";
		buffer[6] = "Q0JFbnRyeRILCgNrZXkYASABKA0SGwoFdmFsdWUYAiABKAsyDC5QQlBJT0ZH";
		buffer[7] = "T0RIQzoCOAEaMgoQQ0lCQ0NPSkxMSUFFbnRyeRILCgNrZXkYASABKA0SDQoF";
		buffer[8] = "dmFsdWUYAiABKA06AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[9] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PBPIOFGODHCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TravelBrochureGetDataScRsp), TravelBrochureGetDataScRsp.Parser, new string[4] { "LNDBNIHAICB", "Retcode", "CustomValue", "CIBCCOJLLIA" }, null, null, null, new GeneratedClrTypeInfo[2])
		}));
	}
}
