using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTalentStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTalentStatusReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdSb2d1ZVRhbGVudFN0YXR1cy5wcm90bypqChFSb2d1ZVRhbGVudFN0YXR1" + "cxIbChdKSElETEJISlBCSl9ES0xQQUFGRkxFRRAAEhsKF0pISURMQkhKUEJK" + "X05HTU1JQ09HREZQEAESGwoXSkhJRExCSEpQQkpfS1BBS0FLT0dEQ00QAkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(RogueTalentStatus) }, null, null));
	}
}
