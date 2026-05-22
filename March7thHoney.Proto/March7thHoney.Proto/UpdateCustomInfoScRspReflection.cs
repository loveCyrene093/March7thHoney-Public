using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateCustomInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateCustomInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtVcGRhdGVDdXN0b21JbmZvU2NSc3AucHJvdG8iXwoVVXBkYXRlQ3VzdG9t" + "SW5mb1NjUnNwEg8KB3JldGNvZGUYAiABKA0SDwoFdGl0bGUYBSABKAlIABIV" + "CgtGQ09LT0dOT0dDQRgLIAEoDUgAQg0KC05MUFBQQ0hHR1BGQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateCustomInfoScRsp), UpdateCustomInfoScRsp.Parser, new string[3] { "Retcode", "Title", "FCOKOGNOGCA" }, new string[1] { "NLPPPCHGGPF" }, null, null, null)
		}));
	}
}
