using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrialActivityDataChangeScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrialActivityDataChangeScNotifyReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiVUcmlhbEFjdGl2aXR5RGF0YUNoYW5nZVNjTm90aWZ5LnByb3RvGhFOTkZK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "QU9KS0tGTy5wcm90bxoXVHJpYWxBY3Rpdml0eUluZm8ucHJvdG8iigEKH1Ry";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "aWFsQWN0aXZpdHlEYXRhQ2hhbmdlU2NOb3RpZnkSIQoLTUFOR0xJUEtNREkY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "AyADKAsyDC5OTkZKQU9KS0tGTxIvChN0cmlhbF9hY3Rpdml0eV9pbmZvGAog";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "ASgLMhIuVHJpYWxBY3Rpdml0eUluZm8SEwoLQkxETEJLTEFJQUwYDiADKA1C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			NNFJAOJKKFOReflection.Descriptor,
			TrialActivityInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrialActivityDataChangeScNotify), TrialActivityDataChangeScNotify.Parser, new string[3] { "MANGLIPKMDI", "TrialActivityInfo", "BLDLBKLAIAL" }, null, null, null, null)
		}));
	}
}
