using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JCADEHNDGLFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JCADEHNDGLFReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFKQ0FERUhOREdMRi5wcm90bxoRTk9LS0FQR0JOSFAucHJvdG8imQEKC0pD";
		buffer[1] = "QURFSE5ER0xGEhMKC0lDSU5ITUlLSkxIGAMgASgNEhMKC09KQ0hQQVBKREZP";
		buffer[2] = "GAQgASgNEhMKC1BFTFBEQVBEQktKGAUgAygNEhMKC0JKSk9OR0hMT0ZDGAgg";
		buffer[3] = "ASgNEhMKC0lITExNTExOSUZOGAogASgNEiEKC05OS0hNSUVKUE9JGA4gAygL";
		buffer[4] = "MgwuTk9LS0FQR0JOSFBCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[5] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { NOKKAPGBNHPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JCADEHNDGLF), JCADEHNDGLF.Parser, new string[6] { "ICINHMIKJLH", "OJCHPAPJDFO", "PELPDAPDBKJ", "BJJONGHLOFC", "IHLLMLLNIFN", "NNKHMIEJPOI" }, null, null, null, null)
		}));
	}
}
