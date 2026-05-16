using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PunkLordMonsterBasicInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PunkLordMonsterBasicInfoReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "Ch5QdW5rTG9yZE1vbnN0ZXJCYXNpY0luZm8ucHJvdG8aF1B1bmtMb3JkU2hh";
		buffer[1] = "cmVUeXBlLnByb3RvItwBChhQdW5rTG9yZE1vbnN0ZXJCYXNpY0luZm8SCwoD";
		buffer[2] = "dWlkGAEgASgNEhIKCm1vbnN0ZXJfaWQYAiABKA0SEQoJY29uZmlnX2lkGAMg";
		buffer[3] = "ASgNEhMKC3dvcmxkX2xldmVsGAQgASgNEhMKC2NyZWF0ZV90aW1lGAUgASgD";
		buffer[4] = "Eg8KB2xlZnRfaHAYBiABKA0SFAoMYXR0YWNrZXJfbnVtGAcgASgNEiYKCnNo";
		buffer[5] = "YXJlX3R5cGUYCCABKA4yEi5QdW5rTG9yZFNoYXJlVHlwZRITCgtPS0hFTElF";
		buffer[6] = "TE5NRRgJIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PunkLordShareTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PunkLordMonsterBasicInfo), PunkLordMonsterBasicInfo.Parser, new string[9] { "Uid", "MonsterId", "ConfigId", "WorldLevel", "CreateTime", "LeftHp", "AttackerNum", "ShareType", "OKHELIELNME" }, null, null, null, null)
		}));
	}
}
