using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EntityBindPropScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EntityBindPropScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlFbnRpdHlCaW5kUHJvcFNjUnNwLnByb3RvIiYKE0VudGl0eUJpbmRQcm9w" + "U2NSc3ASDwoHcmV0Y29kZRgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EntityBindPropScRsp), EntityBindPropScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
