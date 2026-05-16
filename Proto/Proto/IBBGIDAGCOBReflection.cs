using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IBBGIDAGCOBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IBBGIDAGCOBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJQkJHSURBR0NPQi5wcm90byIzCgtJQkJHSURBR0NPQhITCgtJRVBQRktH" + "QkZFUBgIIAEoDRIPCgdyZXRjb2RlGAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IBBGIDAGCOB), IBBGIDAGCOB.Parser, new string[2] { "IEPPFKGBFEP", "Retcode" }, null, null, null, null)
		}));
	}
}
