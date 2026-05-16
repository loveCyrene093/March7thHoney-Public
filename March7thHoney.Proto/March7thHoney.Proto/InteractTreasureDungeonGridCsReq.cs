using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class InteractTreasureDungeonGridCsReq : IMessage<InteractTreasureDungeonGridCsReq>, IMessage, IEquatable<InteractTreasureDungeonGridCsReq>, IDeepCloneable<InteractTreasureDungeonGridCsReq>, IBufferMessage
{
	private static readonly MessageParser<InteractTreasureDungeonGridCsReq> _parser = new MessageParser<InteractTreasureDungeonGridCsReq>(() => new InteractTreasureDungeonGridCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DisplayValueFieldNumber = 10;

	private uint displayValue_;

	public const int TargetSideFieldNumber = 11;

	private uint targetSide_;

	public const int CJOPNFDBJHDFieldNumber = 13;

	private uint cJOPNFDBJHD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<InteractTreasureDungeonGridCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => InteractTreasureDungeonGridCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DisplayValue
	{
		get
		{
			return displayValue_;
		}
		set
		{
			displayValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TargetSide
	{
		get
		{
			return targetSide_;
		}
		set
		{
			targetSide_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CJOPNFDBJHD
	{
		get
		{
			return cJOPNFDBJHD_;
		}
		set
		{
			cJOPNFDBJHD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractTreasureDungeonGridCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractTreasureDungeonGridCsReq(InteractTreasureDungeonGridCsReq other)
		: this()
	{
		displayValue_ = other.displayValue_;
		targetSide_ = other.targetSide_;
		cJOPNFDBJHD_ = other.cJOPNFDBJHD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractTreasureDungeonGridCsReq Clone()
	{
		return new InteractTreasureDungeonGridCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as InteractTreasureDungeonGridCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(InteractTreasureDungeonGridCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DisplayValue != other.DisplayValue)
		{
			return false;
		}
		if (TargetSide != other.TargetSide)
		{
			return false;
		}
		if (CJOPNFDBJHD != other.CJOPNFDBJHD)
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
		if (DisplayValue != 0)
		{
			num ^= DisplayValue.GetHashCode();
		}
		if (TargetSide != 0)
		{
			num ^= TargetSide.GetHashCode();
		}
		if (CJOPNFDBJHD != 0)
		{
			num ^= CJOPNFDBJHD.GetHashCode();
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
		if (DisplayValue != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(DisplayValue);
		}
		if (TargetSide != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(TargetSide);
		}
		if (CJOPNFDBJHD != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(CJOPNFDBJHD);
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
		if (DisplayValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DisplayValue);
		}
		if (TargetSide != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TargetSide);
		}
		if (CJOPNFDBJHD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CJOPNFDBJHD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(InteractTreasureDungeonGridCsReq other)
	{
		if (other != null)
		{
			if (other.DisplayValue != 0)
			{
				DisplayValue = other.DisplayValue;
			}
			if (other.TargetSide != 0)
			{
				TargetSide = other.TargetSide;
			}
			if (other.CJOPNFDBJHD != 0)
			{
				CJOPNFDBJHD = other.CJOPNFDBJHD;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 80u:
				DisplayValue = input.ReadUInt32();
				break;
			case 88u:
				TargetSide = input.ReadUInt32();
				break;
			case 104u:
				CJOPNFDBJHD = input.ReadUInt32();
				break;
			}
		}
	}
}
