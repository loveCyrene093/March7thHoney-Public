using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GNLMENKBHLEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GNLMENKBHLEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHTkxNRU5LQkhMRS5wcm90byI3CgtHTkxNRU5LQkhMRRITCgtNTU9KT0VD" + "RE1JTBgMIAMoDRITCgtHSUpPQUFES0RJThgPIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GNLMENKBHLE), GNLMENKBHLE.Parser, new string[2] { "MMOJOECDMIL", "GIJOAADKDIN" }, null, null, null, null)
		}));
	}
}
