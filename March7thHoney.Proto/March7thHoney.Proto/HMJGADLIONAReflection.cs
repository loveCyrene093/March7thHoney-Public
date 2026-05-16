using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HMJGADLIONAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HMJGADLIONAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFITUpHQURMSU9OQS5wcm90bxoQTW90aW9uSW5mby5wcm90byI9CgtITUpH" + "QURMSU9OQRIRCgllbnRpdHlfaWQYBCABKA0SGwoGbW90aW9uGA4gASgLMgsu" + "TW90aW9uSW5mb0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { MotionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HMJGADLIONA), HMJGADLIONA.Parser, new string[2] { "EntityId", "Motion" }, null, null, null, null)
		}));
	}
}
