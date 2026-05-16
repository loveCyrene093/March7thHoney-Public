using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateMarkChestScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateMarkChestScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChpVcGRhdGVNYXJrQ2hlc3RTY1JzcC5wcm90bxoXTWFya0NoZXN0RnVuY0lu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Zm8ucHJvdG8ihAEKFFVwZGF0ZU1hcmtDaGVzdFNjUnNwEjAKFG1hcmtfY2hl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "c3RfZnVuY19pbmZvGAYgAygLMhIuTWFya0NoZXN0RnVuY0luZm8SDwoHZnVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Y19pZBgJIAEoDRIYChB0cmlnZ2VyX3BhcmFtX2lkGA4gASgNEg8KB3JldGNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "ZGUYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { MarkChestFuncInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateMarkChestScRsp), UpdateMarkChestScRsp.Parser, new string[4] { "MarkChestFuncInfo", "FuncId", "TriggerParamId", "Retcode" }, null, null, null, null)
		}));
	}
}
