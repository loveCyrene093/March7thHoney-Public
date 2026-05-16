using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ENIHADNBFFIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ENIHADNBFFIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFTklIQUROQkZGSS5wcm90byIiCgtFTklIQUROQkZGSRITCgtBTUFERkpO" + "SE1GRhgGIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ENIHADNBFFI), ENIHADNBFFI.Parser, new string[1] { "AMADFJNHMFF" }, null, null, null, null)
		}));
	}
}
