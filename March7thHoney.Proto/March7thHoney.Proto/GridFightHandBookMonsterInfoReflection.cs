using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightHandBookMonsterInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightHandBookMonsterInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJHcmlkRmlnaHRIYW5kQm9va01vbnN0ZXJJbmZvLnByb3RvIjMKHEdyaWRG" + "aWdodEhhbmRCb29rTW9uc3RlckluZm8SEwoLSEdBSE1JUElCTE8YAiADKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightHandBookMonsterInfo), GridFightHandBookMonsterInfo.Parser, new string[1] { "HGAHMIPIBLO" }, null, null, null, null)
		}));
	}
}
