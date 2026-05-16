using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HEKPNLEJADBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HEKPNLEJADBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIRUtQTkxFSkFEQi5wcm90bypkCgtIRUtQTkxFSkFEQhIbChdIRUtQTkxF" + "SkFEQl9HTUlOQ01LRFBORRAAEhsKF0hFS1BOTEVKQURCX0xCS01NTURJQURJ" + "EAESGwoXSEVLUE5MRUpBREJfQU5JTk1NQU1BSEQQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(HEKPNLEJADB) }, null, null));
	}
}
