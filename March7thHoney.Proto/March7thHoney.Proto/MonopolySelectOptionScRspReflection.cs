using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolySelectOptionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolySelectOptionScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "Ch9Nb25vcG9seVNlbGVjdE9wdGlvblNjUnNwLnByb3RvGhFCTElKRUtLT0lK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "SC5wcm90bxoRTlBMQUxFRlBJRUUucHJvdG8imQEKGU1vbm9wb2x5U2VsZWN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "T3B0aW9uU2NSc3ASDwoHcmV0Y29kZRgBIAEoDRIhCgtHR0xET0dJSEZMRxgC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "IAEoCzIMLkJMSUpFS0tPSUpIEhMKC0FNQURGSk5ITUZGGAsgASgNEhAKCGV2";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "ZW50X2lkGA0gASgNEiEKC0pCTExJQ09PQ0FLGA4gAygLMgwuTlBMQUxFRlBJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "RUVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			BLIJEKKOIJHReflection.Descriptor,
			NPLALEFPIEEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolySelectOptionScRsp), MonopolySelectOptionScRsp.Parser, new string[5] { "Retcode", "GGLDOGIHFLG", "AMADFJNHMFF", "EventId", "JBLLICOOCAK" }, null, null, null, null)
		}));
	}
}
