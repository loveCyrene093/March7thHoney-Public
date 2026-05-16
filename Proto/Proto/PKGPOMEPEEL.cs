using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PKGPOMEPEEL : IMessage<PKGPOMEPEEL>, IMessage, IEquatable<PKGPOMEPEEL>, IDeepCloneable<PKGPOMEPEEL>, IBufferMessage
{
	private static readonly MessageParser<PKGPOMEPEEL> _parser = new MessageParser<PKGPOMEPEEL>(() => new PKGPOMEPEEL());

	private UnknownFieldSet _unknownFields;

	public const int ALLCAPABHAHFieldNumber = 3;

	private bool aLLCAPABHAH_;

	public const int EJPLDKFEMDMFieldNumber = 6;

	private ItemCostData eJPLDKFEMDM_;

	public const int IAPFJINFNLOFieldNumber = 7;

	private uint iAPFJINFNLO_;

	public const int KFAMJJGHJOOFieldNumber = 13;

	private bool kFAMJJGHJOO_;

	public const int CostDataFieldNumber = 14;

	private ItemCostData costData_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PKGPOMEPEEL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PKGPOMEPEELReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint IAPFJINFNLO
	{
		get
		{
			return iAPFJINFNLO_;
		}
		set
		{
			iAPFJINFNLO_ = value;
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
	public PKGPOMEPEEL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKGPOMEPEEL(PKGPOMEPEEL other)
		: this()
	{
		aLLCAPABHAH_ = other.aLLCAPABHAH_;
		eJPLDKFEMDM_ = ((other.eJPLDKFEMDM_ != null) ? other.eJPLDKFEMDM_.Clone() : null);
		iAPFJINFNLO_ = other.iAPFJINFNLO_;
		kFAMJJGHJOO_ = other.kFAMJJGHJOO_;
		costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKGPOMEPEEL Clone()
	{
		return new PKGPOMEPEEL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PKGPOMEPEEL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PKGPOMEPEEL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ALLCAPABHAH != other.ALLCAPABHAH)
		{
			return false;
		}
		if (!object.Equals(EJPLDKFEMDM, other.EJPLDKFEMDM))
		{
			return false;
		}
		if (IAPFJINFNLO != other.IAPFJINFNLO)
		{
			return false;
		}
		if (KFAMJJGHJOO != other.KFAMJJGHJOO)
		{
			return false;
		}
		if (!object.Equals(CostData, other.CostData))
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
		if (ALLCAPABHAH)
		{
			num ^= ALLCAPABHAH.GetHashCode();
		}
		if (eJPLDKFEMDM_ != null)
		{
			num ^= EJPLDKFEMDM.GetHashCode();
		}
		if (IAPFJINFNLO != 0)
		{
			num ^= IAPFJINFNLO.GetHashCode();
		}
		if (KFAMJJGHJOO)
		{
			num ^= KFAMJJGHJOO.GetHashCode();
		}
		if (costData_ != null)
		{
			num ^= CostData.GetHashCode();
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
		if (ALLCAPABHAH)
		{
			output.WriteRawTag(24);
			output.WriteBool(ALLCAPABHAH);
		}
		if (eJPLDKFEMDM_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(EJPLDKFEMDM);
		}
		if (IAPFJINFNLO != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(IAPFJINFNLO);
		}
		if (KFAMJJGHJOO)
		{
			output.WriteRawTag(104);
			output.WriteBool(KFAMJJGHJOO);
		}
		if (costData_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(CostData);
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
		if (ALLCAPABHAH)
		{
			num += 2;
		}
		if (eJPLDKFEMDM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EJPLDKFEMDM);
		}
		if (IAPFJINFNLO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IAPFJINFNLO);
		}
		if (KFAMJJGHJOO)
		{
			num += 2;
		}
		if (costData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CostData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PKGPOMEPEEL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ALLCAPABHAH)
		{
			ALLCAPABHAH = other.ALLCAPABHAH;
		}
		if (other.eJPLDKFEMDM_ != null)
		{
			if (eJPLDKFEMDM_ == null)
			{
				EJPLDKFEMDM = new ItemCostData();
			}
			EJPLDKFEMDM.MergeFrom(other.EJPLDKFEMDM);
		}
		if (other.IAPFJINFNLO != 0)
		{
			IAPFJINFNLO = other.IAPFJINFNLO;
		}
		if (other.KFAMJJGHJOO)
		{
			KFAMJJGHJOO = other.KFAMJJGHJOO;
		}
		if (other.costData_ != null)
		{
			if (costData_ == null)
			{
				CostData = new ItemCostData();
			}
			CostData.MergeFrom(other.CostData);
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
			case 24u:
				ALLCAPABHAH = input.ReadBool();
				break;
			case 50u:
				if (eJPLDKFEMDM_ == null)
				{
					EJPLDKFEMDM = new ItemCostData();
				}
				input.ReadMessage(EJPLDKFEMDM);
				break;
			case 56u:
				IAPFJINFNLO = input.ReadUInt32();
				break;
			case 104u:
				KFAMJJGHJOO = input.ReadBool();
				break;
			case 114u:
				if (costData_ == null)
				{
					CostData = new ItemCostData();
				}
				input.ReadMessage(CostData);
				break;
			}
		}
	}
}
