using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JAMLHOHBIGBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JAMLHOHBIGBReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "ChFKQU1MSE9IQklHQi5wcm90bxoRRUNLSURMSUZBRkcucHJvdG8aEUVORU5O";
		buffer[1] = "TU5FT0dLLnByb3RvGhFITUpKTEFETE9ISC5wcm90bxoRTVBHSU9IRE1GQ0cu";
		buffer[2] = "cHJvdG8aEVBCS1BQRUFQQk9NLnByb3RvIukCCgtKQU1MSE9IQklHQhIfCgli";
		buffer[3] = "dWZmX2xpc3QYASADKAsyDC5ITUpKTEFETE9ISBIdCgdvcF9saXN0GAIgAygL";
		buffer[4] = "MgwuRU5FTk5NTkVPR0sSEwoLUEZKQUpLQkVQREMYAyABKA0SEwoLZW5lcmd5";
		buffer[5] = "X2luZm8YBCABKA0SEwoLSUlQREFJRUJJSEEYBSABKA0SEAoIc2NvcmVfaWQY";
		buffer[6] = "BiABKA0SDgoGY3VyX2hwGAcgASgNEh8KCWl0ZW1fbGlzdBgIIAMoCzIMLk1Q";
		buffer[7] = "R0lPSERNRkNHEiEKC0RFTUdCSkNKR05PGAkgASgOMgwuUEJLUFBFQVBCT00S";
		buffer[8] = "EwoLQkFFUE5BQUJBRE4YCiABKA0SIQoLTUhGSE9EREJPUE0YCyABKAsyDC5F";
		buffer[9] = "Q0tJRExJRkFGRxITCgtLUENLTE5DUFBBShgMIAEoDRITCgtJTkZFUE5JRVBO";
		buffer[10] = "RBgNIAMoDRITCgtCTUFKTUxPRkNLSBgOIAEoDUIWqgITTWFyY2g3dGhIb25l";
		buffer[11] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[5]
		{
			ECKIDLIFAFGReflection.Descriptor,
			ENENNMNEOGKReflection.Descriptor,
			HMJJLADLOHHReflection.Descriptor,
			MPGIOHDMFCGReflection.Descriptor,
			PBKPPEAPBOMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JAMLHOHBIGB), JAMLHOHBIGB.Parser, new string[14]
			{
				"BuffList", "OpList", "PFJAJKBEPDC", "EnergyInfo", "IIPDAIEBIHA", "ScoreId", "CurHp", "ItemList", "DEMGBJCJGNO", "BAEPNAABADN",
				"MHFHODDBOPM", "KPCKLNCPPAJ", "INFEPNIEPND", "BMAJMLOFCKH"
			}, null, null, null, null)
		}));
	}
}
