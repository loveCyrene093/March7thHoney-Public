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
		buffer[0] = "ChdIZWFydERpYWxTdGVwVHlwZS5wcm90byroAQoRSGVhcnREaWFsU3RlcFR5";
		buffer[1] = "cGUSIQodSGVhcnREaWFsU3RlcFR5cGVfQ09FRUpBTEVMUEYQABIhCh1IZWFy";
		buffer[2] = "dERpYWxTdGVwVHlwZV9CQURQQkdGSlBOThABEiQKIEhlYXJ0RGlhbFN0ZXBU";
		buffer[3] = "eXBlX2dhbWVfbG9ja19pbmZvEAISIQodSGVhcnREaWFsU3RlcFR5cGVfQ0NK";
		buffer[4] = "TUtOTkhLS0UQAxIhCh1IZWFydERpYWxTdGVwVHlwZV9CRUpFQkJORkdQTRAE";
		buffer[5] = "EiEKHUhlYXJ0RGlhbFN0ZXBUeXBlX05HTkZPSUhOTE1KEAVCFqoCE01hcmNo";
		buffer[6] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(HeartDialStepType) }, null, null));
	}
}
