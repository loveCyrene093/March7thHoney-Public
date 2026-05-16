using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CMHAMBKCJBKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CMHAMBKCJBKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTUhBTUJLQ0pCSy5wcm90byJZCgtDTUhBTUJLQ0pCSxILCgNwb3MYASAB" + "KA0SEwoLSkRQQU5JTkpBRUMYAiABKA0SEwoLTU1GUEVHUEhPRUMYAyABKA0S" + "EwoLREhOQ05MRk1PTEkYBCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CMHAMBKCJBK), CMHAMBKCJBK.Parser, new string[4] { "Pos", "JDPANINJAEC", "MMFPEGPHOEC", "DHNCNLFMOLI" }, null, null, null, null)
		}));
	}
}
