using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneCheckpointRefreshMonsterReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneCheckpointRefreshMonsterReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZTY2VuZUNoZWNrcG9pbnRSZWZyZXNoTW9uc3RlclJlcS5wcm90byJeCiBT" + "Y2VuZUNoZWNrcG9pbnRSZWZyZXNoTW9uc3RlclJlcRIQCghwbGFuZV9pZBgG" + "IAEoDRIWCg5wcm9wX2VudGl0eV9pZBgLIAEoDRIQCghmbG9vcl9pZBgMIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneCheckpointRefreshMonsterReq), SceneCheckpointRefreshMonsterReq.Parser, new string[3] { "PlaneId", "PropEntityId", "FloorId" }, null, null, null, null)
		}));
	}
}
