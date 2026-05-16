using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyUseCardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyUseCardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxUcmFpblBhcnR5VXNlQ2FyZENzUmVxLnByb3RvIi0KFlRyYWluUGFydHlV" + "c2VDYXJkQ3NSZXESEwoLR0RGUEJITU1GRUEYBCABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyUseCardCsReq), TrainPartyUseCardCsReq.Parser, new string[1] { "GDFPBHMMFEA" }, null, null, null, null)
		}));
	}
}
