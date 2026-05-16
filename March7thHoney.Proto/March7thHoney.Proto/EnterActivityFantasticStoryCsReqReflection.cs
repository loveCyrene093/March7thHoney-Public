using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterActivityFantasticStoryCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterActivityFantasticStoryCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiZFbnRlckFjdGl2aXR5RmFudGFzdGljU3RvcnlDc1JlcS5wcm90bxoRT0lJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "QURKQ0VNS0IucHJvdG8igAEKIEVudGVyQWN0aXZpdHlGYW50YXN0aWNTdG9y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "eUNzUmVxEhEKCWJhdHRsZV9pZBgDIAEoDRITCgtDRUlNTkRKRkRKRBgFIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "DRIRCglidWZmX2xpc3QYCSADKA0SIQoLYXZhdGFyX2xpc3QYDyADKAsyDC5P";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "SUlBREpDRU1LQkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { OIIADJCEMKBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterActivityFantasticStoryCsReq), EnterActivityFantasticStoryCsReq.Parser, new string[4] { "BattleId", "CEIMNDJFDJD", "BuffList", "AvatarList" }, null, null, null, null)
		}));
	}
}
