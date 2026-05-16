using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HHBEDPMHNDK : IMessage<HHBEDPMHNDK>, IMessage, IEquatable<HHBEDPMHNDK>, IDeepCloneable<HHBEDPMHNDK>, IBufferMessage
{
	private static readonly MessageParser<HHBEDPMHNDK> _parser = new MessageParser<HHBEDPMHNDK>(() => new HHBEDPMHNDK());

	private UnknownFieldSet _unknownFields;

	public const int AKHFEKJNPFGFieldNumber = 5;

	private static readonly FieldCodec<FLLEBEICKCE> _repeated_aKHFEKJNPFG_codec = FieldCodec.ForMessage(42u, FLLEBEICKCE.Parser);

	private readonly RepeatedField<FLLEBEICKCE> aKHFEKJNPFG_ = new RepeatedField<FLLEBEICKCE>();

	public const int TotalDamageFieldNumber = 7;

	private uint totalDamage_;

	public const int NKIKEDHAIENFieldNumber = 8;

	private static readonly FieldCodec<FLLEBEICKCE> _repeated_nKIKEDHAIEN_codec = FieldCodec.ForMessage(66u, FLLEBEICKCE.Parser);

	private readonly RepeatedField<FLLEBEICKCE> nKIKEDHAIEN_ = new RepeatedField<FLLEBEICKCE>();

	public const int DDEKLGHPNMEFieldNumber = 10;

	private IPMPONAHFBG dDEKLGHPNME_;

	public const int CostTimeFieldNumber = 15;

	private uint costTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HHBEDPMHNDK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HHBEDPMHNDKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FLLEBEICKCE> AKHFEKJNPFG => aKHFEKJNPFG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TotalDamage
	{
		get
		{
			return totalDamage_;
		}
		set
		{
			totalDamage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FLLEBEICKCE> NKIKEDHAIEN => nKIKEDHAIEN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPMPONAHFBG DDEKLGHPNME
	{
		get
		{
			return dDEKLGHPNME_;
		}
		set
		{
			dDEKLGHPNME_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CostTime
	{
		get
		{
			return costTime_;
		}
		set
		{
			costTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHBEDPMHNDK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHBEDPMHNDK(HHBEDPMHNDK other)
		: this()
	{
		aKHFEKJNPFG_ = other.aKHFEKJNPFG_.Clone();
		totalDamage_ = other.totalDamage_;
		nKIKEDHAIEN_ = other.nKIKEDHAIEN_.Clone();
		dDEKLGHPNME_ = ((other.dDEKLGHPNME_ != null) ? other.dDEKLGHPNME_.Clone() : null);
		costTime_ = other.costTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHBEDPMHNDK Clone()
	{
		return new HHBEDPMHNDK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HHBEDPMHNDK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HHBEDPMHNDK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aKHFEKJNPFG_.Equals(other.aKHFEKJNPFG_))
		{
			return false;
		}
		if (TotalDamage != other.TotalDamage)
		{
			return false;
		}
		if (!nKIKEDHAIEN_.Equals(other.nKIKEDHAIEN_))
		{
			return false;
		}
		if (!object.Equals(DDEKLGHPNME, other.DDEKLGHPNME))
		{
			return false;
		}
		if (CostTime != other.CostTime)
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
		num ^= aKHFEKJNPFG_.GetHashCode();
		if (TotalDamage != 0)
		{
			num ^= TotalDamage.GetHashCode();
		}
		num ^= nKIKEDHAIEN_.GetHashCode();
		if (dDEKLGHPNME_ != null)
		{
			num ^= DDEKLGHPNME.GetHashCode();
		}
		if (CostTime != 0)
		{
			num ^= CostTime.GetHashCode();
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
		aKHFEKJNPFG_.WriteTo(ref output, _repeated_aKHFEKJNPFG_codec);
		if (TotalDamage != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(TotalDamage);
		}
		nKIKEDHAIEN_.WriteTo(ref output, _repeated_nKIKEDHAIEN_codec);
		if (dDEKLGHPNME_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(DDEKLGHPNME);
		}
		if (CostTime != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(CostTime);
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
		num += aKHFEKJNPFG_.CalculateSize(_repeated_aKHFEKJNPFG_codec);
		if (TotalDamage != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TotalDamage);
		}
		num += nKIKEDHAIEN_.CalculateSize(_repeated_nKIKEDHAIEN_codec);
		if (dDEKLGHPNME_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DDEKLGHPNME);
		}
		if (CostTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CostTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HHBEDPMHNDK other)
	{
		if (other == null)
		{
			return;
		}
		aKHFEKJNPFG_.Add(other.aKHFEKJNPFG_);
		if (other.TotalDamage != 0)
		{
			TotalDamage = other.TotalDamage;
		}
		nKIKEDHAIEN_.Add(other.nKIKEDHAIEN_);
		if (other.dDEKLGHPNME_ != null)
		{
			if (dDEKLGHPNME_ == null)
			{
				DDEKLGHPNME = new IPMPONAHFBG();
			}
			DDEKLGHPNME.MergeFrom(other.DDEKLGHPNME);
		}
		if (other.CostTime != 0)
		{
			CostTime = other.CostTime;
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
			case 42u:
				aKHFEKJNPFG_.AddEntriesFrom(ref input, _repeated_aKHFEKJNPFG_codec);
				break;
			case 56u:
				TotalDamage = input.ReadUInt32();
				break;
			case 66u:
				nKIKEDHAIEN_.AddEntriesFrom(ref input, _repeated_nKIKEDHAIEN_codec);
				break;
			case 82u:
				if (dDEKLGHPNME_ == null)
				{
					DDEKLGHPNME = new IPMPONAHFBG();
				}
				input.ReadMessage(DDEKLGHPNME);
				break;
			case 120u:
				CostTime = input.ReadUInt32();
				break;
			}
		}
	}
}
