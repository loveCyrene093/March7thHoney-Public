using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HBJCPIOLEICReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HBJCPIOLEICReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		buffer[0] = "ChFIQkpDUElPTEVJQy5wcm90bxoRQ0xGSUlQQklCQkcucHJvdG8aMUNoYWxs";
		buffer[1] = "ZW5nZVBlYWtCb3NzRnJpZW5kTGluZXVwUmVjb21tZW5kYXRpb24ucHJvdG8a";
		buffer[2] = "EURGR0hLR0RLQ0xCLnByb3RvGhtGcmllbmRDaGFsbGVuZ2VMaW5ldXAucHJv";
		buffer[3] = "dG8aFlBsYXllclNpbXBsZUluZm8ucHJvdG8ilwIKC0hCSkNQSU9MRUlDEiYK";
		buffer[4] = "C3BsYXllcl9pbmZvGAQgASgLMhEuUGxheWVyU2ltcGxlSW5mbxITCgtyZW1h";
		buffer[5] = "cmtfbmFtZRgKIAEoCRIjCgtERk1CT0lEREhOTRgBIAEoCzIMLkNMRklJUEJJ";
		buffer[6] = "QkJHSAASLQoLS0pLRkNMRERCS00YAiABKAsyFi5GcmllbmRDaGFsbGVuZ2VM";
		buffer[7] = "aW5ldXBIABIjCgtMQ0VCRkJIQUxIQRgDIAEoCzIMLkRGR0hLR0RLQ0xCSAAS";
		buffer[8] = "QwoLRkVBQ01MTE9BRkIYDCABKAsyLC5DaGFsbGVuZ2VQZWFrQm9zc0ZyaWVu";
		buffer[9] = "ZExpbmV1cFJlY29tbWVuZGF0aW9uSABCDQoLSERPRUZPQ0hMREFCFqoCE01h";
		buffer[10] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[5]
		{
			CLFIIPBIBBGReflection.Descriptor,
			ChallengePeakBossFriendLineupRecommendationReflection.Descriptor,
			DFGHKGDKCLBReflection.Descriptor,
			FriendChallengeLineupReflection.Descriptor,
			PlayerSimpleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HBJCPIOLEIC), HBJCPIOLEIC.Parser, new string[6] { "PlayerInfo", "RemarkName", "DFMBOIDDHNM", "KJKFCLDDBKM", "LCEBFBHALHA", "FEACMLLOAFB" }, new string[1] { "HDOEFOCHLDA" }, null, null, null)
		}));
	}
}
