using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DIMBAAJNEAF : IMessage<DIMBAAJNEAF>, IMessage, IEquatable<DIMBAAJNEAF>, IDeepCloneable<DIMBAAJNEAF>, IBufferMessage
{
	private static readonly MessageParser<DIMBAAJNEAF> _parser = new MessageParser<DIMBAAJNEAF>(() => new DIMBAAJNEAF());

	private UnknownFieldSet _unknownFields;

	public const int BuffIdFieldNumber = 1;

	private uint buffId_;

	public const int ALLCAPABHAHFieldNumber = 2;

	private bool aLLCAPABHAH_;

	public const int CostDataFieldNumber = 4;

	private ItemCostData costData_;

	public const int EJPLDKFEMDMFieldNumber = 5;

	private ItemCostData eJPLDKFEMDM_;

	public const int CHPHBCOKCEOFieldNumber = 10;

	private uint cHPHBCOKCEO_;

	public const int KFAMJJGHJOOFieldNumber = 13;

	private bool kFAMJJGHJOO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DIMBAAJNEAF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DIMBAAJNEAFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ALLCAPABHAH
	{
		get
		{
			return aLLCAPABHAH_;
		}
		set
		{
			aLLCAPABHAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData CostData
	{
		get
		{
			return costData_;
		}
		set
		{
			costData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData EJPLDKFEMDM
	{
		get
		{
			return eJPLDKFEMDM_;
		}
		set
		{
			eJPLDKFEMDM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CHPHBCOKCEO
	{
		get
		{
			return cHPHBCOKCEO_;
		}
		set
		{
			cHPHBCOKCEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KFAMJJGHJOO
	{
		get
		{
			return kFAMJJGHJOO_;
		}
		set
		{
			kFAMJJGHJOO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DIMBAAJNEAF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DIMBAAJNEAF(DIMBAAJNEAF other)
		: this()
	{
		buffId_ = other.buffId_;
		aLLCAPABHAH_ = other.aLLCAPABHAH_;
		costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
		eJPLDKFEMDM_ = ((other.eJPLDKFEMDM_ != null) ? other.eJPLDKFEMDM_.Clone() : null);
		cHPHBCOKCEO_ = other.cHPHBCOKCEO_;
		kFAMJJGHJOO_ = other.kFAMJJGHJOO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DIMBAAJNEAF Clone()
	{
		return new DIMBAAJNEAF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DIMBAAJNEAF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DIMBAAJNEAF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		if (ALLCAPABHAH != other.ALLCAPABHAH)
		{
			return false;
		}
		if (!object.Equals(CostData, other.CostData))
		{
			return false;
		}
		if (!object.Equals(EJPLDKFEMDM, other.EJPLDKFEMDM))
		{
			return false;
		}
		if (CHPHBCOKCEO != other.CHPHBCOKCEO)
		{
			return false;
		}
		if (KFAMJJGHJOO != other.KFAMJJGHJOO)
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
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (ALLCAPABHAH)
		{
			num ^= ALLCAPABHAH.GetHashCode();
		}
		if (costData_ != null)
		{
			num ^= CostData.GetHashCode();
		}
		if (eJPLDKFEMDM_ != null)
		{
			num ^= EJPLDKFEMDM.GetHashCode();
		}
		if (CHPHBCOKCEO != 0)
		{
			num ^= CHPHBCOKCEO.GetHashCode();
		}
		if (KFAMJJGHJOO)
		{
			num ^= KFAMJJGHJOO.GetHashCode();
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
		if (BuffId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(BuffId);
		}
		if (ALLCAPABHAH)
		{
			output.WriteRawTag(16);
			output.WriteBool(ALLCAPABHAH);
		}
		if (costData_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(CostData);
		}
		if (eJPLDKFEMDM_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(EJPLDKFEMDM);
		}
		if (CHPHBCOKCEO != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(CHPHBCOKCEO);
		}
		if (KFAMJJGHJOO)
		{
			output.WriteRawTag(104);
			output.WriteBool(KFAMJJGHJOO);
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
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffId);
		}
		if (ALLCAPABHAH)
		{
			num += 2;
		}
		if (costData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CostData);
		}
		if (eJPLDKFEMDM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EJPLDKFEMDM);
		}
		if (CHPHBCOKCEO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CHPHBCOKCEO);
		}
		if (KFAMJJGHJOO)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DIMBAAJNEAF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BuffId != 0)
		{
			BuffId = other.BuffId;
		}
		if (other.ALLCAPABHAH)
		{
			ALLCAPABHAH = other.ALLCAPABHAH;
		}
		if (other.costData_ != null)
		{
			if (costData_ == null)
			{
				CostData = new ItemCostData();
			}
			CostData.MergeFrom(other.CostData);
		}
		if (other.eJPLDKFEMDM_ != null)
		{
			if (eJPLDKFEMDM_ == null)
			{
				EJPLDKFEMDM = new ItemCostData();
			}
			EJPLDKFEMDM.MergeFrom(other.EJPLDKFEMDM);
		}
		if (other.CHPHBCOKCEO != 0)
		{
			CHPHBCOKCEO = other.CHPHBCOKCEO;
		}
		if (other.KFAMJJGHJOO)
		{
			KFAMJJGHJOO = other.KFAMJJGHJOO;
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
				BuffId = input.ReadUInt32();
				break;
			case 16u:
				ALLCAPABHAH = input.ReadBool();
				break;
			case 34u:
				if (costData_ == null)
				{
					CostData = new ItemCostData();
				}
				input.ReadMessage(CostData);
				break;
			case 42u:
				if (eJPLDKFEMDM_ == null)
				{
					EJPLDKFEMDM = new ItemCostData();
				}
				input.ReadMessage(EJPLDKFEMDM);
				break;
			case 80u:
				CHPHBCOKCEO = input.ReadUInt32();
				break;
			case 104u:
				KFAMJJGHJOO = input.ReadBool();
				break;
			}
		}
	}
}
