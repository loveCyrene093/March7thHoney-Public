using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateTrackMainMissionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateTrackMainMissionScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFVcGRhdGVUcmFja01haW5NaXNzaW9uU2NSc3AucHJvdG8iZwobVXBkYXRl" + "VHJhY2tNYWluTWlzc2lvblNjUnNwEh0KFXByZXZfdHJhY2tfbWlzc2lvbl9p" + "ZBgEIAEoDRIPCgdyZXRjb2RlGAkgASgNEhgKEHRyYWNrX21pc3Npb25faWQY" + "DSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateTrackMainMissionScRsp), UpdateTrackMainMissionScRsp.Parser, new string[3] { "PrevTrackMissionId", "Retcode", "TrackMissionId" }, null, null, null, null)
		}));
	}
}
