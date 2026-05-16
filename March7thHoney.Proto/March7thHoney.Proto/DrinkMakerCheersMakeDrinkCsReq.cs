using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DrinkMakerCheersMakeDrinkCsReq : IMessage<DrinkMakerCheersMakeDrinkCsReq>, IMessage, IEquatable<DrinkMakerCheersMakeDrinkCsReq>, IDeepCloneable<DrinkMakerCheersMakeDrinkCsReq>, IBufferMessage
{
	private static readonly MessageParser<DrinkMakerCheersMakeDrinkCsReq> _parser = new MessageParser<DrinkMakerCheersMakeDrinkCsReq>(() => new DrinkMakerCheersMakeDrinkCsReq());

	private UnknownFieldSet _unknownFields;

	public const int FNNMELEEABIFieldNumber = 5;

	private bool fNNMELEEABI_;

	public const int IHDMLHFAEKHFieldNumber = 7;

	private CIGKBDIGGOI iHDMLHFAEKH_;

	public const int GroupIdFieldNumber = 13;

	private uint groupId_;

	public const int NMKJBKCEIGPFieldNumber = 15;

	private uint nMKJBKCEIGP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DrinkMakerCheersMakeDrinkCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DrinkMakerCheersMakeDrinkCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FNNMELEEABI
	{
		get
		{
			return fNNMELEEABI_;
		}
		set
		{
			fNNMELEEABI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIGKBDIGGOI IHDMLHFAEKH
	{
		get
		{
			return iHDMLHFAEKH_;
		}
		set
		{
			iHDMLHFAEKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NMKJBKCEIGP
	{
		get
		{
			return nMKJBKCEIGP_;
		}
		set
		{
			nMKJBKCEIGP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DrinkMakerCheersMakeDrinkCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DrinkMakerCheersMakeDrinkCsReq(DrinkMakerCheersMakeDrinkCsReq other)
		: this()
	{
		fNNMELEEABI_ = other.fNNMELEEABI_;
		iHDMLHFAEKH_ = ((other.iHDMLHFAEKH_ != null) ? other.iHDMLHFAEKH_.Clone() : null);
		groupId_ = other.groupId_;
		nMKJBKCEIGP_ = other.nMKJBKCEIGP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DrinkMakerCheersMakeDrinkCsReq Clone()
	{
		return new DrinkMakerCheersMakeDrinkCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DrinkMakerCheersMakeDrinkCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DrinkMakerCheersMakeDrinkCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FNNMELEEABI != other.FNNMELEEABI)
		{
			return false;
		}
		if (!object.Equals(IHDMLHFAEKH, other.IHDMLHFAEKH))
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (NMKJBKCEIGP != other.NMKJBKCEIGP)
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
		if (FNNMELEEABI)
		{
			num ^= FNNMELEEABI.GetHashCode();
		}
		if (iHDMLHFAEKH_ != null)
		{
			num ^= IHDMLHFAEKH.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (NMKJBKCEIGP != 0)
		{
			num ^= NMKJBKCEIGP.GetHashCode();
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
		if (FNNMELEEABI)
		{
			output.WriteRawTag(40);
			output.WriteBool(FNNMELEEABI);
		}
		if (iHDMLHFAEKH_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(IHDMLHFAEKH);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(GroupId);
		}
		if (NMKJBKCEIGP != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(NMKJBKCEIGP);
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
		if (FNNMELEEABI)
		{
			num += 2;
		}
		if (iHDMLHFAEKH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IHDMLHFAEKH);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (NMKJBKCEIGP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NMKJBKCEIGP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DrinkMakerCheersMakeDrinkCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.FNNMELEEABI)
		{
			FNNMELEEABI = other.FNNMELEEABI;
		}
		if (other.iHDMLHFAEKH_ != null)
		{
			if (iHDMLHFAEKH_ == null)
			{
				IHDMLHFAEKH = new CIGKBDIGGOI();
			}
			IHDMLHFAEKH.MergeFrom(other.IHDMLHFAEKH);
		}
		if (other.GroupId != 0)
		{
			GroupId = other.GroupId;
		}
		if (other.NMKJBKCEIGP != 0)
		{
			NMKJBKCEIGP = other.NMKJBKCEIGP;
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
			case 40u:
				FNNMELEEABI = input.ReadBool();
				break;
			case 58u:
				if (iHDMLHFAEKH_ == null)
				{
					IHDMLHFAEKH = new CIGKBDIGGOI();
				}
				input.ReadMessage(IHDMLHFAEKH);
				break;
			case 104u:
				GroupId = input.ReadUInt32();
				break;
			case 120u:
				NMKJBKCEIGP = input.ReadUInt32();
				break;
			}
		}
	}
}
