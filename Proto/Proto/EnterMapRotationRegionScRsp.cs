using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnterMapRotationRegionScRsp : IMessage<EnterMapRotationRegionScRsp>, IMessage, IEquatable<EnterMapRotationRegionScRsp>, IDeepCloneable<EnterMapRotationRegionScRsp>, IBufferMessage
{
	private static readonly MessageParser<EnterMapRotationRegionScRsp> _parser = new MessageParser<EnterMapRotationRegionScRsp>(() => new EnterMapRotationRegionScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ClientPosVersionFieldNumber = 6;

	private uint clientPosVersion_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int EnergyInfoFieldNumber = 8;

	private RotaterEnergyInfo energyInfo_;

	public const int JHDLNBPNEKGFieldNumber = 10;

	private uint jHDLNBPNEKG_;

	public const int MotionFieldNumber = 13;

	private MotionInfo motion_;

	public const int BCPCBHMFIINFieldNumber = 14;

	private uint bCPCBHMFIIN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnterMapRotationRegionScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnterMapRotationRegionScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ClientPosVersion
	{
		get
		{
			return clientPosVersion_;
		}
		set
		{
			clientPosVersion_ = value;
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
	public uint JHDLNBPNEKG
	{
		get
		{
			return jHDLNBPNEKG_;
		}
		set
		{
			jHDLNBPNEKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MotionInfo Motion
	{
		get
		{
			return motion_;
		}
		set
		{
			motion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BCPCBHMFIIN
	{
		get
		{
			return bCPCBHMFIIN_;
		}
		set
		{
			bCPCBHMFIIN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterMapRotationRegionScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterMapRotationRegionScRsp(EnterMapRotationRegionScRsp other)
		: this()
	{
		clientPosVersion_ = other.clientPosVersion_;
		retcode_ = other.retcode_;
		energyInfo_ = ((other.energyInfo_ != null) ? other.energyInfo_.Clone() : null);
		jHDLNBPNEKG_ = other.jHDLNBPNEKG_;
		motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
		bCPCBHMFIIN_ = other.bCPCBHMFIIN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterMapRotationRegionScRsp Clone()
	{
		return new EnterMapRotationRegionScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnterMapRotationRegionScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnterMapRotationRegionScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ClientPosVersion != other.ClientPosVersion)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(EnergyInfo, other.EnergyInfo))
		{
			return false;
		}
		if (JHDLNBPNEKG != other.JHDLNBPNEKG)
		{
			return false;
		}
		if (!object.Equals(Motion, other.Motion))
		{
			return false;
		}
		if (BCPCBHMFIIN != other.BCPCBHMFIIN)
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
		if (ClientPosVersion != 0)
		{
			num ^= ClientPosVersion.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (energyInfo_ != null)
		{
			num ^= EnergyInfo.GetHashCode();
		}
		if (JHDLNBPNEKG != 0)
		{
			num ^= JHDLNBPNEKG.GetHashCode();
		}
		if (motion_ != null)
		{
			num ^= Motion.GetHashCode();
		}
		if (BCPCBHMFIIN != 0)
		{
			num ^= BCPCBHMFIIN.GetHashCode();
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
		if (ClientPosVersion != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(ClientPosVersion);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (energyInfo_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(EnergyInfo);
		}
		if (JHDLNBPNEKG != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(JHDLNBPNEKG);
		}
		if (motion_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(Motion);
		}
		if (BCPCBHMFIIN != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(BCPCBHMFIIN);
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
		if (ClientPosVersion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ClientPosVersion);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (energyInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EnergyInfo);
		}
		if (JHDLNBPNEKG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JHDLNBPNEKG);
		}
		if (motion_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Motion);
		}
		if (BCPCBHMFIIN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BCPCBHMFIIN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EnterMapRotationRegionScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ClientPosVersion != 0)
		{
			ClientPosVersion = other.ClientPosVersion;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.energyInfo_ != null)
		{
			if (energyInfo_ == null)
			{
				EnergyInfo = new RotaterEnergyInfo();
			}
			EnergyInfo.MergeFrom(other.EnergyInfo);
		}
		if (other.JHDLNBPNEKG != 0)
		{
			JHDLNBPNEKG = other.JHDLNBPNEKG;
		}
		if (other.motion_ != null)
		{
			if (motion_ == null)
			{
				Motion = new MotionInfo();
			}
			Motion.MergeFrom(other.Motion);
		}
		if (other.BCPCBHMFIIN != 0)
		{
			BCPCBHMFIIN = other.BCPCBHMFIIN;
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
			case 48u:
				ClientPosVersion = input.ReadUInt32();
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 66u:
				if (energyInfo_ == null)
				{
					EnergyInfo = new RotaterEnergyInfo();
				}
				input.ReadMessage(EnergyInfo);
				break;
			case 80u:
				JHDLNBPNEKG = input.ReadUInt32();
				break;
			case 106u:
				if (motion_ == null)
				{
					Motion = new MotionInfo();
				}
				input.ReadMessage(Motion);
				break;
			case 112u:
				BCPCBHMFIIN = input.ReadUInt32();
				break;
			}
		}
	}
}
