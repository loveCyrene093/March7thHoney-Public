using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartAetherDivideStageBattleCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartAetherDivideStageBattleCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidTdGFydEFldGhlckRpdmlkZVN0YWdlQmF0dGxlQ3NSZXEucHJvdG8iNQoh" + "U3RhcnRBZXRoZXJEaXZpZGVTdGFnZUJhdHRsZUNzUmVxEhAKCGV2ZW50X2lk" + "GAUgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartAetherDivideStageBattleCsReq), StartAetherDivideStageBattleCsReq.Parser, new string[1] { "EventId" }, null, null, null, null)
		}));
	}
}
