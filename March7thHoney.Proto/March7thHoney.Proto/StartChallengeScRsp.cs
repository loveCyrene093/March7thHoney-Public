using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartChallengeScRsp : IMessage<StartChallengeScRsp>, IMessage, IEquatable<StartChallengeScRsp>, IDeepCloneable<StartChallengeScRsp>, IBufferMessage
{
	private static readonly MessageParser<StartChallengeScRsp> _parser = new MessageParser<StartChallengeScRsp>(() => new StartChallengeScRsp());

	private UnknownFieldSet _unknownFields;

	public const int StageInfoFieldNumber = 2;

	private ChallengeStageInfo stageInfo_;

	public const int CurChallengeFieldNumber = 3;

	private CurChallenge curChallenge_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int LineupListFieldNumber = 13;

	private static readonly FieldCodec<LineupInfo> _repeated_lineupList_codec = FieldCodec.ForMessage(106u, LineupInfo.Parser);

	private readonly RepeatedField<LineupInfo> lineupList_ = new RepeatedField<LineupInfo>();

	public const int SceneFieldNumber = 15;

	private SceneInfo scene_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartChallengeScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartChallengeScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeStageInfo StageInfo
	{
		get
		{
			return stageInfo_;
		}
		set
		{
			stageInfo_ = value;
		}
	}

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
	public SceneInfo Scene
	{
		get
		{
			return scene_;
		}
		set
		{
			scene_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartChallengeScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartChallengeScRsp(StartChallengeScRsp other)
		: this()
	{
		stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
		curChallenge_ = ((other.curChallenge_ != null) ? other.curChallenge_.Clone() : null);
		retcode_ = other.retcode_;
		lineupList_ = other.lineupList_.Clone();
		scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartChallengeScRsp Clone()
	{
		return new StartChallengeScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartChallengeScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartChallengeScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(StageInfo, other.StageInfo))
		{
			return false;
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
		if (!object.Equals(Scene, other.Scene))
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
		if (stageInfo_ != null)
		{
			num ^= StageInfo.GetHashCode();
		}
		if (curChallenge_ != null)
		{
			num ^= CurChallenge.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= lineupList_.GetHashCode();
		if (scene_ != null)
		{
			num ^= Scene.GetHashCode();
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
		if (stageInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(StageInfo);
		}
		if (curChallenge_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(CurChallenge);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		lineupList_.WriteTo(ref output, _repeated_lineupList_codec);
		if (scene_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(Scene);
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
		if (stageInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StageInfo);
		}
		if (curChallenge_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CurChallenge);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += lineupList_.CalculateSize(_repeated_lineupList_codec);
		if (scene_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Scene);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StartChallengeScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.stageInfo_ != null)
		{
			if (stageInfo_ == null)
			{
				StageInfo = new ChallengeStageInfo();
			}
			StageInfo.MergeFrom(other.StageInfo);
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
		if (other.scene_ != null)
		{
			if (scene_ == null)
			{
				Scene = new SceneInfo();
			}
			Scene.MergeFrom(other.Scene);
		}
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
			case 18u:
				if (stageInfo_ == null)
				{
					StageInfo = new ChallengeStageInfo();
				}
				input.ReadMessage(StageInfo);
				break;
			case 26u:
				if (curChallenge_ == null)
				{
					CurChallenge = new CurChallenge();
				}
				input.ReadMessage(CurChallenge);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 106u:
				lineupList_.AddEntriesFrom(ref input, _repeated_lineupList_codec);
				break;
			case 122u:
				if (scene_ == null)
				{
					Scene = new SceneInfo();
				}
				input.ReadMessage(Scene);
				break;
			}
		}
	}
}
