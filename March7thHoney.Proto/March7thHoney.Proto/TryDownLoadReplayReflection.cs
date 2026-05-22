using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TryDownLoadReplayReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TryDownLoadReplayReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdUcnlEb3duTG9hZFJlcGxheS5wcm90bxoQUmVwbGF5SW5mby5wcm90byJT" + "ChFUcnlEb3duTG9hZFJlcGxheRITCgtyZXBsYXlfbmFtZRgBIAEoCRIpChR0" + "cnlfZG93bl9sb2FkX3JlcGxheRgCIAEoCzILLlJlcGxheUluZm9CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ReplayInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TryDownLoadReplay), TryDownLoadReplay.Parser, new string[2] { "ReplayName", "TryDownLoadReplay_" }, null, null, null, null)
		}));
	}
}
