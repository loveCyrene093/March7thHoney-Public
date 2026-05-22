using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AttackDamagePropertyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AttackDamagePropertyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpBdHRhY2tEYW1hZ2VQcm9wZXJ0eS5wcm90byI7ChRBdHRhY2tEYW1hZ2VQ" + "cm9wZXJ0eRITCgthdHRhY2tfdHlwZRgBIAEoCRIOCgZkYW1hZ2UYAiABKAFC" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AttackDamageProperty), AttackDamageProperty.Parser, new string[2] { "AttackType", "Damage" }, null, null, null, null)
		}));
	}
}
