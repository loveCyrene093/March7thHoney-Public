using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DCEBJIGAPEI : IMessage<DCEBJIGAPEI>, IMessage, IEquatable<DCEBJIGAPEI>, IDeepCloneable<DCEBJIGAPEI>, IBufferMessage
{
	private static readonly MessageParser<DCEBJIGAPEI> _parser = new MessageParser<DCEBJIGAPEI>(() => new DCEBJIGAPEI());

	private UnknownFieldSet _unknownFields;

	public const int HAIOHANDIKIFieldNumber = 4;

	private static readonly FieldCodec<LKFNDAOGMMO> _repeated_hAIOHANDIKI_codec = FieldCodec.ForMessage(34u, LKFNDAOGMMO.Parser);

	private readonly RepeatedField<LKFNDAOGMMO> hAIOHANDIKI_ = new RepeatedField<LKFNDAOGMMO>();

	public const int WaveFieldNumber = 6;

	private uint wave_;

	public const int MaxHpFieldNumber = 7;

	private uint maxHp_;

	public const int CurHpFieldNumber = 9;

	private uint curHp_;

	public const int StageIdFieldNumber = 10;

	private uint stageId_;

	public const int ReasonFieldNumber = 15;

	private GLJLEEPOCDA reason_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DCEBJIGAPEI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DCEBJIGAPEIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LKFNDAOGMMO> HAIOHANDIKI => hAIOHANDIKI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Wave
	{
		get
		{
			return wave_;
		}
		set
		{
			wave_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MaxHp
	{
		get
		{
			return maxHp_;
		}
		set
		{
			maxHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurHp
	{
		get
		{
			return curHp_;
		}
		set
		{
			curHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLJLEEPOCDA Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCEBJIGAPEI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCEBJIGAPEI(DCEBJIGAPEI other)
		: this()
	{
		hAIOHANDIKI_ = other.hAIOHANDIKI_.Clone();
		wave_ = other.wave_;
		maxHp_ = other.maxHp_;
		curHp_ = other.curHp_;
		stageId_ = other.stageId_;
		reason_ = other.reason_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCEBJIGAPEI Clone()
	{
		return new DCEBJIGAPEI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DCEBJIGAPEI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DCEBJIGAPEI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hAIOHANDIKI_.Equals(other.hAIOHANDIKI_))
		{
			return false;
		}
		if (Wave != other.Wave)
		{
			return false;
		}
		if (MaxHp != other.MaxHp)
		{
			return false;
		}
		if (CurHp != other.CurHp)
		{
			return false;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (Reason != other.Reason)
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
		num ^= hAIOHANDIKI_.GetHashCode();
		if (Wave != 0)
		{
			num ^= Wave.GetHashCode();
		}
		if (MaxHp != 0)
		{
			num ^= MaxHp.GetHashCode();
		}
		if (CurHp != 0)
		{
			num ^= CurHp.GetHashCode();
		}
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		if (Reason != GLJLEEPOCDA.Pcpdhelpkem)
		{
			num ^= Reason.GetHashCode();
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
		hAIOHANDIKI_.WriteTo(ref output, _repeated_hAIOHANDIKI_codec);
		if (Wave != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Wave);
		}
		if (MaxHp != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(MaxHp);
		}
		if (CurHp != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(CurHp);
		}
		if (StageId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(StageId);
		}
		if (Reason != GLJLEEPOCDA.Pcpdhelpkem)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)Reason);
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
		num += hAIOHANDIKI_.CalculateSize(_repeated_hAIOHANDIKI_codec);
		if (Wave != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Wave);
		}
		if (MaxHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxHp);
		}
		if (CurHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurHp);
		}
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (Reason != GLJLEEPOCDA.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DCEBJIGAPEI other)
	{
		if (other != null)
		{
			hAIOHANDIKI_.Add(other.hAIOHANDIKI_);
			if (other.Wave != 0)
			{
				Wave = other.Wave;
			}
			if (other.MaxHp != 0)
			{
				MaxHp = other.MaxHp;
			}
			if (other.CurHp != 0)
			{
				CurHp = other.CurHp;
			}
			if (other.StageId != 0)
			{
				StageId = other.StageId;
			}
			if (other.Reason != GLJLEEPOCDA.Pcpdhelpkem)
			{
				Reason = other.Reason;
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
			case 34u:
				hAIOHANDIKI_.AddEntriesFrom(ref input, _repeated_hAIOHANDIKI_codec);
				break;
			case 48u:
				Wave = input.ReadUInt32();
				break;
			case 56u:
				MaxHp = input.ReadUInt32();
				break;
			case 72u:
				CurHp = input.ReadUInt32();
				break;
			case 80u:
				StageId = input.ReadUInt32();
				break;
			case 120u:
				Reason = (GLJLEEPOCDA)input.ReadEnum();
				break;
			}
		}
	}
}
