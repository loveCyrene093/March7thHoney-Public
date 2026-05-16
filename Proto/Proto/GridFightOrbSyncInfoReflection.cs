using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightOrbSyncInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightOrbSyncInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHcmlkRmlnaHRPcmJTeW5jSW5mby5wcm90byI+ChRHcmlkRmlnaHRPcmJT" + "eW5jSW5mbxIRCgl1bmlxdWVfaWQYASABKA0SEwoLb3JiX2l0ZW1faWQYCSAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightOrbSyncInfo), GridFightOrbSyncInfo.Parser, new string[2] { "UniqueId", "OrbItemId" }, null, null, null, null)
		}));
	}
}
