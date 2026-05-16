using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CurTrialActivityScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CurTrialActivityScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch5DdXJUcmlhbEFjdGl2aXR5U2NOb3RpZnkucHJvdG8aGVRyaWFsQWN0aXZp";
		buffer[1] = "dHlTdGF0dXMucHJvdG8iWwoYQ3VyVHJpYWxBY3Rpdml0eVNjTm90aWZ5EiQK";
		buffer[2] = "BnN0YXR1cxgEIAEoDjIULlRyaWFsQWN0aXZpdHlTdGF0dXMSGQoRYWN0aXZp";
		buffer[3] = "dHlfc3RhZ2VfaWQYBSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[4] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { TrialActivityStatusReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CurTrialActivityScNotify), CurTrialActivityScNotify.Parser, new string[2] { "Status", "ActivityStageId" }, null, null, null, null)
		}));
	}
}
