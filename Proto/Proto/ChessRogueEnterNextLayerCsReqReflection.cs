using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueEnterNextLayerCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueEnterNextLayerCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDaGVzc1JvZ3VlRW50ZXJOZXh0TGF5ZXJDc1JlcS5wcm90byIfCh1DaGVz" + "c1JvZ3VlRW50ZXJOZXh0TGF5ZXJDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueEnterNextLayerCsReq), ChessRogueEnterNextLayerCsReq.Parser, null, null, null, null, null)
		}));
	}
}
