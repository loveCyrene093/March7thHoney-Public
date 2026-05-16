using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyMoveCsReq : IMessage<MonopolyMoveCsReq>, IMessage, IEquatable<MonopolyMoveCsReq>, IDeepCloneable<MonopolyMoveCsReq>, IBufferMessage
{
	private static readonly MessageParser<MonopolyMoveCsReq> _parser = new MessageParser<MonopolyMoveCsReq>(() => new MonopolyMoveCsReq());

	private UnknownFieldSet _unknownFields;

	public const int HCOHILBALGGFieldNumber = 7;

	private uint hCOHILBALGG_;

	public const int IFKLEGCLPEEFieldNumber = 9;

	private uint iFKLEGCLPEE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyMoveCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyMoveCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCOHILBALGG
	{
		get
		{
			return hCOHILBALGG_;
		}
		set
		{
			hCOHILBALGG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IFKLEGCLPEE
	{
		get
		{
			return iFKLEGCLPEE_;
		}
		set
		{
			iFKLEGCLPEE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyMoveCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyMoveCsReq(MonopolyMoveCsReq other)
		: this()
	{
		hCOHILBALGG_ = other.hCOHILBALGG_;
		iFKLEGCLPEE_ = other.iFKLEGCLPEE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyMoveCsReq Clone()
	{
		return new MonopolyMoveCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyMoveCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyMoveCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HCOHILBALGG != other.HCOHILBALGG)
		{
			return false;
		}
		if (IFKLEGCLPEE != other.IFKLEGCLPEE)
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
		if (HCOHILBALGG != 0)
		{
			num ^= HCOHILBALGG.GetHashCode();
		}
		if (IFKLEGCLPEE != 0)
		{
			num ^= IFKLEGCLPEE.GetHashCode();
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
		if (HCOHILBALGG != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(HCOHILBALGG);
		}
		if (IFKLEGCLPEE != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(IFKLEGCLPEE);
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
		if (HCOHILBALGG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCOHILBALGG);
		}
		if (IFKLEGCLPEE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IFKLEGCLPEE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyMoveCsReq other)
	{
		if (other != null)
		{
			if (other.HCOHILBALGG != 0)
			{
				HCOHILBALGG = other.HCOHILBALGG;
			}
			if (other.IFKLEGCLPEE != 0)
			{
				IFKLEGCLPEE = other.IFKLEGCLPEE;
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
			case 56u:
				HCOHILBALGG = input.ReadUInt32();
				break;
			case 72u:
				IFKLEGCLPEE = input.ReadUInt32();
				break;
			}
		}
	}
}
