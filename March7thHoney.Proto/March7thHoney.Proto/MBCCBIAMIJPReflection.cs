using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MBCCBIAMIJPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MBCCBIAMIJPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNQkNDQklBTUlKUC5wcm90byI1CgtNQkNDQklBTUlKUBITCgtQQ09FQVBG" + "Q0tDRxgKIAEoCBIRCgllbnRpdHlfaWQYDCABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MBCCBIAMIJP), MBCCBIAMIJP.Parser, new string[2] { "PCOEAPFCKCG", "EntityId" }, null, null, null, null)
		}));
	}
}
