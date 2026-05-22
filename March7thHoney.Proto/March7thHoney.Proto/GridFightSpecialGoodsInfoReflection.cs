using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSpecialGoodsInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSpecialGoodsInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HcmlkRmlnaHRTcGVjaWFsR29vZHNJbmZvLnByb3RvIjUKGUdyaWRGaWdo" + "dFNwZWNpYWxHb29kc0luZm8SGAoQc3BlY2lhbF9nb29kc19pZBgEIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSpecialGoodsInfo), GridFightSpecialGoodsInfo.Parser, new string[1] { "SpecialGoodsId" }, null, null, null, null)
		}));
	}
}
