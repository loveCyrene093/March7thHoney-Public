using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SectionStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SectionStatusReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNTZWN0aW9uU3RhdHVzLnByb3RvGhpNZXNzYWdlU2VjdGlvblN0YXR1cy5w" + "cm90byJSCg1TZWN0aW9uU3RhdHVzEhIKCnNlY3Rpb25faWQYBCABKA0SLQoO" + "c2VjdGlvbl9zdGF0dXMYCyABKA4yFS5NZXNzYWdlU2VjdGlvblN0YXR1c0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { MessageSectionStatusReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SectionStatus), SectionStatus.Parser, new string[2] { "SectionId", "SectionStatus_" }, null, null, null, null)
		}));
	}
}
