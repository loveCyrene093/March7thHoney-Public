using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusChallengeDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusChallengeDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtIZWxpb2J1c0NoYWxsZW5nZURhdGEucHJvdG8iUAoVSGVsaW9idXNDaGFs" + "bGVuZ2VEYXRhEgwKBHN0YXIYAyABKA0SFAoMY2hhbGxlbmdlX2lkGAogASgN" + "EhMKC0ZMTU9LS0JMRkpHGA4gASgIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusChallengeData), HeliobusChallengeData.Parser, new string[3] { "Star", "ChallengeId", "FLMOKKBLFJG" }, null, null, null, null)
		}));
	}
}
