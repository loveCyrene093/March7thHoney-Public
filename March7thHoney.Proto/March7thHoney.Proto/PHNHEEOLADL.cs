using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PHNHEEOLADL : IMessage<PHNHEEOLADL>, IMessage, IEquatable<PHNHEEOLADL>, IDeepCloneable<PHNHEEOLADL>, IBufferMessage
{
	private static readonly MessageParser<PHNHEEOLADL> _parser = new MessageParser<PHNHEEOLADL>(() => new PHNHEEOLADL());

	private UnknownFieldSet _unknownFields;

	public const int NAKKOHEMJBLFieldNumber = 2;

	private KIEEFAOCOCC nAKKOHEMJBL_;

	public const int BHEEDAFLEOJFieldNumber = 3;

	private KMADNGJNOOB bHEEDAFLEOJ_;

	public const int HCPAHPCOEKKFieldNumber = 9;

	private BattleRecordType hCPAHPCOEKK_;

	public const int KIIONJBDKNJFieldNumber = 14;

	private FriendGridFightRecord kIIONJBDKNJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PHNHEEOLADL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PHNHEEOLADLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIEEFAOCOCC NAKKOHEMJBL
	{
		get
		{
			return nAKKOHEMJBL_;
		}
		set
		{
			nAKKOHEMJBL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMADNGJNOOB BHEEDAFLEOJ
	{
		get
		{
			return bHEEDAFLEOJ_;
		}
		set
		{
			bHEEDAFLEOJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleRecordType HCPAHPCOEKK
	{
		get
		{
			return hCPAHPCOEKK_;
		}
		set
		{
			hCPAHPCOEKK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendGridFightRecord KIIONJBDKNJ
	{
		get
		{
			return kIIONJBDKNJ_;
		}
		set
		{
			kIIONJBDKNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHNHEEOLADL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHNHEEOLADL(PHNHEEOLADL other)
		: this()
	{
		nAKKOHEMJBL_ = ((other.nAKKOHEMJBL_ != null) ? other.nAKKOHEMJBL_.Clone() : null);
		bHEEDAFLEOJ_ = ((other.bHEEDAFLEOJ_ != null) ? other.bHEEDAFLEOJ_.Clone() : null);
		hCPAHPCOEKK_ = other.hCPAHPCOEKK_;
		kIIONJBDKNJ_ = ((other.kIIONJBDKNJ_ != null) ? other.kIIONJBDKNJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHNHEEOLADL Clone()
	{
		return new PHNHEEOLADL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PHNHEEOLADL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PHNHEEOLADL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NAKKOHEMJBL, other.NAKKOHEMJBL))
		{
			return false;
		}
		if (!object.Equals(BHEEDAFLEOJ, other.BHEEDAFLEOJ))
		{
			return false;
		}
		if (HCPAHPCOEKK != other.HCPAHPCOEKK)
		{
			return false;
		}
		if (!object.Equals(KIIONJBDKNJ, other.KIIONJBDKNJ))
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
		if (nAKKOHEMJBL_ != null)
		{
			num ^= NAKKOHEMJBL.GetHashCode();
		}
		if (bHEEDAFLEOJ_ != null)
		{
			num ^= BHEEDAFLEOJ.GetHashCode();
		}
		if (HCPAHPCOEKK != BattleRecordType.BattleRecordNone)
		{
			num ^= HCPAHPCOEKK.GetHashCode();
		}
		if (kIIONJBDKNJ_ != null)
		{
			num ^= KIIONJBDKNJ.GetHashCode();
		}
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
		if (nAKKOHEMJBL_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(NAKKOHEMJBL);
		}
		if (bHEEDAFLEOJ_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(BHEEDAFLEOJ);
		}
		if (HCPAHPCOEKK != BattleRecordType.BattleRecordNone)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)HCPAHPCOEKK);
		}
		if (kIIONJBDKNJ_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(KIIONJBDKNJ);
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
		if (nAKKOHEMJBL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NAKKOHEMJBL);
		}
		if (bHEEDAFLEOJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BHEEDAFLEOJ);
		}
		if (HCPAHPCOEKK != BattleRecordType.BattleRecordNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HCPAHPCOEKK);
		}
		if (kIIONJBDKNJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KIIONJBDKNJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PHNHEEOLADL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nAKKOHEMJBL_ != null)
		{
			if (nAKKOHEMJBL_ == null)
			{
				NAKKOHEMJBL = new KIEEFAOCOCC();
			}
			NAKKOHEMJBL.MergeFrom(other.NAKKOHEMJBL);
		}
		if (other.bHEEDAFLEOJ_ != null)
		{
			if (bHEEDAFLEOJ_ == null)
			{
				BHEEDAFLEOJ = new KMADNGJNOOB();
			}
			BHEEDAFLEOJ.MergeFrom(other.BHEEDAFLEOJ);
		}
		if (other.HCPAHPCOEKK != BattleRecordType.BattleRecordNone)
		{
			HCPAHPCOEKK = other.HCPAHPCOEKK;
		}
		if (other.kIIONJBDKNJ_ != null)
		{
			if (kIIONJBDKNJ_ == null)
			{
				KIIONJBDKNJ = new FriendGridFightRecord();
			}
			KIIONJBDKNJ.MergeFrom(other.KIIONJBDKNJ);
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
			case 18u:
				if (nAKKOHEMJBL_ == null)
				{
					NAKKOHEMJBL = new KIEEFAOCOCC();
				}
				input.ReadMessage(NAKKOHEMJBL);
				break;
			case 26u:
				if (bHEEDAFLEOJ_ == null)
				{
					BHEEDAFLEOJ = new KMADNGJNOOB();
				}
				input.ReadMessage(BHEEDAFLEOJ);
				break;
			case 72u:
				HCPAHPCOEKK = (BattleRecordType)input.ReadEnum();
				break;
			case 114u:
				if (kIIONJBDKNJ_ == null)
				{
					KIIONJBDKNJ = new FriendGridFightRecord();
				}
				input.ReadMessage(KIIONJBDKNJ);
				break;
			}
		}
	}
}
