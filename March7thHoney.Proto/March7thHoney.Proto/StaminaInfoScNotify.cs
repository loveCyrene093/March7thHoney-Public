using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StaminaInfoScNotify : IMessage<StaminaInfoScNotify>, IMessage, IEquatable<StaminaInfoScNotify>, IDeepCloneable<StaminaInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<StaminaInfoScNotify> _parser = new MessageParser<StaminaInfoScNotify>(() => new StaminaInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int NextRecoverTimeFieldNumber = 4;

	private long nextRecoverTime_;

	public const int StaminaFieldNumber = 6;

	private uint stamina_;

	public const int DLDIPAHPKOFFieldNumber = 7;

	private long dLDIPAHPKOF_;

	public const int ReserveStaminaFieldNumber = 8;

	private uint reserveStamina_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StaminaInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StaminaInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long NextRecoverTime
	{
		get
		{
			return nextRecoverTime_;
		}
		set
		{
			nextRecoverTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Stamina
	{
		get
		{
			return stamina_;
		}
		set
		{
			stamina_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DLDIPAHPKOF
	{
		get
		{
			return dLDIPAHPKOF_;
		}
		set
		{
			dLDIPAHPKOF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ReserveStamina
	{
		get
		{
			return reserveStamina_;
		}
		set
		{
			reserveStamina_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StaminaInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StaminaInfoScNotify(StaminaInfoScNotify other)
		: this()
	{
		nextRecoverTime_ = other.nextRecoverTime_;
		stamina_ = other.stamina_;
		dLDIPAHPKOF_ = other.dLDIPAHPKOF_;
		reserveStamina_ = other.reserveStamina_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StaminaInfoScNotify Clone()
	{
		return new StaminaInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StaminaInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StaminaInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NextRecoverTime != other.NextRecoverTime)
		{
			return false;
		}
		if (Stamina != other.Stamina)
		{
			return false;
		}
		if (DLDIPAHPKOF != other.DLDIPAHPKOF)
		{
			return false;
		}
		if (ReserveStamina != other.ReserveStamina)
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
		if (NextRecoverTime != 0L)
		{
			num ^= NextRecoverTime.GetHashCode();
		}
		if (Stamina != 0)
		{
			num ^= Stamina.GetHashCode();
		}
		if (DLDIPAHPKOF != 0L)
		{
			num ^= DLDIPAHPKOF.GetHashCode();
		}
		if (ReserveStamina != 0)
		{
			num ^= ReserveStamina.GetHashCode();
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
		if (NextRecoverTime != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(NextRecoverTime);
		}
		if (Stamina != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Stamina);
		}
		if (DLDIPAHPKOF != 0L)
		{
			output.WriteRawTag(56);
			output.WriteInt64(DLDIPAHPKOF);
		}
		if (ReserveStamina != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(ReserveStamina);
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
		if (NextRecoverTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(NextRecoverTime);
		}
		if (Stamina != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Stamina);
		}
		if (DLDIPAHPKOF != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DLDIPAHPKOF);
		}
		if (ReserveStamina != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ReserveStamina);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StaminaInfoScNotify other)
	{
		if (other != null)
		{
			if (other.NextRecoverTime != 0L)
			{
				NextRecoverTime = other.NextRecoverTime;
			}
			if (other.Stamina != 0)
			{
				Stamina = other.Stamina;
			}
			if (other.DLDIPAHPKOF != 0L)
			{
				DLDIPAHPKOF = other.DLDIPAHPKOF;
			}
			if (other.ReserveStamina != 0)
			{
				ReserveStamina = other.ReserveStamina;
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
			case 32u:
				NextRecoverTime = input.ReadInt64();
				break;
			case 48u:
				Stamina = input.ReadUInt32();
				break;
			case 56u:
				DLDIPAHPKOF = input.ReadInt64();
				break;
			case 64u:
				ReserveStamina = input.ReadUInt32();
				break;
			}
		}
	}
}
