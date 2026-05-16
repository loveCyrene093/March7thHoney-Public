using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LHDOBOHHKMB : IMessage<LHDOBOHHKMB>, IMessage, IEquatable<LHDOBOHHKMB>, IDeepCloneable<LHDOBOHHKMB>, IBufferMessage
{
	private static readonly MessageParser<LHDOBOHHKMB> _parser = new MessageParser<LHDOBOHHKMB>(() => new LHDOBOHHKMB());

	private UnknownFieldSet _unknownFields;

	public const int AOKDBDGDCHBFieldNumber = 4;

	private uint aOKDBDGDCHB_;

	public const int CostDataFieldNumber = 6;

	private ItemCostData costData_;

	public const int EKKIAHNMDHMFieldNumber = 11;

	private ItemCostData eKKIAHNMDHM_;

	public const int KLNHLEJKDMLFieldNumber = 12;

	private bool kLNHLEJKDML_;

	public const int CEHOPHJHDEFFieldNumber = 14;

	private uint cEHOPHJHDEF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LHDOBOHHKMB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LHDOBOHHKMBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AOKDBDGDCHB
	{
		get
		{
			return aOKDBDGDCHB_;
		}
		set
		{
			aOKDBDGDCHB_ = value;
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
	public ItemCostData EKKIAHNMDHM
	{
		get
		{
			return eKKIAHNMDHM_;
		}
		set
		{
			eKKIAHNMDHM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KLNHLEJKDML
	{
		get
		{
			return kLNHLEJKDML_;
		}
		set
		{
			kLNHLEJKDML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CEHOPHJHDEF
	{
		get
		{
			return cEHOPHJHDEF_;
		}
		set
		{
			cEHOPHJHDEF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHDOBOHHKMB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHDOBOHHKMB(LHDOBOHHKMB other)
		: this()
	{
		aOKDBDGDCHB_ = other.aOKDBDGDCHB_;
		costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
		eKKIAHNMDHM_ = ((other.eKKIAHNMDHM_ != null) ? other.eKKIAHNMDHM_.Clone() : null);
		kLNHLEJKDML_ = other.kLNHLEJKDML_;
		cEHOPHJHDEF_ = other.cEHOPHJHDEF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHDOBOHHKMB Clone()
	{
		return new LHDOBOHHKMB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LHDOBOHHKMB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LHDOBOHHKMB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AOKDBDGDCHB != other.AOKDBDGDCHB)
		{
			return false;
		}
		if (!object.Equals(CostData, other.CostData))
		{
			return false;
		}
		if (!object.Equals(EKKIAHNMDHM, other.EKKIAHNMDHM))
		{
			return false;
		}
		if (KLNHLEJKDML != other.KLNHLEJKDML)
		{
			return false;
		}
		if (CEHOPHJHDEF != other.CEHOPHJHDEF)
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
		if (AOKDBDGDCHB != 0)
		{
			num ^= AOKDBDGDCHB.GetHashCode();
		}
		if (costData_ != null)
		{
			num ^= CostData.GetHashCode();
		}
		if (eKKIAHNMDHM_ != null)
		{
			num ^= EKKIAHNMDHM.GetHashCode();
		}
		if (KLNHLEJKDML)
		{
			num ^= KLNHLEJKDML.GetHashCode();
		}
		if (CEHOPHJHDEF != 0)
		{
			num ^= CEHOPHJHDEF.GetHashCode();
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
		if (AOKDBDGDCHB != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(AOKDBDGDCHB);
		}
		if (costData_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(CostData);
		}
		if (eKKIAHNMDHM_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(EKKIAHNMDHM);
		}
		if (KLNHLEJKDML)
		{
			output.WriteRawTag(96);
			output.WriteBool(KLNHLEJKDML);
		}
		if (CEHOPHJHDEF != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(CEHOPHJHDEF);
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
		if (AOKDBDGDCHB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AOKDBDGDCHB);
		}
		if (costData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CostData);
		}
		if (eKKIAHNMDHM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EKKIAHNMDHM);
		}
		if (KLNHLEJKDML)
		{
			num += 2;
		}
		if (CEHOPHJHDEF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CEHOPHJHDEF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LHDOBOHHKMB other)
	{
		if (other == null)
		{
			return;
		}
		if (other.AOKDBDGDCHB != 0)
		{
			AOKDBDGDCHB = other.AOKDBDGDCHB;
		}
		if (other.costData_ != null)
		{
			if (costData_ == null)
			{
				CostData = new ItemCostData();
			}
			CostData.MergeFrom(other.CostData);
		}
		if (other.eKKIAHNMDHM_ != null)
		{
			if (eKKIAHNMDHM_ == null)
			{
				EKKIAHNMDHM = new ItemCostData();
			}
			EKKIAHNMDHM.MergeFrom(other.EKKIAHNMDHM);
		}
		if (other.KLNHLEJKDML)
		{
			KLNHLEJKDML = other.KLNHLEJKDML;
		}
		if (other.CEHOPHJHDEF != 0)
		{
			CEHOPHJHDEF = other.CEHOPHJHDEF;
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
			case 32u:
				AOKDBDGDCHB = input.ReadUInt32();
				break;
			case 50u:
				if (costData_ == null)
				{
					CostData = new ItemCostData();
				}
				input.ReadMessage(CostData);
				break;
			case 90u:
				if (eKKIAHNMDHM_ == null)
				{
					EKKIAHNMDHM = new ItemCostData();
				}
				input.ReadMessage(EKKIAHNMDHM);
				break;
			case 96u:
				KLNHLEJKDML = input.ReadBool();
				break;
			case 112u:
				CEHOPHJHDEF = input.ReadUInt32();
				break;
			}
		}
	}
}
