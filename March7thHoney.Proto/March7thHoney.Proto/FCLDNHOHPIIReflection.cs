using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FCLDNHOHPIIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FCLDNHOHPIIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGQ0xETkhPSFBJSS5wcm90byI0CgtGQ0xETkhPSFBJSRIQCghzdGFnZV9p" + "ZBgKIAEoDRITCgtDRUJQQUpBQUpQUBgLIAEoCEIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FCLDNHOHPII), FCLDNHOHPII.Parser, new string[2] { "StageId", "CEBPAJAAJPP" }, null, null, null, null)
		}));
	}
}
