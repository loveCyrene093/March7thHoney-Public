using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesBonusEventInteractScRsp : IMessage<PlanetFesBonusEventInteractScRsp>, IMessage, IEquatable<PlanetFesBonusEventInteractScRsp>, IDeepCloneable<PlanetFesBonusEventInteractScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesBonusEventInteractScRsp> _parser = new MessageParser<PlanetFesBonusEventInteractScRsp>(() => new PlanetFesBonusEventInteractScRsp());

	private UnknownFieldSet _unknownFields;

	public const int PHKAHAHLDAEFieldNumber = 2;

	private uint pHKAHAHLDAE_;

	public const int DIHECIIKELEFieldNumber = 7;

	private JIPACDEJKJC dIHECIIKELE_;

	public const int RewardFieldNumber = 8;

	private HLLCDBLCIPK reward_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesBonusEventInteractScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesBonusEventInteractScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PHKAHAHLDAE
	{
		get
		{
			return pHKAHAHLDAE_;
		}
		set
		{
			pHKAHAHLDAE_ = value;
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
	public PlanetFesBonusEventInteractScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesBonusEventInteractScRsp(PlanetFesBonusEventInteractScRsp other)
		: this()
	{
		pHKAHAHLDAE_ = other.pHKAHAHLDAE_;
		dIHECIIKELE_ = ((other.dIHECIIKELE_ != null) ? other.dIHECIIKELE_.Clone() : null);
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesBonusEventInteractScRsp Clone()
	{
		return new PlanetFesBonusEventInteractScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesBonusEventInteractScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesBonusEventInteractScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PHKAHAHLDAE != other.PHKAHAHLDAE)
		{
			return false;
		}
		if (!object.Equals(DIHECIIKELE, other.DIHECIIKELE))
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (PHKAHAHLDAE != 0)
		{
			num ^= PHKAHAHLDAE.GetHashCode();
		}
		if (dIHECIIKELE_ != null)
		{
			num ^= DIHECIIKELE.GetHashCode();
		}
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
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
		if (PHKAHAHLDAE != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PHKAHAHLDAE);
		}
		if (dIHECIIKELE_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(DIHECIIKELE);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Reward);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
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
		if (PHKAHAHLDAE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PHKAHAHLDAE);
		}
		if (dIHECIIKELE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DIHECIIKELE);
		}
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
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
	public void MergeFrom(PlanetFesBonusEventInteractScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PHKAHAHLDAE != 0)
		{
			PHKAHAHLDAE = other.PHKAHAHLDAE;
		}
		if (other.dIHECIIKELE_ != null)
		{
			if (dIHECIIKELE_ == null)
			{
				DIHECIIKELE = new JIPACDEJKJC();
			}
			DIHECIIKELE.MergeFrom(other.DIHECIIKELE);
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
				PHKAHAHLDAE = input.ReadUInt32();
				break;
			case 58u:
				if (dIHECIIKELE_ == null)
				{
					DIHECIIKELE = new JIPACDEJKJC();
				}
				input.ReadMessage(DIHECIIKELE);
				break;
			case 66u:
				if (reward_ == null)
				{
					Reward = new HLLCDBLCIPK();
				}
				input.ReadMessage(Reward);
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
