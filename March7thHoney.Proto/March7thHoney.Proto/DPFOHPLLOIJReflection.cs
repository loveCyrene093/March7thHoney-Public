using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DPFOHPLLOIJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DPFOHPLLOIJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEUEZPSFBMTE9JSi5wcm90bxoRRkRDRU5GUEtKTU8ucHJvdG8iSAoLRFBG" + "T0hQTExPSUoSFgoOcXVldWVfcG9zaXRpb24YAiABKA0SIQoLSlBQR0ZMSkhE" + "SEsYDSABKAsyDC5GRENFTkZQS0pNT0IWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[1] { FDCENFPKJMOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DPFOHPLLOIJ), DPFOHPLLOIJ.Parser, new string[2] { "QueuePosition", "JPPGFLJHDHK" }, null, null, null, null)
		}));
	}
}
