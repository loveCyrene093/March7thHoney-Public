using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueUpdateDicePassiveAccumulateValueScNotify : IMessage<ChessRogueUpdateDicePassiveAccumulateValueScNotify>, IMessage, IEquatable<ChessRogueUpdateDicePassiveAccumulateValueScNotify>, IDeepCloneable<ChessRogueUpdateDicePassiveAccumulateValueScNotify>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueUpdateDicePassiveAccumulateValueScNotify> _parser = new MessageParser<ChessRogueUpdateDicePassiveAccumulateValueScNotify>(() => new ChessRogueUpdateDicePassiveAccumulateValueScNotify());

	private UnknownFieldSet _unknownFields;

	public const int LBLLFABKGGLFieldNumber = 12;

	private int lBLLFABKGGL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueUpdateDicePassiveAccumulateValueScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueUpdateDicePassiveAccumulateValueScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LBLLFABKGGL
	{
		get
		{
			return lBLLFABKGGL_;
		}
		set
		{
			lBLLFABKGGL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateDicePassiveAccumulateValueScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateDicePassiveAccumulateValueScNotify(ChessRogueUpdateDicePassiveAccumulateValueScNotify other)
		: this()
	{
		lBLLFABKGGL_ = other.lBLLFABKGGL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueUpdateDicePassiveAccumulateValueScNotify Clone()
	{
		return new ChessRogueUpdateDicePassiveAccumulateValueScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueUpdateDicePassiveAccumulateValueScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueUpdateDicePassiveAccumulateValueScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LBLLFABKGGL != other.LBLLFABKGGL)
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
		if (LBLLFABKGGL != 0)
		{
			num ^= LBLLFABKGGL.GetHashCode();
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
		if (LBLLFABKGGL != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(LBLLFABKGGL);
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
		if (LBLLFABKGGL != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LBLLFABKGGL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueUpdateDicePassiveAccumulateValueScNotify other)
	{
		if (other != null)
		{
			if (other.LBLLFABKGGL != 0)
			{
				LBLLFABKGGL = other.LBLLFABKGGL;
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
			if (num != 96)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				LBLLFABKGGL = input.ReadInt32();
			}
		}
	}
}
