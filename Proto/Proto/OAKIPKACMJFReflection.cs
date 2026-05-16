using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OAKIPKACMJFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OAKIPKACMJFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPQUtJUEtBQ01KRi5wcm90byIzCgtPQUtJUEtBQ01KRhITCgtFSUlBR0FC" + "QUZFQxgGIAEoDRIPCgdyb29tX2lkGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OAKIPKACMJF), OAKIPKACMJF.Parser, new string[2] { "EIIAGABAFEC", "RoomId" }, null, null, null, null)
		}));
	}
}
