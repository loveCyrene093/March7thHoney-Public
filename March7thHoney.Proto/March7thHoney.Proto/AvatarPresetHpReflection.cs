using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AvatarPresetHpReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AvatarPresetHpReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRBdmF0YXJQcmVzZXRIcC5wcm90byI4Cg5BdmF0YXJQcmVzZXRIcBITCgtP" + "QUdJREJGUENQQRgGIAEoDRIRCglhdmF0YXJfaWQYDSABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AvatarPresetHp), AvatarPresetHp.Parser, new string[2] { "OAGIDBFPCPA", "AvatarId" }, null, null, null, null)
		}));
	}
}
