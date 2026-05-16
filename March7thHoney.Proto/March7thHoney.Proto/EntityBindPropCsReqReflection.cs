using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EntityBindPropCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EntityBindPropCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlFbnRpdHlCaW5kUHJvcENzUmVxLnByb3RvGhBNb3Rpb25JbmZvLnByb3Rv" + "IkcKE0VudGl0eUJpbmRQcm9wQ3NSZXESEwoLUEZBS0hDQ0VFRUsYBCABKAgS" + "GwoGbW90aW9uGAsgASgLMgsuTW90aW9uSW5mb0IWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { MotionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EntityBindPropCsReq), EntityBindPropCsReq.Parser, new string[2] { "PFAKHCCEEEK", "Motion" }, null, null, null, null)
		}));
	}
}
