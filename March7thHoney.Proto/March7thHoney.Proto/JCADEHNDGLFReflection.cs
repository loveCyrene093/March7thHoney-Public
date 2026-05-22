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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFKQ0FERUhOREdMRi5wcm90bxoRTk9LS0FQR0JOSFAucHJvdG8imQEKC0pD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "QURFSE5ER0xGEhMKC0lDSU5ITUlLSkxIGAMgASgNEhMKC09KQ0hQQVBKREZP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "GAQgASgNEhMKC1BFTFBEQVBEQktKGAUgAygNEhMKC0JKSk9OR0hMT0ZDGAgg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "ASgNEhMKC0lITExNTExOSUZOGAogASgNEiEKC05OS0hNSUVKUE9JGA4gAygL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "MgwuTk9LS0FQR0JOSFBCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { NOKKAPGBNHPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JCADEHNDGLF), JCADEHNDGLF.Parser, new string[6] { "ICINHMIKJLH", "OJCHPAPJDFO", "PELPDAPDBKJ", "BJJONGHLOFC", "IHLLMLLNIFN", "NNKHMIEJPOI" }, null, null, null, null)
		}));
	}
}
