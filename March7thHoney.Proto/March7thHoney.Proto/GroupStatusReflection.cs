using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GroupStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GroupStatusReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHcm91cFN0YXR1cy5wcm90bxoYTWVzc2FnZUdyb3VwU3RhdHVzLnByb3Rv" + "ImAKC0dyb3VwU3RhdHVzEikKDGdyb3VwX3N0YXR1cxgDIAEoDjITLk1lc3Nh" + "Z2VHcm91cFN0YXR1cxIQCghncm91cF9pZBgFIAEoDRIUCgxyZWZyZXNoX3Rp" + "bWUYCSABKANCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { MessageGroupStatusReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GroupStatus), GroupStatus.Parser, new string[3] { "GroupStatus_", "GroupId", "RefreshTime" }, null, null, null, null)
		}));
	}
}
