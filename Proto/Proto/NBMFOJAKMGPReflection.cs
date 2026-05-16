using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NBMFOJAKMGPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NBMFOJAKMGPReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFOQk1GT0pBS01HUC5wcm90bxofUmVsaWNQcmVzZXRQbGFuU291cmNlVHlw";
		buffer[1] = "ZS5wcm90byKFAQoLTkJNRk9KQUtNR1ASLwoLQUxGSE5FSE9CSkEYAyABKA4y";
		buffer[2] = "Gi5SZWxpY1ByZXNldFBsYW5Tb3VyY2VUeXBlEgwKBG5hbWUYBSABKAkSEQoJ";
		buffer[3] = "cmVsaWNfaWRzGAggAygNEhEKCWF2YXRhcl9pZBgNIAEoDRIRCgl1bmlxdWVf";
		buffer[4] = "aWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { RelicPresetPlanSourceTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NBMFOJAKMGP), NBMFOJAKMGP.Parser, new string[5] { "ALFHNEHOBJA", "Name", "RelicIds", "AvatarId", "UniqueId" }, null, null, null, null)
		}));
	}
}
