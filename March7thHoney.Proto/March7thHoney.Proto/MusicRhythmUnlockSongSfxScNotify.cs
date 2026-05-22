using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MusicRhythmUnlockSongSfxScNotify : IMessage<MusicRhythmUnlockSongSfxScNotify>, IMessage, IEquatable<MusicRhythmUnlockSongSfxScNotify>, IDeepCloneable<MusicRhythmUnlockSongSfxScNotify>, IBufferMessage
{
	private static readonly MessageParser<MusicRhythmUnlockSongSfxScNotify> _parser = new MessageParser<MusicRhythmUnlockSongSfxScNotify>(() => new MusicRhythmUnlockSongSfxScNotify());

	private UnknownFieldSet _unknownFields;

	public const int MPMCJPMMDMCFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_mPMCJPMMDMC_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> mPMCJPMMDMC_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MusicRhythmUnlockSongSfxScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MusicRhythmUnlockSongSfxScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MPMCJPMMDMC => mPMCJPMMDMC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmUnlockSongSfxScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmUnlockSongSfxScNotify(MusicRhythmUnlockSongSfxScNotify other)
		: this()
	{
		mPMCJPMMDMC_ = other.mPMCJPMMDMC_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmUnlockSongSfxScNotify Clone()
	{
		return new MusicRhythmUnlockSongSfxScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MusicRhythmUnlockSongSfxScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MusicRhythmUnlockSongSfxScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mPMCJPMMDMC_.Equals(other.mPMCJPMMDMC_))
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
		num ^= mPMCJPMMDMC_.GetHashCode();
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
		mPMCJPMMDMC_.WriteTo(ref output, _repeated_mPMCJPMMDMC_codec);
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
		num += mPMCJPMMDMC_.CalculateSize(_repeated_mPMCJPMMDMC_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MusicRhythmUnlockSongSfxScNotify other)
	{
		if (other != null)
		{
			mPMCJPMMDMC_.Add(other.mPMCJPMMDMC_);
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
			if (num != 16 && num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				mPMCJPMMDMC_.AddEntriesFrom(ref input, _repeated_mPMCJPMMDMC_codec);
			}
		}
	}
}
