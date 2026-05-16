using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSupplyActionResultReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSupplyActionResultReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHcmlkRmlnaHRTdXBwbHlBY3Rpb25SZXN1bHQucHJvdG8iPAobR3JpZEZp" + "Z2h0U3VwcGx5QWN0aW9uUmVzdWx0Eh0KFXNlbGVjdF9zdXBwbHlfaW5kZXhl" + "cxgGIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSupplyActionResult), GridFightSupplyActionResult.Parser, new string[1] { "SelectSupplyIndexes" }, null, null, null, null)
		}));
	}
}
