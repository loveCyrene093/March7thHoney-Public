using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PPIHPDIPLLD : IMessage<PPIHPDIPLLD>, IMessage, IEquatable<PPIHPDIPLLD>, IDeepCloneable<PPIHPDIPLLD>, IBufferMessage
{
	private static readonly MessageParser<PPIHPDIPLLD> _parser = new MessageParser<PPIHPDIPLLD>(() => new PPIHPDIPLLD());

	private UnknownFieldSet _unknownFields;

	public const int FOEKDMEALKFFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_fOEKDMEALKF_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> fOEKDMEALKF_ = new RepeatedField<uint>();

	public const int GameStoryLineIdFieldNumber = 11;

	private uint gameStoryLineId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PPIHPDIPLLD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PPIHPDIPLLDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FOEKDMEALKF => fOEKDMEALKF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GameStoryLineId
	{
		get
		{
			return gameStoryLineId_;
		}
		set
		{
			gameStoryLineId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPIHPDIPLLD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPIHPDIPLLD(PPIHPDIPLLD other)
		: this()
	{
		fOEKDMEALKF_ = other.fOEKDMEALKF_.Clone();
		gameStoryLineId_ = other.gameStoryLineId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PPIHPDIPLLD Clone()
	{
		return new PPIHPDIPLLD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PPIHPDIPLLD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PPIHPDIPLLD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fOEKDMEALKF_.Equals(other.fOEKDMEALKF_))
		{
			return false;
		}
		if (GameStoryLineId != other.GameStoryLineId)
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
		num ^= fOEKDMEALKF_.GetHashCode();
		if (GameStoryLineId != 0)
		{
			num ^= GameStoryLineId.GetHashCode();
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
		fOEKDMEALKF_.WriteTo(ref output, _repeated_fOEKDMEALKF_codec);
		if (GameStoryLineId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(GameStoryLineId);
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
		num += fOEKDMEALKF_.CalculateSize(_repeated_fOEKDMEALKF_codec);
		if (GameStoryLineId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GameStoryLineId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PPIHPDIPLLD other)
	{
		if (other != null)
		{
			fOEKDMEALKF_.Add(other.fOEKDMEALKF_);
			if (other.GameStoryLineId != 0)
			{
				GameStoryLineId = other.GameStoryLineId;
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 64u:
			case 66u:
				fOEKDMEALKF_.AddEntriesFrom(ref input, _repeated_fOEKDMEALKF_codec);
				break;
			case 88u:
				GameStoryLineId = input.ReadUInt32();
				break;
			}
		}
	}
}
