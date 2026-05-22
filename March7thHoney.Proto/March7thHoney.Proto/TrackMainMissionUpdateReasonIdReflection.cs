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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiRUcmFja01haW5NaXNzaW9uVXBkYXRlUmVhc29uSWQucHJvdG8qlAEKHlRy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "YWNrTWFpbk1pc3Npb25VcGRhdGVSZWFzb25JZBIbChdESkVPR0xGREpJRl9E";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "UERGSUlORUFGRhAAEhsKF0RKRU9HTEZESklGX05ER0VESkpCUEJIEAESGwoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "REpFT0dMRkRKSUZfTURMRUtLTEtCQ0IQAhIbChdESkVPR0xGREpJRl9NUEJF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "SURKSExIQRADQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(TrackMainMissionUpdateReasonId) }, null, null));
	}
}
