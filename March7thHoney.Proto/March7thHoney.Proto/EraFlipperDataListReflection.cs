using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EraFlipperDataListReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EraFlipperDataListReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhFcmFGbGlwcGVyRGF0YUxpc3QucHJvdG8aEUJJREdQRUxKUEpLLnByb3Rv" + "IjcKEkVyYUZsaXBwZXJEYXRhTGlzdBIhCgtDRFBGQ1BDSUxPRhgLIAMoCzIM" + "LkJJREdQRUxKUEpLQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { BIDGPELJPJKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EraFlipperDataList), EraFlipperDataList.Parser, new string[1] { "CDPFCPCILOF" }, null, null, null, null)
		}));
	}
}
