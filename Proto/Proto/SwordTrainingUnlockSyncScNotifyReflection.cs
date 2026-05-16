using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingUnlockSyncScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingUnlockSyncScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiVTd29yZFRyYWluaW5nVW5sb2NrU3luY1NjTm90aWZ5LnByb3RvGhFQUERQ";
		buffer[1] = "REdDQkRFSC5wcm90byJZCh9Td29yZFRyYWluaW5nVW5sb2NrU3luY1NjTm90";
		buffer[2] = "aWZ5EiEKC05LSkhLTUJMSUJMGAMgAygLMgwuUFBEUERHQ0JERUgSEwoLSUZF";
		buffer[3] = "SkxKQ0lOQ0kYCiADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PPDPDGCBDEHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingUnlockSyncScNotify), SwordTrainingUnlockSyncScNotify.Parser, new string[2] { "NKJHKMBLIBL", "IFEJLJCINCI" }, null, null, null, null)
		}));
	}
}
