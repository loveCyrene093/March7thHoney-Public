using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterStageCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVFbnRlclN0YWdlQ3NSZXEucHJvdG8iJAoPRW50ZXJTdGFnZUNzUmVxEhEK" + "CXN0b3BfZGVzYxgGIAEoCUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterStageCsReq), EnterStageCsReq.Parser, new string[1] { "StopDesc" }, null, null, null, null)
		}));
	}
}
