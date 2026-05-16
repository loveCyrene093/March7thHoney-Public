using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IDIGEJHHPDLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IDIGEJHHPDLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJRElHRUpISFBETC5wcm90byJMCgtJRElHRUpISFBETBITCgtJSUtDQ0dG" + "SktBQhgDIAEoDRITCgtHRFBHT0JJSUxOTxgKIAEoDRITCgtNT0xMQkFNR0xB" + "RxgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IDIGEJHHPDL), IDIGEJHHPDL.Parser, new string[3] { "IIKCCGFJKAB", "GDPGOBIILNO", "MOLLBAMGLAG" }, null, null, null, null)
		}));
	}
}
