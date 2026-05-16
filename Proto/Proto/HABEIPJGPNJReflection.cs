using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HABEIPJGPNJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HABEIPJGPNJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQUJFSVBKR1BOSi5wcm90byImCgtIQUJFSVBKR1BOShIXCg9jb250YWN0" + "X2lkX2xpc3QYDSADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HABEIPJGPNJ), HABEIPJGPNJ.Parser, new string[1] { "ContactIdList" }, null, null, null, null)
		}));
	}
}
