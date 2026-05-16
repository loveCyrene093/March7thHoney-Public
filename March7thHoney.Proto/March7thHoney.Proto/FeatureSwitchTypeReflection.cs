using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FeatureSwitchTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FeatureSwitchTypeReflection()
	{
		_003C_003Ey__InlineArray64<string> buffer = default(_003C_003Ey__InlineArray64<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 0) = "ChdGZWF0dXJlU3dpdGNoVHlwZS5wcm90byrzFQoRRmVhdHVyZVN3aXRjaFR5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 1) = "cGUSGwoXSUdDS0lKRERKRkpfQUhNQ0tEQU9MTkUQABIbChdJR0NLSUpEREpG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 2) = "Sl9OS0pGRE5KS0FMSxABEhsKF0lHQ0tJSkRESkZKX0lEUE5HRkpBTkpCEAIS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 3) = "GwoXSUdDS0lKRERKRkpfTUFKS05BUFBDRkEQAxIbChdJR0NLSUpEREpGSl9N";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 4) = "UEdBRU1JUERCSRAEEhsKF0lHQ0tJSkRESkZKX01IQ0VNRUxMR0NMEAUSGwoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 5) = "SUdDS0lKRERKRkpfR0ZHTU5DQ01BS04QBhIbChdJR0NLSUpEREpGSl9JSEhC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 6) = "SURBT0JCTRAHEhsKF0lHQ0tJSkRESkZKX0NMQUlPRkZISERGEAgSGwoXSUdD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 7) = "S0lKRERKRkpfQk5BRUxERkFIT04QCRIbChdJR0NLSUpEREpGSl9FQ0NMRU1H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 8) = "TEpBRxAKEhsKF0lHQ0tJSkRESkZKX0xMRUFBT0FNQ0lEEAsSGwoXSUdDS0lK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 9) = "RERKRkpfTkVMS0FOSk9LQkMQDBIbChdJR0NLSUpEREpGSl9PTUVKTUtFQUdE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 10) = "SRANEhsKF0lHQ0tJSkRESkZKX0JMRUNLTkhISkFQEA4SGwoXSUdDS0lKRERK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 11) = "RkpfTVBFQkhLSU1FTUsQDxIbChdJR0NLSUpEREpGSl9OQUtMRkpCSUlHTBAQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 12) = "EhsKF0lHQ0tJSkRESkZKX09FQUVQRU5OS0dLEBESGwoXSUdDS0lKRERKRkpf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 13) = "R0JNT0VDRUJJQUkQEhIbChdJR0NLSUpEREpGSl9OQ01PTU5PRklHRhATEhsK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 14) = "F0lHQ0tJSkRESkZKX01QT09PSkZOUEhOEBQSGwoXSUdDS0lKRERKRkpfSUtG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 15) = "UEpPTklIQUMQFRIbChdJR0NLSUpEREpGSl9NQktHRk1NS0RHSBAWEhsKF0lH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 16) = "Q0tJSkRESkZKX01OTUlGTkxGUEhKEBcSGwoXSUdDS0lKRERKRkpfS0ZLS0RM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 17) = "SkNBQ0sQGBIbChdJR0NLSUpEREpGSl9NREpLRkRIR1BJTxAZEhsKF0lHQ0tJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 18) = "SkRESkZKX0ZPT0FEUE1ISExOEBoSGwoXSUdDS0lKRERKRkpfUFBBQUdPQUlH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 19) = "QU4QGxIbChdJR0NLSUpEREpGSl9KTUZBSUlHQURQSBAcEhsKF0lHQ0tJSkRE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 20) = "SkZKX0JFS0lCSUZCRkpKEB0SGwoXSUdDS0lKRERKRkpfRkFFRUlJUElFRkwQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 21) = "HhIbChdJR0NLSUpEREpGSl9ETU9GTkhDRkxMSRAgEhsKF0lHQ0tJSkRESkZK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 22) = "X0NQRUFCREFKS0lKECESGwoXSUdDS0lKRERKRkpfSk1BSkxLRENLREcQIhIb";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 23) = "ChdJR0NLSUpEREpGSl9GQ0tHS0ZIR0FKQhAjEhsKF0lHQ0tJSkRESkZKX0xD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 24) = "T0NJQ0xHRENMECQSGwoXSUdDS0lKRERKRkpfR0xIRU5HRExIREIQJRIbChdJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 25) = "R0NLSUpEREpGSl9QRkpISEZPTERNSBAmEhsKF0lHQ0tJSkRESkZKX0VNSEJB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 26) = "QU5MS0FNECcSGwoXSUdDS0lKRERKRkpfSE1ET0JCRk5NUEsQKBIbChdJR0NL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 27) = "SUpEREpGSl9EQ0hLTUdJT0RLQxApEhsKF0lHQ0tJSkRESkZKX0tGREdJTk5H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 28) = "QktQECoSGwoXSUdDS0lKRERKRkpfSUpJSk9DQ05HR0kQKxIbChdJR0NLSUpE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 29) = "REpGSl9OR0RPSUdIRVBJRBAsEhsKF0lHQ0tJSkRESkZKX0dFTE5ERkFLR0tM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 30) = "EC0SGwoXSUdDS0lKRERKRkpfQVBJTEZDQ09KSk8QLhIbChdJR0NLSUpEREpG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 31) = "Sl9KRUhBRE9NQ0JEThAvEhsKF0lHQ0tJSkRESkZKX0xJSktNQkpFRktMEDAS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 32) = "GwoXSUdDS0lKRERKRkpfTk9JT0pKREdOQ0IQMRIbChdJR0NLSUpEREpGSl9E";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 33) = "RkVOR0NDRkdFQxAyEhsKF0lHQ0tJSkRESkZKX0VJRkFGTEhNRUNLEDMSGwoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 34) = "SUdDS0lKRERKRkpfTEJLQkNNTktKR1AQNBIbChdJR0NLSUpEREpGSl9DT0NG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 35) = "QUJJTkVOQhA1EhsKF0lHQ0tJSkRESkZKX1BBR0hLQ0VOREZIEDYSGwoXSUdD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 36) = "S0lKRERKRkpfUEhOTUtGUE5BSUkQNxIbChdJR0NLSUpEREpGSl9LRUFNRUZN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 37) = "RU5EQxA4EhsKF0lHQ0tJSkRESkZKX0NMREhPREZBS0xFEDoSGwoXSUdDS0lK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 38) = "RERKRkpfQ0FMTURIRUxJSkcQOxIbChdJR0NLSUpEREpGSl9BR0lISkFMSE1G";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 39) = "TBA8EhsKF0lHQ0tJSkRESkZKX0lDTlBQSE5QQ0lQED0SGwoXSUdDS0lKRERK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 40) = "RkpfTU1PS0ZFSkdIRVAQPhIbChdJR0NLSUpEREpGSl9LT0JGTEJNSktIRxA/";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 41) = "EhsKF0lHQ0tJSkRESkZKX0JOTUtJTkFQSkxLEEASGwoXSUdDS0lKRERKRkpf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 42) = "QkNMQk5GSUJFRk4QQRIbChdJR0NLSUpEREpGSl9QQ0RLRERBR0NIQhBCEhsK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 43) = "F0lHQ0tJSkRESkZKX0JNSkRMS0VQQkZLEEMSGwoXSUdDS0lKRERKRkpfQkhH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 44) = "R0pHSkJLRFAQRBIbChdJR0NLSUpEREpGSl9QR09IREZOTUZKQRBFEhsKF0lH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 45) = "Q0tJSkRESkZKX0pLQUhORE5QQ0xIEEYSGwoXSUdDS0lKRERKRkpfTEZEREhJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 46) = "QUZJRUwQRxIbChdJR0NLSUpEREpGSl9PSE1HSUNORklLTRBIEhsKF0lHQ0tJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 47) = "SkRESkZKX0xNTEpETUpIUERLEEkSGwoXSUdDS0lKRERKRkpfS0pPREFQSk9O";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 48) = "SEUQShIbChdJR0NLSUpEREpGSl9GRU5PTktNRUlMTxBLEhsKF0lHQ0tJSkRE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 49) = "SkZKX0VNQ0JBSlBDRE1DEEwSGwoXSUdDS0lKRERKRkpfRUFCQkFLSUNPT0MQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 50) = "TRIbChdJR0NLSUpEREpGSl9GQUVITklHS05QRBBOEhsKF0lHQ0tJSkRESkZK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 51) = "X0tKREFBTUJMRk5OEE8SGwoXSUdDS0lKRERKRkpfSEpNRFBETklPQ0IQUBIb";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 52) = "ChdJR0NLSUpEREpGSl9OT0dPQUtLSU1CRRBREhsKF0lHQ0tJSkRESkZKX0lL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 53) = "TUNISUVFTEVHEFISGwoXSUdDS0lKRERKRkpfS05NR0pJSEZHT0sQUxIbChdJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 54) = "R0NLSUpEREpGSl9CQUJGRk1PQkdBTRBUEhsKF0lHQ0tJSkRESkZKX0ZPTk5E";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 55) = "SlBMQ0lGEFUSGwoXSUdDS0lKRERKRkpfT0lBUE5FT0JKR00QVhIbChdJR0NL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 56) = "SUpEREpGSl9CTUhOTUdCTkFBRBBXEhsKF0lHQ0tJSkRESkZKX01QTk9KTUhF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 57) = "QVBCEFgSGwoXSUdDS0lKRERKRkpfT0lIQ0NOREtKQ0UQWRIbChdJR0NLSUpE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 58) = "REpGSl9ITktFRkVQQUdKRxBaEhsKF0lHQ0tJSkRESkZKX09FQklITkFBS0hF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 59) = "EFsSGwoXSUdDS0lKRERKRkpfTk5MQ0tJT0ZFTUcQXBIbChdJR0NLSUpEREpG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 60) = "Sl9EUE1DQk5CTEdDSRBdEhsKF0lHQ0tJSkRESkZKX0lHSEdMSkRLQ0ZQEF4S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 61) = "GwoXSUdDS0lKRERKRkpfQUpQSEtIRE9CTUEQXxIbChdJR0NLSUpEREpGSl9Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 62) = "REZFQ0xHR1BQRRBgEhsKF0lHQ0tJSkRESkZKX0tMUEhMS0VPQ0hBEGFCFqoC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray64<string>, string>(ref buffer, 63) = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray64<string>, string>(in buffer, 64))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FeatureSwitchType) }, null, null));
	}
}
