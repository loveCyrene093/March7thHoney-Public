using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGameAugmentSyncReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGameAugmentSyncReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HcmlkRmlnaHRHYW1lQXVnbWVudFN5bmMucHJvdG8aGUdyaWRHYW1lQXVn" + "bWVudEluZm8ucHJvdG8iSwoYR3JpZEZpZ2h0R2FtZUF1Z21lbnRTeW5jEi8K" + "EXN5bmNfYXVnbWVudF9pbmZvGAYgAygLMhQuR3JpZEdhbWVBdWdtZW50SW5m" + "b0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GridGameAugmentInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGameAugmentSync), GridFightGameAugmentSync.Parser, new string[1] { "SyncAugmentInfo" }, null, null, null, null)
		}));
	}
}
