using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DeleteBlacklistScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DeleteBlacklistScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpEZWxldGVCbGFja2xpc3RTY1JzcC5wcm90byI0ChREZWxldGVCbGFja2xp" + "c3RTY1JzcBILCgN1aWQYBiABKA0SDwoHcmV0Y29kZRgJIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DeleteBlacklistScRsp), DeleteBlacklistScRsp.Parser, new string[2] { "Uid", "Retcode" }, null, null, null, null)
		}));
	}
}
