using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PPPFOMBLOIF : IMessage<PPPFOMBLOIF>, IMessage, IEquatable<PPPFOMBLOIF>, IDeepCloneable<PPPFOMBLOIF>, IBufferMessage
{
	private static readonly MessageParser<PPPFOMBLOIF> _parser = new MessageParser<PPPFOMBLOIF>(() => new PPPFOMBLOIF());

	private UnknownFieldSet _unknownFields;

	public const int IndexFieldNumber = 5;

	private uint index_;

	public const int StatusFieldNumber = 7;

	private BNDHJNDFFED status_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PPPFOMBLOIF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PPPFOMBLOIFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Index
	{
		get
		{
			return index_;
		}
		set
		{
			index_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNDHJNDFFED Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPPFOMBLOIF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPPFOMBLOIF(PPPFOMBLOIF other)
		: this()
	{
		index_ = other.index_;
		status_ = other.status_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPPFOMBLOIF Clone()
	{
		return new PPPFOMBLOIF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PPPFOMBLOIF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PPPFOMBLOIF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Index != other.Index)
		{
			return false;
		}
		if (Status != other.Status)
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
		if (Index != 0)
		{
			num ^= Index.GetHashCode();
		}
		if (Status != BNDHJNDFFED.Bhpnpohcgla)
		{
			num ^= Status.GetHashCode();
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
		if (Index != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Index);
		}
		if (Status != BNDHJNDFFED.Bhpnpohcgla)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)Status);
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
		if (Index != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Index);
		}
		if (Status != BNDHJNDFFED.Bhpnpohcgla)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PPPFOMBLOIF other)
	{
		if (other != null)
		{
			if (other.Index != 0)
			{
				Index = other.Index;
			}
			if (other.Status != BNDHJNDFFED.Bhpnpohcgla)
			{
				Status = other.Status;
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
			case 40u:
				Index = input.ReadUInt32();
				break;
			case 56u:
				Status = (BNDHJNDFFED)input.ReadEnum();
				break;
			}
		}
	}
}
