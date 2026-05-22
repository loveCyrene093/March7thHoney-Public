using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPreAvatarActivityListCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPreAvatarActivityListCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNHZXRQcmVBdmF0YXJBY3Rpdml0eUxpc3RDc1JlcS5wcm90byIfCh1HZXRQ" + "cmVBdmF0YXJBY3Rpdml0eUxpc3RDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPreAvatarActivityListCsReq), GetPreAvatarActivityListCsReq.Parser, null, null, null, null, null)
		}));
	}
}
