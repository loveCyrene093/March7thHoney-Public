using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JOJLACDBPNAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JOJLACDBPNAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKT0pMQUNEQlBOQS5wcm90bxoRQkJIUE9KSkxGRUMucHJvdG8iWgoLSk9K" + "TEFDREJQTkESEwoLS0hETE1QQUtFR0YYASABKA0SIQoLUElIR0RIQUtMQ0IY" + "AyABKAsyDC5CQkhQT0pKTEZFQxITCgtFTExFTEpGR0RQSBgMIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { BBHPOJJLFECReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JOJLACDBPNA), JOJLACDBPNA.Parser, new string[3] { "KHDLMPAKEGF", "PIHGDHAKLCB", "ELLELJFGDPH" }, null, null, null, null)
		}));
	}
}
