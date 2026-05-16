using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DKBJKODADGM : IMessage<DKBJKODADGM>, IMessage, IEquatable<DKBJKODADGM>, IDeepCloneable<DKBJKODADGM>, IBufferMessage
{
	private static readonly MessageParser<DKBJKODADGM> _parser = new MessageParser<DKBJKODADGM>(() => new DKBJKODADGM());

	private UnknownFieldSet _unknownFields;

	public const int UniqueIdFieldNumber = 6;

	private uint uniqueId_;

	public const int CurIndexFieldNumber = 10;

	private uint curIndex_;

	public const int LGMDIGLEKENFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_lGMDIGLEKEN_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> lGMDIGLEKEN_ = new RepeatedField<uint>();

	public const int CardIdFieldNumber = 15;

	private uint cardId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DKBJKODADGM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DKBJKODADGMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurIndex
	{
		get
		{
			return curIndex_;
		}
		set
		{
			curIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LGMDIGLEKEN => lGMDIGLEKEN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CardId
	{
		get
		{
			return cardId_;
		}
		set
		{
			cardId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKBJKODADGM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKBJKODADGM(DKBJKODADGM other)
		: this()
	{
		uniqueId_ = other.uniqueId_;
		curIndex_ = other.curIndex_;
		lGMDIGLEKEN_ = other.lGMDIGLEKEN_.Clone();
		cardId_ = other.cardId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKBJKODADGM Clone()
	{
		return new DKBJKODADGM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DKBJKODADGM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DKBJKODADGM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (CurIndex != other.CurIndex)
		{
			return false;
		}
		if (!lGMDIGLEKEN_.Equals(other.lGMDIGLEKEN_))
		{
			return false;
		}
		if (CardId != other.CardId)
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
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (CurIndex != 0)
		{
			num ^= CurIndex.GetHashCode();
		}
		num ^= lGMDIGLEKEN_.GetHashCode();
		if (CardId != 0)
		{
			num ^= CardId.GetHashCode();
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
		if (UniqueId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(UniqueId);
		}
		if (CurIndex != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(CurIndex);
		}
		lGMDIGLEKEN_.WriteTo(ref output, _repeated_lGMDIGLEKEN_codec);
		if (CardId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(CardId);
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
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (CurIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurIndex);
		}
		num += lGMDIGLEKEN_.CalculateSize(_repeated_lGMDIGLEKEN_codec);
		if (CardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CardId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DKBJKODADGM other)
	{
		if (other != null)
		{
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			if (other.CurIndex != 0)
			{
				CurIndex = other.CurIndex;
			}
			lGMDIGLEKEN_.Add(other.lGMDIGLEKEN_);
			if (other.CardId != 0)
			{
				CardId = other.CardId;
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
			case 48u:
				UniqueId = input.ReadUInt32();
				break;
			case 80u:
				CurIndex = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				lGMDIGLEKEN_.AddEntriesFrom(ref input, _repeated_lGMDIGLEKEN_codec);
				break;
			case 120u:
				CardId = input.ReadUInt32();
				break;
			}
		}
	}
}
