using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BPHLEOBMMKMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BPHLEOBMMKMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCUEhMRU9CTU1LTS5wcm90bxoRSEFCRkxNSkVFS0wucHJvdG8iZgoLQlBI" + "TEVPQk1NS00SEQoJYXZhdGFyX2lkGAEgASgNEiEKC0hMSENLUFBOUE5IGAIg" + "ASgLMgwuSEFCRkxNSkVFS0wSIQoLQk5ER0dORE1FTUMYAyABKAsyDC5IQUJG" + "TE1KRUVLTEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { HABFLMJEEKLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BPHLEOBMMKM), BPHLEOBMMKM.Parser, new string[3] { "AvatarId", "HLHCKPPNPNH", "BNDGGNDMEMC" }, null, null, null, null)
		}));
	}
}
