using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StarFightDataChangeNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StarFightDataChangeNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9TdGFyRmlnaHREYXRhQ2hhbmdlTm90aWZ5LnByb3RvGhFFQUtCRExBRUtI" + "Si5wcm90byJQChlTdGFyRmlnaHREYXRhQ2hhbmdlTm90aWZ5EiEKC0dLSElO" + "RUNBRkhOGAUgASgLMgwuRUFLQkRMQUVLSEoSEAoIZ3JvdXBfaWQYDCABKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { EAKBDLAEKHJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StarFightDataChangeNotify), StarFightDataChangeNotify.Parser, new string[2] { "GKHINECAFHN", "GroupId" }, null, null, null, null)
		}));
	}
}
