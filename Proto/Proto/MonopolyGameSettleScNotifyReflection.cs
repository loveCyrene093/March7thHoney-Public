using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGameSettleScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGameSettleScNotifyReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiBNb25vcG9seUdhbWVTZXR0bGVTY05vdGlmeS5wcm90bxoOSXRlbUxpc3Qu";
		buffer[1] = "cHJvdG8aEUtIQ0hQUExPRkpOLnByb3RvIn0KGk1vbm9wb2x5R2FtZVNldHRs";
		buffer[2] = "ZVNjTm90aWZ5Eh4KC0pFSUxJSUFCS0xHGAogASgLMgkuSXRlbUxpc3QSIQoL";
		buffer[3] = "Qk1LQUVGQUtORkoYDiABKAsyDC5LSENIUFBMT0ZKThIcCglpdGVtX2xpc3QY";
		buffer[4] = "DyABKAsyCS5JdGVtTGlzdEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[5] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			KHCHPPLOFJNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGameSettleScNotify), MonopolyGameSettleScNotify.Parser, new string[3] { "JEILIIABKLG", "BMKAEFAKNFJ", "ItemList" }, null, null, null, null)
		}));
	}
}
