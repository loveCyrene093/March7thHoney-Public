using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AHFAFHPLJLA : IMessage<AHFAFHPLJLA>, IMessage, IEquatable<AHFAFHPLJLA>, IDeepCloneable<AHFAFHPLJLA>, IBufferMessage
{
	private static readonly MessageParser<AHFAFHPLJLA> _parser = new MessageParser<AHFAFHPLJLA>(() => new AHFAFHPLJLA());

	private UnknownFieldSet _unknownFields;

	public const int ItemStackCountFieldNumber = 11;

	private uint itemStackCount_;

	public const int CLAFNDLGDAOFieldNumber = 13;

	private uint cLAFNDLGDAO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AHFAFHPLJLA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AHFAFHPLJLAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public AHFAFHPLJLA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHFAFHPLJLA(AHFAFHPLJLA other)
		: this()
	{
		itemStackCount_ = other.itemStackCount_;
		cLAFNDLGDAO_ = other.cLAFNDLGDAO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHFAFHPLJLA Clone()
	{
		return new AHFAFHPLJLA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AHFAFHPLJLA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AHFAFHPLJLA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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
		if (ItemStackCount != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(ItemStackCount);
		}
		if (CLAFNDLGDAO != 0)
		{
			output.WriteRawTag(104);
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
	public void MergeFrom(AHFAFHPLJLA other)
	{
		if (other != null)
		{
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
			case 88u:
				ItemStackCount = input.ReadUInt32();
				break;
			case 104u:
				CLAFNDLGDAO = input.ReadUInt32();
				break;
			}
		}
	}
}
