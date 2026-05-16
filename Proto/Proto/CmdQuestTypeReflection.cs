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
		buffer[0] = "ChJDbWRRdWVzdFR5cGUucHJvdG8qpQMKDENtZFF1ZXN0VHlwZRIbChdPSFBK";
		buffer[1] = "TU1QT0pFTl9QQ1BESEVMUEtFTRAAEiQKH0NtZFRha2VRdWVzdE9wdGlvbmFs";
		buffer[2] = "UmV3YXJkU2NSc3AQzgcSHAoXQ21kVGFrZVF1ZXN0UmV3YXJkQ3NSZXEQ4gcS";
		buffer[3] = "GwoWQ21kQ21kRmluaXNoUXVlc3RDc1JlcRCeBxITCg5DbWRHR0FNUEpMT05H";
		buffer[4] = "RBCrBxIbChZDbWRHZXRRdWVzdFJlY29yZENzUmVxEI0HEhwKF0NtZFRha2VR";
		buffer[5] = "dWVzdFJld2FyZFNjUnNwEOMHEhkKFENtZEdldFF1ZXN0RGF0YVNjUnNwEI4H";
		buffer[6] = "EhsKFkNtZEdldFF1ZXN0UmVjb3JkU2NSc3AQ5gcSGwoWQ21kUXVlc3RSZWNv";
		buffer[7] = "cmRTY05vdGlmeRDDBxIkCh9DbWRUYWtlUXVlc3RPcHRpb25hbFJld2FyZENz";
		buffer[8] = "UmVxEIUHEhMKDkNtZFBKQkVCTE5KQU5NEKoHEhkKFENtZEdldFF1ZXN0RGF0";
		buffer[9] = "YUNzUmVxEN8HEhwKF09IUEpNTVBPSkVOX0ZHT0dESExMT0JGEIgHQhaqAhNN";
		buffer[10] = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdQuestType) }, null, null));
	}
}
