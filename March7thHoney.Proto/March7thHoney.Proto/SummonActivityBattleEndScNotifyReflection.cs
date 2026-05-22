using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SummonActivityBattleEndScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SummonActivityBattleEndScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVTdW1tb25BY3Rpdml0eUJhdHRsZUVuZFNjTm90aWZ5LnByb3RvImsKH1N1" + "bW1vbkFjdGl2aXR5QmF0dGxlRW5kU2NOb3RpZnkSEAoIZ3JvdXBfaWQYAiAB" + "KA0SEwoLTklJRUtDTUJFTkkYByABKA0SDAoEc3RhchgIIAEoDRITCgtJTk9N" + "RkZBSUVPQRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SummonActivityBattleEndScNotify), SummonActivityBattleEndScNotify.Parser, new string[4] { "GroupId", "NIIEKCMBENI", "Star", "INOMFFAIEOA" }, null, null, null, null)
		}));
	}
}
