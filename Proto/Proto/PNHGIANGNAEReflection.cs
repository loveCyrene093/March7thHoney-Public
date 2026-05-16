using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PNHGIANGNAEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PNHGIANGNAEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQTkhHSUFOR05BRS5wcm90byJRCgtQTkhHSUFOR05BRRIlCh11bmZpbmlz" + "aGVkX3N0b3J5X2xpbmVfaWRfbGlzdBgGIAMoDRIbChNiYXNlX2F2YXRhcl9p" + "ZF9saXN0GA4gAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PNHGIANGNAE), PNHGIANGNAE.Parser, new string[2] { "UnfinishedStoryLineIdList", "BaseAvatarIdList" }, null, null, null, null)
		}));
	}
}
