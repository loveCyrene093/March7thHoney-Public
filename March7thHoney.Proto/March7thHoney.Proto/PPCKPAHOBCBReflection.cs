using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PPCKPAHOBCBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PPCKPAHOBCBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQUENLUEFIT0JDQi5wcm90bxoRQURQREtGQkhKUE4ucHJvdG8iMAoLUFBD" + "S1BBSE9CQ0ISIQoLSkNFTUpCTU1DT0cYByABKAsyDC5BRFBES0ZCSEpQTkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ADPDKFBHJPNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PPCKPAHOBCB), PPCKPAHOBCB.Parser, new string[1] { "JCEMJBMMCOG" }, null, null, null, null)
		}));
	}
}
