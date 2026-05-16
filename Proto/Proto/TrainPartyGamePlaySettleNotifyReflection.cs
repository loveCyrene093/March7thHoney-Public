using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyGamePlaySettleNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyGamePlaySettleNotifyReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiRUcmFpblBhcnR5R2FtZVBsYXlTZXR0bGVOb3RpZnkucHJvdG8aHVRyYWlu";
		buffer[1] = "UGFydHlQYXNzZW5nZXJJbmZvLnByb3RvIpABCh5UcmFpblBhcnR5R2FtZVBs";
		buffer[2] = "YXlTZXR0bGVOb3RpZnkSEwoLSUVOR0VQQ0hITUMYBSADKA0SFwoPdW5sb2Nr";
		buffer[3] = "X2FyZWFfbnVtGAkgASgNEhEKCXJlY29yZF9pZBgKIAEoDRItCgtGSUpISUVP";
		buffer[4] = "QU5OTRgMIAEoCzIYLlRyYWluUGFydHlQYXNzZW5nZXJJbmZvQhaqAhNNYXJj";
		buffer[5] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { TrainPartyPassengerInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyGamePlaySettleNotify), TrainPartyGamePlaySettleNotify.Parser, new string[4] { "IENGEPCHHMC", "UnlockAreaNum", "RecordId", "FIJHIEOANNM" }, null, null, null, null)
		}));
	}
}
