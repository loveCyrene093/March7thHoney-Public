using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HKKFBMBEBOC : IMessage<HKKFBMBEBOC>, IMessage, IEquatable<HKKFBMBEBOC>, IDeepCloneable<HKKFBMBEBOC>, IBufferMessage
{
	public enum PANAJBHKAKOOneofCase
	{
		None = 0,
		CGCJLHFLEPN = 4,
		LFPINDFAAHK = 11,
		PJIGHNFHFKD = 15
	}

	private static readonly MessageParser<HKKFBMBEBOC> _parser = new MessageParser<HKKFBMBEBOC>(() => new HKKFBMBEBOC());

	private UnknownFieldSet _unknownFields;

	public const int CGCJLHFLEPNFieldNumber = 4;

	public const int LFPINDFAAHKFieldNumber = 11;

	public const int PJIGHNFHFKDFieldNumber = 15;

	private object pANAJBHKAKO_;

	private PANAJBHKAKOOneofCase pANAJBHKAKOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HKKFBMBEBOC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HKKFBMBEBOCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJFJEMLPKJE CGCJLHFLEPN
	{
		get
		{
			if (pANAJBHKAKOCase_ != PANAJBHKAKOOneofCase.CGCJLHFLEPN)
			{
				return null;
			}
			return (MJFJEMLPKJE)pANAJBHKAKO_;
		}
		set
		{
			pANAJBHKAKO_ = value;
			pANAJBHKAKOCase_ = ((value != null) ? PANAJBHKAKOOneofCase.CGCJLHFLEPN : PANAJBHKAKOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAPPFJLEPLH LFPINDFAAHK
	{
		get
		{
			if (pANAJBHKAKOCase_ != PANAJBHKAKOOneofCase.LFPINDFAAHK)
			{
				return null;
			}
			return (DAPPFJLEPLH)pANAJBHKAKO_;
		}
		set
		{
			pANAJBHKAKO_ = value;
			pANAJBHKAKOCase_ = ((value != null) ? PANAJBHKAKOOneofCase.LFPINDFAAHK : PANAJBHKAKOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDNNGCGIAKO PJIGHNFHFKD
	{
		get
		{
			if (pANAJBHKAKOCase_ != PANAJBHKAKOOneofCase.PJIGHNFHFKD)
			{
				return null;
			}
			return (MDNNGCGIAKO)pANAJBHKAKO_;
		}
		set
		{
			pANAJBHKAKO_ = value;
			pANAJBHKAKOCase_ = ((value != null) ? PANAJBHKAKOOneofCase.PJIGHNFHFKD : PANAJBHKAKOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PANAJBHKAKOOneofCase PANAJBHKAKOCase => pANAJBHKAKOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKKFBMBEBOC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKKFBMBEBOC(HKKFBMBEBOC other)
		: this()
	{
		switch (other.PANAJBHKAKOCase)
		{
		case PANAJBHKAKOOneofCase.CGCJLHFLEPN:
			CGCJLHFLEPN = other.CGCJLHFLEPN.Clone();
			break;
		case PANAJBHKAKOOneofCase.LFPINDFAAHK:
			LFPINDFAAHK = other.LFPINDFAAHK.Clone();
			break;
		case PANAJBHKAKOOneofCase.PJIGHNFHFKD:
			PJIGHNFHFKD = other.PJIGHNFHFKD.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKKFBMBEBOC Clone()
	{
		return new HKKFBMBEBOC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearPANAJBHKAKO()
	{
		pANAJBHKAKOCase_ = PANAJBHKAKOOneofCase.None;
		pANAJBHKAKO_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HKKFBMBEBOC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HKKFBMBEBOC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CGCJLHFLEPN, other.CGCJLHFLEPN))
		{
			return false;
		}
		if (!object.Equals(LFPINDFAAHK, other.LFPINDFAAHK))
		{
			return false;
		}
		if (!object.Equals(PJIGHNFHFKD, other.PJIGHNFHFKD))
		{
			return false;
		}
		if (PANAJBHKAKOCase != other.PANAJBHKAKOCase)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (pANAJBHKAKOCase_ == PANAJBHKAKOOneofCase.CGCJLHFLEPN)
		{
			num ^= CGCJLHFLEPN.GetHashCode();
		}
		if (pANAJBHKAKOCase_ == PANAJBHKAKOOneofCase.LFPINDFAAHK)
		{
			num ^= LFPINDFAAHK.GetHashCode();
		}
		if (pANAJBHKAKOCase_ == PANAJBHKAKOOneofCase.PJIGHNFHFKD)
		{
			num ^= PJIGHNFHFKD.GetHashCode();
		}
		num ^= (int)pANAJBHKAKOCase_;
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (pANAJBHKAKOCase_ == PANAJBHKAKOOneofCase.CGCJLHFLEPN)
		{
			output.WriteRawTag(34);
			output.WriteMessage(CGCJLHFLEPN);
		}
		if (pANAJBHKAKOCase_ == PANAJBHKAKOOneofCase.LFPINDFAAHK)
		{
			output.WriteRawTag(90);
			output.WriteMessage(LFPINDFAAHK);
		}
		if (pANAJBHKAKOCase_ == PANAJBHKAKOOneofCase.PJIGHNFHFKD)
		{
			output.WriteRawTag(122);
			output.WriteMessage(PJIGHNFHFKD);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (pANAJBHKAKOCase_ == PANAJBHKAKOOneofCase.CGCJLHFLEPN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CGCJLHFLEPN);
		}
		if (pANAJBHKAKOCase_ == PANAJBHKAKOOneofCase.LFPINDFAAHK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LFPINDFAAHK);
		}
		if (pANAJBHKAKOCase_ == PANAJBHKAKOOneofCase.PJIGHNFHFKD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PJIGHNFHFKD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HKKFBMBEBOC other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.PANAJBHKAKOCase)
		{
		case PANAJBHKAKOOneofCase.CGCJLHFLEPN:
			if (CGCJLHFLEPN == null)
			{
				CGCJLHFLEPN = new MJFJEMLPKJE();
			}
			CGCJLHFLEPN.MergeFrom(other.CGCJLHFLEPN);
			break;
		case PANAJBHKAKOOneofCase.LFPINDFAAHK:
			if (LFPINDFAAHK == null)
			{
				LFPINDFAAHK = new DAPPFJLEPLH();
			}
			LFPINDFAAHK.MergeFrom(other.LFPINDFAAHK);
			break;
		case PANAJBHKAKOOneofCase.PJIGHNFHFKD:
			if (PJIGHNFHFKD == null)
			{
				PJIGHNFHFKD = new MDNNGCGIAKO();
			}
			PJIGHNFHFKD.MergeFrom(other.PJIGHNFHFKD);
			break;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 34u:
			{
				MJFJEMLPKJE mJFJEMLPKJE = new MJFJEMLPKJE();
				if (pANAJBHKAKOCase_ == PANAJBHKAKOOneofCase.CGCJLHFLEPN)
				{
					mJFJEMLPKJE.MergeFrom(CGCJLHFLEPN);
				}
				input.ReadMessage(mJFJEMLPKJE);
				CGCJLHFLEPN = mJFJEMLPKJE;
				break;
			}
			case 90u:
			{
				DAPPFJLEPLH dAPPFJLEPLH = new DAPPFJLEPLH();
				if (pANAJBHKAKOCase_ == PANAJBHKAKOOneofCase.LFPINDFAAHK)
				{
					dAPPFJLEPLH.MergeFrom(LFPINDFAAHK);
				}
				input.ReadMessage(dAPPFJLEPLH);
				LFPINDFAAHK = dAPPFJLEPLH;
				break;
			}
			case 122u:
			{
				MDNNGCGIAKO mDNNGCGIAKO = new MDNNGCGIAKO();
				if (pANAJBHKAKOCase_ == PANAJBHKAKOOneofCase.PJIGHNFHFKD)
				{
					mDNNGCGIAKO.MergeFrom(PJIGHNFHFKD);
				}
				input.ReadMessage(mDNNGCGIAKO);
				PJIGHNFHFKD = mDNNGCGIAKO;
				break;
			}
			}
		}
	}
}
