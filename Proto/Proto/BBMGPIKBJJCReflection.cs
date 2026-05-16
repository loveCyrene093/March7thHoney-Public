using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BBMGPIKBJJCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BBMGPIKBJJCReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFCQk1HUElLQkpKQy5wcm90bxoRTEdMR0NDSkVLQ0wucHJvdG8inAEKC0JC";
		buffer[1] = "TUdQSUtCSkpDEhYKDmdhbWVfbW9kZV90eXBlGAMgASgNEiEKC0hFT0tHQUtM";
		buffer[2] = "RlBNGAkgAygLMgwuTEdMR0NDSkVLQ0wSEwoLSE9IQU5QSk5BTkEYDCABKA0S";
		buffer[3] = "EwoLQUhLRkZDSUVQREcYDSABKA0SEwoLRUdBQkxCSklKQ0sYDiADKA0SEwoL";
		buffer[4] = "SkJFSUxNRklJR00YDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[5] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { LGLGCCJEKCLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BBMGPIKBJJC), BBMGPIKBJJC.Parser, new string[6] { "GameModeType", "HEOKGAKLFPM", "HOHANPJNANA", "AHKFFCIEPDG", "EGABLBJIJCK", "JBEILMFIIGM" }, null, null, null, null)
		}));
	}
}
