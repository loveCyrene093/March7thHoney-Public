using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class WorldUnlockCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static WorldUnlockCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZXb3JsZFVubG9ja0NzUmVxLnByb3RvIicKEFdvcmxkVW5sb2NrQ3NSZXES" + "EwoLTExPTE9FSFBGSEEYCiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(WorldUnlockCsReq), WorldUnlockCsReq.Parser, new string[1] { "LLOLOEHPFHA" }, null, null, null, null)
		}));
	}
}
