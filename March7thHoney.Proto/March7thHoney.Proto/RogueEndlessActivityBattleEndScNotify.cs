using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueEndlessActivityBattleEndScNotify : IMessage<RogueEndlessActivityBattleEndScNotify>, IMessage, IEquatable<RogueEndlessActivityBattleEndScNotify>, IDeepCloneable<RogueEndlessActivityBattleEndScNotify>, IBufferMessage
{
	private static readonly MessageParser<RogueEndlessActivityBattleEndScNotify> _parser = new MessageParser<RogueEndlessActivityBattleEndScNotify>(() => new RogueEndlessActivityBattleEndScNotify());

	private UnknownFieldSet _unknownFields;

	public const int BNOCEPKMPGKFieldNumber = 1;

	private DGDHBAGEOOI bNOCEPKMPGK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueEndlessActivityBattleEndScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueEndlessActivityBattleEndScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGDHBAGEOOI BNOCEPKMPGK
	{
		get
		{
			return bNOCEPKMPGK_;
		}
		set
		{
			bNOCEPKMPGK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueEndlessActivityBattleEndScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueEndlessActivityBattleEndScNotify(RogueEndlessActivityBattleEndScNotify other)
		: this()
	{
		bNOCEPKMPGK_ = ((other.bNOCEPKMPGK_ != null) ? other.bNOCEPKMPGK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueEndlessActivityBattleEndScNotify Clone()
	{
		return new RogueEndlessActivityBattleEndScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueEndlessActivityBattleEndScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueEndlessActivityBattleEndScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BNOCEPKMPGK, other.BNOCEPKMPGK))
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
		if (bNOCEPKMPGK_ != null)
		{
			num ^= BNOCEPKMPGK.GetHashCode();
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
		if (bNOCEPKMPGK_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(BNOCEPKMPGK);
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
		if (bNOCEPKMPGK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BNOCEPKMPGK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueEndlessActivityBattleEndScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bNOCEPKMPGK_ != null)
		{
			if (bNOCEPKMPGK_ == null)
			{
				BNOCEPKMPGK = new DGDHBAGEOOI();
			}
			BNOCEPKMPGK.MergeFrom(other.BNOCEPKMPGK);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (bNOCEPKMPGK_ == null)
			{
				BNOCEPKMPGK = new DGDHBAGEOOI();
			}
			input.ReadMessage(BNOCEPKMPGK);
		}
	}
}
