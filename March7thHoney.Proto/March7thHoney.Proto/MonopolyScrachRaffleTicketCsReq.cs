using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyScrachRaffleTicketCsReq : IMessage<MonopolyScrachRaffleTicketCsReq>, IMessage, IEquatable<MonopolyScrachRaffleTicketCsReq>, IDeepCloneable<MonopolyScrachRaffleTicketCsReq>, IBufferMessage
{
	private static readonly MessageParser<MonopolyScrachRaffleTicketCsReq> _parser = new MessageParser<MonopolyScrachRaffleTicketCsReq>(() => new MonopolyScrachRaffleTicketCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MBMICCJEBJBFieldNumber = 4;

	private uint mBMICCJEBJB_;

	public const int CBOMHCDNEDGFieldNumber = 10;

	private ulong cBOMHCDNEDG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyScrachRaffleTicketCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyScrachRaffleTicketCsReqReflection.Descriptor.MessageTypes[0];

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
	public ulong CBOMHCDNEDG
	{
		get
		{
			return cBOMHCDNEDG_;
		}
		set
		{
			cBOMHCDNEDG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyScrachRaffleTicketCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyScrachRaffleTicketCsReq(MonopolyScrachRaffleTicketCsReq other)
		: this()
	{
		mBMICCJEBJB_ = other.mBMICCJEBJB_;
		cBOMHCDNEDG_ = other.cBOMHCDNEDG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyScrachRaffleTicketCsReq Clone()
	{
		return new MonopolyScrachRaffleTicketCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyScrachRaffleTicketCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyScrachRaffleTicketCsReq other)
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
		if (CBOMHCDNEDG != other.CBOMHCDNEDG)
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
		if (CBOMHCDNEDG != 0L)
		{
			num ^= CBOMHCDNEDG.GetHashCode();
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
		if (CBOMHCDNEDG != 0L)
		{
			output.WriteRawTag(80);
			output.WriteUInt64(CBOMHCDNEDG);
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
		if (CBOMHCDNEDG != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(CBOMHCDNEDG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyScrachRaffleTicketCsReq other)
	{
		if (other != null)
		{
			if (other.MBMICCJEBJB != 0)
			{
				MBMICCJEBJB = other.MBMICCJEBJB;
			}
			if (other.CBOMHCDNEDG != 0L)
			{
				CBOMHCDNEDG = other.CBOMHCDNEDG;
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
				MBMICCJEBJB = input.ReadUInt32();
				break;
			case 80u:
				CBOMHCDNEDG = input.ReadUInt64();
				break;
			}
		}
	}
}
