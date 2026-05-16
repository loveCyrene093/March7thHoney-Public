using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGameOrbInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGameOrbInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChpHcmlkRmlnaHRHYW1lT3JiSW5mby5wcm90bxoVR3JpZEdhbWVPcmJJbmZv";
		buffer[1] = "LnByb3RvGhZHcmlkR2FtZU9yYkluZm8xLnByb3RvInQKFEdyaWRGaWdodEdh";
		buffer[2] = "bWVPcmJJbmZvEi4KE2dyaWRfZ2FtZV9vcmIxX2xpc3QYCiADKAsyES5Hcmlk";
		buffer[3] = "R2FtZU9yYkluZm8xEiwKEmdyaWRfZ2FtZV9vcmJfbGlzdBgOIAMoCzIQLkdy";
		buffer[4] = "aWRHYW1lT3JiSW5mb0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GridGameOrbInfoReflection.Descriptor,
			GridGameOrbInfo1Reflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGameOrbInfo), GridFightGameOrbInfo.Parser, new string[2] { "GridGameOrb1List", "GridGameOrbList" }, null, null, null, null)
		}));
	}
}
