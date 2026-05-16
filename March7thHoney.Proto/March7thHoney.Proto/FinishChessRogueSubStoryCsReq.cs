using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FinishChessRogueSubStoryCsReq : IMessage<FinishChessRogueSubStoryCsReq>, IMessage, IEquatable<FinishChessRogueSubStoryCsReq>, IDeepCloneable<FinishChessRogueSubStoryCsReq>, IBufferMessage
{
	private static readonly MessageParser<FinishChessRogueSubStoryCsReq> _parser = new MessageParser<FinishChessRogueSubStoryCsReq>(() => new FinishChessRogueSubStoryCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IENBKIAGPBAFieldNumber = 15;

	private uint iENBKIAGPBA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FinishChessRogueSubStoryCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FinishChessRogueSubStoryCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IENBKIAGPBA
	{
		get
		{
			return iENBKIAGPBA_;
		}
		set
		{
			iENBKIAGPBA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishChessRogueSubStoryCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishChessRogueSubStoryCsReq(FinishChessRogueSubStoryCsReq other)
		: this()
	{
		iENBKIAGPBA_ = other.iENBKIAGPBA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishChessRogueSubStoryCsReq Clone()
	{
		return new FinishChessRogueSubStoryCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FinishChessRogueSubStoryCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FinishChessRogueSubStoryCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IENBKIAGPBA != other.IENBKIAGPBA)
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
		if (IENBKIAGPBA != 0)
		{
			num ^= IENBKIAGPBA.GetHashCode();
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
		if (IENBKIAGPBA != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(IENBKIAGPBA);
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
		if (IENBKIAGPBA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IENBKIAGPBA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FinishChessRogueSubStoryCsReq other)
	{
		if (other != null)
		{
			if (other.IENBKIAGPBA != 0)
			{
				IENBKIAGPBA = other.IENBKIAGPBA;
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
			if (num != 120)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				IENBKIAGPBA = input.ReadUInt32();
			}
		}
	}
}
