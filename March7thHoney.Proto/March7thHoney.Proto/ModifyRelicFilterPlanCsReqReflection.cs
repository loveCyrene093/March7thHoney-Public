using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ModifyRelicFilterPlanCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ModifyRelicFilterPlanCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiBNb2RpZnlSZWxpY0ZpbHRlclBsYW5Dc1JlcS5wcm90bxoRRk9GQkRCSkJF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "SkUucHJvdG8aEU9CT0tESERPS0FELnByb3RvIpoBChpNb2RpZnlSZWxpY0Zp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "bHRlclBsYW5Dc1JlcRITCgtLS0dJRUVOQ09JQxgGIAEoDRIjCgtITUlITERQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "TVBPTRgBIAEoCzIMLk9CT0tESERPS0FESAASIwoLSkhISE9OSklLR0wYDiAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "KAsyDC5GT0ZCREJKQkVKRUgAEg4KBG5hbWUYDyABKAlIAEINCgtCUElIRkFK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "Q0xPQ0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			FOFBDBJBEJEReflection.Descriptor,
			OBOKDHDOKADReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ModifyRelicFilterPlanCsReq), ModifyRelicFilterPlanCsReq.Parser, new string[4] { "KKGIEENCOIC", "HMIHLDPMPOM", "JHHHONJIKGL", "Name" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
