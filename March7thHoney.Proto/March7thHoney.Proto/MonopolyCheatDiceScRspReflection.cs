using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyCheatDiceScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyCheatDiceScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxNb25vcG9seUNoZWF0RGljZVNjUnNwLnByb3RvIj4KFk1vbm9wb2x5Q2hl" + "YXREaWNlU2NSc3ASDwoHcmV0Y29kZRgCIAEoDRITCgtNRkhLR1BKSkdCThgF" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyCheatDiceScRsp), MonopolyCheatDiceScRsp.Parser, new string[2] { "Retcode", "MFHKGPJJGBN" }, null, null, null, null)
		}));
	}
}
