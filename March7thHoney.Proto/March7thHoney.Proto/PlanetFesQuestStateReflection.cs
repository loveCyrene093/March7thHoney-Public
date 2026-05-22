using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesQuestStateReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesQuestStateReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChlQbGFuZXRGZXNRdWVzdFN0YXRlLnByb3RvKokBChNQbGFuZXRGZXNRdWVz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dFN0YXRlEhsKF0dLQkFNUEFHTkJFX0FMREdPR1BHTk1PEAASGwoXR0tCQU1Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "QUdOQkVfQklKUENIT0xEQ1AQARIbChdHS0JBTVBBR05CRV9HTUhKSkJLRE5N";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ThACEhsKF0dLQkFNUEFHTkJFX0VGSUdJQ0pORUlNEANCFqoCE01hcmNoN3Ro";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(PlanetFesQuestState) }, null, null));
	}
}
