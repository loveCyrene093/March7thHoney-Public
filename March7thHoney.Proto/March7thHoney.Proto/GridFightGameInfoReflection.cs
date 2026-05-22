using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGameInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGameInfoReflection()
	{
		_003C_003Ey__InlineArray18<string> buffer = default(_003C_003Ey__InlineArray18<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 0) = "ChdHcmlkRmlnaHRHYW1lSW5mby5wcm90bxoeR3JpZEZpZ2h0R2FtZUF1Z21l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 1) = "bnRTeW5jLnByb3RvGhxHcmlkRmlnaHRHYW1lQmFzaWNJbmZvLnByb3RvGhxH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 2) = "cmlkRmlnaHRHYW1lSXRlbXNJbmZvLnByb3RvGhpHcmlkRmlnaHRHYW1lT3Ji";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 3) = "SW5mby5wcm90bxobR3JpZEZpZ2h0R2FtZVNob3BJbmZvLnByb3RvGhtHcmlk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 4) = "RmlnaHRHYW1lVGVhbUluZm8ucHJvdG8aHEdyaWRGaWdodEdhbWVUcmFpdElu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 5) = "Zm8ucHJvdG8aGEdyaWRGaWdodExldmVsSW5mby5wcm90bxoRTEhGRE9QR0VP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 6) = "TUwucHJvdG8i7QMKEUdyaWRGaWdodEdhbWVJbmZvEjIKD2dyaWRfZHJhZnRf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 7) = "aW5mbxgBIAEoCzIXLkdyaWRGaWdodEdhbWVJdGVtc0luZm9IABIxCg9ncmlk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 8) = "X2l0ZW1zX2luZm8YAiABKAsyFi5HcmlkRmlnaHRHYW1lU2hvcEluZm9IABI2";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 9) = "ChRncmlkX3RyYWl0X2dhbWVfaW5mbxgDIAEoCzIWLkdyaWRGaWdodEdhbWVU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 10) = "ZWFtSW5mb0gAEjIKDWdyaWRfb3JiX2luZm8YByABKAsyGS5HcmlkRmlnaHRH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 11) = "YW1lQXVnbWVudFN5bmNIABIrChNncmlkX3RlYW1fZ2FtZV9pbmZvGAggASgL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 12) = "MgwuTEhGRE9QR0VPTUxIABItCg5ncmlkX3Nob3BfaW5mbxgKIAEoCzITLkdy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 13) = "aWRGaWdodExldmVsSW5mb0gAEjQKEWdyaWRfYXVnbWVudF9pbmZvGAwgASgL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 14) = "MhcuR3JpZEZpZ2h0R2FtZVRyYWl0SW5mb0gAEjAKD2dyaWRfbGV2ZWxfaW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 15) = "bxgNIAEoCzIVLkdyaWRGaWdodEdhbWVPcmJJbmZvSAASMgoPZ3JpZF9iYXNp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 16) = "Y19pbmZvGA8gASgLMhcuR3JpZEZpZ2h0R2FtZUJhc2ljSW5mb0gAQg0KC0ZI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 17) = "UEpKSkROS0lPQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray18<string>, string>(in buffer, 18))), new FileDescriptor[9]
		{
			GridFightGameAugmentSyncReflection.Descriptor,
			GridFightGameBasicInfoReflection.Descriptor,
			GridFightGameItemsInfoReflection.Descriptor,
			GridFightGameOrbInfoReflection.Descriptor,
			GridFightGameShopInfoReflection.Descriptor,
			GridFightGameTeamInfoReflection.Descriptor,
			GridFightGameTraitInfoReflection.Descriptor,
			GridFightLevelInfoReflection.Descriptor,
			LHFDOPGEOMLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGameInfo), GridFightGameInfo.Parser, new string[9] { "GridDraftInfo", "GridItemsInfo", "GridTraitGameInfo", "GridOrbInfo", "GridTeamGameInfo", "GridShopInfo", "GridAugmentInfo", "GridLevelInfo", "GridBasicInfo" }, new string[1] { "FHPJJJDNKIO" }, null, null, null)
		}));
	}
}
