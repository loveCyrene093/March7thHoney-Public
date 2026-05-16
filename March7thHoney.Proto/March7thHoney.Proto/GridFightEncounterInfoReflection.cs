using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightEncounterInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightEncounterInfoReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChxHcmlkRmlnaHRFbmNvdW50ZXJJbmZvLnByb3RvGh5HcmlkRW5jb3VudGVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "TW9uc3RlcldhdmUucHJvdG8aF0dyaWRGaWdodERyb3BJbmZvLnByb3RvIrYB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "ChZHcmlkRmlnaHRFbmNvdW50ZXJJbmZvEhMKC0xGS0JNREhLUEZJGAggASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "EhMKC0dET0VPR01KREFPGAsgASgNEjQKEW1vbnN0ZXJfd2F2ZV9saXN0GA0g";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "AygLMhkuR3JpZEVuY291bnRlck1vbnN0ZXJXYXZlEhMKC0JBR0NCSEZKSU1O";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "GA4gASgNEicKC0xNTEFPUE1EQ0NBGA8gASgLMhIuR3JpZEZpZ2h0RHJvcElu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "Zm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			GridEncounterMonsterWaveReflection.Descriptor,
			GridFightDropInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightEncounterInfo), GridFightEncounterInfo.Parser, new string[5] { "LFKBMDHKPFI", "GDOEOGMJDAO", "MonsterWaveList", "BAGCBHFJIMN", "LMLAOPMDCCA" }, null, null, null, null)
		}));
	}
}
