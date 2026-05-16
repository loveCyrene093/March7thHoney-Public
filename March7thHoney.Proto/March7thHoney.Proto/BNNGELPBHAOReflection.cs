using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BNNGELPBHAOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BNNGELPBHAOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCTk5HRUxQQkhBTy5wcm90byIiCgtCTk5HRUxQQkhBTxITCgtHRkVKR0hD" + "Q01JThgOIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BNNGELPBHAO), BNNGELPBHAO.Parser, new string[1] { "GFEJGHCCMIN" }, null, null, null, null)
		}));
	}
}
