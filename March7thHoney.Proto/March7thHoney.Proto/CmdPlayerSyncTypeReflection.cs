using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdPlayerSyncTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdPlayerSyncTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdDbWRQbGF5ZXJTeW5jVHlwZS5wcm90bypMChFDbWRQbGF5ZXJTeW5jVHlw" + "ZRIbChdCSkxPTElCQk1MSF9CQ0dOT0VBT0NPTBAAEhoKFUNtZFBsYXllclN5" + "bmNTY05vdGlmeRCzBUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdPlayerSyncType) }, null, null));
	}
}
