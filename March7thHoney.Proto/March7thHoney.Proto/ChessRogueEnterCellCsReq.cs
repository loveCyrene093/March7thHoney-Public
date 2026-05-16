using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueEnterCellCsReq : IMessage<ChessRogueEnterCellCsReq>, IMessage, IEquatable<ChessRogueEnterCellCsReq>, IDeepCloneable<ChessRogueEnterCellCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueEnterCellCsReq> _parser = new MessageParser<ChessRogueEnterCellCsReq>(() => new ChessRogueEnterCellCsReq());

	private UnknownFieldSet _unknownFields;

	public const int EIIAGABAFECFieldNumber = 9;

	private uint eIIAGABAFEC_;

	public const int JNLNMHOOEKLFieldNumber = 15;

	private uint jNLNMHOOEKL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueEnterCellCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueEnterCellCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EIIAGABAFEC
	{
		get
		{
			return eIIAGABAFEC_;
		}
		set
		{
			eIIAGABAFEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JNLNMHOOEKL
	{
		get
		{
			return jNLNMHOOEKL_;
		}
		set
		{
			jNLNMHOOEKL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueEnterCellCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueEnterCellCsReq(ChessRogueEnterCellCsReq other)
		: this()
	{
		eIIAGABAFEC_ = other.eIIAGABAFEC_;
		jNLNMHOOEKL_ = other.jNLNMHOOEKL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueEnterCellCsReq Clone()
	{
		return new ChessRogueEnterCellCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueEnterCellCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueEnterCellCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EIIAGABAFEC != other.EIIAGABAFEC)
		{
			return false;
		}
		if (JNLNMHOOEKL != other.JNLNMHOOEKL)
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
		if (EIIAGABAFEC != 0)
		{
			num ^= EIIAGABAFEC.GetHashCode();
		}
		if (JNLNMHOOEKL != 0)
		{
			num ^= JNLNMHOOEKL.GetHashCode();
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
		if (EIIAGABAFEC != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(EIIAGABAFEC);
		}
		if (JNLNMHOOEKL != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(JNLNMHOOEKL);
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
		if (EIIAGABAFEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EIIAGABAFEC);
		}
		if (JNLNMHOOEKL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JNLNMHOOEKL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueEnterCellCsReq other)
	{
		if (other != null)
		{
			if (other.EIIAGABAFEC != 0)
			{
				EIIAGABAFEC = other.EIIAGABAFEC;
			}
			if (other.JNLNMHOOEKL != 0)
			{
				JNLNMHOOEKL = other.JNLNMHOOEKL;
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
			case 72u:
				EIIAGABAFEC = input.ReadUInt32();
				break;
			case 120u:
				JNLNMHOOEKL = input.ReadUInt32();
				break;
			}
		}
	}
}
