using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightTraitTrackSyncInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightTraitTrackSyncInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHcmlkRmlnaHRUcmFpdFRyYWNrU3luY0luZm8ucHJvdG8iSwobR3JpZEZp" + "Z2h0VHJhaXRUcmFja1N5bmNJbmZvEg8KB2lzX3N5bmMYDCABKAgSGwoTdHJh" + "Y2tfdHJhaXRfaWRfbGlzdBgOIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightTraitTrackSyncInfo), GridFightTraitTrackSyncInfo.Parser, new string[2] { "IsSync", "TrackTraitIdList" }, null, null, null, null)
		}));
	}
}
