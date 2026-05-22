using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusUpgradeLevelScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusUpgradeLevelScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9IZWxpb2J1c1VwZ3JhZGVMZXZlbFNjUnNwLnByb3RvIjsKGUhlbGlvYnVz" + "VXBncmFkZUxldmVsU2NSc3ASDwoHcmV0Y29kZRgNIAEoDRINCgVsZXZlbBgP" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusUpgradeLevelScRsp), HeliobusUpgradeLevelScRsp.Parser, new string[2] { "Retcode", "Level" }, null, null, null, null)
		}));
	}
}
