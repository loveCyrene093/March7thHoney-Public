using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSupplyRerollActionResultReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSupplyRerollActionResultReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidHcmlkRmlnaHRTdXBwbHlSZXJvbGxBY3Rpb25SZXN1bHQucHJvdG8iIwoh" + "R3JpZEZpZ2h0U3VwcGx5UmVyb2xsQWN0aW9uUmVzdWx0QhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSupplyRerollActionResult), GridFightSupplyRerollActionResult.Parser, null, null, null, null, null)
		}));
	}
}
