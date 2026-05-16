using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ALDEIBDDMONReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ALDEIBDDMONReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBTERFSUJERE1PTi5wcm90bxoRR05BTk1FQURQQkQucHJvdG8iMAoLQUxE" + "RUlCRERNT04SIQoLRUZKQkZCRU5HS0cYDiABKAsyDC5HTkFOTUVBRFBCREIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GNANMEADPBDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ALDEIBDDMON), ALDEIBDDMON.Parser, new string[1] { "EFJBFBENGKG" }, null, null, null, null)
		}));
	}
}
