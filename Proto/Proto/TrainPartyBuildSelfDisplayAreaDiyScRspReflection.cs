using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyBuildSelfDisplayAreaDiyScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyBuildSelfDisplayAreaDiyScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CixUcmFpblBhcnR5QnVpbGRTZWxmRGlzcGxheUFyZWFEaXlTY1JzcC5wcm90";
		buffer[1] = "bxoRS0pHTUFFR05CS0wucHJvdG8iXAomVHJhaW5QYXJ0eUJ1aWxkU2VsZkRp";
		buffer[2] = "c3BsYXlBcmVhRGl5U2NSc3ASIQoLSUNKRkxMRENGSE0YASABKAsyDC5LSkdN";
		buffer[3] = "QUVHTkJLTBIPCgdyZXRjb2RlGAMgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[4] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { KJGMAEGNBKLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyBuildSelfDisplayAreaDiyScRsp), TrainPartyBuildSelfDisplayAreaDiyScRsp.Parser, new string[2] { "ICJFLLDCFHM", "Retcode" }, null, null, null, null)
		}));
	}
}
