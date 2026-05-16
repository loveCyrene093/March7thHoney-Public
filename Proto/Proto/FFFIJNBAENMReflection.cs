using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FFFIJNBAENMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FFFIJNBAENMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGRkZJSk5CQUVOTS5wcm90bxoRT0lESEFHTkdLTEcucHJvdG8iVgoLRkZG" + "SUpOQkFFTk0SEwoLTUFHUEFPTkpPQkQYBiABKA0SDwoHaXRlbV9pZBgLIAEo" + "DRIhCgtCTU5EQktCSElPQxgNIAEoCzIMLk9JREhBR05HS0xHQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { OIDHAGNGKLGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FFFIJNBAENM), FFFIJNBAENM.Parser, new string[3] { "MAGPAONJOBD", "ItemId", "BMNDBKBHIOC" }, null, null, null, null)
		}));
	}
}
