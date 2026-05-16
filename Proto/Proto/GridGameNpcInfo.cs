using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridGameNpcInfo : IMessage<GridGameNpcInfo>, IMessage, IEquatable<GridGameNpcInfo>, IDeepCloneable<GridGameNpcInfo>, IBufferMessage
{
	private static readonly MessageParser<GridGameNpcInfo> _parser = new MessageParser<GridGameNpcInfo>(() => new GridGameNpcInfo());

	private UnknownFieldSet _unknownFields;

	public const int UpdateEquipsComponentFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_updateEquipsComponent_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> updateEquipsComponent_ = new RepeatedField<uint>();

	public const int UniqueIdFieldNumber = 8;

	private uint uniqueId_;

	public const int IdFieldNumber = 10;

	private uint id_;

	public const int PosFieldNumber = 13;

	private uint pos_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridGameNpcInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridGameNpcInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> UpdateEquipsComponent => updateEquipsComponent_;

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
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
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
	public GridGameNpcInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameNpcInfo(GridGameNpcInfo other)
		: this()
	{
		updateEquipsComponent_ = other.updateEquipsComponent_.Clone();
		uniqueId_ = other.uniqueId_;
		id_ = other.id_;
		pos_ = other.pos_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameNpcInfo Clone()
	{
		return new GridGameNpcInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridGameNpcInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridGameNpcInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!updateEquipsComponent_.Equals(other.updateEquipsComponent_))
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Pos != other.Pos)
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
		num ^= updateEquipsComponent_.GetHashCode();
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
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
		updateEquipsComponent_.WriteTo(ref output, _repeated_updateEquipsComponent_codec);
		if (UniqueId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(UniqueId);
		}
		if (Id != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Id);
		}
		if (Pos != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Pos);
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
		num += updateEquipsComponent_.CalculateSize(_repeated_updateEquipsComponent_codec);
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Pos);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridGameNpcInfo other)
	{
		if (other != null)
		{
			updateEquipsComponent_.Add(other.updateEquipsComponent_);
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Pos != 0)
			{
				Pos = other.Pos;
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
			case 16u:
			case 18u:
				updateEquipsComponent_.AddEntriesFrom(ref input, _repeated_updateEquipsComponent_codec);
				break;
			case 64u:
				UniqueId = input.ReadUInt32();
				break;
			case 80u:
				Id = input.ReadUInt32();
				break;
			case 104u:
				Pos = input.ReadUInt32();
				break;
			}
		}
	}
}
