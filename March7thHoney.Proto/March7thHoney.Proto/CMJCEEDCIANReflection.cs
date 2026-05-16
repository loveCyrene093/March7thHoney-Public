using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CMJCEEDCIANReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CMJCEEDCIANReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTUpDRUVEQ0lBTi5wcm90byIeCgtDTUpDRUVEQ0lBThIPCgdyZXRjb2Rl" + "GAQgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CMJCEEDCIAN), CMJCEEDCIAN.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
