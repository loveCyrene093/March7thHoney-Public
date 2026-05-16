using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightTalentInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightTalentInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHcmlkRmlnaHRUYWxlbnRJbmZvLnByb3RvIioKE0dyaWRGaWdodFRhbGVu" + "dEluZm8SEwoLREFOQUdEQVBLSkUYCSADKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightTalentInfo), GridFightTalentInfo.Parser, new string[1] { "DANAGDAPKJE" }, null, null, null, null)
		}));
	}
}
