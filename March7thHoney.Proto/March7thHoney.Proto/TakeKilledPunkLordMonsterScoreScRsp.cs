using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeKilledPunkLordMonsterScoreScRsp : IMessage<TakeKilledPunkLordMonsterScoreScRsp>, IMessage, IEquatable<TakeKilledPunkLordMonsterScoreScRsp>, IDeepCloneable<TakeKilledPunkLordMonsterScoreScRsp>, IBufferMessage
{
	private static readonly MessageParser<TakeKilledPunkLordMonsterScoreScRsp> _parser = new MessageParser<TakeKilledPunkLordMonsterScoreScRsp>(() => new TakeKilledPunkLordMonsterScoreScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MDNFLHMOLNBFieldNumber = 1;

	private bool mDNFLHMOLNB_;

	public const int DGLHFPIPFDJFieldNumber = 4;

	private static readonly FieldCodec<JLLIDDIBOHI> _repeated_dGLHFPIPFDJ_codec = FieldCodec.ForMessage(34u, JLLIDDIBOHI.Parser);

	private readonly RepeatedField<JLLIDDIBOHI> dGLHFPIPFDJ_ = new RepeatedField<JLLIDDIBOHI>();

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int ScoreIdFieldNumber = 12;

	private uint scoreId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeKilledPunkLordMonsterScoreScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeKilledPunkLordMonsterScoreScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MDNFLHMOLNB
	{
		get
		{
			return mDNFLHMOLNB_;
		}
		set
		{
			mDNFLHMOLNB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JLLIDDIBOHI> DGLHFPIPFDJ => dGLHFPIPFDJ_;

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
	public uint ScoreId
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
	public TakeKilledPunkLordMonsterScoreScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeKilledPunkLordMonsterScoreScRsp(TakeKilledPunkLordMonsterScoreScRsp other)
		: this()
	{
		mDNFLHMOLNB_ = other.mDNFLHMOLNB_;
		dGLHFPIPFDJ_ = other.dGLHFPIPFDJ_.Clone();
		retcode_ = other.retcode_;
		scoreId_ = other.scoreId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeKilledPunkLordMonsterScoreScRsp Clone()
	{
		return new TakeKilledPunkLordMonsterScoreScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeKilledPunkLordMonsterScoreScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeKilledPunkLordMonsterScoreScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MDNFLHMOLNB != other.MDNFLHMOLNB)
		{
			return false;
		}
		if (!dGLHFPIPFDJ_.Equals(other.dGLHFPIPFDJ_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (MDNFLHMOLNB)
		{
			num ^= MDNFLHMOLNB.GetHashCode();
		}
		num ^= dGLHFPIPFDJ_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
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
		if (MDNFLHMOLNB)
		{
			output.WriteRawTag(8);
			output.WriteBool(MDNFLHMOLNB);
		}
		dGLHFPIPFDJ_.WriteTo(ref output, _repeated_dGLHFPIPFDJ_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ScoreId);
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
		if (MDNFLHMOLNB)
		{
			num += 2;
		}
		num += dGLHFPIPFDJ_.CalculateSize(_repeated_dGLHFPIPFDJ_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeKilledPunkLordMonsterScoreScRsp other)
	{
		if (other != null)
		{
			if (other.MDNFLHMOLNB)
			{
				MDNFLHMOLNB = other.MDNFLHMOLNB;
			}
			dGLHFPIPFDJ_.Add(other.dGLHFPIPFDJ_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
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
			case 8u:
				MDNFLHMOLNB = input.ReadBool();
				break;
			case 34u:
				dGLHFPIPFDJ_.AddEntriesFrom(ref input, _repeated_dGLHFPIPFDJ_codec);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 96u:
				ScoreId = input.ReadUInt32();
				break;
			}
		}
	}
}
