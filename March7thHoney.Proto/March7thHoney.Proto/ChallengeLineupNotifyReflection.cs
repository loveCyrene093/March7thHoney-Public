using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeLineupNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeLineupNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDaGFsbGVuZ2VMaW5ldXBOb3RpZnkucHJvdG8aFUV4dHJhTGluZXVwVHlw" + "ZS5wcm90byJEChVDaGFsbGVuZ2VMaW5ldXBOb3RpZnkSKwoRZXh0cmFfbGlu" + "ZXVwX3R5cGUYDyABKA4yEC5FeHRyYUxpbmV1cFR5cGVCFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ExtraLineupTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeLineupNotify), ChallengeLineupNotify.Parser, new string[1] { "ExtraLineupType" }, null, null, null, null)
		}));
	}
}
