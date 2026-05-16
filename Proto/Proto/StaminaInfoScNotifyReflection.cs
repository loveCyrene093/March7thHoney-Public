using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StaminaInfoScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StaminaInfoScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlTdGFtaW5hSW5mb1NjTm90aWZ5LnByb3RvIm8KE1N0YW1pbmFJbmZvU2NO" + "b3RpZnkSGQoRbmV4dF9yZWNvdmVyX3RpbWUYBCABKAMSDwoHc3RhbWluYRgG" + "IAEoDRITCgtETERJUEFIUEtPRhgHIAEoAxIXCg9yZXNlcnZlX3N0YW1pbmEY" + "CCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StaminaInfoScNotify), StaminaInfoScNotify.Parser, new string[4] { "NextRecoverTime", "Stamina", "DLDIPAHPKOF", "ReserveStamina" }, null, null, null, null)
		}));
	}
}
