using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LCALDPAIJDOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LCALDPAIJDOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMQ0FMRFBBSUpETy5wcm90byIeCgtMQ0FMRFBBSUpETxIPCgdidWZmX2lk" + "GAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LCALDPAIJDO), LCALDPAIJDO.Parser, new string[1] { "BuffId" }, null, null, null, null)
		}));
	}
}
