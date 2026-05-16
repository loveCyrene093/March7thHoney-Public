using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EKGAMNCMOEJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EKGAMNCMOEJReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFFS0dBTU5DTU9FSi5wcm90bxoRT0NMRUpMRUZCRk8ucHJvdG8ifQoLRUtH";
		buffer[1] = "QU1OQ01PRUoSEwoLREZMTUtDSUtGT1AYAyABKAkSDwoHcmV0Y29kZRgGIAEo";
		buffer[2] = "DRIQCghzdGFnZV9pZBgLIAEoDRIhCgtyZXBsYXlfdHlwZRgNIAEoDjIMLk9D";
		buffer[3] = "TEVKTEVGQkZPEhMKC0VGTEFFQU5LQUNNGA4gASgJQhaqAhNNYXJjaDd0aEhv";
		buffer[4] = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { OCLEJLEFBFOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EKGAMNCMOEJ), EKGAMNCMOEJ.Parser, new string[5] { "DFLMKCIKFOP", "Retcode", "StageId", "ReplayType", "EFLAEANKACM" }, null, null, null, null)
		}));
	}
}
