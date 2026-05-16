using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AFDBEFKBBFM : IMessage<AFDBEFKBBFM>, IMessage, IEquatable<AFDBEFKBBFM>, IDeepCloneable<AFDBEFKBBFM>, IBufferMessage
{
	private static readonly MessageParser<AFDBEFKBBFM> _parser = new MessageParser<AFDBEFKBBFM>(() => new AFDBEFKBBFM());

	private UnknownFieldSet _unknownFields;

	public const int JPNALKEFHOHFieldNumber = 2;

	private static readonly FieldCodec<LOCEJAIMMGG> _repeated_jPNALKEFHOH_codec = FieldCodec.ForMessage(18u, LOCEJAIMMGG.Parser);

	private readonly RepeatedField<LOCEJAIMMGG> jPNALKEFHOH_ = new RepeatedField<LOCEJAIMMGG>();

	public const int LevelIdFieldNumber = 8;

	private uint levelId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AFDBEFKBBFM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AFDBEFKBBFMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LOCEJAIMMGG> JPNALKEFHOH => jPNALKEFHOH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFDBEFKBBFM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFDBEFKBBFM(AFDBEFKBBFM other)
		: this()
	{
		jPNALKEFHOH_ = other.jPNALKEFHOH_.Clone();
		levelId_ = other.levelId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFDBEFKBBFM Clone()
	{
		return new AFDBEFKBBFM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AFDBEFKBBFM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AFDBEFKBBFM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jPNALKEFHOH_.Equals(other.jPNALKEFHOH_))
		{
			return false;
		}
		if (LevelId != other.LevelId)
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
		num ^= jPNALKEFHOH_.GetHashCode();
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
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
		jPNALKEFHOH_.WriteTo(ref output, _repeated_jPNALKEFHOH_codec);
		if (LevelId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(LevelId);
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
		num += jPNALKEFHOH_.CalculateSize(_repeated_jPNALKEFHOH_codec);
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AFDBEFKBBFM other)
	{
		if (other != null)
		{
			jPNALKEFHOH_.Add(other.jPNALKEFHOH_);
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
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
			case 18u:
				jPNALKEFHOH_.AddEntriesFrom(ref input, _repeated_jPNALKEFHOH_codec);
				break;
			case 64u:
				LevelId = input.ReadUInt32();
				break;
			}
		}
	}
}
