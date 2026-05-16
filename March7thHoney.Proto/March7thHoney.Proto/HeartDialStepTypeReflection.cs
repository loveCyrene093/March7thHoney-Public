using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeartDialStepTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeartDialStepTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChdIZWFydERpYWxTdGVwVHlwZS5wcm90byroAQoRSGVhcnREaWFsU3RlcFR5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "cGUSIQodSGVhcnREaWFsU3RlcFR5cGVfQ09FRUpBTEVMUEYQABIhCh1IZWFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "dERpYWxTdGVwVHlwZV9CQURQQkdGSlBOThABEiQKIEhlYXJ0RGlhbFN0ZXBU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "eXBlX2dhbWVfbG9ja19pbmZvEAISIQodSGVhcnREaWFsU3RlcFR5cGVfQ0NK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "TUtOTkhLS0UQAxIhCh1IZWFydERpYWxTdGVwVHlwZV9CRUpFQkJORkdQTRAE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "EiEKHUhlYXJ0RGlhbFN0ZXBUeXBlX05HTkZPSUhOTE1KEAVCFqoCE01hcmNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(HeartDialStepType) }, null, null));
	}
}
