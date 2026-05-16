using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesBingoGameFlipCardCsReq : IMessage<PlanetFesBingoGameFlipCardCsReq>, IMessage, IEquatable<PlanetFesBingoGameFlipCardCsReq>, IDeepCloneable<PlanetFesBingoGameFlipCardCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesBingoGameFlipCardCsReq> _parser = new MessageParser<PlanetFesBingoGameFlipCardCsReq>(() => new PlanetFesBingoGameFlipCardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NBFLCNHFEFMFieldNumber = 8;

	private uint nBFLCNHFEFM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesBingoGameFlipCardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesBingoGameFlipCardCsReqReflection.Descriptor.MessageTypes[0];

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
	public PlanetFesBingoGameFlipCardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesBingoGameFlipCardCsReq(PlanetFesBingoGameFlipCardCsReq other)
		: this()
	{
		nBFLCNHFEFM_ = other.nBFLCNHFEFM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesBingoGameFlipCardCsReq Clone()
	{
		return new PlanetFesBingoGameFlipCardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesBingoGameFlipCardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesBingoGameFlipCardCsReq other)
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
			output.WriteRawTag(64);
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
	public void MergeFrom(PlanetFesBingoGameFlipCardCsReq other)
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
			if (num != 64)
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
