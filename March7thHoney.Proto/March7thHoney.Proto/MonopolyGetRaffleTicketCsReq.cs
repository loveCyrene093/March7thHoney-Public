using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyGetRaffleTicketCsReq : IMessage<MonopolyGetRaffleTicketCsReq>, IMessage, IEquatable<MonopolyGetRaffleTicketCsReq>, IDeepCloneable<MonopolyGetRaffleTicketCsReq>, IBufferMessage
{
	private static readonly MessageParser<MonopolyGetRaffleTicketCsReq> _parser = new MessageParser<MonopolyGetRaffleTicketCsReq>(() => new MonopolyGetRaffleTicketCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MBMICCJEBJBFieldNumber = 4;

	private uint mBMICCJEBJB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyGetRaffleTicketCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyGetRaffleTicketCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MBMICCJEBJB
	{
		get
		{
			return mBMICCJEBJB_;
		}
		set
		{
			mBMICCJEBJB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGetRaffleTicketCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGetRaffleTicketCsReq(MonopolyGetRaffleTicketCsReq other)
		: this()
	{
		mBMICCJEBJB_ = other.mBMICCJEBJB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGetRaffleTicketCsReq Clone()
	{
		return new MonopolyGetRaffleTicketCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyGetRaffleTicketCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyGetRaffleTicketCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MBMICCJEBJB != other.MBMICCJEBJB)
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
		if (MBMICCJEBJB != 0)
		{
			num ^= MBMICCJEBJB.GetHashCode();
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
		if (MBMICCJEBJB != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MBMICCJEBJB);
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
		if (MBMICCJEBJB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MBMICCJEBJB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyGetRaffleTicketCsReq other)
	{
		if (other != null)
		{
			if (other.MBMICCJEBJB != 0)
			{
				MBMICCJEBJB = other.MBMICCJEBJB;
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
			if (num != 32)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				MBMICCJEBJB = input.ReadUInt32();
			}
		}
	}
}
