using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartTrackPhotoStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartTrackPhotoStageScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9TdGFydFRyYWNrUGhvdG9TdGFnZVNjUnNwLnByb3RvIkEKGVN0YXJ0VHJh" + "Y2tQaG90b1N0YWdlU2NSc3ASDwoHcmV0Y29kZRgKIAEoDRITCgtNRElMREpN" + "UE5HSBgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartTrackPhotoStageScRsp), StartTrackPhotoStageScRsp.Parser, new string[2] { "Retcode", "MDILDJMPNGH" }, null, null, null, null)
		}));
	}
}
