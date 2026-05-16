using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OLNPCLEFANN : IMessage<OLNPCLEFANN>, IMessage, IEquatable<OLNPCLEFANN>, IDeepCloneable<OLNPCLEFANN>, IBufferMessage
{
	private static readonly MessageParser<OLNPCLEFANN> _parser = new MessageParser<OLNPCLEFANN>(() => new OLNPCLEFANN());

	private UnknownFieldSet _unknownFields;

	public const int CostDataFieldNumber = 1;

	private ItemCostData costData_;

	public const int KCAJFLAMMACFieldNumber = 6;

	private float kCAJFLAMMAC_;

	public const int BuffIdFieldNumber = 11;

	private uint buffId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OLNPCLEFANN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OLNPCLEFANNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public float KCAJFLAMMAC
	{
		get
		{
			return kCAJFLAMMAC_;
		}
		set
		{
			kCAJFLAMMAC_ = value;
		}
	}

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
	public OLNPCLEFANN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OLNPCLEFANN(OLNPCLEFANN other)
		: this()
	{
		costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
		kCAJFLAMMAC_ = other.kCAJFLAMMAC_;
		buffId_ = other.buffId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OLNPCLEFANN Clone()
	{
		return new OLNPCLEFANN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OLNPCLEFANN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OLNPCLEFANN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CostData, other.CostData))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(KCAJFLAMMAC, other.KCAJFLAMMAC))
		{
			return false;
		}
		if (BuffId != other.BuffId)
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
		if (costData_ != null)
		{
			num ^= CostData.GetHashCode();
		}
		if (KCAJFLAMMAC != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(KCAJFLAMMAC);
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
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
		if (costData_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(CostData);
		}
		if (KCAJFLAMMAC != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(KCAJFLAMMAC);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(BuffId);
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
		if (costData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CostData);
		}
		if (KCAJFLAMMAC != 0f)
		{
			num += 5;
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BuffId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OLNPCLEFANN other)
	{
		if (other == null)
		{
			return;
		}
		if (other.costData_ != null)
		{
			if (costData_ == null)
			{
				CostData = new ItemCostData();
			}
			CostData.MergeFrom(other.CostData);
		}
		if (other.KCAJFLAMMAC != 0f)
		{
			KCAJFLAMMAC = other.KCAJFLAMMAC;
		}
		if (other.BuffId != 0)
		{
			BuffId = other.BuffId;
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
				if (costData_ == null)
				{
					CostData = new ItemCostData();
				}
				input.ReadMessage(CostData);
				break;
			case 53u:
				KCAJFLAMMAC = input.ReadFloat();
				break;
			case 88u:
				BuffId = input.ReadUInt32();
				break;
			}
		}
	}
}
