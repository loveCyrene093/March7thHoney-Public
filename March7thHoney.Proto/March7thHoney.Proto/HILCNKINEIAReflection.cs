using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HILCNKINEIAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HILCNKINEIAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFISUxDTktJTkVJQS5wcm90bxoRRUlQUEdGQ0ZKRU8ucHJvdG8iMAoLSElM" + "Q05LSU5FSUESIQoLTU5PSERIQ01LRUwYDSABKAsyDC5FSVBQR0ZDRkpFT0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { EIPPGFCFJEOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HILCNKINEIA), HILCNKINEIA.Parser, new string[1] { "MNOHDHCMKEL" }, null, null, null, null)
		}));
	}
}
