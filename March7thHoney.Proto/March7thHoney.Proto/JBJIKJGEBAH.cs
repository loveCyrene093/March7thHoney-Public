using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JBJIKJGEBAH : IMessage<JBJIKJGEBAH>, IMessage, IEquatable<JBJIKJGEBAH>, IDeepCloneable<JBJIKJGEBAH>, IBufferMessage
{
	private static readonly MessageParser<JBJIKJGEBAH> _parser = new MessageParser<JBJIKJGEBAH>(() => new JBJIKJGEBAH());

	private UnknownFieldSet _unknownFields;

	public const int ItemIdFieldNumber = 4;

	private uint itemId_;

	public const int DCHAKLDHANLFieldNumber = 12;

	private uint dCHAKLDHANL_;

	public const int NumFieldNumber = 13;

	private uint num_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JBJIKJGEBAH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JBJIKJGEBAHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DCHAKLDHANL
	{
		get
		{
			return dCHAKLDHANL_;
		}
		set
		{
			dCHAKLDHANL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Num
	{
		get
		{
			return num_;
		}
		set
		{
			num_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBJIKJGEBAH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBJIKJGEBAH(JBJIKJGEBAH other)
		: this()
	{
		itemId_ = other.itemId_;
		dCHAKLDHANL_ = other.dCHAKLDHANL_;
		num_ = other.num_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBJIKJGEBAH Clone()
	{
		return new JBJIKJGEBAH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JBJIKJGEBAH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JBJIKJGEBAH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (DCHAKLDHANL != other.DCHAKLDHANL)
		{
			return false;
		}
		if (Num != other.Num)
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
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (DCHAKLDHANL != 0)
		{
			num ^= DCHAKLDHANL.GetHashCode();
		}
		if (Num != 0)
		{
			num ^= Num.GetHashCode();
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
		if (ItemId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(ItemId);
		}
		if (DCHAKLDHANL != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(DCHAKLDHANL);
		}
		if (Num != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Num);
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
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		if (DCHAKLDHANL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DCHAKLDHANL);
		}
		if (Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Num);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JBJIKJGEBAH other)
	{
		if (other != null)
		{
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.DCHAKLDHANL != 0)
			{
				DCHAKLDHANL = other.DCHAKLDHANL;
			}
			if (other.Num != 0)
			{
				Num = other.Num;
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
				ItemId = input.ReadUInt32();
				break;
			case 96u:
				DCHAKLDHANL = input.ReadUInt32();
				break;
			case 104u:
				Num = input.ReadUInt32();
				break;
			}
		}
	}
}
