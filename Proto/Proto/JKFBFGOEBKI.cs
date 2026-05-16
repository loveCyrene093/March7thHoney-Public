using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JKFBFGOEBKI : IMessage<JKFBFGOEBKI>, IMessage, IEquatable<JKFBFGOEBKI>, IDeepCloneable<JKFBFGOEBKI>, IBufferMessage
{
	private static readonly MessageParser<JKFBFGOEBKI> _parser = new MessageParser<JKFBFGOEBKI>(() => new JKFBFGOEBKI());

	private UnknownFieldSet _unknownFields;

	public const int NAKKOHEMJBLFieldNumber = 11;

	private KIEEFAOCOCC nAKKOHEMJBL_;

	public const int ChallengeListFieldNumber = 14;

	private static readonly FieldCodec<KMADNGJNOOB> _repeated_challengeList_codec = FieldCodec.ForMessage(114u, KMADNGJNOOB.Parser);

	private readonly RepeatedField<KMADNGJNOOB> challengeList_ = new RepeatedField<KMADNGJNOOB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JKFBFGOEBKI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JKFBFGOEBKIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIEEFAOCOCC NAKKOHEMJBL
	{
		get
		{
			return nAKKOHEMJBL_;
		}
		set
		{
			nAKKOHEMJBL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KMADNGJNOOB> ChallengeList => challengeList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKFBFGOEBKI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKFBFGOEBKI(JKFBFGOEBKI other)
		: this()
	{
		nAKKOHEMJBL_ = ((other.nAKKOHEMJBL_ != null) ? other.nAKKOHEMJBL_.Clone() : null);
		challengeList_ = other.challengeList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKFBFGOEBKI Clone()
	{
		return new JKFBFGOEBKI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JKFBFGOEBKI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JKFBFGOEBKI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NAKKOHEMJBL, other.NAKKOHEMJBL))
		{
			return false;
		}
		if (!challengeList_.Equals(other.challengeList_))
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
		if (nAKKOHEMJBL_ != null)
		{
			num ^= NAKKOHEMJBL.GetHashCode();
		}
		num ^= challengeList_.GetHashCode();
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
		if (nAKKOHEMJBL_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(NAKKOHEMJBL);
		}
		challengeList_.WriteTo(ref output, _repeated_challengeList_codec);
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
		if (nAKKOHEMJBL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NAKKOHEMJBL);
		}
		num += challengeList_.CalculateSize(_repeated_challengeList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JKFBFGOEBKI other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nAKKOHEMJBL_ != null)
		{
			if (nAKKOHEMJBL_ == null)
			{
				NAKKOHEMJBL = new KIEEFAOCOCC();
			}
			NAKKOHEMJBL.MergeFrom(other.NAKKOHEMJBL);
		}
		challengeList_.Add(other.challengeList_);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 90u:
				if (nAKKOHEMJBL_ == null)
				{
					NAKKOHEMJBL = new KIEEFAOCOCC();
				}
				input.ReadMessage(NAKKOHEMJBL);
				break;
			case 114u:
				challengeList_.AddEntriesFrom(ref input, _repeated_challengeList_codec);
				break;
			}
		}
	}
}
