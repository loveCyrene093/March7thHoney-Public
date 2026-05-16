using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrackMainMissionUpdateReasonIdReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrackMainMissionUpdateReasonIdReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiRUcmFja01haW5NaXNzaW9uVXBkYXRlUmVhc29uSWQucHJvdG8qlAEKHlRy";
		buffer[1] = "YWNrTWFpbk1pc3Npb25VcGRhdGVSZWFzb25JZBIbChdESkVPR0xGREpJRl9E";
		buffer[2] = "UERGSUlORUFGRhAAEhsKF0RKRU9HTEZESklGX05ER0VESkpCUEJIEAESGwoX";
		buffer[3] = "REpFT0dMRkRKSUZfTURMRUtLTEtCQ0IQAhIbChdESkVPR0xGREpJRl9NUEJF";
		buffer[4] = "SURKSExIQRADQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(TrackMainMissionUpdateReasonId) }, null, null));
	}
}
