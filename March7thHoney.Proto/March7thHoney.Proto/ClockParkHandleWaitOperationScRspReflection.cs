using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ClockParkHandleWaitOperationScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ClockParkHandleWaitOperationScRspReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "CidDbG9ja1BhcmtIYW5kbGVXYWl0T3BlcmF0aW9uU2NSc3AucHJvdG8aGUNs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "b2NrUGFya1BsYXlTdGF0dXMucHJvdG8aFVNjZW5lQmF0dGxlSW5mby5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "byLFAQohQ2xvY2tQYXJrSGFuZGxlV2FpdE9wZXJhdGlvblNjUnNwEikKC05L";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "QUhERUVPSEFPGAIgASgOMhQuQ2xvY2tQYXJrUGxheVN0YXR1cxIPCgdyZXRj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "b2RlGAcgASgNEhMKC05ERUVCRERFT0ZBGAggASgNEiUKC2JhdHRsZV9pbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "GAsgASgLMhAuU2NlbmVCYXR0bGVJbmZvEhMKC05ORkFNT0pBSENIGAwgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "EhMKC0lITk1ITlBNSEpHGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[2]
		{
			ClockParkPlayStatusReflection.Descriptor,
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ClockParkHandleWaitOperationScRsp), ClockParkHandleWaitOperationScRsp.Parser, new string[6] { "NKAHDEEOHAO", "Retcode", "NDEEBDDEOFA", "BattleInfo", "NNFAMOJAHCH", "IHNMHNPMHJG" }, null, null, null, null)
		}));
	}
}
