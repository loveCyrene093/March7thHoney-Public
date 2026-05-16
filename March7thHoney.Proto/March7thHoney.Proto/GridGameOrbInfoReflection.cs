using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridGameOrbInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridGameOrbInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVHcmlkR2FtZU9yYkluZm8ucHJvdG8iOQoPR3JpZEdhbWVPcmJJbmZvEhEK" + "CXVuaXF1ZV9pZBgFIAEoDRITCgtvcmJfaXRlbV9pZBgHIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridGameOrbInfo), GridGameOrbInfo.Parser, new string[2] { "UniqueId", "OrbItemId" }, null, null, null, null)
		}));
	}
}
