using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PKNBPAHCIMJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PKNBPAHCIMJReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFQS05CUEFIQ0lNSi5wcm90byK0AQoLUEtOQlBBSENJTUoSEwoLQ09LR09Q";
		buffer[1] = "Qk1MUFAYAiABKA0SMgoLSE5FTktBSERCS00YBSADKAsyHS5QS05CUEFIQ0lN";
		buffer[2] = "Si5ITkVOS0FIREJLTUVudHJ5EhMKC1BQT0dQT0pKRUxKGAwgASgNEhMKC0dM";
		buffer[3] = "SU9ORUVMT0pIGA0gASgNGjIKEEhORU5LQUhEQktNRW50cnkSCwoDa2V5GAEg";
		buffer[4] = "ASgNEg0KBXZhbHVlGAIgASgNOgI4AUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[5] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PKNBPAHCIMJ), PKNBPAHCIMJ.Parser, new string[4] { "COKGOPBMLPP", "HNENKAHDBKM", "PPOGPOJJELJ", "GLIONEELOJH" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
