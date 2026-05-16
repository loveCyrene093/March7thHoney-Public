using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TarotBookFinishInteractionCsReq : IMessage<TarotBookFinishInteractionCsReq>, IMessage, IEquatable<TarotBookFinishInteractionCsReq>, IDeepCloneable<TarotBookFinishInteractionCsReq>, IBufferMessage
{
	private static readonly MessageParser<TarotBookFinishInteractionCsReq> _parser = new MessageParser<TarotBookFinishInteractionCsReq>(() => new TarotBookFinishInteractionCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NGEIJBMCPNAFieldNumber = 15;

	private uint nGEIJBMCPNA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TarotBookFinishInteractionCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TarotBookFinishInteractionCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NGEIJBMCPNA
	{
		get
		{
			return nGEIJBMCPNA_;
		}
		set
		{
			nGEIJBMCPNA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookFinishInteractionCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookFinishInteractionCsReq(TarotBookFinishInteractionCsReq other)
		: this()
	{
		nGEIJBMCPNA_ = other.nGEIJBMCPNA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookFinishInteractionCsReq Clone()
	{
		return new TarotBookFinishInteractionCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TarotBookFinishInteractionCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TarotBookFinishInteractionCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NGEIJBMCPNA != other.NGEIJBMCPNA)
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
		if (NGEIJBMCPNA != 0)
		{
			num ^= NGEIJBMCPNA.GetHashCode();
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
		if (NGEIJBMCPNA != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(NGEIJBMCPNA);
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
		if (NGEIJBMCPNA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NGEIJBMCPNA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TarotBookFinishInteractionCsReq other)
	{
		if (other != null)
		{
			if (other.NGEIJBMCPNA != 0)
			{
				NGEIJBMCPNA = other.NGEIJBMCPNA;
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
				NGEIJBMCPNA = input.ReadUInt32();
			}
		}
	}
}
