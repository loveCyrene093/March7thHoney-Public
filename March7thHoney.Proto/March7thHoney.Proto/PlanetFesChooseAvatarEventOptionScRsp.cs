using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesChooseAvatarEventOptionScRsp : IMessage<PlanetFesChooseAvatarEventOptionScRsp>, IMessage, IEquatable<PlanetFesChooseAvatarEventOptionScRsp>, IDeepCloneable<PlanetFesChooseAvatarEventOptionScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesChooseAvatarEventOptionScRsp> _parser = new MessageParser<PlanetFesChooseAvatarEventOptionScRsp>(() => new PlanetFesChooseAvatarEventOptionScRsp());

	private UnknownFieldSet _unknownFields;

	public const int DIHECIIKELEFieldNumber = 5;

	private JIPACDEJKJC dIHECIIKELE_;

	public const int EEMNDGIPBICFieldNumber = 6;

	private uint eEMNDGIPBIC_;

	public const int RewardFieldNumber = 8;

	private HLLCDBLCIPK reward_;

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	public const int AAIJKIBONOOFieldNumber = 14;

	private uint aAIJKIBONOO_;

	public const int COKGOPBMLPPFieldNumber = 15;

	private uint cOKGOPBMLPP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesChooseAvatarEventOptionScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesChooseAvatarEventOptionScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint COKGOPBMLPP
	{
		get
		{
			return cOKGOPBMLPP_;
		}
		set
		{
			cOKGOPBMLPP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesChooseAvatarEventOptionScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesChooseAvatarEventOptionScRsp(PlanetFesChooseAvatarEventOptionScRsp other)
		: this()
	{
		dIHECIIKELE_ = ((other.dIHECIIKELE_ != null) ? other.dIHECIIKELE_.Clone() : null);
		eEMNDGIPBIC_ = other.eEMNDGIPBIC_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		retcode_ = other.retcode_;
		aAIJKIBONOO_ = other.aAIJKIBONOO_;
		cOKGOPBMLPP_ = other.cOKGOPBMLPP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesChooseAvatarEventOptionScRsp Clone()
	{
		return new PlanetFesChooseAvatarEventOptionScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesChooseAvatarEventOptionScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesChooseAvatarEventOptionScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DIHECIIKELE, other.DIHECIIKELE))
		{
			return false;
		}
		if (EEMNDGIPBIC != other.EEMNDGIPBIC)
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (AAIJKIBONOO != other.AAIJKIBONOO)
		{
			return false;
		}
		if (COKGOPBMLPP != other.COKGOPBMLPP)
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
		if (dIHECIIKELE_ != null)
		{
			num ^= DIHECIIKELE.GetHashCode();
		}
		if (EEMNDGIPBIC != 0)
		{
			num ^= EEMNDGIPBIC.GetHashCode();
		}
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (AAIJKIBONOO != 0)
		{
			num ^= AAIJKIBONOO.GetHashCode();
		}
		if (COKGOPBMLPP != 0)
		{
			num ^= COKGOPBMLPP.GetHashCode();
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
		if (dIHECIIKELE_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(DIHECIIKELE);
		}
		if (EEMNDGIPBIC != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(EEMNDGIPBIC);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Reward);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Retcode);
		}
		if (AAIJKIBONOO != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(AAIJKIBONOO);
		}
		if (COKGOPBMLPP != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(COKGOPBMLPP);
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
		if (dIHECIIKELE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DIHECIIKELE);
		}
		if (EEMNDGIPBIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EEMNDGIPBIC);
		}
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (AAIJKIBONOO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AAIJKIBONOO);
		}
		if (COKGOPBMLPP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(COKGOPBMLPP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesChooseAvatarEventOptionScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.dIHECIIKELE_ != null)
		{
			if (dIHECIIKELE_ == null)
			{
				DIHECIIKELE = new JIPACDEJKJC();
			}
			DIHECIIKELE.MergeFrom(other.DIHECIIKELE);
		}
		if (other.EEMNDGIPBIC != 0)
		{
			EEMNDGIPBIC = other.EEMNDGIPBIC;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new HLLCDBLCIPK();
			}
			Reward.MergeFrom(other.Reward);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.AAIJKIBONOO != 0)
		{
			AAIJKIBONOO = other.AAIJKIBONOO;
		}
		if (other.COKGOPBMLPP != 0)
		{
			COKGOPBMLPP = other.COKGOPBMLPP;
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
				if (dIHECIIKELE_ == null)
				{
					DIHECIIKELE = new JIPACDEJKJC();
				}
				input.ReadMessage(DIHECIIKELE);
				break;
			case 48u:
				EEMNDGIPBIC = input.ReadUInt32();
				break;
			case 66u:
				if (reward_ == null)
				{
					Reward = new HLLCDBLCIPK();
				}
				input.ReadMessage(Reward);
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			case 112u:
				AAIJKIBONOO = input.ReadUInt32();
				break;
			case 120u:
				COKGOPBMLPP = input.ReadUInt32();
				break;
			}
		}
	}
}
