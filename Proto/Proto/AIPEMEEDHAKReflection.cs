using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AIPEMEEDHAKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AIPEMEEDHAKReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFBSVBFTUVFREhBSy5wcm90bxoRSUFNQUxNTEJPRUkucHJvdG8aEUlGTE9H";
		buffer[1] = "SkJPTkhJLnByb3RvIooBCgtBSVBFTUVFREhBSxITCgtFUExCQ05GTUxJTBgB";
		buffer[2] = "IAEoDRIQCghzdGFnZV9pZBgDIAEoDRIOCgZpc193aW4YBCABKAgSIQoLSk1J";
		buffer[3] = "S1BDUElGQ0QYCSADKAsyDC5JRkxPR0pCT05ISRIhCgtJQ0hNS0ZNQUlCQhgL";
		buffer[4] = "IAMoCzIMLklBTUFMTUxCT0VJQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[5] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			IAMALMLBOEIReflection.Descriptor,
			IFLOGJBONHIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AIPEMEEDHAK), AIPEMEEDHAK.Parser, new string[5] { "EPLBCNFMLIL", "StageId", "IsWin", "JMIKPCPIFCD", "ICHMKFMAIBB" }, null, null, null, null)
		}));
	}
}
