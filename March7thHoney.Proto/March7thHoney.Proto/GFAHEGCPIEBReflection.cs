using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GFAHEGCPIEBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GFAHEGCPIEBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHRkFIRUdDUElFQi5wcm90byIwCgtHRkFIRUdDUElFQhITCgtIQ0pQRE5E" + "T0hBTRgBIAEoDRIMCgRzbG90GAIgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GFAHEGCPIEB), GFAHEGCPIEB.Parser, new string[2] { "HCJPDNDOHAM", "Slot" }, null, null, null, null)
		}));
	}
}
