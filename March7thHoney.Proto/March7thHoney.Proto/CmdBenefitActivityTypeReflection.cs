using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdBenefitActivityTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdBenefitActivityTypeReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChxDbWRCZW5lZml0QWN0aXZpdHlUeXBlLnByb3RvKoECChZDbWRCZW5lZml0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "QWN0aXZpdHlUeXBlEhsKF0RMSlBBTEhBUFBMX1BDUERIRUxQS0VNEAASHgoZ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "Q21kR2V0QmVuZWZpdEFjdGl2aXR5SW5mbxD5JRITCg5DbWRDREZHQlBPUE5B";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "TBCYJhIgChtDbWRKb2luQmVuZWZpdEFjdGl2aXR5Q3NSZXEQlSYSIwoeQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "R2V0QmVuZWZpdEFjdGl2aXR5SW5mb0NzUmVxEP8lEiYKIUNtZFRha2VCZW5l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "Zml0QWN0aXZpdHlSZXdhcmRDc1JlcRCQJhImCiFDbWRUYWtlQmVuZWZpdEFj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "dGl2aXR5UmV3YXJkU2NSc3AQjSZCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdBenefitActivityType) }, null, null));
	}
}
