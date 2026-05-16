using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JKAIDKIGEGPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JKAIDKIGEGPReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFKS0FJREtJR0VHUC5wcm90bxoQTGluZXVwSW5mby5wcm90bxoRTUFERUVO";
		buffer[1] = "QUJPS0UucHJvdG8aD1NjZW5lSW5mby5wcm90byJoCgtKS0FJREtJR0VHUBIb";
		buffer[2] = "CgZsaW5ldXAYCiABKAsyCy5MaW5ldXBJbmZvEiEKC0VOUEFJQ05MQ01LGA4g";
		buffer[3] = "ASgLMgwuTUFERUVOQUJPS0USGQoFc2NlbmUYDyABKAsyCi5TY2VuZUluZm9C";
		buffer[4] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			LineupInfoReflection.Descriptor,
			MADEENABOKEReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JKAIDKIGEGP), JKAIDKIGEGP.Parser, new string[3] { "Lineup", "ENPAICNLCMK", "Scene" }, null, null, null, null)
		}));
	}
}
