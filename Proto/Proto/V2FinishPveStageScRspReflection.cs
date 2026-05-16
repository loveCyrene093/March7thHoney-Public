using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class V2FinishPveStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static V2FinishPveStageScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChtWMkZpbmlzaFB2ZVN0YWdlU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnByb3Rv";
		buffer[1] = "ImgKFVYyRmluaXNoUHZlU3RhZ2VTY1JzcBIPCgdyZXRjb2RlGAQgASgNEhMK";
		buffer[2] = "C01NTEtGSklBS0tIGAggASgNEhkKBnJld2FyZBgJIAEoCzIJLkl0ZW1MaXN0";
		buffer[3] = "Eg4KBmlzX3dpbhgNIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(V2FinishPveStageScRsp), V2FinishPveStageScRsp.Parser, new string[4] { "Retcode", "MMLKFJIAKKH", "Reward", "IsWin" }, null, null, null, null)
		}));
	}
}
