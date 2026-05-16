using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightRoundBeginActionResultReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightRoundBeginActionResultReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVHcmlkRmlnaHRSb3VuZEJlZ2luQWN0aW9uUmVzdWx0LnByb3RvIiEKH0dy" + "aWRGaWdodFJvdW5kQmVnaW5BY3Rpb25SZXN1bHRCFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightRoundBeginActionResult), GridFightRoundBeginActionResult.Parser, null, null, null, null, null)
		}));
	}
}
