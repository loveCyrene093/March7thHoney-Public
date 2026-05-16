using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JGBLCLCHHIOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JGBLCLCHHIOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKR0JMQ0xDSEhJTy5wcm90bxoVQ2hhdE1lc3NhZ2VEYXRhLnByb3RvIjIK" + "C0pHQkxDTENISElPEiMKCXN0b3BfZGVzYxgBIAEoCzIQLkNoYXRNZXNzYWdl" + "RGF0YUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ChatMessageDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JGBLCLCHHIO), JGBLCLCHHIO.Parser, new string[1] { "StopDesc" }, null, null, null, null)
		}));
	}
}
