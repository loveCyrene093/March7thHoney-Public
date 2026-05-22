using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IdleLiveFinishNodeBattleQuitCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IdleLiveFinishNodeBattleQuitCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CidJZGxlTGl2ZUZpbmlzaE5vZGVCYXR0bGVRdWl0Q3NSZXEucHJvdG8aEUtG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "TkZISUFFS0lOLnByb3RvGhFLR0ZNQk5JSVBQQS5wcm90byJpCiFJZGxlTGl2";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ZUZpbmlzaE5vZGVCYXR0bGVRdWl0Q3NSZXESIQoLTE1MRk9FTERNSkQYByAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "KA4yDC5LR0ZNQk5JSVBQQRIhCgtNTkxCTUFMRFBFShgPIAEoCzIMLktGTkZI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "SUFFS0lOQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			KFNFHIAEKINReflection.Descriptor,
			KGFMBNIIPPAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IdleLiveFinishNodeBattleQuitCsReq), IdleLiveFinishNodeBattleQuitCsReq.Parser, new string[2] { "LMLFOELDMJD", "MNLBMALDPEJ" }, null, null, null, null)
		}));
	}
}
