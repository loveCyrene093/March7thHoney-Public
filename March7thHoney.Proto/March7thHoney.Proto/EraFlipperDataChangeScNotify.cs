using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EraFlipperDataChangeScNotify : IMessage<EraFlipperDataChangeScNotify>, IMessage, IEquatable<EraFlipperDataChangeScNotify>, IDeepCloneable<EraFlipperDataChangeScNotify>, IBufferMessage
{
	private static readonly MessageParser<EraFlipperDataChangeScNotify> _parser = new MessageParser<EraFlipperDataChangeScNotify>(() => new EraFlipperDataChangeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int DataFieldNumber = 2;

	private EraFlipperDataList data_;

	public const int FloorIdFieldNumber = 3;

	private uint floorId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EraFlipperDataChangeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EraFlipperDataChangeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EraFlipperDataList Data
	{
		get
		{
			return data_;
		}
		set
		{
			data_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FloorId
	{
		get
		{
			return floorId_;
		}
		set
		{
			floorId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EraFlipperDataChangeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EraFlipperDataChangeScNotify(EraFlipperDataChangeScNotify other)
		: this()
	{
		data_ = ((other.data_ != null) ? other.data_.Clone() : null);
		floorId_ = other.floorId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EraFlipperDataChangeScNotify Clone()
	{
		return new EraFlipperDataChangeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EraFlipperDataChangeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EraFlipperDataChangeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Data, other.Data))
		{
			return false;
		}
		if (FloorId != other.FloorId)
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
		if (data_ != null)
		{
			num ^= Data.GetHashCode();
		}
		if (FloorId != 0)
		{
			num ^= FloorId.GetHashCode();
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
		if (data_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Data);
		}
		if (FloorId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(FloorId);
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
		if (data_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Data);
		}
		if (FloorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FloorId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EraFlipperDataChangeScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.data_ != null)
		{
			if (data_ == null)
			{
				Data = new EraFlipperDataList();
			}
			Data.MergeFrom(other.Data);
		}
		if (other.FloorId != 0)
		{
			FloorId = other.FloorId;
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
			case 18u:
				if (data_ == null)
				{
					Data = new EraFlipperDataList();
				}
				input.ReadMessage(Data);
				break;
			case 24u:
				FloorId = input.ReadUInt32();
				break;
			}
		}
	}
}
