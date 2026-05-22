using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DGKNDMAHMAPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DGKNDMAHMAPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFER0tORE1BSE1BUC5wcm90bxoRSEdFTEtER0NDT0wucHJvdG8iMAoLREdL" + "TkRNQUhNQVASIQoLQklCR0hJQ0lES1AYAiADKAsyDC5IR0VMS0RHQ0NPTEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { HGELKDGCCOLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DGKNDMAHMAP), DGKNDMAHMAP.Parser, new string[1] { "BIBGHICIDKP" }, null, null, null, null)
		}));
	}
}
