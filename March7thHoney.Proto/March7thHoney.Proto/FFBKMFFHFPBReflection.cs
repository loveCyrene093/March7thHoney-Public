using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FFBKMFFHFPBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FFBKMFFHFPBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGRkJLTUZGSEZQQi5wcm90byIzCgtGRkJLTUZGSEZQQhITCgtMUExGUEpI" + "T1BLSxgCIAMoDRIPCgdyZXRjb2RlGAUgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FFBKMFFHFPB), FFBKMFFHFPB.Parser, new string[2] { "LPLFPJHOPKK", "Retcode" }, null, null, null, null)
		}));
	}
}
