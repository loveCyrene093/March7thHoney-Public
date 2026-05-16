using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HFHMIKIFLPOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HFHMIKIFLPOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIRkhNSUtJRkxQTy5wcm90byJXCgtIRkhNSUtJRkxQTxIRCglhdmF0YXJf" + "aWQYAyABKA0SDQoFbGV2ZWwYDCABKA0SEQoJcm9sZV9zdGFyGA0gASgNEhMK" + "C0pMSFBJTUpQRExPGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HFHMIKIFLPO), HFHMIKIFLPO.Parser, new string[4] { "AvatarId", "Level", "RoleStar", "JLHPIMJPDLO" }, null, null, null, null)
		}));
	}
}
