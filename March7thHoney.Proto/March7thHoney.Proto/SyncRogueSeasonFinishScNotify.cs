using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncRogueSeasonFinishScNotify : IMessage<SyncRogueSeasonFinishScNotify>, IMessage, IEquatable<SyncRogueSeasonFinishScNotify>, IDeepCloneable<SyncRogueSeasonFinishScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncRogueSeasonFinishScNotify> _parser = new MessageParser<SyncRogueSeasonFinishScNotify>(() => new SyncRogueSeasonFinishScNotify());

	private UnknownFieldSet _unknownFields;

	public const int FinishInfoFieldNumber = 2;

	private JMIIFOMFOGO finishInfo_;

	public const int OIFKNJAFGDCFieldNumber = 5;

	private bool oIFKNJAFGDC_;

	public const int AHBFAAMNKNOFieldNumber = 6;

	private BGKINCFGKGI aHBFAAMNKNO_;

	public const int LineupFieldNumber = 10;

	private LineupInfo lineup_;

	public const int SceneFieldNumber = 13;

	private SceneInfo scene_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncRogueSeasonFinishScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncRogueSeasonFinishScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JMIIFOMFOGO FinishInfo
	{
		get
		{
			return finishInfo_;
		}
		set
		{
			finishInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OIFKNJAFGDC
	{
		get
		{
			return oIFKNJAFGDC_;
		}
		set
		{
			oIFKNJAFGDC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGKINCFGKGI AHBFAAMNKNO
	{
		get
		{
			return aHBFAAMNKNO_;
		}
		set
		{
			aHBFAAMNKNO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LineupInfo Lineup
	{
		get
		{
			return lineup_;
		}
		set
		{
			lineup_ = value;
		}
	}

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
	public SyncRogueSeasonFinishScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueSeasonFinishScNotify(SyncRogueSeasonFinishScNotify other)
		: this()
	{
		finishInfo_ = ((other.finishInfo_ != null) ? other.finishInfo_.Clone() : null);
		oIFKNJAFGDC_ = other.oIFKNJAFGDC_;
		aHBFAAMNKNO_ = ((other.aHBFAAMNKNO_ != null) ? other.aHBFAAMNKNO_.Clone() : null);
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueSeasonFinishScNotify Clone()
	{
		return new SyncRogueSeasonFinishScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncRogueSeasonFinishScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncRogueSeasonFinishScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FinishInfo, other.FinishInfo))
		{
			return false;
		}
		if (OIFKNJAFGDC != other.OIFKNJAFGDC)
		{
			return false;
		}
		if (!object.Equals(AHBFAAMNKNO, other.AHBFAAMNKNO))
		{
			return false;
		}
		if (!object.Equals(Lineup, other.Lineup))
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
		if (finishInfo_ != null)
		{
			num ^= FinishInfo.GetHashCode();
		}
		if (OIFKNJAFGDC)
		{
			num ^= OIFKNJAFGDC.GetHashCode();
		}
		if (aHBFAAMNKNO_ != null)
		{
			num ^= AHBFAAMNKNO.GetHashCode();
		}
		if (lineup_ != null)
		{
			num ^= Lineup.GetHashCode();
		}
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
		if (finishInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(FinishInfo);
		}
		if (OIFKNJAFGDC)
		{
			output.WriteRawTag(40);
			output.WriteBool(OIFKNJAFGDC);
		}
		if (aHBFAAMNKNO_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(AHBFAAMNKNO);
		}
		if (lineup_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(Lineup);
		}
		if (scene_ != null)
		{
			output.WriteRawTag(106);
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
		if (finishInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FinishInfo);
		}
		if (OIFKNJAFGDC)
		{
			num += 2;
		}
		if (aHBFAAMNKNO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AHBFAAMNKNO);
		}
		if (lineup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
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
	public void MergeFrom(SyncRogueSeasonFinishScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.finishInfo_ != null)
		{
			if (finishInfo_ == null)
			{
				FinishInfo = new JMIIFOMFOGO();
			}
			FinishInfo.MergeFrom(other.FinishInfo);
		}
		if (other.OIFKNJAFGDC)
		{
			OIFKNJAFGDC = other.OIFKNJAFGDC;
		}
		if (other.aHBFAAMNKNO_ != null)
		{
			if (aHBFAAMNKNO_ == null)
			{
				AHBFAAMNKNO = new BGKINCFGKGI();
			}
			AHBFAAMNKNO.MergeFrom(other.AHBFAAMNKNO);
		}
		if (other.lineup_ != null)
		{
			if (lineup_ == null)
			{
				Lineup = new LineupInfo();
			}
			Lineup.MergeFrom(other.Lineup);
		}
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
				if (finishInfo_ == null)
				{
					FinishInfo = new JMIIFOMFOGO();
				}
				input.ReadMessage(FinishInfo);
				break;
			case 40u:
				OIFKNJAFGDC = input.ReadBool();
				break;
			case 50u:
				if (aHBFAAMNKNO_ == null)
				{
					AHBFAAMNKNO = new BGKINCFGKGI();
				}
				input.ReadMessage(AHBFAAMNKNO);
				break;
			case 82u:
				if (lineup_ == null)
				{
					Lineup = new LineupInfo();
				}
				input.ReadMessage(Lineup);
				break;
			case 106u:
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
