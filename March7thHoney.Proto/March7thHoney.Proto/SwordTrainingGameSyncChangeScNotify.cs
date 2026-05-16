using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SwordTrainingGameSyncChangeScNotify : IMessage<SwordTrainingGameSyncChangeScNotify>, IMessage, IEquatable<SwordTrainingGameSyncChangeScNotify>, IDeepCloneable<SwordTrainingGameSyncChangeScNotify>, IBufferMessage
{
	private static readonly MessageParser<SwordTrainingGameSyncChangeScNotify> _parser = new MessageParser<SwordTrainingGameSyncChangeScNotify>(() => new SwordTrainingGameSyncChangeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int CJFBLHNPHAKFieldNumber = 7;

	private static readonly FieldCodec<AOOLDKDFOBO> _repeated_cJFBLHNPHAK_codec = FieldCodec.ForMessage(58u, AOOLDKDFOBO.Parser);

	private readonly RepeatedField<AOOLDKDFOBO> cJFBLHNPHAK_ = new RepeatedField<AOOLDKDFOBO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SwordTrainingGameSyncChangeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SwordTrainingGameSyncChangeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AOOLDKDFOBO> CJFBLHNPHAK => cJFBLHNPHAK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingGameSyncChangeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingGameSyncChangeScNotify(SwordTrainingGameSyncChangeScNotify other)
		: this()
	{
		cJFBLHNPHAK_ = other.cJFBLHNPHAK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingGameSyncChangeScNotify Clone()
	{
		return new SwordTrainingGameSyncChangeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SwordTrainingGameSyncChangeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SwordTrainingGameSyncChangeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cJFBLHNPHAK_.Equals(other.cJFBLHNPHAK_))
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
		num ^= cJFBLHNPHAK_.GetHashCode();
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
		cJFBLHNPHAK_.WriteTo(ref output, _repeated_cJFBLHNPHAK_codec);
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
		num += cJFBLHNPHAK_.CalculateSize(_repeated_cJFBLHNPHAK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SwordTrainingGameSyncChangeScNotify other)
	{
		if (other != null)
		{
			cJFBLHNPHAK_.Add(other.cJFBLHNPHAK_);
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
			if (num != 58)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				cJFBLHNPHAK_.AddEntriesFrom(ref input, _repeated_cJFBLHNPHAK_codec);
			}
		}
	}
}
