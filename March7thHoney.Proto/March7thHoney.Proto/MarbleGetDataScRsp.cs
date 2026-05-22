using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MarbleGetDataScRsp : IMessage<MarbleGetDataScRsp>, IMessage, IEquatable<MarbleGetDataScRsp>, IDeepCloneable<MarbleGetDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<MarbleGetDataScRsp> _parser = new MessageParser<MarbleGetDataScRsp>(() => new MarbleGetDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CNLBNACFCJEFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_cNLBNACFCJE_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> cNLBNACFCJE_ = new RepeatedField<uint>();

	public const int JHDMGFGJMEBFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_jHDMGFGJMEB_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> jHDMGFGJMEB_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	public const int HIKDAMMFGDJFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_hIKDAMMFGDJ_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> hIKDAMMFGDJ_ = new RepeatedField<uint>();

	public const int ScoreIdFieldNumber = 15;

	private int scoreId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MarbleGetDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MarbleGetDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CNLBNACFCJE => cNLBNACFCJE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JHDMGFGJMEB => jHDMGFGJMEB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HIKDAMMFGDJ => hIKDAMMFGDJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarbleGetDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarbleGetDataScRsp(MarbleGetDataScRsp other)
		: this()
	{
		cNLBNACFCJE_ = other.cNLBNACFCJE_.Clone();
		jHDMGFGJMEB_ = other.jHDMGFGJMEB_.Clone();
		retcode_ = other.retcode_;
		hIKDAMMFGDJ_ = other.hIKDAMMFGDJ_.Clone();
		scoreId_ = other.scoreId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarbleGetDataScRsp Clone()
	{
		return new MarbleGetDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MarbleGetDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MarbleGetDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cNLBNACFCJE_.Equals(other.cNLBNACFCJE_))
		{
			return false;
		}
		if (!jHDMGFGJMEB_.Equals(other.jHDMGFGJMEB_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!hIKDAMMFGDJ_.Equals(other.hIKDAMMFGDJ_))
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
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
		num ^= cNLBNACFCJE_.GetHashCode();
		num ^= jHDMGFGJMEB_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= hIKDAMMFGDJ_.GetHashCode();
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
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
		cNLBNACFCJE_.WriteTo(ref output, _repeated_cNLBNACFCJE_codec);
		jHDMGFGJMEB_.WriteTo(ref output, _repeated_jHDMGFGJMEB_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Retcode);
		}
		hIKDAMMFGDJ_.WriteTo(ref output, _repeated_hIKDAMMFGDJ_codec);
		if (ScoreId != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(ScoreId);
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
		num += cNLBNACFCJE_.CalculateSize(_repeated_cNLBNACFCJE_codec);
		num += jHDMGFGJMEB_.CalculateSize(_repeated_jHDMGFGJMEB_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += hIKDAMMFGDJ_.CalculateSize(_repeated_hIKDAMMFGDJ_codec);
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ScoreId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MarbleGetDataScRsp other)
	{
		if (other != null)
		{
			cNLBNACFCJE_.Add(other.cNLBNACFCJE_);
			jHDMGFGJMEB_.Add(other.jHDMGFGJMEB_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			hIKDAMMFGDJ_.Add(other.hIKDAMMFGDJ_);
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
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
			case 16u:
			case 18u:
				cNLBNACFCJE_.AddEntriesFrom(ref input, _repeated_cNLBNACFCJE_codec);
				break;
			case 56u:
			case 58u:
				jHDMGFGJMEB_.AddEntriesFrom(ref input, _repeated_jHDMGFGJMEB_codec);
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			case 112u:
			case 114u:
				hIKDAMMFGDJ_.AddEntriesFrom(ref input, _repeated_hIKDAMMFGDJ_codec);
				break;
			case 120u:
				ScoreId = input.ReadInt32();
				break;
			}
		}
	}
}
