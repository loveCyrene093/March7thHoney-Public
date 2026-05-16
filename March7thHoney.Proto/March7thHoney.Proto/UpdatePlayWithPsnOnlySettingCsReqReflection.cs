using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdatePlayWithPsnOnlySettingCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdatePlayWithPsnOnlySettingCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CidVcGRhdGVQbGF5V2l0aFBzbk9ubHlTZXR0aW5nQ3NSZXEucHJvdG8aEUtF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "QkhLSENBTEJPLnByb3RvGhFPRkxFRUxHTUJJTy5wcm90byJ+CiFVcGRhdGVQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "bGF5V2l0aFBzbk9ubHlTZXR0aW5nQ3NSZXESJAoLQUdKQ0dPSEVHUEwYkgYg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "ASgLMgwuS0VCSEtIQ0FMQk9IABIkCgtLTk9FS0hQTEFBThijByABKAsyDC5P";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "RkxFRUxHTUJJT0gAQg0KC0hOSUtHTEJJTU1JQhaqAhNNYXJjaDd0aEhvbmV5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			KEBHKHCALBOReflection.Descriptor,
			OFLEELGMBIOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdatePlayWithPsnOnlySettingCsReq), UpdatePlayWithPsnOnlySettingCsReq.Parser, new string[2] { "AGJCGOHEGPL", "KNOEKHPLAAN" }, new string[1] { "HNIKGLBIMMI" }, null, null, null)
		}));
	}
}
