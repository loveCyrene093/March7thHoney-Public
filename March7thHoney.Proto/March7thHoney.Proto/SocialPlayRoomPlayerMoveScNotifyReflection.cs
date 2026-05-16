using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SocialPlayRoomPlayerMoveScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SocialPlayRoomPlayerMoveScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiZTb2NpYWxQbGF5Um9vbVBsYXllck1vdmVTY05vdGlmeS5wcm90bxoRQ0NL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Q0NLSEVGRkIucHJvdG8ibwogU29jaWFsUGxheVJvb21QbGF5ZXJNb3ZlU2NO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "b3RpZnkSEwoLTUZCRE1MUERFT0UYCCABKA0SIQoLRklQSURHS1BGSEEYDCAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "KAsyDC5DQ0tDQ0tIRUZGQhITCgtOQ0ZIR0lCQ0VCRxgNIAEoDUIWqgITTWFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { CCKCCKHEFFBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SocialPlayRoomPlayerMoveScNotify), SocialPlayRoomPlayerMoveScNotify.Parser, new string[3] { "MFBDMLPDEOE", "FIPIDGKPFHA", "NCFHGIBCEBG" }, null, null, null, null)
		}));
	}
}
