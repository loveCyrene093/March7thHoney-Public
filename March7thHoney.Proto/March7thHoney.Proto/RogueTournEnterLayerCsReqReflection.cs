using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournEnterLayerCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournEnterLayerCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Sb2d1ZVRvdXJuRW50ZXJMYXllckNzUmVxLnByb3RvIkUKGVJvZ3VlVG91" + "cm5FbnRlckxheWVyQ3NSZXESEwoLTU5NQUZLTE9KQ0MYAiABKA0SEwoLQVBN" + "SUFLRFBISkwYCCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournEnterLayerCsReq), RogueTournEnterLayerCsReq.Parser, new string[2] { "MNMAFKLOJCC", "APMIAKDPHJL" }, null, null, null, null)
		}));
	}
}
