using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CENOIEMJPKKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CENOIEMJPKKReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFDRU5PSUVNSlBLSy5wcm90bxoRQU5IQ0RITE5FSk4ucHJvdG8aF0ZlYXR1";
		buffer[1] = "cmVTd2l0Y2hUeXBlLnByb3RvImcKC0NFTk9JRU1KUEtLEiAKBHR5cGUYASAB";
		buffer[2] = "KA4yEi5GZWF0dXJlU3dpdGNoVHlwZRIhCgtKS01CRENCT0ZPRxgCIAMoCzIM";
		buffer[3] = "LkFOSENESExORUpOEhMKC09PUENMSFBLSkJPGAMgASgIQhaqAhNNYXJjaDd0";
		buffer[4] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ANHCDHLNEJNReflection.Descriptor,
			FeatureSwitchTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CENOIEMJPKK), CENOIEMJPKK.Parser, new string[3] { "Type", "JKMBDCBOFOG", "OOPCLHPKJBO" }, null, null, null, null)
		}));
	}
}
