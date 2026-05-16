using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdWaypointTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdWaypointTypeReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChVDbWRXYXlwb2ludFR5cGUucHJvdG8qjwIKD0NtZFdheXBvaW50VHlwZRIb";
		buffer[1] = "ChdEQ0VFREhNRVBNQ19QQ1BESEVMUEtFTRAAEhwKF0RDRUVESE1FUE1DX0RC";
		buffer[2] = "TElNQ0NOTEFDEPIDEhwKF0RDRUVESE1FUE1DX0ZJQkdDT0JETktHEJ4DEhMK";
		buffer[3] = "DkNtZEpHTE1BTkpFTUpBEM8DEhMKDkNtZE5LSU9JUE1DT05HEO8DEhMKDkNt";
		buffer[4] = "ZEtQT0NBSU5GSkRBEKIDEhwKF0RDRUVESE1FUE1DX0hESU5ESkdNQ0xCEO4D";
		buffer[5] = "EhMKDkNtZE9MRE1LQ0lJTkdIEJoDEhwKF0RDRUVESE1FUE1DX05KTUNQQ0lF";
		buffer[6] = "REdEEOsDEhMKDkNtZERFQkhISElGSUhLEJkDQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[7] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdWaypointType) }, null, null));
	}
}
