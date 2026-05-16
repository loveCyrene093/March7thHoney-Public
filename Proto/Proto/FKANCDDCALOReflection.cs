using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FKANCDDCALOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FKANCDDCALOReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFGS0FOQ0REQ0FMTy5wcm90byqBAQoLRktBTkNERENBTE8SGwoXRktBTkNE";
		buffer[1] = "RENBTE9fUENQREhFTFBLRU0QABIbChdGS0FOQ0REQ0FMT19QQ1BLRkNET0pQ";
		buffer[2] = "RBABEhsKF0ZLQU5DRERDQUxPX0hQSkVCRkZISk5QEAISGwoXRktBTkNERENB";
		buffer[3] = "TE9fS0xIRENPUFBMTkcQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FKANCDDCALO) }, null, null));
	}
}
