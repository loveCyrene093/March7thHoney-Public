using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdFightActivityTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdFightActivityTypeReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "ChpDbWRGaWdodEFjdGl2aXR5VHlwZS5wcm90byq6AgoUQ21kRmlnaHRBY3Rp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "dml0eVR5cGUSGwoXTkFDQk9FUEVJQ01fUENQREhFTFBLRU0QABIkCh9DbWRU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "YWtlRmlnaHRBY3Rpdml0eVJld2FyZFNjUnNwEJkcEiQKH0NtZFRha2VGaWdo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "dEFjdGl2aXR5UmV3YXJkQ3NSZXEQohwSIQocQ21kR2V0RmlnaHRBY3Rpdml0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "eURhdGFDc1JlcRDrHBIhChxDbWRHZXRGaWdodEFjdGl2aXR5RGF0YVNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "EJocEiQKH0NtZEVudGVyRmlnaHRBY3Rpdml0eVN0YWdlQ3NSZXEQ7xwSJAof";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "Q21kRW50ZXJGaWdodEFjdGl2aXR5U3RhZ2VTY1JzcBCeHBInCiJDbWRGaWdo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "dEFjdGl2aXR5RGF0YUNoYW5nZVNjTm90aWZ5EO4cQhaqAhNNYXJjaDd0aEhv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdFightActivityType) }, null, null));
	}
}
