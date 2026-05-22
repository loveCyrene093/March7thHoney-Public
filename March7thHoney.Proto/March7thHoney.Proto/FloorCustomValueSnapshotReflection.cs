using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FloorCustomValueSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FloorCustomValueSnapshotReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch5GbG9vckN1c3RvbVZhbHVlU25hcHNob3QucHJvdG8aEUJMTERLQUJHS0xG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "LnByb3RvInoKGEZsb29yQ3VzdG9tVmFsdWVTbmFwc2hvdBIMCgRuYW1lGAEg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ASgJEhoKBHR5cGUYAiABKA4yDC5CTExES0FCR0tMRhIQCghib29sX3ZhbBgD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "IAEoCBIRCglmbG9hdF92YWwYBCABKAISDwoHc3RyX3ZhbBgFIAEoCUIWqgIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { BLLDKABGKLFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FloorCustomValueSnapshot), FloorCustomValueSnapshot.Parser, new string[5] { "Name", "Type", "BoolVal", "FloatVal", "StrVal" }, null, null, null, null)
		}));
	}
}
