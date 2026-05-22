using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HMDJNPFBOMMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HMDJNPFBOMMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFITURKTlBGQk9NTS5wcm90bxoRRUhLRUpFUE5HTUIucHJvdG8iMAoLSE1E" + "Sk5QRkJPTU0SIQoLSU1CQ0pLSE1PQUIYASADKAsyDC5FSEtFSkVQTkdNQkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { EHKEJEPNGMBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HMDJNPFBOMM), HMDJNPFBOMM.Parser, new string[1] { "IMBCJKHMOAB" }, null, null, null, null)
		}));
	}
}
