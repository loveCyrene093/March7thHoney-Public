using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightDropInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightDropInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHcmlkRmlnaHREcm9wSW5mby5wcm90bxoRTEhQUElBS0tGTUUucHJvdG8i" + "NgoRR3JpZEZpZ2h0RHJvcEluZm8SIQoLUElCTEpMQkNLSkwYASADKAsyDC5M" + "SFBQSUFLS0ZNRUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { LHPPIAKKFMEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightDropInfo), GridFightDropInfo.Parser, new string[1] { "PIBLJLBCKJL" }, null, null, null, null)
		}));
	}
}
