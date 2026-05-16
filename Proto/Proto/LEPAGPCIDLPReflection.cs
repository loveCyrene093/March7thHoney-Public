using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LEPAGPCIDLPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LEPAGPCIDLPReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMRVBBR1BDSURMUC5wcm90bxoRQUNQTUtQTE9CRUYucHJvdG8aEUFESE5K";
		buffer[1] = "QURJSkFDLnByb3RvIl0KC0xFUEFHUENJRExQEg8KB3JldGNvZGUYASABKA0S";
		buffer[2] = "IQoLQklFQkZIRUNFUE0YBSADKAsyDC5BREhOSkFESUpBQxIaCgRkYXRhGAkg";
		buffer[3] = "ASgLMgwuQUNQTUtQTE9CRUZCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[4] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ACPMKPLOBEFReflection.Descriptor,
			ADHNJADIJACReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LEPAGPCIDLP), LEPAGPCIDLP.Parser, new string[3] { "Retcode", "BIEBFHECEPM", "Data" }, null, null, null, null)
		}));
	}
}
