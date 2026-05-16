using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightNpcInfoPb : IMessage<GridFightNpcInfoPb>, IMessage, IEquatable<GridFightNpcInfoPb>, IDeepCloneable<GridFightNpcInfoPb>, IBufferMessage
{
	private static readonly MessageParser<GridFightNpcInfoPb> _parser = new MessageParser<GridFightNpcInfoPb>(() => new GridFightNpcInfoPb());

	private UnknownFieldSet _unknownFields;

	public const int NpcIdFieldNumber = 1;

	private uint npcId_;

	public const int PosFieldNumber = 2;

	private uint pos_;

	public const int UniqueIdFieldNumber = 3;

	private uint uniqueId_;

	public const int EquipmentIdsFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_equipmentIds_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> equipmentIds_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightNpcInfoPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightDataReflection.Descriptor.MessageTypes[7];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NpcId
	{
		get
		{
			return npcId_;
		}
		set
		{
			npcId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

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
	public RepeatedField<uint> EquipmentIds => equipmentIds_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightNpcInfoPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightNpcInfoPb(GridFightNpcInfoPb other)
		: this()
	{
		npcId_ = other.npcId_;
		pos_ = other.pos_;
		uniqueId_ = other.uniqueId_;
		equipmentIds_ = other.equipmentIds_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightNpcInfoPb Clone()
	{
		return new GridFightNpcInfoPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightNpcInfoPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightNpcInfoPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NpcId != other.NpcId)
		{
			return false;
		}
		if (Pos != other.Pos)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (!equipmentIds_.Equals(other.equipmentIds_))
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
		if (NpcId != 0)
		{
			num ^= NpcId.GetHashCode();
		}
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		num ^= equipmentIds_.GetHashCode();
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
		if (NpcId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(NpcId);
		}
		if (Pos != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Pos);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(UniqueId);
		}
		equipmentIds_.WriteTo(ref output, _repeated_equipmentIds_codec);
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
		if (NpcId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NpcId);
		}
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Pos);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		num += equipmentIds_.CalculateSize(_repeated_equipmentIds_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightNpcInfoPb other)
	{
		if (other != null)
		{
			if (other.NpcId != 0)
			{
				NpcId = other.NpcId;
			}
			if (other.Pos != 0)
			{
				Pos = other.Pos;
			}
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			equipmentIds_.Add(other.equipmentIds_);
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
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				NpcId = input.ReadUInt32();
				break;
			case 16u:
				Pos = input.ReadUInt32();
				break;
			case 24u:
				UniqueId = input.ReadUInt32();
				break;
			case 32u:
			case 34u:
				equipmentIds_.AddEntriesFrom(ref input, _repeated_equipmentIds_codec);
				break;
			}
		}
	}
}
