using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AAPCAHCHMFNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AAPCAHCHMFNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBQVBDQUhDSE1GTi5wcm90bxoRR01GQ05ORkhNR0UucHJvdG8iMAoLQUFQ" + "Q0FIQ0hNRk4SIQoLRVBHQVBDQ0FFTVAYDCADKAsyDC5HTUZDTk5GSE1HRUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GMFCNNFHMGEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AAPCAHCHMFN), AAPCAHCHMFN.Parser, new string[1] { "EPGAPCCAEMP" }, null, null, null, null)
		}));
	}
}
