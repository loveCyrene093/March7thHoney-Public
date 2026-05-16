using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpgradeAreaScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpgradeAreaScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZVcGdyYWRlQXJlYVNjUnNwLnByb3RvIkMKEFVwZ3JhZGVBcmVhU2NSc3AS" + "DQoFbGV2ZWwYBCABKA0SDwoHcmV0Y29kZRgHIAEoDRIPCgdhcmVhX2lkGA4g" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpgradeAreaScRsp), UpgradeAreaScRsp.Parser, new string[3] { "Level", "Retcode", "AreaId" }, null, null, null, null)
		}));
	}
}
