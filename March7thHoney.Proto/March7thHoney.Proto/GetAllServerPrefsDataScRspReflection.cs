using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAllServerPrefsDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAllServerPrefsDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBHZXRBbGxTZXJ2ZXJQcmVmc0RhdGFTY1JzcC5wcm90bxoRU2VydmVyUHJl" + "ZnMucHJvdG8iVgoaR2V0QWxsU2VydmVyUHJlZnNEYXRhU2NSc3ASDwoHcmV0" + "Y29kZRgDIAEoDRInChFzZXJ2ZXJfcHJlZnNfbGlzdBgKIAMoCzIMLlNlcnZl" + "clByZWZzQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ServerPrefsReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAllServerPrefsDataScRsp), GetAllServerPrefsDataScRsp.Parser, new string[2] { "Retcode", "ServerPrefsList" }, null, null, null, null)
		}));
	}
}
