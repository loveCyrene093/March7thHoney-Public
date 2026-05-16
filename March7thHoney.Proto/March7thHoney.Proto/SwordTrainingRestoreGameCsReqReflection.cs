using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingRestoreGameCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingRestoreGameCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNTd29yZFRyYWluaW5nUmVzdG9yZUdhbWVDc1JlcS5wcm90byIfCh1Td29y" + "ZFRyYWluaW5nUmVzdG9yZUdhbWVDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingRestoreGameCsReq), SwordTrainingRestoreGameCsReq.Parser, null, null, null, null, null)
		}));
	}
}
