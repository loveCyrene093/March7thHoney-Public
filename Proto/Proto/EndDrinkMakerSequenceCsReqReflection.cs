using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EndDrinkMakerSequenceCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EndDrinkMakerSequenceCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBFbmREcmlua01ha2VyU2VxdWVuY2VDc1JlcS5wcm90byIcChpFbmREcmlu" + "a01ha2VyU2VxdWVuY2VDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EndDrinkMakerSequenceCsReq), EndDrinkMakerSequenceCsReq.Parser, null, null, null, null, null)
		}));
	}
}
