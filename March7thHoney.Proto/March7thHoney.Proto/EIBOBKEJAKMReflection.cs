using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EIBOBKEJAKMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EIBOBKEJAKMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFSUJPQktFSkFLTS5wcm90byI1CgtFSUJPQktFSkFLTRIRCglhdmF0YXJf" + "aWQYASABKA0SEwoLRktNTkFCTEFNRlAYAiABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EIBOBKEJAKM), EIBOBKEJAKM.Parser, new string[2] { "AvatarId", "FKMNABLAMFP" }, null, null, null, null)
		}));
	}
}
