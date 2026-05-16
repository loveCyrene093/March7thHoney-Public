using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetServerPrefsDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetServerPrefsDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXRTZXJ2ZXJQcmVmc0RhdGFDc1JlcS5wcm90byIyChdHZXRTZXJ2ZXJQ" + "cmVmc0RhdGFDc1JlcRIXCg9zZXJ2ZXJfcHJlZnNfaWQYBiABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetServerPrefsDataCsReq), GetServerPrefsDataCsReq.Parser, new string[1] { "ServerPrefsId" }, null, null, null, null)
		}));
	}
}
