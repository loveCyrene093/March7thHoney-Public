using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakePunkLordPointRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakePunkLordPointRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJUYWtlUHVua0xvcmRQb2ludFJld2FyZENzUmVxLnByb3RvIkIKHFRha2VQ" + "dW5rTG9yZFBvaW50UmV3YXJkQ3NSZXESDQoFbGV2ZWwYASABKA0SEwoLT0lO" + "TUVORlBPRFAYByABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakePunkLordPointRewardCsReq), TakePunkLordPointRewardCsReq.Parser, new string[2] { "Level", "OINMENFPODP" }, null, null, null, null)
		}));
	}
}
