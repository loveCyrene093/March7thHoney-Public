using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BDHENEOKMFEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BDHENEOKMFEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCREhFTkVPS01GRS5wcm90bypkCgtCREhFTkVPS01GRRIbChdCREhFTkVP" + "S01GRV9QQ1BESEVMUEtFTRAAEhsKF0JESEVORU9LTUZFX0xOQkpGQUdLUENE" + "EAESGwoXQkRIRU5FT0tNRkVfSEJJS0lJR1BKTUoQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(BDHENEOKMFE) }, null, null));
	}
}
