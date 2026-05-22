using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MissionSnapshot : IMessage<MissionSnapshot>, IMessage, IEquatable<MissionSnapshot>, IDeepCloneable<MissionSnapshot>, IBufferMessage
{
	private static readonly MessageParser<MissionSnapshot> _parser = new MessageParser<MissionSnapshot>(() => new MissionSnapshot());

	private UnknownFieldSet _unknownFields;

	public const int ServerMcvListFieldNumber = 1;

	private static readonly FieldCodec<MainMissionMcvSnapshot> _repeated_serverMcvList_codec = FieldCodec.ForMessage(10u, MainMissionMcvSnapshot.Parser);

	private readonly RepeatedField<MainMissionMcvSnapshot> serverMcvList_ = new RepeatedField<MainMissionMcvSnapshot>();

	public const int ClientMcvListFieldNumber = 2;

	private static readonly FieldCodec<MainMissionMcvSnapshot> _repeated_clientMcvList_codec = FieldCodec.ForMessage(18u, MainMissionMcvSnapshot.Parser);

	private readonly RepeatedField<MainMissionMcvSnapshot> clientMcvList_ = new RepeatedField<MainMissionMcvSnapshot>();

	public const int TrackingMainMissionFieldNumber = 3;

	private MainMissionSnapshot trackingMainMission_;

	public const int HasMissionAudioSnapshotFieldNumber = 4;

	private bool hasMissionAudioSnapshot_;

	public const int CurAudioEmotionStateFieldNumber = 5;

	private string curAudioEmotionState_ = "";

	public const int CurSoundEffectStateFieldNumber = 6;

	private string curSoundEffectState_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MissionSnapshot> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MissionSnapshotReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MainMissionMcvSnapshot> ServerMcvList => serverMcvList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MainMissionMcvSnapshot> ClientMcvList => clientMcvList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MainMissionSnapshot TrackingMainMission
	{
		get
		{
			return trackingMainMission_;
		}
		set
		{
			trackingMainMission_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasMissionAudioSnapshot
	{
		get
		{
			return hasMissionAudioSnapshot_;
		}
		set
		{
			hasMissionAudioSnapshot_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CurAudioEmotionState
	{
		get
		{
			return curAudioEmotionState_;
		}
		set
		{
			curAudioEmotionState_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CurSoundEffectState
	{
		get
		{
			return curSoundEffectState_;
		}
		set
		{
			curSoundEffectState_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionSnapshot()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionSnapshot(MissionSnapshot other)
		: this()
	{
		serverMcvList_ = other.serverMcvList_.Clone();
		clientMcvList_ = other.clientMcvList_.Clone();
		trackingMainMission_ = ((other.trackingMainMission_ != null) ? other.trackingMainMission_.Clone() : null);
		hasMissionAudioSnapshot_ = other.hasMissionAudioSnapshot_;
		curAudioEmotionState_ = other.curAudioEmotionState_;
		curSoundEffectState_ = other.curSoundEffectState_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionSnapshot Clone()
	{
		return new MissionSnapshot(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MissionSnapshot);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MissionSnapshot other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!serverMcvList_.Equals(other.serverMcvList_))
		{
			return false;
		}
		if (!clientMcvList_.Equals(other.clientMcvList_))
		{
			return false;
		}
		if (!object.Equals(TrackingMainMission, other.TrackingMainMission))
		{
			return false;
		}
		if (HasMissionAudioSnapshot != other.HasMissionAudioSnapshot)
		{
			return false;
		}
		if (CurAudioEmotionState != other.CurAudioEmotionState)
		{
			return false;
		}
		if (CurSoundEffectState != other.CurSoundEffectState)
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
		num ^= serverMcvList_.GetHashCode();
		num ^= clientMcvList_.GetHashCode();
		if (trackingMainMission_ != null)
		{
			num ^= TrackingMainMission.GetHashCode();
		}
		if (HasMissionAudioSnapshot)
		{
			num ^= HasMissionAudioSnapshot.GetHashCode();
		}
		if (CurAudioEmotionState.Length != 0)
		{
			num ^= CurAudioEmotionState.GetHashCode();
		}
		if (CurSoundEffectState.Length != 0)
		{
			num ^= CurSoundEffectState.GetHashCode();
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
		serverMcvList_.WriteTo(ref output, _repeated_serverMcvList_codec);
		clientMcvList_.WriteTo(ref output, _repeated_clientMcvList_codec);
		if (trackingMainMission_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(TrackingMainMission);
		}
		if (HasMissionAudioSnapshot)
		{
			output.WriteRawTag(32);
			output.WriteBool(HasMissionAudioSnapshot);
		}
		if (CurAudioEmotionState.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(CurAudioEmotionState);
		}
		if (CurSoundEffectState.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(CurSoundEffectState);
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
		num += serverMcvList_.CalculateSize(_repeated_serverMcvList_codec);
		num += clientMcvList_.CalculateSize(_repeated_clientMcvList_codec);
		if (trackingMainMission_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TrackingMainMission);
		}
		if (HasMissionAudioSnapshot)
		{
			num += 2;
		}
		if (CurAudioEmotionState.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CurAudioEmotionState);
		}
		if (CurSoundEffectState.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CurSoundEffectState);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MissionSnapshot other)
	{
		if (other == null)
		{
			return;
		}
		serverMcvList_.Add(other.serverMcvList_);
		clientMcvList_.Add(other.clientMcvList_);
		if (other.trackingMainMission_ != null)
		{
			if (trackingMainMission_ == null)
			{
				TrackingMainMission = new MainMissionSnapshot();
			}
			TrackingMainMission.MergeFrom(other.TrackingMainMission);
		}
		if (other.HasMissionAudioSnapshot)
		{
			HasMissionAudioSnapshot = other.HasMissionAudioSnapshot;
		}
		if (other.CurAudioEmotionState.Length != 0)
		{
			CurAudioEmotionState = other.CurAudioEmotionState;
		}
		if (other.CurSoundEffectState.Length != 0)
		{
			CurSoundEffectState = other.CurSoundEffectState;
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
			case 10u:
				serverMcvList_.AddEntriesFrom(ref input, _repeated_serverMcvList_codec);
				break;
			case 18u:
				clientMcvList_.AddEntriesFrom(ref input, _repeated_clientMcvList_codec);
				break;
			case 26u:
				if (trackingMainMission_ == null)
				{
					TrackingMainMission = new MainMissionSnapshot();
				}
				input.ReadMessage(TrackingMainMission);
				break;
			case 32u:
				HasMissionAudioSnapshot = input.ReadBool();
				break;
			case 42u:
				CurAudioEmotionState = input.ReadString();
				break;
			case 50u:
				CurSoundEffectState = input.ReadString();
				break;
			}
		}
	}
}
