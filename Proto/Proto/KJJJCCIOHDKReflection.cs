using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KJJJCCIOHDKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KJJJCCIOHDKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLSkpKQ0NJT0hESy5wcm90bxoRTUhHREpQTUVGRk4ucHJvdG8iRAoLS0pK" + "SkNDSU9IREsSIQoLTUtIRElOREdITUQYASABKA4yDC5NSEdESlBNRUZGThIS" + "Cgpjb250ZW50X2lkGAogASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[1] { MHGDJPMEFFNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KJJJCCIOHDK), KJJJCCIOHDK.Parser, new string[2] { "MKHDINDGHMD", "ContentId" }, null, null, null, null)
		}));
	}
}
