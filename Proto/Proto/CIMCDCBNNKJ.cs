using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CIMCDCBNNKJ : IMessage<CIMCDCBNNKJ>, IMessage, IEquatable<CIMCDCBNNKJ>, IDeepCloneable<CIMCDCBNNKJ>, IBufferMessage
{
	private static readonly MessageParser<CIMCDCBNNKJ> _parser = new MessageParser<CIMCDCBNNKJ>(() => new CIMCDCBNNKJ());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 1;

	private uint avatarId_;

	public const int BLDMBKKNMNDFieldNumber = 2;

	private uint bLDMBKKNMND_;

	public const int AvatarLevelFieldNumber = 3;

	private uint avatarLevel_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CIMCDCBNNKJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CIMCDCBNNKJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BLDMBKKNMND
	{
		get
		{
			return bLDMBKKNMND_;
		}
		set
		{
			bLDMBKKNMND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarLevel
	{
		get
		{
			return avatarLevel_;
		}
		set
		{
			avatarLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIMCDCBNNKJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIMCDCBNNKJ(CIMCDCBNNKJ other)
		: this()
	{
		avatarId_ = other.avatarId_;
		bLDMBKKNMND_ = other.bLDMBKKNMND_;
		avatarLevel_ = other.avatarLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIMCDCBNNKJ Clone()
	{
		return new CIMCDCBNNKJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CIMCDCBNNKJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CIMCDCBNNKJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (BLDMBKKNMND != other.BLDMBKKNMND)
		{
			return false;
		}
		if (AvatarLevel != other.AvatarLevel)
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
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (BLDMBKKNMND != 0)
		{
			num ^= BLDMBKKNMND.GetHashCode();
		}
		if (AvatarLevel != 0)
		{
			num ^= AvatarLevel.GetHashCode();
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
		if (AvatarId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AvatarId);
		}
		if (BLDMBKKNMND != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(BLDMBKKNMND);
		}
		if (AvatarLevel != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(AvatarLevel);
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
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (BLDMBKKNMND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BLDMBKKNMND);
		}
		if (AvatarLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CIMCDCBNNKJ other)
	{
		if (other != null)
		{
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.BLDMBKKNMND != 0)
			{
				BLDMBKKNMND = other.BLDMBKKNMND;
			}
			if (other.AvatarLevel != 0)
			{
				AvatarLevel = other.AvatarLevel;
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
				AvatarId = input.ReadUInt32();
				break;
			case 16u:
				BLDMBKKNMND = input.ReadUInt32();
				break;
			case 24u:
				AvatarLevel = input.ReadUInt32();
				break;
			}
		}
	}
}
