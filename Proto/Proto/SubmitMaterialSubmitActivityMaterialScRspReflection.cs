using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SubmitMaterialSubmitActivityMaterialScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SubmitMaterialSubmitActivityMaterialScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ci9TdWJtaXRNYXRlcmlhbFN1Ym1pdEFjdGl2aXR5TWF0ZXJpYWxTY1JzcC5w";
		buffer[1] = "cm90bxoRSEJQRkZLTk5MQkMucHJvdG8iXwopU3VibWl0TWF0ZXJpYWxTdWJt";
		buffer[2] = "aXRBY3Rpdml0eU1hdGVyaWFsU2NSc3ASDwoHcmV0Y29kZRgFIAEoDRIhCgtE";
		buffer[3] = "TU1PRkNDTUtQRRgLIAEoCzIMLkhCUEZGS05OTEJDQhaqAhNNYXJjaDd0aEhv";
		buffer[4] = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { HBPFFKNNLBCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SubmitMaterialSubmitActivityMaterialScRsp), SubmitMaterialSubmitActivityMaterialScRsp.Parser, new string[2] { "Retcode", "DMMOFCCMKPE" }, null, null, null, null)
		}));
	}
}
