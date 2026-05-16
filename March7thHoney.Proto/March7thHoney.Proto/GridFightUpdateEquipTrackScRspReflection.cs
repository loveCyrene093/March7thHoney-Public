using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightUpdateEquipTrackScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightUpdateEquipTrackScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRHcmlkRmlnaHRVcGRhdGVFcXVpcFRyYWNrU2NSc3AucHJvdG8iMQoeR3Jp" + "ZEZpZ2h0VXBkYXRlRXF1aXBUcmFja1NjUnNwEg8KB3JldGNvZGUYDCABKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightUpdateEquipTrackScRsp), GridFightUpdateEquipTrackScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
