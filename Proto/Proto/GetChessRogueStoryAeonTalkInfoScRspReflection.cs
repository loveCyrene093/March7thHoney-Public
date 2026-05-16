using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetChessRogueStoryAeonTalkInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetChessRogueStoryAeonTalkInfoScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "CilHZXRDaGVzc1JvZ3VlU3RvcnlBZW9uVGFsa0luZm9TY1JzcC5wcm90byLL";
		buffer[1] = "AQojR2V0Q2hlc3NSb2d1ZVN0b3J5QWVvblRhbGtJbmZvU2NSc3ASDwoHcmV0";
		buffer[2] = "Y29kZRgEIAEoDRITCgtBSEtGRkNJRVBERxgJIAEoDRJKCgtGT0VKRkVNTFBQ";
		buffer[3] = "QxgLIAMoCzI1LkdldENoZXNzUm9ndWVTdG9yeUFlb25UYWxrSW5mb1NjUnNw";
		buffer[4] = "LkZPRUpGRU1MUFBDRW50cnkaMgoQRk9FSkZFTUxQUENFbnRyeRILCgNrZXkY";
		buffer[5] = "ASABKA0SDQoFdmFsdWUYAiABKA06AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[6] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetChessRogueStoryAeonTalkInfoScRsp), GetChessRogueStoryAeonTalkInfoScRsp.Parser, new string[3] { "Retcode", "AHKFFCIEPDG", "FOEJFEMLPPC" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
