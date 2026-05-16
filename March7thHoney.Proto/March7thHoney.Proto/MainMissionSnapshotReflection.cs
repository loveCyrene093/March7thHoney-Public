using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MainMissionSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MainMissionSnapshotReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlNYWluTWlzc2lvblNuYXBzaG90LnByb3RvGhhTdWJNaXNzaW9uU25hcHNo" + "b3QucHJvdG8iXQoTTWFpbk1pc3Npb25TbmFwc2hvdBIXCg9tYWluX21pc3Np" + "b25faWQYASABKA0SLQoQc3ViX21pc3Npb25fbGlzdBgCIAMoCzITLlN1Yk1p" + "c3Npb25TbmFwc2hvdEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { SubMissionSnapshotReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MainMissionSnapshot), MainMissionSnapshot.Parser, new string[2] { "MainMissionId", "SubMissionList" }, null, null, null, null)
		}));
	}
}
