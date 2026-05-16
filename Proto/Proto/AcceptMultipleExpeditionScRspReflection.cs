using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AcceptMultipleExpeditionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AcceptMultipleExpeditionScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiNBY2NlcHRNdWx0aXBsZUV4cGVkaXRpb25TY1JzcC5wcm90bxoURXhwZWRp";
		buffer[1] = "dGlvbkluZm8ucHJvdG8aDkl0ZW1MaXN0LnByb3RvIpcBCh1BY2NlcHRNdWx0";
		buffer[2] = "aXBsZUV4cGVkaXRpb25TY1JzcBITCgtLQU1CQkZERUJBTRgHIAEoAxIPCgdy";
		buffer[3] = "ZXRjb2RlGAsgASgNEh4KC0hBTEZHTEdMRExPGA4gAygLMgkuSXRlbUxpc3QS";
		buffer[4] = "MAoXYWNjZXB0X211bHRpX2V4cGVkaXRpb24YDyADKAsyDy5FeHBlZGl0aW9u";
		buffer[5] = "SW5mb0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ExpeditionInfoReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AcceptMultipleExpeditionScRsp), AcceptMultipleExpeditionScRsp.Parser, new string[4] { "KAMBBFDEBAM", "Retcode", "HALFGLGLDLO", "AcceptMultiExpedition" }, null, null, null, null)
		}));
	}
}
