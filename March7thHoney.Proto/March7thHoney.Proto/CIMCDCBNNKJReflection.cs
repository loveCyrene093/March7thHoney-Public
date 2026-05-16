using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CIMCDCBNNKJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CIMCDCBNNKJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDSU1DRENCTk5LSi5wcm90byJLCgtDSU1DRENCTk5LShIRCglhdmF0YXJf" + "aWQYASABKA0SEwoLQkxETUJLS05NTkQYAiABKA0SFAoMYXZhdGFyX2xldmVs" + "GAMgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CIMCDCBNNKJ), CIMCDCBNNKJ.Parser, new string[3] { "AvatarId", "BLDMBKKNMND", "AvatarLevel" }, null, null, null, null)
		}));
	}
}
