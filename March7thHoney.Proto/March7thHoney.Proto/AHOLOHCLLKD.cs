using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AHOLOHCLLKD : IMessage<AHOLOHCLLKD>, IMessage, IEquatable<AHOLOHCLLKD>, IDeepCloneable<AHOLOHCLLKD>, IBufferMessage
{
	private static readonly MessageParser<AHOLOHCLLKD> _parser = new MessageParser<AHOLOHCLLKD>(() => new AHOLOHCLLKD());

	private UnknownFieldSet _unknownFields;

	public const int ItemValueFieldNumber = 1;

	private PGJNBNANDEE itemValue_;

	public const int EIENKJFFFJGFieldNumber = 3;

	private IOLJBGLNLCJ eIENKJFFFJG_;

	public const int BasicInfoFieldNumber = 4;

	private KGABJENCFDC basicInfo_;

	public const int HKKIJABGCNAFieldNumber = 5;

	private NKLOBAKEMII hKKIJABGCNA_;

	public const int LevelFieldNumber = 9;

	private ACCBPEAJFEO level_;

	public const int LineupFieldNumber = 11;

	private MICOMIBPIOA lineup_;

	public const int OFAOIMCDHPNFieldNumber = 12;

	private OJAEEMPKCBN oFAOIMCDHPN_;

	public const int MMAOONPAPDPFieldNumber = 14;

	private KKFANGIJAOF mMAOONPAPDP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AHOLOHCLLKD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AHOLOHCLLKDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGJNBNANDEE ItemValue
	{
		get
		{
			return itemValue_;
		}
		set
		{
			itemValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IOLJBGLNLCJ EIENKJFFFJG
	{
		get
		{
			return eIENKJFFFJG_;
		}
		set
		{
			eIENKJFFFJG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGABJENCFDC BasicInfo
	{
		get
		{
			return basicInfo_;
		}
		set
		{
			basicInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NKLOBAKEMII HKKIJABGCNA
	{
		get
		{
			return hKKIJABGCNA_;
		}
		set
		{
			hKKIJABGCNA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACCBPEAJFEO Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MICOMIBPIOA Lineup
	{
		get
		{
			return lineup_;
		}
		set
		{
			lineup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJAEEMPKCBN OFAOIMCDHPN
	{
		get
		{
			return oFAOIMCDHPN_;
		}
		set
		{
			oFAOIMCDHPN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKFANGIJAOF MMAOONPAPDP
	{
		get
		{
			return mMAOONPAPDP_;
		}
		set
		{
			mMAOONPAPDP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHOLOHCLLKD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHOLOHCLLKD(AHOLOHCLLKD other)
		: this()
	{
		itemValue_ = ((other.itemValue_ != null) ? other.itemValue_.Clone() : null);
		eIENKJFFFJG_ = ((other.eIENKJFFFJG_ != null) ? other.eIENKJFFFJG_.Clone() : null);
		basicInfo_ = ((other.basicInfo_ != null) ? other.basicInfo_.Clone() : null);
		hKKIJABGCNA_ = ((other.hKKIJABGCNA_ != null) ? other.hKKIJABGCNA_.Clone() : null);
		level_ = ((other.level_ != null) ? other.level_.Clone() : null);
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		oFAOIMCDHPN_ = ((other.oFAOIMCDHPN_ != null) ? other.oFAOIMCDHPN_.Clone() : null);
		mMAOONPAPDP_ = ((other.mMAOONPAPDP_ != null) ? other.mMAOONPAPDP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHOLOHCLLKD Clone()
	{
		return new AHOLOHCLLKD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AHOLOHCLLKD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AHOLOHCLLKD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ItemValue, other.ItemValue))
		{
			return false;
		}
		if (!object.Equals(EIENKJFFFJG, other.EIENKJFFFJG))
		{
			return false;
		}
		if (!object.Equals(BasicInfo, other.BasicInfo))
		{
			return false;
		}
		if (!object.Equals(HKKIJABGCNA, other.HKKIJABGCNA))
		{
			return false;
		}
		if (!object.Equals(Level, other.Level))
		{
			return false;
		}
		if (!object.Equals(Lineup, other.Lineup))
		{
			return false;
		}
		if (!object.Equals(OFAOIMCDHPN, other.OFAOIMCDHPN))
		{
			return false;
		}
		if (!object.Equals(MMAOONPAPDP, other.MMAOONPAPDP))
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
		if (itemValue_ != null)
		{
			num ^= ItemValue.GetHashCode();
		}
		if (eIENKJFFFJG_ != null)
		{
			num ^= EIENKJFFFJG.GetHashCode();
		}
		if (basicInfo_ != null)
		{
			num ^= BasicInfo.GetHashCode();
		}
		if (hKKIJABGCNA_ != null)
		{
			num ^= HKKIJABGCNA.GetHashCode();
		}
		if (level_ != null)
		{
			num ^= Level.GetHashCode();
		}
		if (lineup_ != null)
		{
			num ^= Lineup.GetHashCode();
		}
		if (oFAOIMCDHPN_ != null)
		{
			num ^= OFAOIMCDHPN.GetHashCode();
		}
		if (mMAOONPAPDP_ != null)
		{
			num ^= MMAOONPAPDP.GetHashCode();
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
		if (itemValue_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ItemValue);
		}
		if (eIENKJFFFJG_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(EIENKJFFFJG);
		}
		if (basicInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(BasicInfo);
		}
		if (hKKIJABGCNA_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(HKKIJABGCNA);
		}
		if (level_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Level);
		}
		if (lineup_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(Lineup);
		}
		if (oFAOIMCDHPN_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(OFAOIMCDHPN);
		}
		if (mMAOONPAPDP_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(MMAOONPAPDP);
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
		if (itemValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemValue);
		}
		if (eIENKJFFFJG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EIENKJFFFJG);
		}
		if (basicInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BasicInfo);
		}
		if (hKKIJABGCNA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HKKIJABGCNA);
		}
		if (level_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Level);
		}
		if (lineup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
		if (oFAOIMCDHPN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OFAOIMCDHPN);
		}
		if (mMAOONPAPDP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MMAOONPAPDP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AHOLOHCLLKD other)
	{
		if (other == null)
		{
			return;
		}
		if (other.itemValue_ != null)
		{
			if (itemValue_ == null)
			{
				ItemValue = new PGJNBNANDEE();
			}
			ItemValue.MergeFrom(other.ItemValue);
		}
		if (other.eIENKJFFFJG_ != null)
		{
			if (eIENKJFFFJG_ == null)
			{
				EIENKJFFFJG = new IOLJBGLNLCJ();
			}
			EIENKJFFFJG.MergeFrom(other.EIENKJFFFJG);
		}
		if (other.basicInfo_ != null)
		{
			if (basicInfo_ == null)
			{
				BasicInfo = new KGABJENCFDC();
			}
			BasicInfo.MergeFrom(other.BasicInfo);
		}
		if (other.hKKIJABGCNA_ != null)
		{
			if (hKKIJABGCNA_ == null)
			{
				HKKIJABGCNA = new NKLOBAKEMII();
			}
			HKKIJABGCNA.MergeFrom(other.HKKIJABGCNA);
		}
		if (other.level_ != null)
		{
			if (level_ == null)
			{
				Level = new ACCBPEAJFEO();
			}
			Level.MergeFrom(other.Level);
		}
		if (other.lineup_ != null)
		{
			if (lineup_ == null)
			{
				Lineup = new MICOMIBPIOA();
			}
			Lineup.MergeFrom(other.Lineup);
		}
		if (other.oFAOIMCDHPN_ != null)
		{
			if (oFAOIMCDHPN_ == null)
			{
				OFAOIMCDHPN = new OJAEEMPKCBN();
			}
			OFAOIMCDHPN.MergeFrom(other.OFAOIMCDHPN);
		}
		if (other.mMAOONPAPDP_ != null)
		{
			if (mMAOONPAPDP_ == null)
			{
				MMAOONPAPDP = new KKFANGIJAOF();
			}
			MMAOONPAPDP.MergeFrom(other.MMAOONPAPDP);
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
			case 10u:
				if (itemValue_ == null)
				{
					ItemValue = new PGJNBNANDEE();
				}
				input.ReadMessage(ItemValue);
				break;
			case 26u:
				if (eIENKJFFFJG_ == null)
				{
					EIENKJFFFJG = new IOLJBGLNLCJ();
				}
				input.ReadMessage(EIENKJFFFJG);
				break;
			case 34u:
				if (basicInfo_ == null)
				{
					BasicInfo = new KGABJENCFDC();
				}
				input.ReadMessage(BasicInfo);
				break;
			case 42u:
				if (hKKIJABGCNA_ == null)
				{
					HKKIJABGCNA = new NKLOBAKEMII();
				}
				input.ReadMessage(HKKIJABGCNA);
				break;
			case 74u:
				if (level_ == null)
				{
					Level = new ACCBPEAJFEO();
				}
				input.ReadMessage(Level);
				break;
			case 90u:
				if (lineup_ == null)
				{
					Lineup = new MICOMIBPIOA();
				}
				input.ReadMessage(Lineup);
				break;
			case 98u:
				if (oFAOIMCDHPN_ == null)
				{
					OFAOIMCDHPN = new OJAEEMPKCBN();
				}
				input.ReadMessage(OFAOIMCDHPN);
				break;
			case 114u:
				if (mMAOONPAPDP_ == null)
				{
					MMAOONPAPDP = new KKFANGIJAOF();
				}
				input.ReadMessage(MMAOONPAPDP);
				break;
			}
		}
	}
}
