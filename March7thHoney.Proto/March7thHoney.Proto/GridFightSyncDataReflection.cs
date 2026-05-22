using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSyncDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSyncDataReflection()
	{
		_003C_003Ey__InlineArray76<string> buffer = default(_003C_003Ey__InlineArray76<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 0) = "ChdHcmlkRmlnaHRTeW5jRGF0YS5wcm90bxoRQ0tDS0lESE1NRUcucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 1) = "EUNMT0VQUEJDS0dGLnByb3RvGhFDTUNKTktQS0JFTS5wcm90bxoRRElCSkdB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 2) = "S09DTE8ucHJvdG8aHEdyaWRGaWdodERhbWFnZVN0dEluZm8ucHJvdG8aIkdy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 3) = "aWRGaWdodEVsaXRlQnJhbmNoU3luY0luZm8ucHJvdG8aHUdyaWRGaWdodEdh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 4) = "bWVBdWdtZW50QWRkLnByb3RvGiBHcmlkRmlnaHRHYW1lQXVnbWVudFVwZGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 5) = "ZS5wcm90bxobR3JpZEZpZ2h0R2FtZUl0ZW1JbmZvLnByb3RvGh9HcmlkRmln";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 6) = "aHRHYW1lSXRlbVN5bmNJbmZvLnByb3RvGhxHcmlkRmlnaHRMZXZlbFN5bmNJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 7) = "bmZvLnByb3RvGh9HcmlkRmlnaHRMaW5ldXBIcFN5bmNJbmZvLnByb3RvGhdH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 8) = "cmlkRmlnaHRMb2NrSW5mby5wcm90bxoXR3JpZEZpZ2h0TG9ja1R5cGUucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 9) = "dG8aGkdyaWRGaWdodE9yYlN5bmNJbmZvLnByb3RvGhxHcmlkRmlnaHRQZW5k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 10) = "aW5nQWN0aW9uLnByb3RvGiJHcmlkRmlnaHRQbGF5ZXJMZXZlbFN5bmNJbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 11) = "LnByb3RvGiVHcmlkRmlnaHRQb3J0YWxTZXJ2ZXJEYXRhVXBkYXRlLnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 12) = "GiBHcmlkRmlnaHRTZWN0aW9uUmVjb3JkSW5mby5wcm90bxobR3JpZEZpZ2h0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 13) = "U2hvcFN5bmNJbmZvLnByb3RvGhxHcmlkRmlnaHRUcmFpdFN5bmNJbmZvLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 14) = "b3RvGiFHcmlkRmlnaHRUcmFpdFRyYWNrU3luY0luZm8ucHJvdG8aH0dyaWRG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 15) = "aWdodFR1dG9yaWFsU3luY0luZm8ucHJvdG8aG0dyaWRHYW1lRm9yZ2VJdGVt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 16) = "SW5mby5wcm90bxoVR3JpZEdhbWVOcGNJbmZvLnByb3RvGhVHcmlkR2FtZU9y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 17) = "YkluZm8ucHJvdG8aFkdyaWRHYW1lUm9sZUluZm8ucHJvdG8aEUpQQkNLQ0RF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 18) = "R09NLnByb3RvGiBSb2xlVHJhY2tFcXVpcG1lbnRTeW5jSW5mby5wcm90byLg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 19) = "EwoRR3JpZEZpZ2h0U3luY0RhdGESFQoLQ0pFTUtDT0NFQ0cYEyABKA1IABIe";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 20) = "ChRyZW1vdmVfb3JiX3VuaXF1ZV9pZBg1IAEoDUgAEkAKGWVxdWlwbWVudF90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 21) = "cmFja19zeW5jX2luZm8YOSABKAsyGy5Sb2xlVHJhY2tFcXVpcG1lbnRTeW5j";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 22) = "SW5mb0gAEh0KE21heF9iYXR0bGVfcm9sZV9udW0YSCABKA1IABIkCgtDRk5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 23) = "R05NUE5EThiMASABKAsyDC5DTUNKTktQS0JFTUgAEisKDWFkZF9yb2xlX2lu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 24) = "Zm8Y0gEgASgLMhEuR3JpZEdhbWVSb2xlSW5mb0gAEikKDGFkZF9ucGNfaW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 25) = "bxjmASABKAsyEC5HcmlkR2FtZU5wY0luZm9IABIWCgtITEZCQkFOTUpEShiB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 26) = "AiABKA1IABIzCg90cmFpdF9zeW5jX2luZm8YggIgASgLMhcuR3JpZEZpZ2h0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 27) = "VHJhaXRTeW5jSW5mb0gAEkYKGXBvcnRhbF9zZXJ2ZXJfZGF0YV91cGRhdGUY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 28) = "jwIgASgLMiAuR3JpZEZpZ2h0UG9ydGFsU2VydmVyRGF0YVVwZGF0ZUgAEjwK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 29) = "FXVwZGF0ZV9nYW1lX2l0ZW1faW5mbxicAiABKAsyGi5HcmlkRmlnaHRHYW1l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 30) = "SXRlbVN5bmNJbmZvSAASMQoOYWRkX2ZvcmdlX2luZm8YggMgASgLMhYuR3Jp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 31) = "ZEdhbWVGb3JnZUl0ZW1JbmZvSAASLgoQdXBkYXRlX3JvbGVfaW5mbxiJAyAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 32) = "KAsyES5HcmlkR2FtZVJvbGVJbmZvSAASFgoLQUpJTU9BTUdDSUkYpwMgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 33) = "SAASPgoaZ3JpZF9maWdodF9kYW1hZ2Vfc3R0X2luZm8YtQMgASgLMhcuR3Jp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 34) = "ZEZpZ2h0RGFtYWdlU3R0SW5mb0gAEiMKGGdyaWRfZmlnaHRfY29tYm9fd2lu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 35) = "X251bRjNAyABKA1IABItCg5zeW5jX2xvY2tfaW5mbxjUAyABKAsyEi5Hcmlk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 36) = "RmlnaHRMb2NrSW5mb0gAEhYKC0dEUEJKREhHRkxCGIQEIAEoDUgAEiMKGHJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 37) = "bW92ZV9hdWdtZW50X3VuaXF1ZV9pZBiLBCABKA1IABImChtncmlkX2ZpZ2h0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 38) = "X21heF9hdmF0YXJfY291bnQYpAQgASgNSAASNgoRYXVnbWVudF9zeW5jX2lu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 39) = "Zm8YrgQgASgLMhguR3JpZEZpZ2h0R2FtZUF1Z21lbnRBZGRIABIkChlmaW5p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 40) = "c2hfcGVuZGluZ19hY3Rpb25fcG9zGL0EIAEoDUgAEjIKDnBlbmRpbmdfYWN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 41) = "aW9uGJIGIAEoCzIXLkdyaWRGaWdodFBlbmRpbmdBY3Rpb25IABIoCgtQT0lQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 42) = "R05IT05NQRieBiABKAsyEC5HcmlkR2FtZU9yYkluZm9IABIzCg9sZXZlbF9z";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 43) = "eW5jX2luZm8YxgYgASgLMhcuR3JpZEZpZ2h0TGV2ZWxTeW5jSW5mb0gAEicK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 44) = "HGdyaWRfZmlnaHRfbWF4X2ludGVyZXN0X2dvbGQY1wYgASgNSAASNAoRdXBk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 45) = "YXRlX2ZvcmdlX2luZm8YjQcgASgLMhYuR3JpZEdhbWVGb3JnZUl0ZW1JbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 46) = "SAASNgoMcGxheWVyX2xldmVsGOMHIAEoCzIdLkdyaWRGaWdodFBsYXllckxl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 47) = "dmVsU3luY0luZm9IABIWCgtLQUNISkhETU5MTRjkByABKA1IABIkCgtKSUZL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 48) = "T0hMTkhBSxj4ByABKAsyDC5DS0NLSURITU1FR0gAEj8KGGdyaWRfZmlnaHRf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 49) = "dHV0b3JpYWxfc3luYxj+ByABKAsyGi5HcmlkRmlnaHRUdXRvcmlhbFN5bmNJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 50) = "bmZvSAASKQoeZ3JpZF9maWdodF9vZmZfZmllbGRfbWF4X2NvdW50GKYIIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 51) = "DUgAEigKCWxvY2tfdHlwZRjYCCABKA4yEi5HcmlkRmlnaHRMb2NrVHlwZUgA";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 52) = "EjwKFXJlbW92ZV9nYW1lX2l0ZW1faW5mbxjpCCABKAsyGi5HcmlkRmlnaHRH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 53) = "YW1lSXRlbVN5bmNJbmZvSAASOwoUZ3JpZF9maWdodF9saW5ldXBfaHAY8ggg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 54) = "ASgLMhouR3JpZEZpZ2h0TGluZXVwSHBTeW5jSW5mb0gAEkAKGHNlY3Rpb25f";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 55) = "cmVjb3JkX3N5bmNfaW5mbxiDCSABKAsyGy5HcmlkRmlnaHRTZWN0aW9uUmVj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 56) = "b3JkSW5mb0gAEkEKHmdyaWRfZmlnaHRfc3luY19nYW1lX2l0ZW1faW5mbxie";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 57) = "CSABKAsyFi5HcmlkRmlnaHRHYW1lSXRlbUluZm9IABIiChdncmlkX2ZpZ2h0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 58) = "X2J1eV9leHBfY29zdBjZCSABKA1IABI+ChV0cmFpdF90cmFja19zeW5jX2lu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 59) = "Zm8YwQogASgLMhwuR3JpZEZpZ2h0VHJhaXRUcmFja1N5bmNJbmZvSAASJAoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 60) = "QkFPREhQQ09KTEgYpAsgASgLMgwuQ0tDS0lESE1NRUdIABI5ChJhZGRfZ2Ft";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 61) = "ZV9pdGVtX2luZm8Y6QsgASgLMhouR3JpZEZpZ2h0R2FtZUl0ZW1TeW5jSW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 62) = "b0gAEiwKD3VwZGF0ZV9ucGNfaW5mbxjtCyABKAsyEC5HcmlkR2FtZU5wY0lu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 63) = "Zm9IABIhChZyZW1vdmVfZm9yZ2VfdW5pcXVlX2lkGJwMIAEoDUgAEiEKFnJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 64) = "bW92ZV90cmFpdF9lZmZlY3RfaWQYyAwgASgNSAASJAoLR01KTEpESkRJR00Y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 65) = "3AwgASgLMgwuSlBCQ0tDREVHT01IABIWCgtGSEhIRUJMTU9CTBj8DCABKA1I";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 66) = "ABIgChVyZW1vdmVfcm9sZV91bmlxdWVfaWQYqA0gASgNSAASQAoWZWxpdGVf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 67) = "YnJhbmNoX3N5bmNfaW5mbxjKDSABKAsyHS5HcmlkRmlnaHRFbGl0ZUJyYW5j";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 68) = "aFN5bmNJbmZvSAASJAoLSUJDRVBDRkZNT0wYlQ4gASgLMgwuRElCSkdBS09D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 69) = "TE9IABIkCgtQR1BLUE1PSUFJTBjCDiABKAsyDC5DTE9FUFBCQ0tHRkgAEi8K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 70) = "DW9yYl9zeW5jX2luZm8Y5w4gASgLMhUuR3JpZEZpZ2h0T3JiU3luY0luZm9I";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 71) = "ABIVCgppdGVtX3ZhbHVlGJcPIAEoDUgAEkAKGGdyaWRfZ2FtZV9hdWdtZW50";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 72) = "X3VwZGF0ZRjKDyABKAsyGy5HcmlkRmlnaHRHYW1lQXVnbWVudFVwZGF0ZUgA";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 73) = "EjEKDnNob3Bfc3luY19pbmZvGPcPIAEoCzIWLkdyaWRGaWdodFNob3BTeW5j";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 74) = "SW5mb0gAEh8KFHJlbW92ZV9ucGNfdW5pcXVlX2lkGPgPIAEoDUgAQg0KC0tD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray76<string>, string>(ref buffer, 75) = "T0NDR0VPRUNPQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray76<string>, string>(in buffer, 76))), new FileDescriptor[29]
		{
			CKCKIDHMMEGReflection.Descriptor,
			CLOEPPBCKGFReflection.Descriptor,
			CMCJNKPKBEMReflection.Descriptor,
			DIBJGAKOCLOReflection.Descriptor,
			GridFightDamageSttInfoReflection.Descriptor,
			GridFightEliteBranchSyncInfoReflection.Descriptor,
			GridFightGameAugmentAddReflection.Descriptor,
			GridFightGameAugmentUpdateReflection.Descriptor,
			GridFightGameItemInfoReflection.Descriptor,
			GridFightGameItemSyncInfoReflection.Descriptor,
			GridFightLevelSyncInfoReflection.Descriptor,
			GridFightLineupHpSyncInfoReflection.Descriptor,
			GridFightLockInfoReflection.Descriptor,
			GridFightLockTypeReflection.Descriptor,
			GridFightOrbSyncInfoReflection.Descriptor,
			GridFightPendingActionReflection.Descriptor,
			GridFightPlayerLevelSyncInfoReflection.Descriptor,
			GridFightPortalServerDataUpdateReflection.Descriptor,
			GridFightSectionRecordInfoReflection.Descriptor,
			GridFightShopSyncInfoReflection.Descriptor,
			GridFightTraitSyncInfoReflection.Descriptor,
			GridFightTraitTrackSyncInfoReflection.Descriptor,
			GridFightTutorialSyncInfoReflection.Descriptor,
			GridGameForgeItemInfoReflection.Descriptor,
			GridGameNpcInfoReflection.Descriptor,
			GridGameOrbInfoReflection.Descriptor,
			GridGameRoleInfoReflection.Descriptor,
			JPBCKCDEGOMReflection.Descriptor,
			RoleTrackEquipmentSyncInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSyncData), GridFightSyncData.Parser, new string[55]
			{
				"CJEMKCOCECG", "RemoveOrbUniqueId", "EquipmentTrackSyncInfo", "MaxBattleRoleNum", "CFNPGNMPNDN", "AddRoleInfo", "AddNpcInfo", "HLFBBANMJDJ", "TraitSyncInfo", "PortalServerDataUpdate",
				"UpdateGameItemInfo", "AddForgeInfo", "UpdateRoleInfo", "AJIMOAMGCII", "GridFightDamageSttInfo", "GridFightComboWinNum", "SyncLockInfo", "GDPBJDHGFLB", "RemoveAugmentUniqueId", "GridFightMaxAvatarCount",
				"AugmentSyncInfo", "FinishPendingActionPos", "PendingAction", "POIPGNHONMA", "LevelSyncInfo", "GridFightMaxInterestGold", "UpdateForgeInfo", "PlayerLevel", "KACHJHDMNLM", "JIFKOHLNHAK",
				"GridFightTutorialSync", "GridFightOffFieldMaxCount", "LockType", "RemoveGameItemInfo", "GridFightLineupHp", "SectionRecordSyncInfo", "GridFightSyncGameItemInfo", "GridFightBuyExpCost", "TraitTrackSyncInfo", "BAODHPCOJLH",
				"AddGameItemInfo", "UpdateNpcInfo", "RemoveForgeUniqueId", "RemoveTraitEffectId", "GMJLJDJDIGM", "FHHHEBLMOBL", "RemoveRoleUniqueId", "EliteBranchSyncInfo", "IBCEPCFFMOL", "PGPKPMOIAIL",
				"OrbSyncInfo", "ItemValue", "GridGameAugmentUpdate", "ShopSyncInfo", "RemoveNpcUniqueId"
			}, new string[1] { "KCOCCGEOECO" }, null, null, null)
		}));
	}
}
