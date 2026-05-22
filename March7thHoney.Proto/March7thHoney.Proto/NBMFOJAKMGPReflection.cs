using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NBMFOJAKMGPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NBMFOJAKMGPReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFOQk1GT0pBS01HUC5wcm90bxofUmVsaWNQcmVzZXRQbGFuU291cmNlVHlw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "ZS5wcm90byKFAQoLTkJNRk9KQUtNR1ASLwoLQUxGSE5FSE9CSkEYAyABKA4y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Gi5SZWxpY1ByZXNldFBsYW5Tb3VyY2VUeXBlEgwKBG5hbWUYBSABKAkSEQoJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "cmVsaWNfaWRzGAggAygNEhEKCWF2YXRhcl9pZBgNIAEoDRIRCgl1bmlxdWVf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { RelicPresetPlanSourceTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NBMFOJAKMGP), NBMFOJAKMGP.Parser, new string[5] { "ALFHNEHOBJA", "Name", "RelicIds", "AvatarId", "UniqueId" }, null, null, null, null)
		}));
	}
}
