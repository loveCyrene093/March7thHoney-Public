using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OOKCIAEIPONReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OOKCIAEIPONReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPT0tDSUFFSVBPTi5wcm90byJ2CgtPT0tDSUFFSVBPThITCgtJTUlIR0xB" + "T0lFRxgBIAEoDRITCgtMSkVFQ09PUE1MTRgFIAEoDRITCgtLS0hOREdFSkJI" + "ShgGIAEoDRITCgtHT09EUERLR0pBShgHIAEoDRITCgtHRkVMSElDS09HSRgM" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OOKCIAEIPON), OOKCIAEIPON.Parser, new string[5] { "IMIHGLAOIEG", "LJEECOOPMLM", "KKHNDGEJBHJ", "GOODPDKGJAJ", "GFELHICKOGI" }, null, null, null, null)
		}));
	}
}
