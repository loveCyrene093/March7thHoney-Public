using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HIDPJPNFCKOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HIDPJPNFCKOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFISURQSlBORkNLTy5wcm90byJ0CgtISURQSlBORkNLTxIRCglhdmF0YXJf" + "aWQYASABKA0SEwoLTU1LSktHTUlFQVAYAiABKAgSEwoLSkZPQUdOSUxOS0sY" + "AyABKAgSEwoLTkZJTEFPTFBPS0UYBCABKAgSEwoLUEpIREtEQUZISkQYBSAB" + "KAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HIDPJPNFCKO), HIDPJPNFCKO.Parser, new string[5] { "AvatarId", "MMKJKGMIEAP", "JFOAGNILNKK", "NFILAOLPOKE", "PJHDKDAFHJD" }, null, null, null, null)
		}));
	}
}
