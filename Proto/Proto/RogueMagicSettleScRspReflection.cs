using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueMagicSettleScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueMagicSettleScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChtSb2d1ZU1hZ2ljU2V0dGxlU2NSc3AucHJvdG8aEUJITUpBSkdPSlBNLnBy";
		buffer[1] = "b3RvGg5JdGVtTGlzdC5wcm90bxoRSktBSURLSUdFR1AucHJvdG8aEU9KRkRF";
		buffer[2] = "S0lQUEpGLnByb3RvIrEBChVSb2d1ZU1hZ2ljU2V0dGxlU2NSc3ASDwoHcmV0";
		buffer[3] = "Y29kZRgBIAEoDRIhCgtNSlBFSlBNQUNGRxgGIAEoCzIMLk9KRkRFS0lQUEpG";
		buffer[4] = "Eh4KC0ZOS0VCT0ZBSE1FGAcgASgLMgkuSXRlbUxpc3QSIQoLQUZMSkpKRkNC";
		buffer[5] = "SU4YCyABKAsyDC5KS0FJREtJR0VHUBIhCgtFREtKTVBBQ0hOShgNIAEoCzIM";
		buffer[6] = "LkJITUpBSkdPSlBNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			BHMJAJGOJPMReflection.Descriptor,
			ItemListReflection.Descriptor,
			JKAIDKIGEGPReflection.Descriptor,
			OJFDEKIPPJFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicSettleScRsp), RogueMagicSettleScRsp.Parser, new string[5] { "Retcode", "MJPEJPMACFG", "FNKEBOFAHME", "AFLJJJFCBIN", "EDKJMPACHNJ" }, null, null, null, null)
		}));
	}
}
