using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OEBEKIEALFHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OEBEKIEALFHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPRUJFS0lFQUxGSC5wcm90bxoRS0hISEZIRU9ERUQucHJvdG8iRQoLT0VC" + "RUtJRUFMRkgSEwoLT0ZIQ05HSEpGSEkYASABKA0SIQoLQ09MRE5FTExJSUUY" + "BCADKAsyDC5LSEhIRkhFT0RFREIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { KHHHFHEODEDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OEBEKIEALFH), OEBEKIEALFH.Parser, new string[2] { "OFHCNGHJFHI", "COLDNELLIIE" }, null, null, null, null)
		}));
	}
}
