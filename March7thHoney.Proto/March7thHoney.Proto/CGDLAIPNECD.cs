using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CGDLAIPNECD : IMessage<CGDLAIPNECD>, IMessage, IEquatable<CGDLAIPNECD>, IDeepCloneable<CGDLAIPNECD>, IBufferMessage
{
	private static readonly MessageParser<CGDLAIPNECD> _parser = new MessageParser<CGDLAIPNECD>(() => new CGDLAIPNECD());

	private UnknownFieldSet _unknownFields;

	public const int ALLCAPABHAHFieldNumber = 2;

	private bool aLLCAPABHAH_;

	public const int DOMGLHIKJEDFieldNumber = 6;

	private uint dOMGLHIKJED_;

	public const int EJPLDKFEMDMFieldNumber = 13;

	private ItemCostData eJPLDKFEMDM_;

	public const int CostDataFieldNumber = 14;

	private ItemCostData costData_;

	public const int KFAMJJGHJOOFieldNumber = 15;

	private bool kFAMJJGHJOO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CGDLAIPNECD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CGDLAIPNECDReflection.Descriptor.MessageTypes[0];

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
	public uint DOMGLHIKJED
	{
		get
		{
			return dOMGLHIKJED_;
		}
		set
		{
			dOMGLHIKJED_ = value;
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
	public CGDLAIPNECD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGDLAIPNECD(CGDLAIPNECD other)
		: this()
	{
		aLLCAPABHAH_ = other.aLLCAPABHAH_;
		dOMGLHIKJED_ = other.dOMGLHIKJED_;
		eJPLDKFEMDM_ = ((other.eJPLDKFEMDM_ != null) ? other.eJPLDKFEMDM_.Clone() : null);
		costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
		kFAMJJGHJOO_ = other.kFAMJJGHJOO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGDLAIPNECD Clone()
	{
		return new CGDLAIPNECD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CGDLAIPNECD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CGDLAIPNECD other)
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
		if (DOMGLHIKJED != other.DOMGLHIKJED)
		{
			return false;
		}
		if (!object.Equals(EJPLDKFEMDM, other.EJPLDKFEMDM))
		{
			return false;
		}
		if (!object.Equals(CostData, other.CostData))
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
		if (ALLCAPABHAH)
		{
			num ^= ALLCAPABHAH.GetHashCode();
		}
		if (DOMGLHIKJED != 0)
		{
			num ^= DOMGLHIKJED.GetHashCode();
		}
		if (eJPLDKFEMDM_ != null)
		{
			num ^= EJPLDKFEMDM.GetHashCode();
		}
		if (costData_ != null)
		{
			num ^= CostData.GetHashCode();
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
		if (ALLCAPABHAH)
		{
			output.WriteRawTag(16);
			output.WriteBool(ALLCAPABHAH);
		}
		if (DOMGLHIKJED != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(DOMGLHIKJED);
		}
		if (eJPLDKFEMDM_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(EJPLDKFEMDM);
		}
		if (costData_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(CostData);
		}
		if (KFAMJJGHJOO)
		{
			output.WriteRawTag(120);
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
		if (ALLCAPABHAH)
		{
			num += 2;
		}
		if (DOMGLHIKJED != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DOMGLHIKJED);
		}
		if (eJPLDKFEMDM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EJPLDKFEMDM);
		}
		if (costData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CostData);
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
	public void MergeFrom(CGDLAIPNECD other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ALLCAPABHAH)
		{
			ALLCAPABHAH = other.ALLCAPABHAH;
		}
		if (other.DOMGLHIKJED != 0)
		{
			DOMGLHIKJED = other.DOMGLHIKJED;
		}
		if (other.eJPLDKFEMDM_ != null)
		{
			if (eJPLDKFEMDM_ == null)
			{
				EJPLDKFEMDM = new ItemCostData();
			}
			EJPLDKFEMDM.MergeFrom(other.EJPLDKFEMDM);
		}
		if (other.costData_ != null)
		{
			if (costData_ == null)
			{
				CostData = new ItemCostData();
			}
			CostData.MergeFrom(other.CostData);
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
			case 16u:
				ALLCAPABHAH = input.ReadBool();
				break;
			case 48u:
				DOMGLHIKJED = input.ReadUInt32();
				break;
			case 106u:
				if (eJPLDKFEMDM_ == null)
				{
					EJPLDKFEMDM = new ItemCostData();
				}
				input.ReadMessage(EJPLDKFEMDM);
				break;
			case 114u:
				if (costData_ == null)
				{
					CostData = new ItemCostData();
				}
				input.ReadMessage(CostData);
				break;
			case 120u:
				KFAMJJGHJOO = input.ReadBool();
				break;
			}
		}
	}
}
