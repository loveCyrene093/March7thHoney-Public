using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PGHPHPGIDMBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PGHPHPGIDMBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQR0hQSFBHSURNQi5wcm90byJFCgtQR0hQSFBHSURNQhITCgtLSk1KUERO" + "TU9JQhgFIAEoDRIMCgR0eXBlGAggASgNEhMKC0VORk9GRUFLRERLGA0gAygN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PGHPHPGIDMB), PGHPHPGIDMB.Parser, new string[3] { "KJMJPDNMOIB", "Type", "ENFOFEAKDDK" }, null, null, null, null)
		}));
	}
}
