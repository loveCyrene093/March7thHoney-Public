using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterTelevisionActivityStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterTelevisionActivityStageCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CidFbnRlclRlbGV2aXNpb25BY3Rpdml0eVN0YWdlQ3NSZXEucHJvdG8aEU5P";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SkNJRUdLQU9CLnByb3RvIm4KIUVudGVyVGVsZXZpc2lvbkFjdGl2aXR5U3Rh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Z2VDc1JlcRIRCglidWZmX2xpc3QYASADKA0SEwoLREVCTU9HQ0dNTEkYCCAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "KA0SIQoLYXZhdGFyX2xpc3QYCiADKAsyDC5OT0pDSUVHS0FPQkIWqgITTWFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { NOJCIEGKAOBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterTelevisionActivityStageCsReq), EnterTelevisionActivityStageCsReq.Parser, new string[3] { "BuffList", "DEBMOGCGMLI", "AvatarList" }, null, null, null, null)
		}));
	}
}
