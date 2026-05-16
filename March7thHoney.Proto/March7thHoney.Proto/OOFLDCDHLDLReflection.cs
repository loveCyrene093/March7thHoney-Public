using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OOFLDCDHLDLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OOFLDCDHLDLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPT0ZMRENESExETC5wcm90bxoRQURITkpBRElKQUMucHJvdG8aEUpMR05L" + "TUJNUEtMLnByb3RvIlMKC09PRkxEQ0RITERMEiEKC1BPRk9DTUlISklBGAMg" + "ASgLMgwuSkxHTktNQk1QS0wSIQoLQklFQkZIRUNFUE0YDSADKAsyDC5BREhO" + "SkFESUpBQ0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[2]
		{
			ADHNJADIJACReflection.Descriptor,
			JLGNKMBMPKLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OOFLDCDHLDL), OOFLDCDHLDL.Parser, new string[2] { "POFOCMIHJIA", "BIEBFHECEPM" }, null, null, null, null)
		}));
	}
}
