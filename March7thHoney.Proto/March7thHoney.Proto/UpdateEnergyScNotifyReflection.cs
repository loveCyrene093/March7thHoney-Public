using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateEnergyScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateEnergyScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpVcGRhdGVFbmVyZ3lTY05vdGlmeS5wcm90bxoXUm90YXRlckVuZXJneUlu" + "Zm8ucHJvdG8iPwoUVXBkYXRlRW5lcmd5U2NOb3RpZnkSJwoLZW5lcmd5X2lu" + "Zm8YCSABKAsyEi5Sb3RhdGVyRW5lcmd5SW5mb0IWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { RotaterEnergyInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateEnergyScNotify), UpdateEnergyScNotify.Parser, new string[1] { "EnergyInfo" }, null, null, null, null)
		}));
	}
}
