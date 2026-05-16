using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyLikeScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyLikeScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpNb25vcG9seUxpa2VTY05vdGlmeS5wcm90byJAChRNb25vcG9seUxpa2VT" + "Y05vdGlmeRITCgtDSE5QTUlCSE9BQRgEIAEoDRITCgtIRkpORE9BSURPUBgP" + "IAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyLikeScNotify), MonopolyLikeScNotify.Parser, new string[2] { "CHNPMIBHOAA", "HFJNDOAIDOP" }, null, null, null, null)
		}));
	}
}
