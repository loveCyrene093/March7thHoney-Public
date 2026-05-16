using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightRoundBeginActionInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightRoundBeginActionInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNHcmlkRmlnaHRSb3VuZEJlZ2luQWN0aW9uSW5mby5wcm90byIfCh1Hcmlk" + "RmlnaHRSb3VuZEJlZ2luQWN0aW9uSW5mb0IWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightRoundBeginActionInfo), GridFightRoundBeginActionInfo.Parser, null, null, null, null, null)
		}));
	}
}
