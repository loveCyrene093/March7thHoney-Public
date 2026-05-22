using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MatchBoxingClubOpponentCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MatchBoxingClubOpponentCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiJNYXRjaEJveGluZ0NsdWJPcHBvbmVudENzUmVxLnByb3RvGhFNSEpOQkJQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "QkxCTy5wcm90byJsChxNYXRjaEJveGluZ0NsdWJPcHBvbmVudENzUmVxEhMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "C2F2YXRhcl9saXN0GAIgAygNEhQKDGNoYWxsZW5nZV9pZBgEIAEoDRIhCgtJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "RE9JRERFSElKRxgGIAMoCzIMLk1ISk5CQlBCTEJPQhaqAhNNYXJjaDd0aEhv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { MHJNBBPBLBOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MatchBoxingClubOpponentCsReq), MatchBoxingClubOpponentCsReq.Parser, new string[3] { "AvatarList", "ChallengeId", "IDOIDDEHIJG" }, null, null, null, null)
		}));
	}
}
