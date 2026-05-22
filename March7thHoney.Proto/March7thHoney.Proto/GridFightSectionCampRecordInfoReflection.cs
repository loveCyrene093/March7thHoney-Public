using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSectionCampRecordInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSectionCampRecordInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRHcmlkRmlnaHRTZWN0aW9uQ2FtcFJlY29yZEluZm8ucHJvdG8iSgoeR3Jp" + "ZEZpZ2h0U2VjdGlvbkNhbXBSZWNvcmRJbmZvEhMKC1BNT0dIRklHS1BPGAUg" + "ASgNEhMKC0dESEhHS0lBTU5FGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSectionCampRecordInfo), GridFightSectionCampRecordInfo.Parser, new string[2] { "PMOGHFIGKPO", "GDHHGKIAMNE" }, null, null, null, null)
		}));
	}
}
