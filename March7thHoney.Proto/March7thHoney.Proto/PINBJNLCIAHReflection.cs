using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PINBJNLCIAHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PINBJNLCIAHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQSU5CSk5MQ0lBSC5wcm90byJMCgtQSU5CSk5MQ0lBSBITCgtIQ0RBRE9H" + "SEFETBgFIAMoDRITCgtJRUlORUNQSE9GTBgGIAEoDRITCgtQSUlDS01FT0JJ" + "UBgIIAEoBUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PINBJNLCIAH), PINBJNLCIAH.Parser, new string[3] { "HCDADOGHADL", "IEINECPHOFL", "PIICKMEOBIP" }, null, null, null, null)
		}));
	}
}
