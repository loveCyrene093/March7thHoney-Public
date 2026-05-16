using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MusicRhythmUnlockTrackScNotify : IMessage<MusicRhythmUnlockTrackScNotify>, IMessage, IEquatable<MusicRhythmUnlockTrackScNotify>, IDeepCloneable<MusicRhythmUnlockTrackScNotify>, IBufferMessage
{
	private static readonly MessageParser<MusicRhythmUnlockTrackScNotify> _parser = new MessageParser<MusicRhythmUnlockTrackScNotify>(() => new MusicRhythmUnlockTrackScNotify());

	private UnknownFieldSet _unknownFields;

	public const int MMKNEGDACBOFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_mMKNEGDACBO_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> mMKNEGDACBO_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MusicRhythmUnlockTrackScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MusicRhythmUnlockTrackScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MMKNEGDACBO => mMKNEGDACBO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmUnlockTrackScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmUnlockTrackScNotify(MusicRhythmUnlockTrackScNotify other)
		: this()
	{
		mMKNEGDACBO_ = other.mMKNEGDACBO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmUnlockTrackScNotify Clone()
	{
		return new MusicRhythmUnlockTrackScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MusicRhythmUnlockTrackScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MusicRhythmUnlockTrackScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mMKNEGDACBO_.Equals(other.mMKNEGDACBO_))
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
		num ^= mMKNEGDACBO_.GetHashCode();
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
		mMKNEGDACBO_.WriteTo(ref output, _repeated_mMKNEGDACBO_codec);
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
		num += mMKNEGDACBO_.CalculateSize(_repeated_mMKNEGDACBO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MusicRhythmUnlockTrackScNotify other)
	{
		if (other != null)
		{
			mMKNEGDACBO_.Add(other.mMKNEGDACBO_);
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
			if (num != 56 && num != 58)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				mMKNEGDACBO_.AddEntriesFrom(ref input, _repeated_mMKNEGDACBO_codec);
			}
		}
	}
}
