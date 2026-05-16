using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OIDOEJMAMDEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OIDOEJMAMDEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPSURPRUpNQU1ERS5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIkIKC09J" + "RE9FSk1BTURFEiIKC0tCRUZLT05QS0dKGAkgASgLMg0uSXRlbUNvc3REYXRh" + "Eg8KB3JldGNvZGUYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OIDOEJMAMDE), OIDOEJMAMDE.Parser, new string[2] { "KBEFKONPKGJ", "Retcode" }, null, null, null, null)
		}));
	}
}
