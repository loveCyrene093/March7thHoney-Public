using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SocialPlayTalkCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SocialPlayTalkCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlTb2NpYWxQbGF5VGFsa0NzUmVxLnByb3RvGhFHRkxLREhQQkFNSi5wcm90" + "byI4ChNTb2NpYWxQbGF5VGFsa0NzUmVxEiEKC05HUEdLRkVMQ0VEGAwgASgL" + "MgwuR0ZMS0RIUEJBTUpCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[1] { GFLKDHPBAMJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SocialPlayTalkCsReq), SocialPlayTalkCsReq.Parser, new string[1] { "NGPGKFELCED" }, null, null, null, null)
		}));
	}
}
