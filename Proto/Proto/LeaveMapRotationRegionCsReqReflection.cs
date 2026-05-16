using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LeaveMapRotationRegionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LeaveMapRotationRegionCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFMZWF2ZU1hcFJvdGF0aW9uUmVnaW9uQ3NSZXEucHJvdG8aEE1vdGlvbklu" + "Zm8ucHJvdG8iOgobTGVhdmVNYXBSb3RhdGlvblJlZ2lvbkNzUmVxEhsKBm1v" + "dGlvbhgBIAEoCzILLk1vdGlvbkluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[1] { MotionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LeaveMapRotationRegionCsReq), LeaveMapRotationRegionCsReq.Parser, new string[1] { "Motion" }, null, null, null, null)
		}));
	}
}
