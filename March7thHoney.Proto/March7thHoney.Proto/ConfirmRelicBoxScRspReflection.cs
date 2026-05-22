using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ConfirmRelicBoxScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ConfirmRelicBoxScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDb25maXJtUmVsaWNCb3hTY1JzcC5wcm90byJmChRDb25maXJtUmVsaWNC" + "b3hTY1JzcBITCgtOTEdGQUFGSUlJRRgBIAEoCBITCgtLQUlNSE9KQUFLUBgD" + "IAMoDRIPCgdyZXRjb2RlGAogASgNEhMKC0VLQU9DSFBIT0FBGA0gASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ConfirmRelicBoxScRsp), ConfirmRelicBoxScRsp.Parser, new string[4] { "NLGFAAFIIIE", "KAIMHOJAAKP", "Retcode", "EKAOCHPHOAA" }, null, null, null, null)
		}));
	}
}
