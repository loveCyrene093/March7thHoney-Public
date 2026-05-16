using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GLHDNGFKAADReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GLHDNGFKAADReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFHTEhETkdGS0FBRC5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvImwKC0dM";
		buffer[1] = "SEROR0ZLQUFEEg8KB2l0ZW1faWQYAyABKA0SEwoLUElNSkVERUxPSE4YBCAB";
		buffer[2] = "KA0SIgoLTEFBTFBNSkdNTE4YByABKAsyDS5JdGVtQ29zdERhdGESEwoLREtK";
		buffer[3] = "RkRMS0pMQkUYCiABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GLHDNGFKAAD), GLHDNGFKAAD.Parser, new string[4] { "ItemId", "PIMJEDELOHN", "LAALPMJGMLN", "DKJFDLKJLBE" }, null, null, null, null)
		}));
	}
}
