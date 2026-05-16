using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PKJGGAPLONCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PKJGGAPLONCReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFQS0pHR0FQTE9OQy5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJuCgtQS0pH";
		buffer[1] = "R0FQTE9OQxIgCgthdmF0YXJfdHlwZRgBIAEoDjILLkF2YXRhclR5cGUSCgoC";
		buffer[2] = "aWQYAiABKA0SDQoFbGV2ZWwYAyABKA0SDQoFaW5kZXgYBCABKA0SEwoLQ0JI";
		buffer[3] = "S0ZPRU9NRkYYBSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PKJGGAPLONC), PKJGGAPLONC.Parser, new string[5] { "AvatarType", "Id", "Level", "Index", "CBHKFOEOMFF" }, null, null, null, null)
		}));
	}
}
