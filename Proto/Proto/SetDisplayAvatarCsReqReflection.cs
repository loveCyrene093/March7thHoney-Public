using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetDisplayAvatarCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetDisplayAvatarCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTZXREaXNwbGF5QXZhdGFyQ3NSZXEucHJvdG8aF0Rpc3BsYXlBdmF0YXJE" + "YXRhLnByb3RvIkgKFVNldERpc3BsYXlBdmF0YXJDc1JlcRIvChNkaXNwbGF5" + "X2F2YXRhcl9saXN0GA4gAygLMhIuRGlzcGxheUF2YXRhckRhdGFCFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { DisplayAvatarDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetDisplayAvatarCsReq), SetDisplayAvatarCsReq.Parser, new string[1] { "DisplayAvatarList" }, null, null, null, null)
		}));
	}
}
