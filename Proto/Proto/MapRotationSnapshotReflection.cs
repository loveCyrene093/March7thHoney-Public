using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MapRotationSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MapRotationSnapshotReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChlNYXBSb3RhdGlvblNuYXBzaG90LnByb3RvGh1Sb3RhdGlvbk1hcEluZm9T";
		buffer[1] = "bmFwc2hvdC5wcm90byJlChNNYXBSb3RhdGlvblNuYXBzaG90EhEKCXJlZ2lv";
		buffer[2] = "bl9pZBgBIAEoBRIPCgdwb3NlX2lkGAIgASgNEioKCG1hcF9pbmZvGAMgASgL";
		buffer[3] = "MhguUm90YXRpb25NYXBJbmZvU25hcHNob3RCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[4] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { RotationMapInfoSnapshotReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MapRotationSnapshot), MapRotationSnapshot.Parser, new string[3] { "RegionId", "PoseId", "MapInfo" }, null, null, null, null)
		}));
	}
}
