using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class InteractChargerScRsp : IMessage<InteractChargerScRsp>, IMessage, IEquatable<InteractChargerScRsp>, IDeepCloneable<InteractChargerScRsp>, IBufferMessage
{
	private static readonly MessageParser<InteractChargerScRsp> _parser = new MessageParser<InteractChargerScRsp>(() => new InteractChargerScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ChargerInfoFieldNumber = 8;

	private ChargerInfo chargerInfo_;

	public const int EnergyInfoFieldNumber = 10;

	private RotaterEnergyInfo energyInfo_;

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<InteractChargerScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => InteractChargerScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChargerInfo ChargerInfo
	{
		get
		{
			return chargerInfo_;
		}
		set
		{
			chargerInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RotaterEnergyInfo EnergyInfo
	{
		get
		{
			return energyInfo_;
		}
		set
		{
			energyInfo_ = value;
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
	public InteractChargerScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractChargerScRsp(InteractChargerScRsp other)
		: this()
	{
		chargerInfo_ = ((other.chargerInfo_ != null) ? other.chargerInfo_.Clone() : null);
		energyInfo_ = ((other.energyInfo_ != null) ? other.energyInfo_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractChargerScRsp Clone()
	{
		return new InteractChargerScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as InteractChargerScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(InteractChargerScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ChargerInfo, other.ChargerInfo))
		{
			return false;
		}
		if (!object.Equals(EnergyInfo, other.EnergyInfo))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (chargerInfo_ != null)
		{
			num ^= ChargerInfo.GetHashCode();
		}
		if (energyInfo_ != null)
		{
			num ^= EnergyInfo.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (chargerInfo_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(ChargerInfo);
		}
		if (energyInfo_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(EnergyInfo);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Retcode);
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
		if (chargerInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ChargerInfo);
		}
		if (energyInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EnergyInfo);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(InteractChargerScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.chargerInfo_ != null)
		{
			if (chargerInfo_ == null)
			{
				ChargerInfo = new ChargerInfo();
			}
			ChargerInfo.MergeFrom(other.ChargerInfo);
		}
		if (other.energyInfo_ != null)
		{
			if (energyInfo_ == null)
			{
				EnergyInfo = new RotaterEnergyInfo();
			}
			EnergyInfo.MergeFrom(other.EnergyInfo);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 66u:
				if (chargerInfo_ == null)
				{
					ChargerInfo = new ChargerInfo();
				}
				input.ReadMessage(ChargerInfo);
				break;
			case 82u:
				if (energyInfo_ == null)
				{
					EnergyInfo = new RotaterEnergyInfo();
				}
				input.ReadMessage(EnergyInfo);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
