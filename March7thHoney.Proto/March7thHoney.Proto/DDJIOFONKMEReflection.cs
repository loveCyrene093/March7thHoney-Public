using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DDJIOFONKMEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DDJIOFONKMEReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFEREpJT0ZPTktNRS5wcm90bxocR3JpZEZpZ2h0RGFtYWdlU3R0SW5mby5w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "cm90bxogR3JpZEZpZ2h0U2VjdGlvblJlY29yZEluZm8ucHJvdG8ifAoLRERK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "SU9GT05LTUUSMAoLS0lMQUJHUE1QQkIYCSADKAsyGy5HcmlkRmlnaHRTZWN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "aW9uUmVjb3JkSW5mbxI7ChpncmlkX2ZpZ2h0X2RhbWFnZV9zdHRfaW5mbxgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "IAEoCzIXLkdyaWRGaWdodERhbWFnZVN0dEluZm9CFqoCE01hcmNoN3RoSG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			GridFightDamageSttInfoReflection.Descriptor,
			GridFightSectionRecordInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DDJIOFONKME), DDJIOFONKME.Parser, new string[2] { "KILABGPMPBB", "GridFightDamageSttInfo" }, null, null, null, null)
		}));
	}
}
