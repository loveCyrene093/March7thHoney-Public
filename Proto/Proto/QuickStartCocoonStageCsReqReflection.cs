using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class QuickStartCocoonStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static QuickStartCocoonStageCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiBRdWlja1N0YXJ0Q29jb29uU3RhZ2VDc1JlcS5wcm90bxoRTktOQUFESUdH";
		buffer[1] = "TkEucHJvdG8ihAEKGlF1aWNrU3RhcnRDb2Nvb25TdGFnZUNzUmVxEhMKC3dv";
		buffer[2] = "cmxkX2xldmVsGAIgASgNEgwKBHdhdmUYBCABKA0SDQoFQ291bnQYBSABKA0S";
		buffer[3] = "IQoLRExBQ0VFRkpBSEIYCyABKAsyDC5OS05BQURJR0dOQRIRCgljb2Nvb25f";
		buffer[4] = "aWQYDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { NKNAADIGGNAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(QuickStartCocoonStageCsReq), QuickStartCocoonStageCsReq.Parser, new string[5] { "WorldLevel", "Wave", "Count", "DLACEEFJAHB", "CocoonId" }, null, null, null, null)
		}));
	}
}
