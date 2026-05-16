using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DLGEGGCHCIDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DLGEGGCHCIDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFETEdFR0dDSENJRC5wcm90bxoRTEhQUElBS0tGTUUucHJvdG8iQwoLRExH" + "RUdHQ0hDSUQSEQoJcm9sZV9zdGFyGAggASgNEiEKC1BHTk1ESklJS0pCGA4g" + "AygLMgwuTEhQUElBS0tGTUVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[1] { LHPPIAKKFMEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DLGEGGCHCID), DLGEGGCHCID.Parser, new string[2] { "RoleStar", "PGNMDJIIKJB" }, null, null, null, null)
		}));
	}
}
