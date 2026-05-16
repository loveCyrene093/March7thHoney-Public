using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueUpdateLevelBaseInfoScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueUpdateLevelBaseInfoScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CitDaGVzc1JvZ3VlVXBkYXRlTGV2ZWxCYXNlSW5mb1NjTm90aWZ5LnByb3Rv";
		buffer[1] = "GhFJREZDR0dNTUZGQS5wcm90bxoRS0dESU1QRU9HT0wucHJvdG8iaAolQ2hl";
		buffer[2] = "c3NSb2d1ZVVwZGF0ZUxldmVsQmFzZUluZm9TY05vdGlmeRIcCgZyZWFzb24Y";
		buffer[3] = "BSABKA4yDC5JREZDR0dNTUZGQRIhCgtMSEpFSkVQR0tGSBgMIAEoDjIMLktH";
		buffer[4] = "RElNUEVPR09MQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			IDFCGGMMFFAReflection.Descriptor,
			KGDIMPEOGOLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueUpdateLevelBaseInfoScNotify), ChessRogueUpdateLevelBaseInfoScNotify.Parser, new string[2] { "Reason", "LHJEJEPGKFH" }, null, null, null, null)
		}));
	}
}
