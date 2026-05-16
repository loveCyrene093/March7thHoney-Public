using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetTrialActivityDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetTrialActivityDataScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "Ch9HZXRUcmlhbEFjdGl2aXR5RGF0YVNjUnNwLnByb3RvGhFOTkZKQU9KS0tG";
		buffer[1] = "Ty5wcm90bxoXVHJpYWxBY3Rpdml0eUluZm8ucHJvdG8itQEKGUdldFRyaWFs";
		buffer[2] = "QWN0aXZpdHlEYXRhU2NSc3ASEwoLQkxETEJLTEFJQUwYAiADKA0SDwoHcmV0";
		buffer[3] = "Y29kZRgDIAEoDRIZChFhY3Rpdml0eV9zdGFnZV9pZBgFIAEoDRIhCgtNQU5H";
		buffer[4] = "TElQS01ESRgNIAMoCzIMLk5ORkpBT0pLS0ZPEjQKGHRyaWFsX2FjdGl2aXR5";
		buffer[5] = "X2luZm9fbGlzdBgPIAMoCzISLlRyaWFsQWN0aXZpdHlJbmZvQhaqAhNNYXJj";
		buffer[6] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			NNFJAOJKKFOReflection.Descriptor,
			TrialActivityInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetTrialActivityDataScRsp), GetTrialActivityDataScRsp.Parser, new string[5] { "BLDLBKLAIAL", "Retcode", "ActivityStageId", "MANGLIPKMDI", "TrialActivityInfoList" }, null, null, null, null)
		}));
	}
}
