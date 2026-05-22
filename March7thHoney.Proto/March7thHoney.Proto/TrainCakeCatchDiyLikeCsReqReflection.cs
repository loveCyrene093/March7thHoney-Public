using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainCakeCatchDiyLikeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainCakeCatchDiyLikeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBUcmFpbkNha2VDYXRjaERpeUxpa2VDc1JlcS5wcm90byIcChpUcmFpbkNh" + "a2VDYXRjaERpeUxpa2VDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainCakeCatchDiyLikeCsReq), TrainCakeCatchDiyLikeCsReq.Parser, null, null, null, null, null)
		}));
	}
}
