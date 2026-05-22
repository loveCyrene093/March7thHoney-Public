using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JCEEENOLDIFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JCEEENOLDIFReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFKQ0VFRU5PTERJRi5wcm90bxofVHJlYXN1cmVEdW5nZW9uUmVjb3JkVHlw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "ZS5wcm90byKLAQoLSkNFRUVOT0xESUYSKAoEdHlwZRgDIAEoDjIaLlRyZWFz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "dXJlRHVuZ2VvblJlY29yZFR5cGUSEwoLQ01BUENHR0FCSkkYCCABKA0SEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "R0hBSUdMQUhNSE8YCiABKA0SEwoLUE5JRE5PR0hNQkgYDCABKA0SEwoLSEFG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "RkRERFBGR0EYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { TreasureDungeonRecordTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JCEEENOLDIF), JCEEENOLDIF.Parser, new string[5] { "Type", "CMAPCGGABJI", "GHAIGLAHMHO", "PNIDNOGHMBH", "HAFFDDDPFGA" }, null, null, null, null)
		}));
	}
}
