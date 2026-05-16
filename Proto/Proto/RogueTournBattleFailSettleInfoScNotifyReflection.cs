using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournBattleFailSettleInfoScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournBattleFailSettleInfoScNotifyReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CixSb2d1ZVRvdXJuQmF0dGxlRmFpbFNldHRsZUluZm9TY05vdGlmeS5wcm90";
		buffer[1] = "bxoRQUxHSk9NRkNMS0wucHJvdG8aEUJGRUlQRUxGQ0RGLnByb3RvIm4KJlJv";
		buffer[2] = "Z3VlVG91cm5CYXR0bGVGYWlsU2V0dGxlSW5mb1NjTm90aWZ5EiEKC0VES0pN";
		buffer[3] = "UEFDSE5KGAQgASgLMgwuQUxHSk9NRkNMS0wSIQoLQUZMSkpKRkNCSU4YBiAB";
		buffer[4] = "KAsyDC5CRkVJUEVMRkNERkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[5] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ALGJOMFCLKLReflection.Descriptor,
			BFEIPELFCDFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournBattleFailSettleInfoScNotify), RogueTournBattleFailSettleInfoScNotify.Parser, new string[2] { "EDKJMPACHNJ", "AFLJJJFCBIN" }, null, null, null, null)
		}));
	}
}
