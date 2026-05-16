using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainCakeCatchGetDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainCakeCatchGetDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBUcmFpbkNha2VDYXRjaEdldERhdGFDc1JlcS5wcm90byIcChpUcmFpbkNh" + "a2VDYXRjaEdldERhdGFDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainCakeCatchGetDataCsReq), TrainCakeCatchGetDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
