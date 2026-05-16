using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TravelBrochureApplyPasterListCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TravelBrochureApplyPasterListCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CihUcmF2ZWxCcm9jaHVyZUFwcGx5UGFzdGVyTGlzdENzUmVxLnByb3RvGhFJ";
		buffer[1] = "SExMQkhMRUdNRC5wcm90byJcCiJUcmF2ZWxCcm9jaHVyZUFwcGx5UGFzdGVy";
		buffer[2] = "TGlzdENzUmVxEiEKC01MRk5MSUJDQk1PGA0gAygLMgwuSUhMTEJITEVHTUQS";
		buffer[3] = "EwoLSEJDSlBDTUpQSEUYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { IHLLBHLEGMDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TravelBrochureApplyPasterListCsReq), TravelBrochureApplyPasterListCsReq.Parser, new string[2] { "MLFNLIBCBMO", "HBCJPCMJPHE" }, null, null, null, null)
		}));
	}
}
