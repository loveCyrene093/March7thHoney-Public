using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetHipplenOutfitScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetHipplenOutfitScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTZXRIaXBwbGVuT3V0Zml0U2NSc3AucHJvdG8iPQoVU2V0SGlwcGxlbk91" + "dGZpdFNjUnNwEhMKC01KTExPRUVESkVBGAUgAygNEg8KB3JldGNvZGUYCCAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetHipplenOutfitScRsp), SetHipplenOutfitScRsp.Parser, new string[2] { "MJLLOEEDJEA", "Retcode" }, null, null, null, null)
		}));
	}
}
