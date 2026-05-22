using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MatchThreeSyncDataScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MatchThreeSyncDataScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBNYXRjaFRocmVlU3luY0RhdGFTY05vdGlmeS5wcm90bxoRTUpNUERHTkZJ" + "S04ucHJvdG8iPwoaTWF0Y2hUaHJlZVN5bmNEYXRhU2NOb3RpZnkSIQoLRENG" + "R09GTkJMQ00YAyABKAsyDC5NSk1QREdORklLTkIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { MJMPDGNFIKNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MatchThreeSyncDataScNotify), MatchThreeSyncDataScNotify.Parser, new string[1] { "DCFGOFNBLCM" }, null, null, null, null)
		}));
	}
}
