using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JNHCBCKHCEMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JNHCBCKHCEMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKTkhDQkNLSENFTS5wcm90byI1CgtKTkhDQkNLSENFTRITCgtCSERISUlC" + "Q0RJShgBIAEoDRIRCglhdmF0YXJfaWQYDyABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JNHCBCKHCEM), JNHCBCKHCEM.Parser, new string[2] { "BHDHIIBCDIJ", "AvatarId" }, null, null, null, null)
		}));
	}
}
