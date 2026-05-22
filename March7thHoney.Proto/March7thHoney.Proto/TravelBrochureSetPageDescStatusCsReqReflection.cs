using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TravelBrochureSetPageDescStatusCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TravelBrochureSetPageDescStatusCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CipUcmF2ZWxCcm9jaHVyZVNldFBhZ2VEZXNjU3RhdHVzQ3NSZXEucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "EUhBRElCRU1GRE1MLnByb3RvIl4KJFRyYXZlbEJyb2NodXJlU2V0UGFnZURl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "c2NTdGF0dXNDc1JlcRIhCgtHT0RBREFCR09KRBgFIAEoDjIMLkhBRElCRU1G";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "RE1MEhMKC0hCQ0pQQ01KUEhFGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { HADIBEMFDMLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TravelBrochureSetPageDescStatusCsReq), TravelBrochureSetPageDescStatusCsReq.Parser, new string[2] { "GODADABGOJD", "HBCJPCMJPHE" }, null, null, null, null)
		}));
	}
}
