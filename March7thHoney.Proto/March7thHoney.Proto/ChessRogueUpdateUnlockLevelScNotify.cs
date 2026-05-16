using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueUpdateUnlockLevelScNotify : IMessage<ChessRogueUpdateUnlockLevelScNotify>, IMessage, IEquatable<ChessRogueUpdateUnlockLevelScNotify>, IDeepCloneable<ChessRogueUpdateUnlockLevelScNotify>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueUpdateUnlockLevelScNotify> _parser = new MessageParser<ChessRogueUpdateUnlockLevelScNotify>(() => new ChessRogueUpdateUnlockLevelScNotify());

	private UnknownFieldSet _unknownFields;

	public const int JHCMEALPDEBFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_jHCMEALPDEB_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> jHCMEALPDEB_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueUpdateUnlockLevelScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueUpdateUnlockLevelScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JHCMEALPDEB => jHCMEALPDEB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateUnlockLevelScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateUnlockLevelScNotify(ChessRogueUpdateUnlockLevelScNotify other)
		: this()
	{
		jHCMEALPDEB_ = other.jHCMEALPDEB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateUnlockLevelScNotify Clone()
	{
		return new ChessRogueUpdateUnlockLevelScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueUpdateUnlockLevelScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueUpdateUnlockLevelScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jHCMEALPDEB_.Equals(other.jHCMEALPDEB_))
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
		num ^= jHCMEALPDEB_.GetHashCode();
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
		jHCMEALPDEB_.WriteTo(ref output, _repeated_jHCMEALPDEB_codec);
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
		num += jHCMEALPDEB_.CalculateSize(_repeated_jHCMEALPDEB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueUpdateUnlockLevelScNotify other)
	{
		if (other != null)
		{
			jHCMEALPDEB_.Add(other.jHCMEALPDEB_);
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
			if (num != 72 && num != 74)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				jHCMEALPDEB_.AddEntriesFrom(ref input, _repeated_jHCMEALPDEB_codec);
			}
		}
	}
}
