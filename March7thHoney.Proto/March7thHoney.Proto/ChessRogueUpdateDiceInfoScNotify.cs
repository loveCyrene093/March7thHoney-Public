using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueUpdateDiceInfoScNotify : IMessage<ChessRogueUpdateDiceInfoScNotify>, IMessage, IEquatable<ChessRogueUpdateDiceInfoScNotify>, IDeepCloneable<ChessRogueUpdateDiceInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueUpdateDiceInfoScNotify> _parser = new MessageParser<ChessRogueUpdateDiceInfoScNotify>(() => new ChessRogueUpdateDiceInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int PJABKDBFPIMFieldNumber = 1;

	private DFAOIALEBOH pJABKDBFPIM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueUpdateDiceInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueUpdateDiceInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFAOIALEBOH PJABKDBFPIM
	{
		get
		{
			return pJABKDBFPIM_;
		}
		set
		{
			pJABKDBFPIM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateDiceInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateDiceInfoScNotify(ChessRogueUpdateDiceInfoScNotify other)
		: this()
	{
		pJABKDBFPIM_ = ((other.pJABKDBFPIM_ != null) ? other.pJABKDBFPIM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateDiceInfoScNotify Clone()
	{
		return new ChessRogueUpdateDiceInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueUpdateDiceInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueUpdateDiceInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PJABKDBFPIM, other.PJABKDBFPIM))
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
		if (pJABKDBFPIM_ != null)
		{
			num ^= PJABKDBFPIM.GetHashCode();
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
		if (pJABKDBFPIM_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(PJABKDBFPIM);
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
		if (pJABKDBFPIM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PJABKDBFPIM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueUpdateDiceInfoScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pJABKDBFPIM_ != null)
		{
			if (pJABKDBFPIM_ == null)
			{
				PJABKDBFPIM = new DFAOIALEBOH();
			}
			PJABKDBFPIM.MergeFrom(other.PJABKDBFPIM);
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
			if (pJABKDBFPIM_ == null)
			{
				PJABKDBFPIM = new DFAOIALEBOH();
			}
			input.ReadMessage(PJABKDBFPIM);
		}
	}
}
