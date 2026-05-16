using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MJDBHCKMLILReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MJDBHCKMLILReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNSkRCSENLTUxJTC5wcm90bxoRUE9OUEhIREJFSkoucHJvdG8iPwoLTUpE" + "QkhDS01MSUwSDQoFbGV2ZWwYCiABKA0SIQoLQ0lEREpLUEdNREkYCyABKA4y" + "DC5QT05QSEhEQkVKSkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { PONPHHDBEJJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MJDBHCKMLIL), MJDBHCKMLIL.Parser, new string[2] { "Level", "CIDDJKPGMDI" }, null, null, null, null)
		}));
	}
}
