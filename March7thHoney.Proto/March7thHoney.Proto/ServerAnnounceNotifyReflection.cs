using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ServerAnnounceNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ServerAnnounceNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTZXJ2ZXJBbm5vdW5jZU5vdGlmeS5wcm90bxoSQW5ub3VuY2VEYXRhLnBy" + "b3RvIkEKFFNlcnZlckFubm91bmNlTm90aWZ5EikKEmFubm91bmNlX2RhdGFf" + "bGlzdBgFIAMoCzINLkFubm91bmNlRGF0YUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[1] { AnnounceDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ServerAnnounceNotify), ServerAnnounceNotify.Parser, new string[1] { "AnnounceDataList" }, null, null, null, null)
		}));
	}
}
