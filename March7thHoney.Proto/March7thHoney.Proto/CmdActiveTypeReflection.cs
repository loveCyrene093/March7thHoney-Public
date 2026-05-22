using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdActiveTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdActiveTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChNDbWRBY3RpdmVUeXBlLnByb3RvKuwBCg1DbWRBY3RpdmVUeXBlEhsKF0RP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "SUxQRFBFTkxKX1BDUERIRUxQS0VNEAASIgodQ21kR2V0QWN0aXZlQWN0aXZp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "dHlEYXRhU2NSc3AQ4koSKAojQ21kQWN0aXZlQWN0aXZpdHlEYXRhQ2hhbmdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "U2NOb3RpZnkQ3UoSJQogQ21kVGFrZUFjdGl2ZUFjdGl2aXR5UmV3YXJkQ3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "ZXEQ0EoSIgodQ21kR2V0QWN0aXZpdHlBY3RpdmVEYXRhQ3NSZXEQz0oSJQog";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "Q21kVGFrZUFjdGl2ZUFjdGl2aXR5UmV3YXJkU2NSc3AQ2EpCFqoCE01hcmNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdActiveType) }, null, null));
	}
}
