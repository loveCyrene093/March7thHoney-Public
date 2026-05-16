using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OKEPFGMNJAO : IMessage<OKEPFGMNJAO>, IMessage, IEquatable<OKEPFGMNJAO>, IDeepCloneable<OKEPFGMNJAO>, IBufferMessage
{
	private static readonly MessageParser<OKEPFGMNJAO> _parser = new MessageParser<OKEPFGMNJAO>(() => new OKEPFGMNJAO());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 3;

	private MissionSyncRecord type_;

	public const int IdFieldNumber = 4;

	private uint id_;

	public const int DisplayValueFieldNumber = 11;

	private uint displayValue_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OKEPFGMNJAO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OKEPFGMNJAOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionSyncRecord Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
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
	public OKEPFGMNJAO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKEPFGMNJAO(OKEPFGMNJAO other)
		: this()
	{
		type_ = other.type_;
		id_ = other.id_;
		displayValue_ = other.displayValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKEPFGMNJAO Clone()
	{
		return new OKEPFGMNJAO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OKEPFGMNJAO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OKEPFGMNJAO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (DisplayValue != other.DisplayValue)
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
		if (Type != MissionSyncRecord.AlgpcoobeffAdpjfmjjabn)
		{
			num ^= Type.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (DisplayValue != 0)
		{
			num ^= DisplayValue.GetHashCode();
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
		if (Type != MissionSyncRecord.AlgpcoobeffAdpjfmjjabn)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Type);
		}
		if (Id != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Id);
		}
		if (DisplayValue != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(DisplayValue);
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
		if (Type != MissionSyncRecord.AlgpcoobeffAdpjfmjjabn)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (DisplayValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DisplayValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OKEPFGMNJAO other)
	{
		if (other != null)
		{
			if (other.Type != MissionSyncRecord.AlgpcoobeffAdpjfmjjabn)
			{
				Type = other.Type;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.DisplayValue != 0)
			{
				DisplayValue = other.DisplayValue;
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
			case 24u:
				Type = (MissionSyncRecord)input.ReadEnum();
				break;
			case 32u:
				Id = input.ReadUInt32();
				break;
			case 88u:
				DisplayValue = input.ReadUInt32();
				break;
			}
		}
	}
}
