using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JCJACKICPHNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JCJACKICPHNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKQ0pBQ0tJQ1BITi5wcm90byItCgtKQ0pBQ0tJQ1BIThISCgpoYXNfcGFz" + "c2VkGAkgASgIEgoKAmlkGAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JCJACKICPHN), JCJACKICPHN.Parser, new string[2] { "HasPassed", "Id" }, null, null, null, null)
		}));
	}
}
