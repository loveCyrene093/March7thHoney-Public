using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JNMOPCFJDPD : IMessage<JNMOPCFJDPD>, IMessage, IEquatable<JNMOPCFJDPD>, IDeepCloneable<JNMOPCFJDPD>, IBufferMessage
{
	private static readonly MessageParser<JNMOPCFJDPD> _parser = new MessageParser<JNMOPCFJDPD>(() => new JNMOPCFJDPD());

	private UnknownFieldSet _unknownFields;

	public const int ItemIdFieldNumber = 2;

	private uint itemId_;

	public const int CLAFNDLGDAOFieldNumber = 3;

	private uint cLAFNDLGDAO_;

	public const int ItemStackCountFieldNumber = 7;

	private uint itemStackCount_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JNMOPCFJDPD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JNMOPCFJDPDReflection.Descriptor.MessageTypes[0];

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
	public JNMOPCFJDPD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNMOPCFJDPD(JNMOPCFJDPD other)
		: this()
	{
		itemId_ = other.itemId_;
		cLAFNDLGDAO_ = other.cLAFNDLGDAO_;
		itemStackCount_ = other.itemStackCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNMOPCFJDPD Clone()
	{
		return new JNMOPCFJDPD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JNMOPCFJDPD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JNMOPCFJDPD other)
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
		if (CLAFNDLGDAO != other.CLAFNDLGDAO)
		{
			return false;
		}
		if (ItemStackCount != other.ItemStackCount)
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
		if (CLAFNDLGDAO != 0)
		{
			num ^= CLAFNDLGDAO.GetHashCode();
		}
		if (ItemStackCount != 0)
		{
			num ^= ItemStackCount.GetHashCode();
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
			output.WriteRawTag(16);
			output.WriteUInt32(ItemId);
		}
		if (CLAFNDLGDAO != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(CLAFNDLGDAO);
		}
		if (ItemStackCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ItemStackCount);
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
		if (CLAFNDLGDAO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CLAFNDLGDAO);
		}
		if (ItemStackCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemStackCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JNMOPCFJDPD other)
	{
		if (other != null)
		{
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.CLAFNDLGDAO != 0)
			{
				CLAFNDLGDAO = other.CLAFNDLGDAO;
			}
			if (other.ItemStackCount != 0)
			{
				ItemStackCount = other.ItemStackCount;
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
				ItemId = input.ReadUInt32();
				break;
			case 24u:
				CLAFNDLGDAO = input.ReadUInt32();
				break;
			case 56u:
				ItemStackCount = input.ReadUInt32();
				break;
			}
		}
	}
}
