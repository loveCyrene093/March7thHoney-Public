using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetPlayerOutfitCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetPlayerOutfitCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTZXRQbGF5ZXJPdXRmaXRDc1JlcS5wcm90bxoWUGxheWVyT3V0Zml0SW5m" + "by5wcm90byJDChRTZXRQbGF5ZXJPdXRmaXRDc1JlcRIrChBQbGF5ZXJPdXRm" + "aXREYXRhGAIgASgLMhEuUGxheWVyT3V0Zml0SW5mb0IWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { PlayerOutfitInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetPlayerOutfitCsReq), SetPlayerOutfitCsReq.Parser, new string[1] { "PlayerOutfitData" }, null, null, null, null)
		}));
	}
}
