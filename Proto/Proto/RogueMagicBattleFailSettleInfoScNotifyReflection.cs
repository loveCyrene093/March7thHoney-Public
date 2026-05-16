using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueMagicBattleFailSettleInfoScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueMagicBattleFailSettleInfoScNotifyReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CixSb2d1ZU1hZ2ljQmF0dGxlRmFpbFNldHRsZUluZm9TY05vdGlmeS5wcm90";
		buffer[1] = "bxoRQkhNSkFKR09KUE0ucHJvdG8aEUpLQUlES0lHRUdQLnByb3RvIm4KJlJv";
		buffer[2] = "Z3VlTWFnaWNCYXR0bGVGYWlsU2V0dGxlSW5mb1NjTm90aWZ5EiEKC0FGTEpK";
		buffer[3] = "SkZDQklOGAEgASgLMgwuSktBSURLSUdFR1ASIQoLRURLSk1QQUNITkoYCyAB";
		buffer[4] = "KAsyDC5CSE1KQUpHT0pQTUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[5] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			BHMJAJGOJPMReflection.Descriptor,
			JKAIDKIGEGPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicBattleFailSettleInfoScNotify), RogueMagicBattleFailSettleInfoScNotify.Parser, new string[2] { "AFLJJJFCBIN", "EDKJMPACHNJ" }, null, null, null, null)
		}));
	}
}
