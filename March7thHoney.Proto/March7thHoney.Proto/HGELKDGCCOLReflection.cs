using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HGELKDGCCOLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HGELKDGCCOLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIR0VMS0RHQ0NPTC5wcm90byIqCgtIR0VMS0RHQ0NPTBINCgV2YWx1ZRgC" + "IAEoDRIMCgR0eXBlGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HGELKDGCCOL), HGELKDGCCOL.Parser, new string[2] { "Value", "Type" }, null, null, null, null)
		}));
	}
}
