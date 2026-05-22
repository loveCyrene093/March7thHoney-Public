using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyBuildStartStepCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyBuildStartStepCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiNUcmFpblBhcnR5QnVpbGRTdGFydFN0ZXBDc1JlcS5wcm90bxoVQXJlYUR5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "bmFtaWNJbmZvLnByb3RvIoEBCh1UcmFpblBhcnR5QnVpbGRTdGFydFN0ZXBD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "c1JlcRITCgtPSUdIQk9NRkdHRBgBIAEoDRIPCgdhcmVhX2lkGAMgASgNEhMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "C0ZOTE5QTEhPRUpOGA0gASgNEiUKC0xNSElCSEdJTkxHGA8gASgLMhAuQXJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "YUR5bmFtaWNJbmZvQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { AreaDynamicInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyBuildStartStepCsReq), TrainPartyBuildStartStepCsReq.Parser, new string[4] { "OIGHBOMFGGD", "AreaId", "FNLNPLHOEJN", "LMHIBHGINLG" }, null, null, null, null)
		}));
	}
}
