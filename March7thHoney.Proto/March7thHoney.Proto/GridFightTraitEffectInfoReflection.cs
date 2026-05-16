using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightTraitEffectInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightTraitEffectInfoReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "Ch5HcmlkRmlnaHRUcmFpdEVmZmVjdEluZm8ucHJvdG8aEURMSUVGR0tBTE5C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "LnByb3RvGhFIS09NRUZCT0RHUC5wcm90byLAAQoYR3JpZEZpZ2h0VHJhaXRF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "ZmZlY3RJbmZvEhEKCWVmZmVjdF9pZBgLIAEoDRIjCgtIQUlOSktMTExLRhhu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "IAEoCzIMLkhLT01FRkJPREdQSAASFgoLRUhDSkpNQUJFT00YnQEgASgNSAAS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "KQoQYXZhdGFyX2NvcmVfaW5mbxiABiABKAsyDC5ETElFRkdLQUxOQkgAEhoK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "D3RyYWl0X2NvcmVfcm9sZRjGCCABKA1IAEINCgtIREFDQ0lFSUpGT0IWqgIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			DLIEFGKALNBReflection.Descriptor,
			HKOMEFBODGPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightTraitEffectInfo), GridFightTraitEffectInfo.Parser, new string[5] { "EffectId", "HAINJKLLLKF", "EHCJJMABEOM", "AvatarCoreInfo", "TraitCoreRole" }, new string[1] { "HDACCIEIJFO" }, null, null, null)
		}));
	}
}
