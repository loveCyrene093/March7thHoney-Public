using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DressRelicParam : IMessage<DressRelicParam>, IMessage, IEquatable<DressRelicParam>, IDeepCloneable<DressRelicParam>, IBufferMessage
{
	private static readonly MessageParser<DressRelicParam> _parser = new MessageParser<DressRelicParam>(() => new DressRelicParam());

	private UnknownFieldSet _unknownFields;

	public const int RelicUniqueIdFieldNumber = 2;

	private uint relicUniqueId_;

	public const int RelicTypeFieldNumber = 11;

	private uint relicType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DressRelicParam> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DressRelicParamReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RelicUniqueId
	{
		get
		{
			return relicUniqueId_;
		}
		set
		{
			relicUniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RelicType
	{
		get
		{
			return relicType_;
		}
		set
		{
			relicType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DressRelicParam()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DressRelicParam(DressRelicParam other)
		: this()
	{
		relicUniqueId_ = other.relicUniqueId_;
		relicType_ = other.relicType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DressRelicParam Clone()
	{
		return new DressRelicParam(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DressRelicParam);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DressRelicParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RelicUniqueId != other.RelicUniqueId)
		{
			return false;
		}
		if (RelicType != other.RelicType)
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
		if (RelicUniqueId != 0)
		{
			num ^= RelicUniqueId.GetHashCode();
		}
		if (RelicType != 0)
		{
			num ^= RelicType.GetHashCode();
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
		if (RelicUniqueId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(RelicUniqueId);
		}
		if (RelicType != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(RelicType);
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
		if (RelicUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RelicUniqueId);
		}
		if (RelicType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RelicType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DressRelicParam other)
	{
		if (other != null)
		{
			if (other.RelicUniqueId != 0)
			{
				RelicUniqueId = other.RelicUniqueId;
			}
			if (other.RelicType != 0)
			{
				RelicType = other.RelicType;
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
				RelicUniqueId = input.ReadUInt32();
				break;
			case 88u:
				RelicType = input.ReadUInt32();
				break;
			}
		}
	}
}
