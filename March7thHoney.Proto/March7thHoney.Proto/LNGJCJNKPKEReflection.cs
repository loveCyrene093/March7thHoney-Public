using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LNGJCJNKPKEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LNGJCJNKPKEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMTkdKQ0pOS1BLRS5wcm90byJCCgtMTkdKQ0pOS1BLRRIQCghsZXZlbF9p" + "ZBgCIAEoDRITCgtJRE9QTkNLQUFETxgJIAEoCBIMCgR0aW1lGAsgASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LNGJCJNKPKE), LNGJCJNKPKE.Parser, new string[3] { "LevelId", "IDOPNCKAADO", "Time" }, null, null, null, null)
		}));
	}
}
