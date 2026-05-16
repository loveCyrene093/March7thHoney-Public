using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdQuestTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdQuestTypeReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 0) = "ChJDbWRRdWVzdFR5cGUucHJvdG8qpQMKDENtZFF1ZXN0VHlwZRIbChdPSFBK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 1) = "TU1QT0pFTl9QQ1BESEVMUEtFTRAAEiQKH0NtZFRha2VRdWVzdE9wdGlvbmFs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 2) = "UmV3YXJkU2NSc3AQzgcSHAoXQ21kVGFrZVF1ZXN0UmV3YXJkQ3NSZXEQ4gcS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 3) = "GwoWQ21kQ21kRmluaXNoUXVlc3RDc1JlcRCeBxITCg5DbWRHR0FNUEpMT05H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 4) = "RBCrBxIbChZDbWRHZXRRdWVzdFJlY29yZENzUmVxEI0HEhwKF0NtZFRha2VR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 5) = "dWVzdFJld2FyZFNjUnNwEOMHEhkKFENtZEdldFF1ZXN0RGF0YVNjUnNwEI4H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 6) = "EhsKFkNtZEdldFF1ZXN0UmVjb3JkU2NSc3AQ5gcSGwoWQ21kUXVlc3RSZWNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 7) = "cmRTY05vdGlmeRDDBxIkCh9DbWRUYWtlUXVlc3RPcHRpb25hbFJld2FyZENz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 8) = "UmVxEIUHEhMKDkNtZFBKQkVCTE5KQU5NEKoHEhkKFENtZEdldFF1ZXN0RGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 9) = "YUNzUmVxEN8HEhwKF09IUEpNTVBPSkVOX0ZHT0dESExMT0JGEIgHQhaqAhNN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 10) = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray11<string>, string>(in buffer, 11))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdQuestType) }, null, null));
	}
}
