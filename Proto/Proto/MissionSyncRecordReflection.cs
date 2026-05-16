using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MissionSyncRecordReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MissionSyncRecordReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChdNaXNzaW9uU3luY1JlY29yZC5wcm90byq1AgoRTWlzc2lvblN5bmNSZWNv";
		buffer[1] = "cmQSGwoXQUxHUENPT0JFRkZfQURQSkZNSkpBQk4QABIbChdBTEdQQ09PQkVG";
		buffer[2] = "Rl9LSEpDS0NERkVKTBABEhsKF0FMR1BDT09CRUZGX0ZNSUpQQlBPSEpEEAIS";
		buffer[3] = "GwoXQUxHUENPT0JFRkZfUE9HUE5OQkhNSU8QAxIbChdBTEdQQ09PQkVGRl9P";
		buffer[4] = "TU5GTEFJS0lCQxAEEhsKF0FMR1BDT09CRUZGX0VBSEJNT0ZKSUZJEAsSGwoX";
		buffer[5] = "QUxHUENPT0JFRkZfRkFFS0RDRVBQTk4QDBIbChdBTEdQQ09PQkVGRl9DREVI";
		buffer[6] = "REJJSUFBSBANEhsKF0FMR1BDT09CRUZGX0NHRURESUVDT0tBEA4SGwoXQUxH";
		buffer[7] = "UENPT0JFRkZfT01ISEZKTUhQT0IQD0IWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[8] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MissionSyncRecord) }, null, null));
	}
}
