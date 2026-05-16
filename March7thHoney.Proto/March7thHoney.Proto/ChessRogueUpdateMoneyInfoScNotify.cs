using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueUpdateMoneyInfoScNotify : IMessage<ChessRogueUpdateMoneyInfoScNotify>, IMessage, IEquatable<ChessRogueUpdateMoneyInfoScNotify>, IDeepCloneable<ChessRogueUpdateMoneyInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueUpdateMoneyInfoScNotify> _parser = new MessageParser<ChessRogueUpdateMoneyInfoScNotify>(() => new ChessRogueUpdateMoneyInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int CGIFJAOHHAOFieldNumber = 5;

	private EJDFGNGBNOO cGIFJAOHHAO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueUpdateMoneyInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueUpdateMoneyInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EJDFGNGBNOO CGIFJAOHHAO
	{
		get
		{
			return cGIFJAOHHAO_;
		}
		set
		{
			cGIFJAOHHAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateMoneyInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateMoneyInfoScNotify(ChessRogueUpdateMoneyInfoScNotify other)
		: this()
	{
		cGIFJAOHHAO_ = ((other.cGIFJAOHHAO_ != null) ? other.cGIFJAOHHAO_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateMoneyInfoScNotify Clone()
	{
		return new ChessRogueUpdateMoneyInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueUpdateMoneyInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueUpdateMoneyInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CGIFJAOHHAO, other.CGIFJAOHHAO))
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
		if (cGIFJAOHHAO_ != null)
		{
			num ^= CGIFJAOHHAO.GetHashCode();
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
		if (cGIFJAOHHAO_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(CGIFJAOHHAO);
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
		if (cGIFJAOHHAO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CGIFJAOHHAO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueUpdateMoneyInfoScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.cGIFJAOHHAO_ != null)
		{
			if (cGIFJAOHHAO_ == null)
			{
				CGIFJAOHHAO = new EJDFGNGBNOO();
			}
			CGIFJAOHHAO.MergeFrom(other.CGIFJAOHHAO);
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
			if (cGIFJAOHHAO_ == null)
			{
				CGIFJAOHHAO = new EJDFGNGBNOO();
			}
			input.ReadMessage(CGIFJAOHHAO);
		}
	}
}
