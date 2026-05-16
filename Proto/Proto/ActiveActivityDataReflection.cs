using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ActiveActivityDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ActiveActivityDataReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChhBY3RpdmVBY3Rpdml0eURhdGEucHJvdG8ijQEKEkFjdGl2ZUFjdGl2aXR5";
		buffer[1] = "RGF0YRITCgtPS0tKTEZLTEhCSBgCIAEoDRIQCghwYW5lbF9pZBgFIAEoDRIK";
		buffer[2] = "CgJpZBgGIAEoDRIaChJ0YWtlbl9zdGFyX3Jld2FyZHMYByADKA0SEwoLUEdE";
		buffer[3] = "R0dBUEZQQk4YCCABKA0SEwoLQUNMQk1JRUhCSkUYDCABKA1CFqoCE01hcmNo";
		buffer[4] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ActiveActivityData), ActiveActivityData.Parser, new string[6] { "OKKJLFKLHBH", "PanelId", "Id", "TakenStarRewards", "PGDGGAPFPBN", "ACLBMIEHBJE" }, null, null, null, null)
		}));
	}
}
