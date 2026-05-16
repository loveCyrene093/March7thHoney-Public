using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncRogueGetItemScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncRogueGetItemScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5TeW5jUm9ndWVHZXRJdGVtU2NOb3RpZnkucHJvdG8aDkl0ZW1MaXN0LnBy" + "b3RvIlwKGFN5bmNSb2d1ZUdldEl0ZW1TY05vdGlmeRIeCgtJT0hBT05GRExL" + "RRgIIAEoCzIJLkl0ZW1MaXN0EiAKDWdldF9pdGVtX2xpc3QYDiABKAsyCS5J" + "dGVtTGlzdEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueGetItemScNotify), SyncRogueGetItemScNotify.Parser, new string[2] { "IOHAONFDLKE", "GetItemList" }, null, null, null, null)
		}));
	}
}
