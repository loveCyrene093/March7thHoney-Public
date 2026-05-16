using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PCHLKJCNCENReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PCHLKJCNCENReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQQ0hMS0pDTkNFTi5wcm90byI0CgtQQ0hMS0pDTkNFThIlCh1hc3Npc3Rf" + "bW9uc3Rlcl9lbnRpdHlfaWRfbGlzdBgPIAMoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PCHLKJCNCEN), PCHLKJCNCEN.Parser, new string[1] { "AssistMonsterEntityIdList" }, null, null, null, null)
		}));
	}
}
