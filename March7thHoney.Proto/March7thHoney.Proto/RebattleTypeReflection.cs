using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RebattleTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RebattleTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChJSZWJhdHRsZVR5cGUucHJvdG8q+AEKDFJlYmF0dGxlVHlwZRIWChJSRUJB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "VFRMRV9UWVBFX05PTkUQABIhCh1SRUJBVFRMRV9UWVBFX1JFQkFUVExFX01J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "RFdBWRABEh8KG1JFQkFUVExFX1RZUEVfUkVCQVRUTEVfTE9TRRACEigKJFJF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "QkFUVExFX1RZUEVfUkVCQVRUTEVfTUlEV0FZX0xJTkVVUBADEiYKIlJFQkFU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "VExFX1RZUEVfUkVCQVRUTEVfTE9TRV9MSU5FVVAQBBIdChlSRUJBVFRMRV9U";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "WVBFX1FVSVRfTUlEV0FZEAUSGwoXUkVCQVRUTEVfVFlQRV9RVUlUX0xPU0UQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "BkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(RebattleType) }, null, null));
	}
}
