using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusUpgradeLevelCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusUpgradeLevelCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9IZWxpb2J1c1VwZ3JhZGVMZXZlbENzUmVxLnByb3RvIhsKGUhlbGlvYnVz" + "VXBncmFkZUxldmVsQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusUpgradeLevelCsReq), HeliobusUpgradeLevelCsReq.Parser, null, null, null, null, null)
		}));
	}
}
