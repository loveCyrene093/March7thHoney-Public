using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueCellUpdateNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueCellUpdateNotifyReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "CiBDaGVzc1JvZ3VlQ2VsbFVwZGF0ZU5vdGlmeS5wcm90bxoRQkdPQkJPTUxK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "Q00ucHJvdG8aEU5BS0lHTFBHS0JBLnByb3RvGh1Sb2d1ZU1vZGlmaWVyU291";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "cmNlVHlwZS5wcm90byKhAQoaQ2hlc3NSb2d1ZUNlbGxVcGRhdGVOb3RpZnkS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "IQoLRERQS0pLSEVETEgYBSADKAsyDC5OQUtJR0xQR0tCQRIcCgZyZWFzb24Y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "CyABKA4yDC5CR09CQk9NTEpDTRITCgtPSEhHQUFLR0xETxgOIAEoDRItCgtG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "UEFGSEJQQkhFRhgPIAEoDjIYLlJvZ3VlTW9kaWZpZXJTb3VyY2VUeXBlQhaq";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[3]
		{
			BGOBBOMLJCMReflection.Descriptor,
			NAKIGLPGKBAReflection.Descriptor,
			RogueModifierSourceTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueCellUpdateNotify), ChessRogueCellUpdateNotify.Parser, new string[4] { "DDPKJKHEDLH", "Reason", "OHHGAAKGLDO", "FPAFHBPBHEF" }, null, null, null, null)
		}));
	}
}
