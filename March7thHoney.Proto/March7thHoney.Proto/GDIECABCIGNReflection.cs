using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GDIECABCIGNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GDIECABCIGNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHRElFQ0FCQ0lHTi5wcm90byJMCgtHRElFQ0FCQ0lHThITCgtKT0JPQkpM" + "RENBShgCIAEoDRITCgtMR01LRkJJSU5HSxgHIAEoDRITCgtPRU1NREhNQkRQ" + "QRgJIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GDIECABCIGN), GDIECABCIGN.Parser, new string[3] { "JOBOBJLDCAJ", "LGMKFBIINGK", "OEMMDHMBDPA" }, null, null, null, null)
		}));
	}
}
