using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueNousDiceUpdateNotify : IMessage<ChessRogueNousDiceUpdateNotify>, IMessage, IEquatable<ChessRogueNousDiceUpdateNotify>, IDeepCloneable<ChessRogueNousDiceUpdateNotify>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueNousDiceUpdateNotify> _parser = new MessageParser<ChessRogueNousDiceUpdateNotify>(() => new ChessRogueNousDiceUpdateNotify());

	private UnknownFieldSet _unknownFields;

	public const int NNKCOFOPNBNFieldNumber = 5;

	private GCIMMIHKPEI nNKCOFOPNBN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueNousDiceUpdateNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueNousDiceUpdateNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCIMMIHKPEI NNKCOFOPNBN
	{
		get
		{
			return nNKCOFOPNBN_;
		}
		set
		{
			nNKCOFOPNBN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueNousDiceUpdateNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueNousDiceUpdateNotify(ChessRogueNousDiceUpdateNotify other)
		: this()
	{
		nNKCOFOPNBN_ = ((other.nNKCOFOPNBN_ != null) ? other.nNKCOFOPNBN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueNousDiceUpdateNotify Clone()
	{
		return new ChessRogueNousDiceUpdateNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueNousDiceUpdateNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueNousDiceUpdateNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NNKCOFOPNBN, other.NNKCOFOPNBN))
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
		if (nNKCOFOPNBN_ != null)
		{
			num ^= NNKCOFOPNBN.GetHashCode();
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
		if (nNKCOFOPNBN_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(NNKCOFOPNBN);
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
		if (nNKCOFOPNBN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NNKCOFOPNBN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueNousDiceUpdateNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nNKCOFOPNBN_ != null)
		{
			if (nNKCOFOPNBN_ == null)
			{
				NNKCOFOPNBN = new GCIMMIHKPEI();
			}
			NNKCOFOPNBN.MergeFrom(other.NNKCOFOPNBN);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			if (num != 42)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (nNKCOFOPNBN_ == null)
			{
				NNKCOFOPNBN = new GCIMMIHKPEI();
			}
			input.ReadMessage(NNKCOFOPNBN);
		}
	}
}
