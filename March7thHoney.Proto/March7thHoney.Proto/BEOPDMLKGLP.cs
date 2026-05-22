using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BEOPDMLKGLP : IMessage<BEOPDMLKGLP>, IMessage, IEquatable<BEOPDMLKGLP>, IDeepCloneable<BEOPDMLKGLP>, IBufferMessage
{
	private static readonly MessageParser<BEOPDMLKGLP> _parser = new MessageParser<BEOPDMLKGLP>(() => new BEOPDMLKGLP());

	private UnknownFieldSet _unknownFields;

	public const int LAGGMKGMGPBFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_lAGGMKGMGPB_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> lAGGMKGMGPB_ = new RepeatedField<uint>();

	public const int LevelIdFieldNumber = 15;

	private uint levelId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BEOPDMLKGLP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BEOPDMLKGLPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LAGGMKGMGPB => lAGGMKGMGPB_;

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
	public BEOPDMLKGLP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BEOPDMLKGLP(BEOPDMLKGLP other)
		: this()
	{
		lAGGMKGMGPB_ = other.lAGGMKGMGPB_.Clone();
		levelId_ = other.levelId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BEOPDMLKGLP Clone()
	{
		return new BEOPDMLKGLP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BEOPDMLKGLP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BEOPDMLKGLP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lAGGMKGMGPB_.Equals(other.lAGGMKGMGPB_))
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
		num ^= lAGGMKGMGPB_.GetHashCode();
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
		lAGGMKGMGPB_.WriteTo(ref output, _repeated_lAGGMKGMGPB_codec);
		if (LevelId != 0)
		{
			output.WriteRawTag(120);
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
		num += lAGGMKGMGPB_.CalculateSize(_repeated_lAGGMKGMGPB_codec);
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
	public void MergeFrom(BEOPDMLKGLP other)
	{
		if (other != null)
		{
			lAGGMKGMGPB_.Add(other.lAGGMKGMGPB_);
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
			case 104u:
			case 106u:
				lAGGMKGMGPB_.AddEntriesFrom(ref input, _repeated_lAGGMKGMGPB_codec);
				break;
			case 120u:
				LevelId = input.ReadUInt32();
				break;
			}
		}
	}
}
