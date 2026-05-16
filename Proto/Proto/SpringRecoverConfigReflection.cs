using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SpringRecoverConfigReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SpringRecoverConfigReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChlTcHJpbmdSZWNvdmVyQ29uZmlnLnByb3RvGhRBdmF0YXJQcmVzZXRIcC5w";
		buffer[1] = "cm90byJlChNTcHJpbmdSZWNvdmVyQ29uZmlnEhMKC0JKSk1BSE1LT05DGAQg";
		buffer[2] = "ASgNEiQKC0ZPSE1CTkpOTEtGGAkgAygLMg8uQXZhdGFyUHJlc2V0SHASEwoL";
		buffer[3] = "Q0FDSEVDQU9ERU4YCiABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[4] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { AvatarPresetHpReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SpringRecoverConfig), SpringRecoverConfig.Parser, new string[3] { "BJJMAHMKONC", "FOHMBNJNLKF", "CACHECAODEN" }, null, null, null, null)
		}));
	}
}
