using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BKNMOOFGGKH : IMessage<BKNMOOFGGKH>, IMessage, IEquatable<BKNMOOFGGKH>, IDeepCloneable<BKNMOOFGGKH>, IBufferMessage
{
	private static readonly MessageParser<BKNMOOFGGKH> _parser = new MessageParser<BKNMOOFGGKH>(() => new BKNMOOFGGKH());

	private UnknownFieldSet _unknownFields;

	public const int KKGIEENCOICFieldNumber = 2;

	private uint kKGIEENCOIC_;

	public const int EOGACILLEBOFieldNumber = 3;

	private AKCFLPEANJB eOGACILLEBO_;

	public const int ALMALADADFBFieldNumber = 4;

	private long aLMALADADFB_;

	public const int NameFieldNumber = 6;

	private string name_ = "";

	public const int TimeFieldNumber = 7;

	private long time_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BKNMOOFGGKH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BKNMOOFGGKHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public AKCFLPEANJB EOGACILLEBO
	{
		get
		{
			return eOGACILLEBO_;
		}
		set
		{
			eOGACILLEBO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ALMALADADFB
	{
		get
		{
			return aLMALADADFB_;
		}
		set
		{
			aLMALADADFB_ = value;
		}
	}

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
	public BKNMOOFGGKH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BKNMOOFGGKH(BKNMOOFGGKH other)
		: this()
	{
		kKGIEENCOIC_ = other.kKGIEENCOIC_;
		eOGACILLEBO_ = ((other.eOGACILLEBO_ != null) ? other.eOGACILLEBO_.Clone() : null);
		aLMALADADFB_ = other.aLMALADADFB_;
		name_ = other.name_;
		time_ = other.time_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BKNMOOFGGKH Clone()
	{
		return new BKNMOOFGGKH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BKNMOOFGGKH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BKNMOOFGGKH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KKGIEENCOIC != other.KKGIEENCOIC)
		{
			return false;
		}
		if (!object.Equals(EOGACILLEBO, other.EOGACILLEBO))
		{
			return false;
		}
		if (ALMALADADFB != other.ALMALADADFB)
		{
			return false;
		}
		if (Name != other.Name)
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
		if (KKGIEENCOIC != 0)
		{
			num ^= KKGIEENCOIC.GetHashCode();
		}
		if (eOGACILLEBO_ != null)
		{
			num ^= EOGACILLEBO.GetHashCode();
		}
		if (ALMALADADFB != 0L)
		{
			num ^= ALMALADADFB.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
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
		if (KKGIEENCOIC != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(KKGIEENCOIC);
		}
		if (eOGACILLEBO_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(EOGACILLEBO);
		}
		if (ALMALADADFB != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(ALMALADADFB);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Name);
		}
		if (Time != 0L)
		{
			output.WriteRawTag(56);
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
		if (KKGIEENCOIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKGIEENCOIC);
		}
		if (eOGACILLEBO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EOGACILLEBO);
		}
		if (ALMALADADFB != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(ALMALADADFB);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
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
	public void MergeFrom(BKNMOOFGGKH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.KKGIEENCOIC != 0)
		{
			KKGIEENCOIC = other.KKGIEENCOIC;
		}
		if (other.eOGACILLEBO_ != null)
		{
			if (eOGACILLEBO_ == null)
			{
				EOGACILLEBO = new AKCFLPEANJB();
			}
			EOGACILLEBO.MergeFrom(other.EOGACILLEBO);
		}
		if (other.ALMALADADFB != 0L)
		{
			ALMALADADFB = other.ALMALADADFB;
		}
		if (other.Name.Length != 0)
		{
			Name = other.Name;
		}
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
			case 16u:
				KKGIEENCOIC = input.ReadUInt32();
				break;
			case 26u:
				if (eOGACILLEBO_ == null)
				{
					EOGACILLEBO = new AKCFLPEANJB();
				}
				input.ReadMessage(EOGACILLEBO);
				break;
			case 32u:
				ALMALADADFB = input.ReadInt64();
				break;
			case 50u:
				Name = input.ReadString();
				break;
			case 56u:
				Time = input.ReadInt64();
				break;
			}
		}
	}
}
