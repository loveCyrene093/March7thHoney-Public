using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetCurChallengeScRsp : IMessage<GetCurChallengeScRsp>, IMessage, IEquatable<GetCurChallengeScRsp>, IDeepCloneable<GetCurChallengeScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetCurChallengeScRsp> _parser = new MessageParser<GetCurChallengeScRsp>(() => new GetCurChallengeScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CurChallengeFieldNumber = 1;

	private CurChallenge curChallenge_;

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	public const int LineupListFieldNumber = 14;

	private static readonly FieldCodec<LineupInfo> _repeated_lineupList_codec = FieldCodec.ForMessage(114u, LineupInfo.Parser);

	private readonly RepeatedField<LineupInfo> lineupList_ = new RepeatedField<LineupInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetCurChallengeScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetCurChallengeScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CurChallenge CurChallenge
	{
		get
		{
			return curChallenge_;
		}
		set
		{
			curChallenge_ = value;
		}
	}

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
	public RepeatedField<LineupInfo> LineupList => lineupList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetCurChallengeScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetCurChallengeScRsp(GetCurChallengeScRsp other)
		: this()
	{
		curChallenge_ = ((other.curChallenge_ != null) ? other.curChallenge_.Clone() : null);
		retcode_ = other.retcode_;
		lineupList_ = other.lineupList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetCurChallengeScRsp Clone()
	{
		return new GetCurChallengeScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetCurChallengeScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetCurChallengeScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CurChallenge, other.CurChallenge))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!lineupList_.Equals(other.lineupList_))
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
		if (curChallenge_ != null)
		{
			num ^= CurChallenge.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= lineupList_.GetHashCode();
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
		if (curChallenge_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(CurChallenge);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Retcode);
		}
		lineupList_.WriteTo(ref output, _repeated_lineupList_codec);
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
		if (curChallenge_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CurChallenge);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += lineupList_.CalculateSize(_repeated_lineupList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetCurChallengeScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.curChallenge_ != null)
		{
			if (curChallenge_ == null)
			{
				CurChallenge = new CurChallenge();
			}
			CurChallenge.MergeFrom(other.CurChallenge);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		lineupList_.Add(other.lineupList_);
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
			case 10u:
				if (curChallenge_ == null)
				{
					CurChallenge = new CurChallenge();
				}
				input.ReadMessage(CurChallenge);
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			case 114u:
				lineupList_.AddEntriesFrom(ref input, _repeated_lineupList_codec);
				break;
			}
		}
	}
}
