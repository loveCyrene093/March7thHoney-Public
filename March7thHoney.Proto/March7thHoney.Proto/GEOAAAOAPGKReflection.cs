using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GEOAAAOAPGKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GEOAAAOAPGKReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFHRU9BQUFPQVBHSy5wcm90bxoRQ0NCS0dKR05EQ0wucHJvdG8aEUVJTkpM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "QkJBR0RMLnByb3RvGhFKQ0NNR09PUEhCTy5wcm90byKLAQoLR0VPQUFBT0FQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "R0sSIQoLSk9CSUhLUExIRU4YAiADKAsyDC5DQ0JLR0pHTkRDTBIhCgtJQUhK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "SkJQR09LQhgFIAMoCzIMLkVJTkpMQkJBR0RMEhMKC0ZORkhITkZPRUlNGAcg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "AygNEiEKC09BSUtJRkVLRkxHGA8gAygLMgwuSkNDTUdPT1BIQk9CFqoCE01h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[3]
		{
			CCBKGJGNDCLReflection.Descriptor,
			EINJLBBAGDLReflection.Descriptor,
			JCCMGOOPHBOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GEOAAAOAPGK), GEOAAAOAPGK.Parser, new string[4] { "JOBIHKPLHEN", "IAHJJBPGOKB", "FNFHHNFOEIM", "OAIKIFEKFLG" }, null, null, null, null)
		}));
	}
}
