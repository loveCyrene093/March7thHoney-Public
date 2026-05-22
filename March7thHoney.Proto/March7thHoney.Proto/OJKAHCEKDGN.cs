using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OJKAHCEKDGN : IMessage<OJKAHCEKDGN>, IMessage, IEquatable<OJKAHCEKDGN>, IDeepCloneable<OJKAHCEKDGN>, IBufferMessage
{
	private static readonly MessageParser<OJKAHCEKDGN> _parser = new MessageParser<OJKAHCEKDGN>(() => new OJKAHCEKDGN());

	private UnknownFieldSet _unknownFields;

	public const int NameFieldNumber = 3;

	private string name_ = "";

	public const int EndTimeFieldNumber = 4;

	private long endTime_;

	public const int KKGIEENCOICFieldNumber = 5;

	private uint kKGIEENCOIC_;

	public const int HHDLEADBJGNFieldNumber = 6;

	private APMHDGPDGNP hHDLEADBJGN_;

	public const int HCEHOHDCCFEFieldNumber = 7;

	private CNMBIPOPOFH hCEHOHDCCFE_;

	public const int DataFieldNumber = 12;

	private NCDBPKAIHIN data_;

	public const int AvatarListFieldNumber = 13;

	private static readonly FieldCodec<HDDBJIKNEPF> _repeated_avatarList_codec = FieldCodec.ForMessage(106u, HDDBJIKNEPF.Parser);

	private readonly RepeatedField<HDDBJIKNEPF> avatarList_ = new RepeatedField<HDDBJIKNEPF>();

	public const int TimeFieldNumber = 15;

	private long time_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OJKAHCEKDGN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OJKAHCEKDGNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public uint KKGIEENCOIC
	{
		get
		{
			return kKGIEENCOIC_;
		}
		set
		{
			kKGIEENCOIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APMHDGPDGNP HHDLEADBJGN
	{
		get
		{
			return hHDLEADBJGN_;
		}
		set
		{
			hHDLEADBJGN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNMBIPOPOFH HCEHOHDCCFE
	{
		get
		{
			return hCEHOHDCCFE_;
		}
		set
		{
			hCEHOHDCCFE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCDBPKAIHIN Data
	{
		get
		{
			return data_;
		}
		set
		{
			data_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HDDBJIKNEPF> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJKAHCEKDGN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJKAHCEKDGN(OJKAHCEKDGN other)
		: this()
	{
		name_ = other.name_;
		endTime_ = other.endTime_;
		kKGIEENCOIC_ = other.kKGIEENCOIC_;
		hHDLEADBJGN_ = ((other.hHDLEADBJGN_ != null) ? other.hHDLEADBJGN_.Clone() : null);
		hCEHOHDCCFE_ = ((other.hCEHOHDCCFE_ != null) ? other.hCEHOHDCCFE_.Clone() : null);
		data_ = ((other.data_ != null) ? other.data_.Clone() : null);
		avatarList_ = other.avatarList_.Clone();
		time_ = other.time_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJKAHCEKDGN Clone()
	{
		return new OJKAHCEKDGN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OJKAHCEKDGN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OJKAHCEKDGN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (EndTime != other.EndTime)
		{
			return false;
		}
		if (KKGIEENCOIC != other.KKGIEENCOIC)
		{
			return false;
		}
		if (!object.Equals(HHDLEADBJGN, other.HHDLEADBJGN))
		{
			return false;
		}
		if (!object.Equals(HCEHOHDCCFE, other.HCEHOHDCCFE))
		{
			return false;
		}
		if (!object.Equals(Data, other.Data))
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (Time != other.Time)
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
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
		}
		if (KKGIEENCOIC != 0)
		{
			num ^= KKGIEENCOIC.GetHashCode();
		}
		if (hHDLEADBJGN_ != null)
		{
			num ^= HHDLEADBJGN.GetHashCode();
		}
		if (hCEHOHDCCFE_ != null)
		{
			num ^= HCEHOHDCCFE.GetHashCode();
		}
		if (data_ != null)
		{
			num ^= Data.GetHashCode();
		}
		num ^= avatarList_.GetHashCode();
		if (Time != 0L)
		{
			num ^= Time.GetHashCode();
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
		if (Name.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Name);
		}
		if (EndTime != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(EndTime);
		}
		if (KKGIEENCOIC != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(KKGIEENCOIC);
		}
		if (hHDLEADBJGN_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(HHDLEADBJGN);
		}
		if (hCEHOHDCCFE_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(HCEHOHDCCFE);
		}
		if (data_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(Data);
		}
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		if (Time != 0L)
		{
			output.WriteRawTag(120);
			output.WriteInt64(Time);
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
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndTime);
		}
		if (KKGIEENCOIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKGIEENCOIC);
		}
		if (hHDLEADBJGN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HHDLEADBJGN);
		}
		if (hCEHOHDCCFE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HCEHOHDCCFE);
		}
		if (data_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Data);
		}
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (Time != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Time);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OJKAHCEKDGN other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Name.Length != 0)
		{
			Name = other.Name;
		}
		if (other.EndTime != 0L)
		{
			EndTime = other.EndTime;
		}
		if (other.KKGIEENCOIC != 0)
		{
			KKGIEENCOIC = other.KKGIEENCOIC;
		}
		if (other.hHDLEADBJGN_ != null)
		{
			if (hHDLEADBJGN_ == null)
			{
				HHDLEADBJGN = new APMHDGPDGNP();
			}
			HHDLEADBJGN.MergeFrom(other.HHDLEADBJGN);
		}
		if (other.hCEHOHDCCFE_ != null)
		{
			if (hCEHOHDCCFE_ == null)
			{
				HCEHOHDCCFE = new CNMBIPOPOFH();
			}
			HCEHOHDCCFE.MergeFrom(other.HCEHOHDCCFE);
		}
		if (other.data_ != null)
		{
			if (data_ == null)
			{
				Data = new NCDBPKAIHIN();
			}
			Data.MergeFrom(other.Data);
		}
		avatarList_.Add(other.avatarList_);
		if (other.Time != 0L)
		{
			Time = other.Time;
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
			case 26u:
				Name = input.ReadString();
				break;
			case 32u:
				EndTime = input.ReadInt64();
				break;
			case 40u:
				KKGIEENCOIC = input.ReadUInt32();
				break;
			case 50u:
				if (hHDLEADBJGN_ == null)
				{
					HHDLEADBJGN = new APMHDGPDGNP();
				}
				input.ReadMessage(HHDLEADBJGN);
				break;
			case 58u:
				if (hCEHOHDCCFE_ == null)
				{
					HCEHOHDCCFE = new CNMBIPOPOFH();
				}
				input.ReadMessage(HCEHOHDCCFE);
				break;
			case 98u:
				if (data_ == null)
				{
					Data = new NCDBPKAIHIN();
				}
				input.ReadMessage(Data);
				break;
			case 106u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 120u:
				Time = input.ReadInt64();
				break;
			}
		}
	}
}
