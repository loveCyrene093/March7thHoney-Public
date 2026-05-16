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
		buffer[0] = "CiVUcmlhbEFjdGl2aXR5RGF0YUNoYW5nZVNjTm90aWZ5LnByb3RvGhFOTkZK";
		buffer[1] = "QU9KS0tGTy5wcm90bxoXVHJpYWxBY3Rpdml0eUluZm8ucHJvdG8iigEKH1Ry";
		buffer[2] = "aWFsQWN0aXZpdHlEYXRhQ2hhbmdlU2NOb3RpZnkSIQoLTUFOR0xJUEtNREkY";
		buffer[3] = "AyADKAsyDC5OTkZKQU9KS0tGTxIvChN0cmlhbF9hY3Rpdml0eV9pbmZvGAog";
		buffer[4] = "ASgLMhIuVHJpYWxBY3Rpdml0eUluZm8SEwoLQkxETEJLTEFJQUwYDiADKA1C";
		buffer[5] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			NNFJAOJKKFOReflection.Descriptor,
			TrialActivityInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrialActivityDataChangeScNotify), TrialActivityDataChangeScNotify.Parser, new string[3] { "MANGLIPKMDI", "TrialActivityInfo", "BLDLBKLAIAL" }, null, null, null, null)
		}));
	}
}
