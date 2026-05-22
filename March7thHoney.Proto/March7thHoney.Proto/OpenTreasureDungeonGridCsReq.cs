using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OpenTreasureDungeonGridCsReq : IMessage<OpenTreasureDungeonGridCsReq>, IMessage, IEquatable<OpenTreasureDungeonGridCsReq>, IDeepCloneable<OpenTreasureDungeonGridCsReq>, IBufferMessage
{
	private static readonly MessageParser<OpenTreasureDungeonGridCsReq> _parser = new MessageParser<OpenTreasureDungeonGridCsReq>(() => new OpenTreasureDungeonGridCsReq());

	private UnknownFieldSet _unknownFields;

	public const int CJOPNFDBJHDFieldNumber = 5;

	private uint cJOPNFDBJHD_;

	public const int TargetSideFieldNumber = 10;

	private uint targetSide_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OpenTreasureDungeonGridCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OpenTreasureDungeonGridCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public OpenTreasureDungeonGridCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OpenTreasureDungeonGridCsReq(OpenTreasureDungeonGridCsReq other)
		: this()
	{
		cJOPNFDBJHD_ = other.cJOPNFDBJHD_;
		targetSide_ = other.targetSide_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OpenTreasureDungeonGridCsReq Clone()
	{
		return new OpenTreasureDungeonGridCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OpenTreasureDungeonGridCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OpenTreasureDungeonGridCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CJOPNFDBJHD != other.CJOPNFDBJHD)
		{
			return false;
		}
		if (TargetSide != other.TargetSide)
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
		if (CJOPNFDBJHD != 0)
		{
			num ^= CJOPNFDBJHD.GetHashCode();
		}
		if (TargetSide != 0)
		{
			num ^= TargetSide.GetHashCode();
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
		if (CJOPNFDBJHD != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(CJOPNFDBJHD);
		}
		if (TargetSide != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(TargetSide);
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
		if (CJOPNFDBJHD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CJOPNFDBJHD);
		}
		if (TargetSide != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TargetSide);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OpenTreasureDungeonGridCsReq other)
	{
		if (other != null)
		{
			if (other.CJOPNFDBJHD != 0)
			{
				CJOPNFDBJHD = other.CJOPNFDBJHD;
			}
			if (other.TargetSide != 0)
			{
				TargetSide = other.TargetSide;
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
			case 40u:
				CJOPNFDBJHD = input.ReadUInt32();
				break;
			case 80u:
				TargetSide = input.ReadUInt32();
				break;
			}
		}
	}
}
