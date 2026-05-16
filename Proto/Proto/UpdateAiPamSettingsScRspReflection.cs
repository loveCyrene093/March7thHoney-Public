using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateAiPamSettingsScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateAiPamSettingsScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5VcGRhdGVBaVBhbVNldHRpbmdzU2NSc3AucHJvdG8iQAoYVXBkYXRlQWlQ" + "YW1TZXR0aW5nc1NjUnNwEg8KB3JldGNvZGUYBSABKA0SEwoLRUtCTUlPQ09M" + "SUMYDyABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateAiPamSettingsScRsp), UpdateAiPamSettingsScRsp.Parser, new string[2] { "Retcode", "EKBMIOCOLIC" }, null, null, null, null)
		}));
	}
}
