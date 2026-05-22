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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ci9TdWJtaXRNYXRlcmlhbFN1Ym1pdEFjdGl2aXR5TWF0ZXJpYWxTY1JzcC5w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "cm90bxoRSEJQRkZLTk5MQkMucHJvdG8iXwopU3VibWl0TWF0ZXJpYWxTdWJt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "aXRBY3Rpdml0eU1hdGVyaWFsU2NSc3ASDwoHcmV0Y29kZRgFIAEoDRIhCgtE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "TU1PRkNDTUtQRRgLIAEoCzIMLkhCUEZGS05OTEJDQhaqAhNNYXJjaDd0aEhv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { HBPFFKNNLBCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SubmitMaterialSubmitActivityMaterialScRsp), SubmitMaterialSubmitActivityMaterialScRsp.Parser, new string[2] { "Retcode", "DMMOFCCMKPE" }, null, null, null, null)
		}));
	}
}
