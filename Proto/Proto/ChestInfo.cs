using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChestInfo : IMessage<ChestInfo>, IMessage, IEquatable<ChestInfo>, IDeepCloneable<ChestInfo>, IBufferMessage
{
	private static readonly MessageParser<ChestInfo> _parser = new MessageParser<ChestInfo>(() => new ChestInfo());

	private UnknownFieldSet _unknownFields;

	public const int ExistNumFieldNumber = 4;

	private uint existNum_;

	public const int OpenedNumFieldNumber = 5;

	private uint openedNum_;

	public const int ChestTypeFieldNumber = 7;

	private ChestType chestType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChestInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChestInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ExistNum
	{
		get
		{
			return existNum_;
		}
		set
		{
			existNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OpenedNum
	{
		get
		{
			return openedNum_;
		}
		set
		{
			openedNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChestType ChestType
	{
		get
		{
			return chestType_;
		}
		set
		{
			chestType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChestInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChestInfo(ChestInfo other)
		: this()
	{
		existNum_ = other.existNum_;
		openedNum_ = other.openedNum_;
		chestType_ = other.chestType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChestInfo Clone()
	{
		return new ChestInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChestInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChestInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ExistNum != other.ExistNum)
		{
			return false;
		}
		if (OpenedNum != other.OpenedNum)
		{
			return false;
		}
		if (ChestType != other.ChestType)
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
		if (ExistNum != 0)
		{
			num ^= ExistNum.GetHashCode();
		}
		if (OpenedNum != 0)
		{
			num ^= OpenedNum.GetHashCode();
		}
		if (ChestType != ChestType.MapInfoChestTypeNone)
		{
			num ^= ChestType.GetHashCode();
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
		if (ExistNum != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(ExistNum);
		}
		if (OpenedNum != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(OpenedNum);
		}
		if (ChestType != ChestType.MapInfoChestTypeNone)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)ChestType);
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
		if (ExistNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ExistNum);
		}
		if (OpenedNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OpenedNum);
		}
		if (ChestType != ChestType.MapInfoChestTypeNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ChestType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChestInfo other)
	{
		if (other != null)
		{
			if (other.ExistNum != 0)
			{
				ExistNum = other.ExistNum;
			}
			if (other.OpenedNum != 0)
			{
				OpenedNum = other.OpenedNum;
			}
			if (other.ChestType != ChestType.MapInfoChestTypeNone)
			{
				ChestType = other.ChestType;
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
			case 32u:
				ExistNum = input.ReadUInt32();
				break;
			case 40u:
				OpenedNum = input.ReadUInt32();
				break;
			case 56u:
				ChestType = (ChestType)input.ReadEnum();
				break;
			}
		}
	}
}
