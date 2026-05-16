using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EFNNFKOMADNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EFNNFKOMADNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFRk5ORktPTUFETi5wcm90byI3CgtFRk5ORktPTUFEThITCgtPQkFNSENJ" + "RkZPQxgLIAEoDRITCgtBTE9ESkZQREtBTRgPIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EFNNFKOMADN), EFNNFKOMADN.Parser, new string[2] { "OBAMHCIFFOC", "ALODJFPDKAM" }, null, null, null, null)
		}));
	}
}
