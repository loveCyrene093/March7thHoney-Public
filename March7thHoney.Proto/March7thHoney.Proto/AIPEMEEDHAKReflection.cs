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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFBSVBFTUVFREhBSy5wcm90bxoRSUFNQUxNTEJPRUkucHJvdG8aEUlGTE9H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "SkJPTkhJLnByb3RvIooBCgtBSVBFTUVFREhBSxITCgtFUExCQ05GTUxJTBgB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "IAEoDRIQCghzdGFnZV9pZBgDIAEoDRIOCgZpc193aW4YBCABKAgSIQoLSk1J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "S1BDUElGQ0QYCSADKAsyDC5JRkxPR0pCT05ISRIhCgtJQ0hNS0ZNQUlCQhgL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "IAMoCzIMLklBTUFMTUxCT0VJQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			IAMALMLBOEIReflection.Descriptor,
			IFLOGJBONHIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AIPEMEEDHAK), AIPEMEEDHAK.Parser, new string[5] { "EPLBCNFMLIL", "StageId", "IsWin", "JMIKPCPIFCD", "ICHMKFMAIBB" }, null, null, null, null)
		}));
	}
}
