using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SelectPhoneThemeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SelectPhoneThemeScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTZWxlY3RQaG9uZVRoZW1lU2NSc3AucHJvdG8iVgoVU2VsZWN0UGhvbmVU" + "aGVtZVNjUnNwEhMKC05BTExFQk5CUEtCGAEgASgNEhcKD2N1cl9waG9uZV90" + "aGVtZRgGIAEoDRIPCgdyZXRjb2RlGAggASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SelectPhoneThemeScRsp), SelectPhoneThemeScRsp.Parser, new string[3] { "NALLEBNBPKB", "CurPhoneTheme", "Retcode" }, null, null, null, null)
		}));
	}
}
