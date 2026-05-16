using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicReforgeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicReforgeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdSZWxpY1JlZm9yZ2VDc1JlcS5wcm90byJQChFSZWxpY1JlZm9yZ2VDc1Jl" + "cRIiChpyZWZvcmdlX2Jsb2NrX3N1Yl9hZmZpeF9pZBgGIAEoDRIXCg9yZWxp" + "Y191bmlxdWVfaWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicReforgeCsReq), RelicReforgeCsReq.Parser, new string[2] { "ReforgeBlockSubAffixId", "RelicUniqueId" }, null, null, null, null)
		}));
	}
}
