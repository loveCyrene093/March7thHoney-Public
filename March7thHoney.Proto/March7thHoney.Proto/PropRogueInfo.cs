using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PropRogueInfo : IMessage<PropRogueInfo>, IMessage, IEquatable<PropRogueInfo>, IDeepCloneable<PropRogueInfo>, IBufferMessage
{
	private static readonly MessageParser<PropRogueInfo> _parser = new MessageParser<PropRogueInfo>(() => new PropRogueInfo());

	private UnknownFieldSet _unknownFields;

	public const int CNPOJFHKEKHFieldNumber = 2;

	private uint cNPOJFHKEKH_;

	public const int HCMJDMFNENEFieldNumber = 5;

	private uint hCMJDMFNENE_;

	public const int RoomIdFieldNumber = 8;

	private uint roomId_;

	public const int KGFFNDAINAKFieldNumber = 15;

	private uint kGFFNDAINAK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PropRogueInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PropRogueInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CNPOJFHKEKH
	{
		get
		{
			return cNPOJFHKEKH_;
		}
		set
		{
			cNPOJFHKEKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCMJDMFNENE
	{
		get
		{
			return hCMJDMFNENE_;
		}
		set
		{
			hCMJDMFNENE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoomId
	{
		get
		{
			return roomId_;
		}
		set
		{
			roomId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KGFFNDAINAK
	{
		get
		{
			return kGFFNDAINAK_;
		}
		set
		{
			kGFFNDAINAK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PropRogueInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PropRogueInfo(PropRogueInfo other)
		: this()
	{
		cNPOJFHKEKH_ = other.cNPOJFHKEKH_;
		hCMJDMFNENE_ = other.hCMJDMFNENE_;
		roomId_ = other.roomId_;
		kGFFNDAINAK_ = other.kGFFNDAINAK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PropRogueInfo Clone()
	{
		return new PropRogueInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PropRogueInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PropRogueInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CNPOJFHKEKH != other.CNPOJFHKEKH)
		{
			return false;
		}
		if (HCMJDMFNENE != other.HCMJDMFNENE)
		{
			return false;
		}
		if (RoomId != other.RoomId)
		{
			return false;
		}
		if (KGFFNDAINAK != other.KGFFNDAINAK)
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
		if (CNPOJFHKEKH != 0)
		{
			num ^= CNPOJFHKEKH.GetHashCode();
		}
		if (HCMJDMFNENE != 0)
		{
			num ^= HCMJDMFNENE.GetHashCode();
		}
		if (RoomId != 0)
		{
			num ^= RoomId.GetHashCode();
		}
		if (KGFFNDAINAK != 0)
		{
			num ^= KGFFNDAINAK.GetHashCode();
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
		if (CNPOJFHKEKH != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CNPOJFHKEKH);
		}
		if (HCMJDMFNENE != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(HCMJDMFNENE);
		}
		if (RoomId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(RoomId);
		}
		if (KGFFNDAINAK != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(KGFFNDAINAK);
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
		if (CNPOJFHKEKH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CNPOJFHKEKH);
		}
		if (HCMJDMFNENE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCMJDMFNENE);
		}
		if (RoomId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoomId);
		}
		if (KGFFNDAINAK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KGFFNDAINAK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PropRogueInfo other)
	{
		if (other != null)
		{
			if (other.CNPOJFHKEKH != 0)
			{
				CNPOJFHKEKH = other.CNPOJFHKEKH;
			}
			if (other.HCMJDMFNENE != 0)
			{
				HCMJDMFNENE = other.HCMJDMFNENE;
			}
			if (other.RoomId != 0)
			{
				RoomId = other.RoomId;
			}
			if (other.KGFFNDAINAK != 0)
			{
				KGFFNDAINAK = other.KGFFNDAINAK;
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
			case 16u:
				CNPOJFHKEKH = input.ReadUInt32();
				break;
			case 40u:
				HCMJDMFNENE = input.ReadUInt32();
				break;
			case 64u:
				RoomId = input.ReadUInt32();
				break;
			case 120u:
				KGFFNDAINAK = input.ReadUInt32();
				break;
			}
		}
	}
}
