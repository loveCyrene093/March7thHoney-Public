using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ECELDDGKCAKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ECELDDGKCAKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFQ0VMRERHS0NBSy5wcm90byIsCgtFQ0VMRERHS0NBSxIdChVncmlkX2Zp" + "Z2h0X3RyYWl0X2luZm8YAiADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ECELDDGKCAK), ECELDDGKCAK.Parser, new string[1] { "GridFightTraitInfo" }, null, null, null, null)
		}));
	}
}
