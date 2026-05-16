using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingStartGameCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingStartGameCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFTd29yZFRyYWluaW5nU3RhcnRHYW1lQ3NSZXEucHJvdG8iOQobU3dvcmRU" + "cmFpbmluZ1N0YXJ0R2FtZUNzUmVxEhoKEmdhbWVfc3RvcnlfbGluZV9pZBgL" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingStartGameCsReq), SwordTrainingStartGameCsReq.Parser, new string[1] { "GameStoryLineId" }, null, null, null, null)
		}));
	}
}
