using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ECJNAIOLKJDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ECJNAIOLKJDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFQ0pOQUlPTEtKRC5wcm90bxoRTUNBQ0RGSENQSUUucHJvdG8iRQoLRUNK" + "TkFJT0xLSkQSEwoLUEJDTEtDQkxNTUkYAiABKA0SIQoLdGFsZW50X2luZm8Y" + "BSABKAsyDC5NQ0FDREZIQ1BJRUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { MCACDFHCPIEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ECJNAIOLKJD), ECJNAIOLKJD.Parser, new string[2] { "PBCLKCBLMMI", "TalentInfo" }, null, null, null, null)
		}));
	}
}
