using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SocialPlayTalkScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SocialPlayTalkScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlTb2NpYWxQbGF5VGFsa1NjUnNwLnByb3RvGhFHRkxLREhQQkFNSi5wcm90" + "byJbChNTb2NpYWxQbGF5VGFsa1NjUnNwEg8KB3JldGNvZGUYBCABKA0SIQoL" + "TkdQR0tGRUxDRUQYBSABKAsyDC5HRkxLREhQQkFNShIQCghlbmRfdGltZRgL" + "IAEoA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GFLKDHPBAMJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SocialPlayTalkScRsp), SocialPlayTalkScRsp.Parser, new string[3] { "Retcode", "NGPGKFELCED", "EndTime" }, null, null, null, null)
		}));
	}
}
