using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightStaticGameInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightStaticGameInfoReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "Ch1HcmlkRmlnaHRTdGF0aWNHYW1lSW5mby5wcm90bxobR3JpZEZpZ2h0SGFu";
		buffer[1] = "ZEJvb2tJbmZvLnByb3RvGhlHcmlkRmlnaHRUYWxlbnRJbmZvLnByb3RvGhFK";
		buffer[2] = "SUJBS0pHT1BKTS5wcm90byKCAgoXR3JpZEZpZ2h0U3RhdGljR2FtZUluZm8S";
		buffer[3] = "GQoDZXhwGAIgASgLMgwuSklCQUtKR09QSk0SEwoLRURJR0ZORlBCS0EYAyAB";
		buffer[4] = "KA0SIAoYZ3JpZF9maWdodF9jb21ib193aW5fbnVtGAYgASgNEisKC0VKQ0ZE";
		buffer[5] = "QUFCTE9DGAggASgLMhYuR3JpZEZpZ2h0SGFuZEJvb2tJbmZvEhMKC0NLRklB";
		buffer[6] = "Q0tITkFFGAkgASgNEhMKC2RpdmlzaW9uX2lkGAsgASgNEikKC09KTEFPRElB";
		buffer[7] = "TExFGA0gASgLMhQuR3JpZEZpZ2h0VGFsZW50SW5mbxITCgtDQUxJTUFLR0dI";
		buffer[8] = "ShgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			GridFightHandBookInfoReflection.Descriptor,
			GridFightTalentInfoReflection.Descriptor,
			JIBAKJGOPJMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightStaticGameInfo), GridFightStaticGameInfo.Parser, new string[8] { "Exp", "EDIGFNFPBKA", "GridFightComboWinNum", "EJCFDAABLOC", "CKFIACKHNAE", "DivisionId", "OJLAODIALLE", "CALIMAKGGHJ" }, null, null, null, null)
		}));
	}
}
