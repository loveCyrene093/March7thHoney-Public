using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CPPAAIIHAGIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CPPAAIIHAGIReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFDUFBBQUlJSEFHSS5wcm90bxoRTkFLSUdMUEdLQkEucHJvdG8ihAEKC0NQ";
		buffer[1] = "UEFBSUlIQUdJEhMKC0xETE9IRkxFT01HGAEgASgNEiEKC0REUEtKS0hFRExI";
		buffer[2] = "GAQgAygLMgwuTkFLSUdMUEdLQkESEwoLR0pHS0lBTkVOSVAYBiABKA0SEwoL";
		buffer[3] = "TU9FRlBGT0pFREkYCCABKA0SEwoLSk5CR0VGSlBLQ0MYCyABKA1CFqoCE01h";
		buffer[4] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { NAKIGLPGKBAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CPPAAIIHAGI), CPPAAIIHAGI.Parser, new string[5] { "LDLOHFLEOMG", "DDPKJKHEDLH", "GJGKIANENIP", "MOEFPFOJEDI", "JNBGEFJPKCC" }, null, null, null, null)
		}));
	}
}
