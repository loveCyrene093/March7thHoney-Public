using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyGameBingoFlipCardCsReq : IMessage<MonopolyGameBingoFlipCardCsReq>, IMessage, IEquatable<MonopolyGameBingoFlipCardCsReq>, IDeepCloneable<MonopolyGameBingoFlipCardCsReq>, IBufferMessage
{
	private static readonly MessageParser<MonopolyGameBingoFlipCardCsReq> _parser = new MessageParser<MonopolyGameBingoFlipCardCsReq>(() => new MonopolyGameBingoFlipCardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NBFLCNHFEFMFieldNumber = 10;

	private uint nBFLCNHFEFM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyGameBingoFlipCardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyGameBingoFlipCardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NBFLCNHFEFM
	{
		get
		{
			return nBFLCNHFEFM_;
		}
		set
		{
			nBFLCNHFEFM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGameBingoFlipCardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGameBingoFlipCardCsReq(MonopolyGameBingoFlipCardCsReq other)
		: this()
	{
		nBFLCNHFEFM_ = other.nBFLCNHFEFM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyGameBingoFlipCardCsReq Clone()
	{
		return new MonopolyGameBingoFlipCardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyGameBingoFlipCardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyGameBingoFlipCardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NBFLCNHFEFM != other.NBFLCNHFEFM)
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
		if (NBFLCNHFEFM != 0)
		{
			num ^= NBFLCNHFEFM.GetHashCode();
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
		if (NBFLCNHFEFM != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(NBFLCNHFEFM);
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
		if (NBFLCNHFEFM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NBFLCNHFEFM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyGameBingoFlipCardCsReq other)
	{
		if (other != null)
		{
			if (other.NBFLCNHFEFM != 0)
			{
				NBFLCNHFEFM = other.NBFLCNHFEFM;
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
			if (num != 80)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				NBFLCNHFEFM = input.ReadUInt32();
			}
		}
	}
}
