using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetDrinkMakerDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetDrinkMakerDataScRspReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChxHZXREcmlua01ha2VyRGF0YVNjUnNwLnByb3RvGhFDSUdLQkRJR0dPSS5w";
		buffer[1] = "cm90bxoRUE9ISUVLUEhNR0gucHJvdG8i9AEKFkdldERyaW5rTWFrZXJEYXRh";
		buffer[2] = "U2NSc3ASIQoLREtHT0ROQU1CSEgYASABKAsyDC5DSUdLQkRJR0dPSRITCgtE";
		buffer[3] = "T0hMTE1MRExNUBgDIAMoDRITCgtFREJPSERKREpBQRgEIAEoDRITCgtGRE5E";
		buffer[4] = "S09KTElDRBgFIAEoDRITCgtLSk5BSkVPT0JLQRgGIAEoDRIhCgtOSkhNTkdI";
		buffer[5] = "T0dKUBgHIAMoCzIMLlBPSElFS1BITUdIEg0KBWxldmVsGAggASgNEg8KB3Jl";
		buffer[6] = "dGNvZGUYCiABKA0SCwoDZXhwGAwgASgNEhMKC01HR0VQQU5KUExQGA8gASgN";
		buffer[7] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			CIGKBDIGGOIReflection.Descriptor,
			POHIEKPHMGHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetDrinkMakerDataScRsp), GetDrinkMakerDataScRsp.Parser, new string[10] { "DKGODNAMBHH", "DOHLLMLDLMP", "EDBOHDJDJAA", "FDNDKOJLICD", "KJNAJEOOBKA", "NJHMNGHOGJP", "Level", "Retcode", "Exp", "MGGEPANJPLP" }, null, null, null, null)
		}));
	}
}
