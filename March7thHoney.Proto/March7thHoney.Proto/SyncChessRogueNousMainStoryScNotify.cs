using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncChessRogueNousMainStoryScNotify : IMessage<SyncChessRogueNousMainStoryScNotify>, IMessage, IEquatable<SyncChessRogueNousMainStoryScNotify>, IDeepCloneable<SyncChessRogueNousMainStoryScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncChessRogueNousMainStoryScNotify> _parser = new MessageParser<SyncChessRogueNousMainStoryScNotify>(() => new SyncChessRogueNousMainStoryScNotify());

	private UnknownFieldSet _unknownFields;

	public const int OLHNBEPHHFGFieldNumber = 10;

	private static readonly FieldCodec<CACLDCAFCKH> _repeated_oLHNBEPHHFG_codec = FieldCodec.ForMessage(82u, CACLDCAFCKH.Parser);

	private readonly RepeatedField<CACLDCAFCKH> oLHNBEPHHFG_ = new RepeatedField<CACLDCAFCKH>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncChessRogueNousMainStoryScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncChessRogueNousMainStoryScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CACLDCAFCKH> OLHNBEPHHFG => oLHNBEPHHFG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncChessRogueNousMainStoryScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncChessRogueNousMainStoryScNotify(SyncChessRogueNousMainStoryScNotify other)
		: this()
	{
		oLHNBEPHHFG_ = other.oLHNBEPHHFG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncChessRogueNousMainStoryScNotify Clone()
	{
		return new SyncChessRogueNousMainStoryScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncChessRogueNousMainStoryScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncChessRogueNousMainStoryScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!oLHNBEPHHFG_.Equals(other.oLHNBEPHHFG_))
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
		num ^= oLHNBEPHHFG_.GetHashCode();
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
		oLHNBEPHHFG_.WriteTo(ref output, _repeated_oLHNBEPHHFG_codec);
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
		num += oLHNBEPHHFG_.CalculateSize(_repeated_oLHNBEPHHFG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncChessRogueNousMainStoryScNotify other)
	{
		if (other != null)
		{
			oLHNBEPHHFG_.Add(other.oLHNBEPHHFG_);
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
			if (num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				oLHNBEPHHFG_.AddEntriesFrom(ref input, _repeated_oLHNBEPHHFG_codec);
			}
		}
	}
}
