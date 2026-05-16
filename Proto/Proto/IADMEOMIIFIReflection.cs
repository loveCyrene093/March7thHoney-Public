using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IADMEOMIIFIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IADMEOMIIFIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJQURNRU9NSUlGSS5wcm90byImCgtJQURNRU9NSUlGSRIXCg9iYXR0bGVf" + "ZXZlbnRfaWQYByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IADMEOMIIFI), IADMEOMIIFI.Parser, new string[1] { "BattleEventId" }, null, null, null, null)
		}));
	}
}
