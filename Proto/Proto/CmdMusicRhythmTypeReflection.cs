using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdMusicRhythmTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdMusicRhythmTypeReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "ChhDbWRNdXNpY1JoeXRobVR5cGUucHJvdG8q0wMKEkNtZE11c2ljUmh5dGht";
		buffer[1] = "VHlwZRIbChdORU1FQUZMRU9IS19QQ1BESEVMUEtFTRAAEhwKF0NtZE11c2lj";
		buffer[2] = "Umh5dGhtRGF0YVNjUnNwEKQ7EiIKHUNtZE11c2ljUmh5dGhtU3RhcnRMZXZl";
		buffer[3] = "bFNjUnNwEKU7EiMKHkNtZE11c2ljUmh5dGhtRmluaXNoTGV2ZWxTY1JzcBCT";
		buffer[4] = "OxIoCiNDbWRNdXNpY1JoeXRobVVubG9ja1NvbmdTZnhTY05vdGlmeRCrOxIj";
		buffer[5] = "Ch5DbWRNdXNpY1JoeXRobUZpbmlzaExldmVsQ3NSZXEQlTsSIgodQ21kTXVz";
		buffer[6] = "aWNSaHl0aG1TdGFydExldmVsQ3NSZXEQljsSJgohQ21kTXVzaWNSaHl0aG1V";
		buffer[7] = "bmxvY2tUcmFja1NjTm90aWZ5EJo7EioKJUNtZE11c2ljUmh5dGhtU2F2ZVNv";
		buffer[8] = "bmdDb25maWdEYXRhQ3NSZXEQqjsSKgolQ21kTXVzaWNSaHl0aG1TYXZlU29u";
		buffer[9] = "Z0NvbmZpZ0RhdGFTY1JzcBCwOxIcChdDbWRNdXNpY1JoeXRobURhdGFDc1Jl";
		buffer[10] = "cRCUOxITCg5DbWRIRENPT0ZBSE1IShCtOxITCg5DbWRETUVKSElMTUtBSBCh";
		buffer[11] = "O0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMusicRhythmType) }, null, null));
	}
}
