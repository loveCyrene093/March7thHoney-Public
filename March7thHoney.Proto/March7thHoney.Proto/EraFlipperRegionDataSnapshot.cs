using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EraFlipperRegionDataSnapshot : IMessage<EraFlipperRegionDataSnapshot>, IMessage, IEquatable<EraFlipperRegionDataSnapshot>, IDeepCloneable<EraFlipperRegionDataSnapshot>, IBufferMessage
{
	private static readonly MessageParser<EraFlipperRegionDataSnapshot> _parser = new MessageParser<EraFlipperRegionDataSnapshot>(() => new EraFlipperRegionDataSnapshot());

	private UnknownFieldSet _unknownFields;

	public const int RegionIdFieldNumber = 1;

	private uint regionId_;

	public const int StateFieldNumber = 2;

	private uint state_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EraFlipperRegionDataSnapshot> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EraFlipperRegionDataSnapshotReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RegionId
	{
		get
		{
			return regionId_;
		}
		set
		{
			regionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EraFlipperRegionDataSnapshot()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EraFlipperRegionDataSnapshot(EraFlipperRegionDataSnapshot other)
		: this()
	{
		regionId_ = other.regionId_;
		state_ = other.state_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EraFlipperRegionDataSnapshot Clone()
	{
		return new EraFlipperRegionDataSnapshot(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EraFlipperRegionDataSnapshot);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EraFlipperRegionDataSnapshot other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RegionId != other.RegionId)
		{
			return false;
		}
		if (State != other.State)
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
		if (RegionId != 0)
		{
			num ^= RegionId.GetHashCode();
		}
		if (State != 0)
		{
			num ^= State.GetHashCode();
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
		if (RegionId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(RegionId);
		}
		if (State != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(State);
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
		if (RegionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RegionId);
		}
		if (State != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(State);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EraFlipperRegionDataSnapshot other)
	{
		if (other != null)
		{
			if (other.RegionId != 0)
			{
				RegionId = other.RegionId;
			}
			if (other.State != 0)
			{
				State = other.State;
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
			case 8u:
				RegionId = input.ReadUInt32();
				break;
			case 16u:
				State = input.ReadUInt32();
				break;
			}
		}
	}
}
