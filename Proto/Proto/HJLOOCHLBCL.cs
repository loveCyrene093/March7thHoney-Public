using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HJLOOCHLBCL : IMessage<HJLOOCHLBCL>, IMessage, IEquatable<HJLOOCHLBCL>, IDeepCloneable<HJLOOCHLBCL>, IBufferMessage
{
	private static readonly MessageParser<HJLOOCHLBCL> _parser = new MessageParser<HJLOOCHLBCL>(() => new HJLOOCHLBCL());

	private UnknownFieldSet _unknownFields;

	public const int ItemIdFieldNumber = 6;

	private uint itemId_;

	public const int ItemStackCountFieldNumber = 8;

	private uint itemStackCount_;

	public const int CLAFNDLGDAOFieldNumber = 10;

	private uint cLAFNDLGDAO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HJLOOCHLBCL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HJLOOCHLBCLReflection.Descriptor.MessageTypes[0];

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
	public uint ItemStackCount
	{
		get
		{
			return itemStackCount_;
		}
		set
		{
			itemStackCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CLAFNDLGDAO
	{
		get
		{
			return cLAFNDLGDAO_;
		}
		set
		{
			cLAFNDLGDAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJLOOCHLBCL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJLOOCHLBCL(HJLOOCHLBCL other)
		: this()
	{
		itemId_ = other.itemId_;
		itemStackCount_ = other.itemStackCount_;
		cLAFNDLGDAO_ = other.cLAFNDLGDAO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HJLOOCHLBCL Clone()
	{
		return new HJLOOCHLBCL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HJLOOCHLBCL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HJLOOCHLBCL other)
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
		if (ItemStackCount != other.ItemStackCount)
		{
			return false;
		}
		if (CLAFNDLGDAO != other.CLAFNDLGDAO)
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
		if (ItemStackCount != 0)
		{
			num ^= ItemStackCount.GetHashCode();
		}
		if (CLAFNDLGDAO != 0)
		{
			num ^= CLAFNDLGDAO.GetHashCode();
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
			output.WriteRawTag(48);
			output.WriteUInt32(ItemId);
		}
		if (ItemStackCount != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(ItemStackCount);
		}
		if (CLAFNDLGDAO != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(CLAFNDLGDAO);
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
		if (ItemStackCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemStackCount);
		}
		if (CLAFNDLGDAO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CLAFNDLGDAO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HJLOOCHLBCL other)
	{
		if (other != null)
		{
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.ItemStackCount != 0)
			{
				ItemStackCount = other.ItemStackCount;
			}
			if (other.CLAFNDLGDAO != 0)
			{
				CLAFNDLGDAO = other.CLAFNDLGDAO;
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
			case 48u:
				ItemId = input.ReadUInt32();
				break;
			case 64u:
				ItemStackCount = input.ReadUInt32();
				break;
			case 80u:
				CLAFNDLGDAO = input.ReadUInt32();
				break;
			}
		}
	}
}
