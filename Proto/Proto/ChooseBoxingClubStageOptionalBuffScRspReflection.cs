using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChooseBoxingClubStageOptionalBuffScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChooseBoxingClubStageOptionalBuffScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CixDaG9vc2VCb3hpbmdDbHViU3RhZ2VPcHRpb25hbEJ1ZmZTY1JzcC5wcm90";
		buffer[1] = "bxoRT09NSU5HRUZQQUYucHJvdG8iXAomQ2hvb3NlQm94aW5nQ2x1YlN0YWdl";
		buffer[2] = "T3B0aW9uYWxCdWZmU2NSc3ASIQoLT1BDR05KTUdKREUYASABKAsyDC5PT01J";
		buffer[3] = "TkdFRlBBRhIPCgdyZXRjb2RlGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[4] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { OOMINGEFPAFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChooseBoxingClubStageOptionalBuffScRsp), ChooseBoxingClubStageOptionalBuffScRsp.Parser, new string[2] { "OPCGNJMGJDE", "Retcode" }, null, null, null, null)
		}));
	}
}
