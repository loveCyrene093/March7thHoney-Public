using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSupplyActionInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSupplyActionInfoReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "Ch9HcmlkRmlnaHRTdXBwbHlBY3Rpb25JbmZvLnByb3RvGh1HcmlkRmlnaHRT";
		buffer[1] = "dXBwbHlSb2xlSW5mby5wcm90byKoAQoZR3JpZEZpZ2h0U3VwcGx5QWN0aW9u";
		buffer[2] = "SW5mbxI3ChVzdXBwbHlfcm9sZV9pbmZvX2xpc3QYAiADKAsyGC5HcmlkRmln";
		buffer[3] = "aHRTdXBwbHlSb2xlSW5mbxITCgtFT09QT0ZDQ0hBQRgFIAEoDRITCgtDR0ZM";
		buffer[4] = "TUNITUJITBgGIAEoDRITCgtGQ0hQSktBSUJIQhgLIAEoDRITCgtQREZJQ0JJ";
		buffer[5] = "TUhKTRgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightSupplyRoleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSupplyActionInfo), GridFightSupplyActionInfo.Parser, new string[5] { "SupplyRoleInfoList", "EOOPOFCCHAA", "CGFLMCHMBHL", "FCHPJKAIBHB", "PDFICBIMHJM" }, null, null, null, null)
		}));
	}
}
