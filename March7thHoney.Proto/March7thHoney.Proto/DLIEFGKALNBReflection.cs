using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DLIEFGKALNBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DLIEFGKALNBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFETElFRkdLQUxOQi5wcm90byJdCgtETElFRkdLQUxOQhIeChZncmlkX2Zp" + "Z2h0X2F2YXRhcl9saXN0GAIgAygNEi4KJmdyaWRfZmlnaHRfdHJhaXRfbWVt" + "YmVyX3VuaXF1ZV9pZF9saXN0GA4gAygNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DLIEFGKALNB), DLIEFGKALNB.Parser, new string[2] { "GridFightAvatarList", "GridFightTraitMemberUniqueIdList" }, null, null, null, null)
		}));
	}
}
