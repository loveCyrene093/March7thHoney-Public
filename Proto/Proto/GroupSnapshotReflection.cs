using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GroupSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GroupSnapshotReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChNHcm91cFNuYXBzaG90LnByb3RvGhpBY3RpdmVNQ1ZLZXlTbmFwc2hvdC5w";
		buffer[1] = "cm90bxoURW50aXR5U25hcHNob3QucHJvdG8imwIKDUdyb3VwU25hcHNob3QS";
		buffer[2] = "EAoIZ3JvdXBfaWQYASABKA0SEwoLZ3JvdXBfc3RhdGUYAiABKA0SJAoLZW50";
		buffer[3] = "aXR5X2xpc3QYAyADKAsyDy5FbnRpdHlTbmFwc2hvdBI1Cgxwcm9wZXJ0eV9t";
		buffer[4] = "YXAYBCADKAsyHy5Hcm91cFNuYXBzaG90LlByb3BlcnR5TWFwRW50cnkSHgoW";
		buffer[5] = "YWN0aXZlX3N1Ym1pc3Npb25fbGlzdBgFIAMoDRIyChNhY3RpdmVfbWN2X2tl";
		buffer[6] = "eV9saXN0GAYgAygLMhUuQWN0aXZlTUNWS2V5U25hcHNob3QaMgoQUHJvcGVy";
		buffer[7] = "dHlNYXBFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAU6AjgBQhaq";
		buffer[8] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ActiveMCVKeySnapshotReflection.Descriptor,
			EntitySnapshotReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GroupSnapshot), GroupSnapshot.Parser, new string[6] { "GroupId", "GroupState", "EntityList", "PropertyMap", "ActiveSubmissionList", "ActiveMcvKeyList" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
