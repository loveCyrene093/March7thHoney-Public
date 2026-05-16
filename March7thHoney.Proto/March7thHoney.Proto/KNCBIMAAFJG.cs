using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KNCBIMAAFJG : IMessage<KNCBIMAAFJG>, IMessage, IEquatable<KNCBIMAAFJG>, IDeepCloneable<KNCBIMAAFJG>, IBufferMessage
{
	private static readonly MessageParser<KNCBIMAAFJG> _parser = new MessageParser<KNCBIMAAFJG>(() => new KNCBIMAAFJG());

	private UnknownFieldSet _unknownFields;

	public const int UniqueIdFieldNumber = 1;

	private uint uniqueId_;

	public const int BHJPDMJDJMNFieldNumber = 5;

	private uint bHJPDMJDJMN_;

	public const int DDGEOOLHAPGFieldNumber = 7;

	private uint dDGEOOLHAPG_;

	public const int CJAKEBNPGFAFieldNumber = 9;

	private int cJAKEBNPGFA_;

	public const int CCNJKIAOMFFFieldNumber = 12;

	private int cCNJKIAOMFF_;

	public const int ExpFieldNumber = 13;

	private uint exp_;

	public const int EquipmentGoodsInfoFieldNumber = 14;

	private JCGBNPKJKHB equipmentGoodsInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KNCBIMAAFJG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KNCBIMAAFJGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BHJPDMJDJMN
	{
		get
		{
			return bHJPDMJDJMN_;
		}
		set
		{
			bHJPDMJDJMN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DDGEOOLHAPG
	{
		get
		{
			return dDGEOOLHAPG_;
		}
		set
		{
			dDGEOOLHAPG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CJAKEBNPGFA
	{
		get
		{
			return cJAKEBNPGFA_;
		}
		set
		{
			cJAKEBNPGFA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CCNJKIAOMFF
	{
		get
		{
			return cCNJKIAOMFF_;
		}
		set
		{
			cCNJKIAOMFF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Exp
	{
		get
		{
			return exp_;
		}
		set
		{
			exp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCGBNPKJKHB EquipmentGoodsInfo
	{
		get
		{
			return equipmentGoodsInfo_;
		}
		set
		{
			equipmentGoodsInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNCBIMAAFJG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNCBIMAAFJG(KNCBIMAAFJG other)
		: this()
	{
		uniqueId_ = other.uniqueId_;
		bHJPDMJDJMN_ = other.bHJPDMJDJMN_;
		dDGEOOLHAPG_ = other.dDGEOOLHAPG_;
		cJAKEBNPGFA_ = other.cJAKEBNPGFA_;
		cCNJKIAOMFF_ = other.cCNJKIAOMFF_;
		exp_ = other.exp_;
		equipmentGoodsInfo_ = ((other.equipmentGoodsInfo_ != null) ? other.equipmentGoodsInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNCBIMAAFJG Clone()
	{
		return new KNCBIMAAFJG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KNCBIMAAFJG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KNCBIMAAFJG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (BHJPDMJDJMN != other.BHJPDMJDJMN)
		{
			return false;
		}
		if (DDGEOOLHAPG != other.DDGEOOLHAPG)
		{
			return false;
		}
		if (CJAKEBNPGFA != other.CJAKEBNPGFA)
		{
			return false;
		}
		if (CCNJKIAOMFF != other.CCNJKIAOMFF)
		{
			return false;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (!object.Equals(EquipmentGoodsInfo, other.EquipmentGoodsInfo))
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
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (BHJPDMJDJMN != 0)
		{
			num ^= BHJPDMJDJMN.GetHashCode();
		}
		if (DDGEOOLHAPG != 0)
		{
			num ^= DDGEOOLHAPG.GetHashCode();
		}
		if (CJAKEBNPGFA != 0)
		{
			num ^= CJAKEBNPGFA.GetHashCode();
		}
		if (CCNJKIAOMFF != 0)
		{
			num ^= CCNJKIAOMFF.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (equipmentGoodsInfo_ != null)
		{
			num ^= EquipmentGoodsInfo.GetHashCode();
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
		if (UniqueId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(UniqueId);
		}
		if (BHJPDMJDJMN != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(BHJPDMJDJMN);
		}
		if (DDGEOOLHAPG != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(DDGEOOLHAPG);
		}
		if (CJAKEBNPGFA != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(CJAKEBNPGFA);
		}
		if (CCNJKIAOMFF != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(CCNJKIAOMFF);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Exp);
		}
		if (equipmentGoodsInfo_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(EquipmentGoodsInfo);
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
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (BHJPDMJDJMN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BHJPDMJDJMN);
		}
		if (DDGEOOLHAPG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DDGEOOLHAPG);
		}
		if (CJAKEBNPGFA != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CJAKEBNPGFA);
		}
		if (CCNJKIAOMFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CCNJKIAOMFF);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (equipmentGoodsInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EquipmentGoodsInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KNCBIMAAFJG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UniqueId != 0)
		{
			UniqueId = other.UniqueId;
		}
		if (other.BHJPDMJDJMN != 0)
		{
			BHJPDMJDJMN = other.BHJPDMJDJMN;
		}
		if (other.DDGEOOLHAPG != 0)
		{
			DDGEOOLHAPG = other.DDGEOOLHAPG;
		}
		if (other.CJAKEBNPGFA != 0)
		{
			CJAKEBNPGFA = other.CJAKEBNPGFA;
		}
		if (other.CCNJKIAOMFF != 0)
		{
			CCNJKIAOMFF = other.CCNJKIAOMFF;
		}
		if (other.Exp != 0)
		{
			Exp = other.Exp;
		}
		if (other.equipmentGoodsInfo_ != null)
		{
			if (equipmentGoodsInfo_ == null)
			{
				EquipmentGoodsInfo = new JCGBNPKJKHB();
			}
			EquipmentGoodsInfo.MergeFrom(other.EquipmentGoodsInfo);
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
			case 8u:
				UniqueId = input.ReadUInt32();
				break;
			case 40u:
				BHJPDMJDJMN = input.ReadUInt32();
				break;
			case 56u:
				DDGEOOLHAPG = input.ReadUInt32();
				break;
			case 72u:
				CJAKEBNPGFA = input.ReadInt32();
				break;
			case 96u:
				CCNJKIAOMFF = input.ReadInt32();
				break;
			case 104u:
				Exp = input.ReadUInt32();
				break;
			case 114u:
				if (equipmentGoodsInfo_ == null)
				{
					EquipmentGoodsInfo = new JCGBNPKJKHB();
				}
				input.ReadMessage(EquipmentGoodsInfo);
				break;
			}
		}
	}
}
