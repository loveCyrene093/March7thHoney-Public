using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MakeMissionDrinkScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MakeMissionDrinkScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChtNYWtlTWlzc2lvbkRyaW5rU2NSc3AucHJvdG8aEUNJR0tCRElHR09JLnBy";
		buffer[1] = "b3RvInEKFU1ha2VNaXNzaW9uRHJpbmtTY1JzcBIPCgdpc19zYXZlGAUgASgI";
		buffer[2] = "EhMKC0RBSUtOS0FMS0NNGAcgASgIEiEKC0RLR09ETkFNQkhIGAsgASgLMgwu";
		buffer[3] = "Q0lHS0JESUdHT0kSDwoHcmV0Y29kZRgOIAEoDUIWqgITTWFyY2g3dGhIb25l";
		buffer[4] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { CIGKBDIGGOIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MakeMissionDrinkScRsp), MakeMissionDrinkScRsp.Parser, new string[4] { "IsSave", "DAIKNKALKCM", "DKGODNAMBHH", "Retcode" }, null, null, null, null)
		}));
	}
}
