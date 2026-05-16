using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AnnounceData : IMessage<AnnounceData>, IMessage, IEquatable<AnnounceData>, IDeepCloneable<AnnounceData>, IBufferMessage
{
	private static readonly MessageParser<AnnounceData> _parser = new MessageParser<AnnounceData>(() => new AnnounceData());

	private UnknownFieldSet _unknownFields;

	public const int EmergencyTextFieldNumber = 2;

	private string emergencyText_ = "";

	public const int BeginTimeFieldNumber = 3;

	private long beginTime_;

	public const int MPPDNHNPFENFieldNumber = 4;

	private uint mPPDNHNPFEN_;

	public const int ConfigIdFieldNumber = 5;

	private uint configId_;

	public const int EndTimeFieldNumber = 6;

	private long endTime_;

	public const int AEDGENKIEPBFieldNumber = 8;

	private string aEDGENKIEPB_ = "";

	public const int BannerFrequencyFieldNumber = 11;

	private uint bannerFrequency_;

	public const int BannerTextFieldNumber = 13;

	private string bannerText_ = "";

	public const int HasRecommandFieldNumber = 14;

	private bool hasRecommand_;

	public const int LHLEAGCJPFCFieldNumber = 15;

	private bool lHLEAGCJPFC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AnnounceData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AnnounceDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string EmergencyText
	{
		get
		{
			return emergencyText_;
		}
		set
		{
			emergencyText_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long BeginTime
	{
		get
		{
			return beginTime_;
		}
		set
		{
			beginTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MPPDNHNPFEN
	{
		get
		{
			return mPPDNHNPFEN_;
		}
		set
		{
			mPPDNHNPFEN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ConfigId
	{
		get
		{
			return configId_;
		}
		set
		{
			configId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EndTime
	{
		get
		{
			return endTime_;
		}
		set
		{
			endTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AEDGENKIEPB
	{
		get
		{
			return aEDGENKIEPB_;
		}
		set
		{
			aEDGENKIEPB_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BannerFrequency
	{
		get
		{
			return bannerFrequency_;
		}
		set
		{
			bannerFrequency_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string BannerText
	{
		get
		{
			return bannerText_;
		}
		set
		{
			bannerText_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasRecommand
	{
		get
		{
			return hasRecommand_;
		}
		set
		{
			hasRecommand_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LHLEAGCJPFC
	{
		get
		{
			return lHLEAGCJPFC_;
		}
		set
		{
			lHLEAGCJPFC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AnnounceData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AnnounceData(AnnounceData other)
		: this()
	{
		emergencyText_ = other.emergencyText_;
		beginTime_ = other.beginTime_;
		mPPDNHNPFEN_ = other.mPPDNHNPFEN_;
		configId_ = other.configId_;
		endTime_ = other.endTime_;
		aEDGENKIEPB_ = other.aEDGENKIEPB_;
		bannerFrequency_ = other.bannerFrequency_;
		bannerText_ = other.bannerText_;
		hasRecommand_ = other.hasRecommand_;
		lHLEAGCJPFC_ = other.lHLEAGCJPFC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AnnounceData Clone()
	{
		return new AnnounceData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AnnounceData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AnnounceData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EmergencyText != other.EmergencyText)
		{
			return false;
		}
		if (BeginTime != other.BeginTime)
		{
			return false;
		}
		if (MPPDNHNPFEN != other.MPPDNHNPFEN)
		{
			return false;
		}
		if (ConfigId != other.ConfigId)
		{
			return false;
		}
		if (EndTime != other.EndTime)
		{
			return false;
		}
		if (AEDGENKIEPB != other.AEDGENKIEPB)
		{
			return false;
		}
		if (BannerFrequency != other.BannerFrequency)
		{
			return false;
		}
		if (BannerText != other.BannerText)
		{
			return false;
		}
		if (HasRecommand != other.HasRecommand)
		{
			return false;
		}
		if (LHLEAGCJPFC != other.LHLEAGCJPFC)
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
		if (EmergencyText.Length != 0)
		{
			num ^= EmergencyText.GetHashCode();
		}
		if (BeginTime != 0L)
		{
			num ^= BeginTime.GetHashCode();
		}
		if (MPPDNHNPFEN != 0)
		{
			num ^= MPPDNHNPFEN.GetHashCode();
		}
		if (ConfigId != 0)
		{
			num ^= ConfigId.GetHashCode();
		}
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
		}
		if (AEDGENKIEPB.Length != 0)
		{
			num ^= AEDGENKIEPB.GetHashCode();
		}
		if (BannerFrequency != 0)
		{
			num ^= BannerFrequency.GetHashCode();
		}
		if (BannerText.Length != 0)
		{
			num ^= BannerText.GetHashCode();
		}
		if (HasRecommand)
		{
			num ^= HasRecommand.GetHashCode();
		}
		if (LHLEAGCJPFC)
		{
			num ^= LHLEAGCJPFC.GetHashCode();
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
		if (EmergencyText.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(EmergencyText);
		}
		if (BeginTime != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(BeginTime);
		}
		if (MPPDNHNPFEN != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MPPDNHNPFEN);
		}
		if (ConfigId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(ConfigId);
		}
		if (EndTime != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(EndTime);
		}
		if (AEDGENKIEPB.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(AEDGENKIEPB);
		}
		if (BannerFrequency != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(BannerFrequency);
		}
		if (BannerText.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(BannerText);
		}
		if (HasRecommand)
		{
			output.WriteRawTag(112);
			output.WriteBool(HasRecommand);
		}
		if (LHLEAGCJPFC)
		{
			output.WriteRawTag(120);
			output.WriteBool(LHLEAGCJPFC);
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
		if (EmergencyText.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EmergencyText);
		}
		if (BeginTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(BeginTime);
		}
		if (MPPDNHNPFEN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MPPDNHNPFEN);
		}
		if (ConfigId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ConfigId);
		}
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndTime);
		}
		if (AEDGENKIEPB.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AEDGENKIEPB);
		}
		if (BannerFrequency != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BannerFrequency);
		}
		if (BannerText.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BannerText);
		}
		if (HasRecommand)
		{
			num += 2;
		}
		if (LHLEAGCJPFC)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AnnounceData other)
	{
		if (other != null)
		{
			if (other.EmergencyText.Length != 0)
			{
				EmergencyText = other.EmergencyText;
			}
			if (other.BeginTime != 0L)
			{
				BeginTime = other.BeginTime;
			}
			if (other.MPPDNHNPFEN != 0)
			{
				MPPDNHNPFEN = other.MPPDNHNPFEN;
			}
			if (other.ConfigId != 0)
			{
				ConfigId = other.ConfigId;
			}
			if (other.EndTime != 0L)
			{
				EndTime = other.EndTime;
			}
			if (other.AEDGENKIEPB.Length != 0)
			{
				AEDGENKIEPB = other.AEDGENKIEPB;
			}
			if (other.BannerFrequency != 0)
			{
				BannerFrequency = other.BannerFrequency;
			}
			if (other.BannerText.Length != 0)
			{
				BannerText = other.BannerText;
			}
			if (other.HasRecommand)
			{
				HasRecommand = other.HasRecommand;
			}
			if (other.LHLEAGCJPFC)
			{
				LHLEAGCJPFC = other.LHLEAGCJPFC;
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
				EmergencyText = input.ReadString();
				break;
			case 24u:
				BeginTime = input.ReadInt64();
				break;
			case 32u:
				MPPDNHNPFEN = input.ReadUInt32();
				break;
			case 40u:
				ConfigId = input.ReadUInt32();
				break;
			case 48u:
				EndTime = input.ReadInt64();
				break;
			case 66u:
				AEDGENKIEPB = input.ReadString();
				break;
			case 88u:
				BannerFrequency = input.ReadUInt32();
				break;
			case 106u:
				BannerText = input.ReadString();
				break;
			case 112u:
				HasRecommand = input.ReadBool();
				break;
			case 120u:
				LHLEAGCJPFC = input.ReadBool();
				break;
			}
		}
	}
}
