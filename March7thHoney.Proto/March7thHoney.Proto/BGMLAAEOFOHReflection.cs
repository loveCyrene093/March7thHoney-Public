using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BGMLAAEOFOHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BGMLAAEOFOHReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChFCR01MQUFFT0ZPSC5wcm90bxoRSUxPR0pJTE9KR0IucHJvdG8aEU5GQUJJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "SUJNTlBCLnByb3RvItABCgtCR01MQUFFT0ZPSBILCgN1aWQYASABKA0SEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "QU5CQlBQSEJDSkgYAiABKA0SEwoLQkJET0NKR0FFRUoYAyABKA0SEwoLTVBQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "Rk9KQ0VOUEQYBCABKA0SEwoLRENQS1BOTEtHTU0YBSABKA0SEgoKc2VjdGlv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "bl9pZBgGIAEoDRIpChNncmlkX2dhbWVfcm9sZV9saXN0GAcgAygLMgwuTkZB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "QklJQk1OUEISIQoLTEhDSEJBQkNQTUkYCCABKAsyDC5JTE9HSklMT0pHQkIW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			ILOGJILOJGBReflection.Descriptor,
			NFABIIBMNPBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BGMLAAEOFOH), BGMLAAEOFOH.Parser, new string[8] { "Uid", "ANBBPPHBCJH", "BBDOCJGAEEJ", "MPPFOJCENPD", "DCPKPNLKGMM", "SectionId", "GridGameRoleList", "LHCHBABCPMI" }, null, null, null, null)
		}));
	}
}
