using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IPHFDELCNBDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IPHFDELCNBDReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFJUEhGREVMQ05CRC5wcm90bxoRS0ZPRUVQR05ET0MucHJvdG8aEU1DQUZH";
		buffer[1] = "QlBMRkVILnByb3RvIosBCgtJUEhGREVMQ05CRBIhCgtCUEhFQ0ZOQ0lDQxgB";
		buffer[2] = "IAEoDjIMLktGT0VFUEdORE9DEhEKCXVuaXF1ZV9pZBgCIAEoDRIcCgZzb3Vy";
		buffer[3] = "Y2UYAyABKAsyDC5NQ0FGR0JQTEZFSBITCgtQRUlMUElFS0xLRBgEIAEoARIT";
		buffer[4] = "CgtIT0tITU5HTUhLQRgNIAEoAUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[5] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			KFOEEPGNDOCReflection.Descriptor,
			MCAFGBPLFEHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IPHFDELCNBD), IPHFDELCNBD.Parser, new string[5] { "BPHECFNCICC", "UniqueId", "Source", "PEILPIEKLKD", "HOKHMNGMHKA" }, null, null, null, null)
		}));
	}
}
