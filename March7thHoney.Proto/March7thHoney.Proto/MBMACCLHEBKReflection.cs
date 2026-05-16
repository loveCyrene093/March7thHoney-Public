using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MBMACCLHEBKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MBMACCLHEBKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNQk1BQ0NMSEVCSy5wcm90bxoOSXRlbUxpc3QucHJvdG8iOgoLTUJNQUND" + "TEhFQksSEAoIY2hlc3RfaWQYASABKA0SGQoGcmV3YXJkGA0gASgLMgkuSXRl" + "bUxpc3RCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MBMACCLHEBK), MBMACCLHEBK.Parser, new string[2] { "ChestId", "Reward" }, null, null, null, null)
		}));
	}
}
