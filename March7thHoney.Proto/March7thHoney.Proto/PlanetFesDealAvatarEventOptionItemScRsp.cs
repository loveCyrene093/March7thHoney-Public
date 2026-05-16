using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesDealAvatarEventOptionItemScRsp : IMessage<PlanetFesDealAvatarEventOptionItemScRsp>, IMessage, IEquatable<PlanetFesDealAvatarEventOptionItemScRsp>, IDeepCloneable<PlanetFesDealAvatarEventOptionItemScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesDealAvatarEventOptionItemScRsp> _parser = new MessageParser<PlanetFesDealAvatarEventOptionItemScRsp>(() => new PlanetFesDealAvatarEventOptionItemScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ICOGAHFFCLDFieldNumber = 1;

	private bool iCOGAHFFCLD_;

	public const int AAIJKIBONOOFieldNumber = 7;

	private uint aAIJKIBONOO_;

	public const int RewardFieldNumber = 9;

	private HLLCDBLCIPK reward_;

	public const int EEMNDGIPBICFieldNumber = 10;

	private uint eEMNDGIPBIC_;

	public const int DIHECIIKELEFieldNumber = 12;

	private JIPACDEJKJC dIHECIIKELE_;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesDealAvatarEventOptionItemScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesDealAvatarEventOptionItemScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ICOGAHFFCLD
	{
		get
		{
			return iCOGAHFFCLD_;
		}
		set
		{
			iCOGAHFFCLD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AAIJKIBONOO
	{
		get
		{
			return aAIJKIBONOO_;
		}
		set
		{
			aAIJKIBONOO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLLCDBLCIPK Reward
	{
		get
		{
			return reward_;
		}
		set
		{
			reward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EEMNDGIPBIC
	{
		get
		{
			return eEMNDGIPBIC_;
		}
		set
		{
			eEMNDGIPBIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIPACDEJKJC DIHECIIKELE
	{
		get
		{
			return dIHECIIKELE_;
		}
		set
		{
			dIHECIIKELE_ = value;
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
	public PlanetFesDealAvatarEventOptionItemScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesDealAvatarEventOptionItemScRsp(PlanetFesDealAvatarEventOptionItemScRsp other)
		: this()
	{
		iCOGAHFFCLD_ = other.iCOGAHFFCLD_;
		aAIJKIBONOO_ = other.aAIJKIBONOO_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		eEMNDGIPBIC_ = other.eEMNDGIPBIC_;
		dIHECIIKELE_ = ((other.dIHECIIKELE_ != null) ? other.dIHECIIKELE_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesDealAvatarEventOptionItemScRsp Clone()
	{
		return new PlanetFesDealAvatarEventOptionItemScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesDealAvatarEventOptionItemScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesDealAvatarEventOptionItemScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ICOGAHFFCLD != other.ICOGAHFFCLD)
		{
			return false;
		}
		if (AAIJKIBONOO != other.AAIJKIBONOO)
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (EEMNDGIPBIC != other.EEMNDGIPBIC)
		{
			return false;
		}
		if (!object.Equals(DIHECIIKELE, other.DIHECIIKELE))
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
		if (ICOGAHFFCLD)
		{
			num ^= ICOGAHFFCLD.GetHashCode();
		}
		if (AAIJKIBONOO != 0)
		{
			num ^= AAIJKIBONOO.GetHashCode();
		}
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		if (EEMNDGIPBIC != 0)
		{
			num ^= EEMNDGIPBIC.GetHashCode();
		}
		if (dIHECIIKELE_ != null)
		{
			num ^= DIHECIIKELE.GetHashCode();
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
		if (ICOGAHFFCLD)
		{
			output.WriteRawTag(8);
			output.WriteBool(ICOGAHFFCLD);
		}
		if (AAIJKIBONOO != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(AAIJKIBONOO);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Reward);
		}
		if (EEMNDGIPBIC != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(EEMNDGIPBIC);
		}
		if (dIHECIIKELE_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(DIHECIIKELE);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
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
		if (ICOGAHFFCLD)
		{
			num += 2;
		}
		if (AAIJKIBONOO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AAIJKIBONOO);
		}
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (EEMNDGIPBIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EEMNDGIPBIC);
		}
		if (dIHECIIKELE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DIHECIIKELE);
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
	public void MergeFrom(PlanetFesDealAvatarEventOptionItemScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ICOGAHFFCLD)
		{
			ICOGAHFFCLD = other.ICOGAHFFCLD;
		}
		if (other.AAIJKIBONOO != 0)
		{
			AAIJKIBONOO = other.AAIJKIBONOO;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new HLLCDBLCIPK();
			}
			Reward.MergeFrom(other.Reward);
		}
		if (other.EEMNDGIPBIC != 0)
		{
			EEMNDGIPBIC = other.EEMNDGIPBIC;
		}
		if (other.dIHECIIKELE_ != null)
		{
			if (dIHECIIKELE_ == null)
			{
				DIHECIIKELE = new JIPACDEJKJC();
			}
			DIHECIIKELE.MergeFrom(other.DIHECIIKELE);
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
			case 8u:
				ICOGAHFFCLD = input.ReadBool();
				break;
			case 56u:
				AAIJKIBONOO = input.ReadUInt32();
				break;
			case 74u:
				if (reward_ == null)
				{
					Reward = new HLLCDBLCIPK();
				}
				input.ReadMessage(Reward);
				break;
			case 80u:
				EEMNDGIPBIC = input.ReadUInt32();
				break;
			case 98u:
				if (dIHECIIKELE_ == null)
				{
					DIHECIIKELE = new JIPACDEJKJC();
				}
				input.ReadMessage(DIHECIIKELE);
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
