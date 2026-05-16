using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KLCICNHAOPFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KLCICNHAOPFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLTENJQ05IQU9QRi5wcm90bxoRT0xOUENMRUZBTk4ucHJvdG8iMAoLS0xD" + "SUNOSEFPUEYSIQoLRUxDUE9OSVBFSUgYDCADKAsyDC5PTE5QQ0xFRkFOTkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { OLNPCLEFANNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KLCICNHAOPF), KLCICNHAOPF.Parser, new string[1] { "ELCPONIPEIH" }, null, null, null, null)
		}));
	}
}
