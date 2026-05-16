using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyEventLoadUpdateScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyEventLoadUpdateScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiVNb25vcG9seUV2ZW50TG9hZFVwZGF0ZVNjTm90aWZ5LnByb3RvGhFBQUhC";
		buffer[1] = "RUNJQ09FTi5wcm90byJnCh9Nb25vcG9seUV2ZW50TG9hZFVwZGF0ZVNjTm90";
		buffer[2] = "aWZ5EiEKC0xDUElPRENMTkhMGAMgAygLMgwuQUFIQkVDSUNPRU4SIQoLUEdJ";
		buffer[3] = "SEdOT0xJT0kYByADKAsyDC5BQUhCRUNJQ09FTkIWqgITTWFyY2g3dGhIb25l";
		buffer[4] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { AAHBECICOENReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyEventLoadUpdateScNotify), MonopolyEventLoadUpdateScNotify.Parser, new string[2] { "LCPIODCLNHL", "PGIHGNOLIOI" }, null, null, null, null)
		}));
	}
}
