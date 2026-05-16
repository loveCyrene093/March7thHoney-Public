using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyActionResultReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyActionResultReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChpNb25vcG9seUFjdGlvblJlc3VsdC5wcm90bxoRSkRNUEFBRUdNQ0QucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "dG8aEU5HQUVGUE5CREFELnByb3RvIsoBChRNb25vcG9seUFjdGlvblJlc3Vs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "dBIcCgZkZXRhaWwYAiABKAsyDC5KRE1QQUFFR01DRBIhCgtzb3VyY2VfdHlw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "ZRgDIAEoDjIMLk5HQUVGUE5CREFEEhUKDWNsaWNrX2NlbGxfaWQYByABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "FwoPdHJpZ2dlcl9jZWxsX2lkGAggASgNEhMKC2VmZmVjdF90eXBlGAkgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "EhYKDnRyaWdnZXJfbWFwX2lkGAogASgNEhQKDGNsaWNrX21hcF9pZBgPIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			JDMPAAEGMCDReflection.Descriptor,
			NGAEFPNBDADReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyActionResult), MonopolyActionResult.Parser, new string[7] { "Detail", "SourceType", "ClickCellId", "TriggerCellId", "EffectType", "TriggerMapId", "ClickMapId" }, null, null, null, null)
		}));
	}
}
