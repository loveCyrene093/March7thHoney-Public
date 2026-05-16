using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CLOEPPBCKGFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CLOEPPBCKGFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTE9FUFBCQ0tHRi5wcm90byItCgtDTE9FUFBCQ0tHRhIeChZncmlkX2Zp" + "Z2h0X2F2YXRhcl9saXN0GAcgAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CLOEPPBCKGF), CLOEPPBCKGF.Parser, new string[1] { "GridFightAvatarList" }, null, null, null, null)
		}));
	}
}
