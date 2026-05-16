using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UnlockBackGroundMusicCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UnlockBackGroundMusicCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBVbmxvY2tCYWNrR3JvdW5kTXVzaWNDc1JlcS5wcm90byIxChpVbmxvY2tC" + "YWNrR3JvdW5kTXVzaWNDc1JlcRITCgtKQ0NPT0dMQ01OUBgMIAMoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UnlockBackGroundMusicCsReq), UnlockBackGroundMusicCsReq.Parser, new string[1] { "JCCOOGLCMNP" }, null, null, null, null)
		}));
	}
}
