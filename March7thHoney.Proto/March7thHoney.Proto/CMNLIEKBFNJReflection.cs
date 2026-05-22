using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CMNLIEKBFNJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CMNLIEKBFNJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTU5MSUVLQkZOSi5wcm90bxoRRUVOSEhITURIS0gucHJvdG8iSgoLQ01O" + "TElFS0JGTkoSKgoUY29udGVudF9wYWNrYWdlX2xpc3QYAiADKAsyDC5FRU5I" + "SEhNREhLSBIPCgdyZXRjb2RlGAQgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[1] { EENHHHMDHKHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CMNLIEKBFNJ), CMNLIEKBFNJ.Parser, new string[2] { "ContentPackageList", "Retcode" }, null, null, null, null)
		}));
	}
}
