using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridGameForgeItemInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridGameForgeItemInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChtHcmlkR2FtZUZvcmdlSXRlbUluZm8ucHJvdG8aHUdyaWRGaWdodEZvcmdl";
		buffer[1] = "R29vZHNJbmZvLnByb3RvIoIBChVHcmlkR2FtZUZvcmdlSXRlbUluZm8SFQoN";
		buffer[2] = "Zm9yZ2VfaXRlbV9pZBgBIAEoDRIyChBmb3JnZV9nb29kc19saXN0GAQgAygL";
		buffer[3] = "MhguR3JpZEZpZ2h0Rm9yZ2VHb29kc0luZm8SCwoDcG9zGAUgASgNEhEKCXVu";
		buffer[4] = "aXF1ZV9pZBgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightForgeGoodsInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridGameForgeItemInfo), GridGameForgeItemInfo.Parser, new string[4] { "ForgeItemId", "ForgeGoodsList", "Pos", "UniqueId" }, null, null, null, null)
		}));
	}
}
