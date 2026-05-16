using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IJKNDKJLMEN : IMessage<IJKNDKJLMEN>, IMessage, IEquatable<IJKNDKJLMEN>, IDeepCloneable<IJKNDKJLMEN>, IBufferMessage
{
	private static readonly MessageParser<IJKNDKJLMEN> _parser = new MessageParser<IJKNDKJLMEN>(() => new IJKNDKJLMEN());

	private UnknownFieldSet _unknownFields;

	public const int BJDBOEFFIAGFieldNumber = 1;

	private RogueRoomStatus bJDBOEFFIAG_;

	public const int HCMJDMFNENEFieldNumber = 4;

	private uint hCMJDMFNENE_;

	public const int IOGGIAJBEPPFieldNumber = 10;

	private uint iOGGIAJBEPP_;

	public const int MCEBJKDJHGPFieldNumber = 11;

	private RogueRoomStatus mCEBJKDJHGP_;

	public const int RoomIdFieldNumber = 15;

	private uint roomId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IJKNDKJLMEN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IJKNDKJLMENReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueRoomStatus BJDBOEFFIAG
	{
		get
		{
			return bJDBOEFFIAG_;
		}
		set
		{
			bJDBOEFFIAG_ = value;
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
	public uint IOGGIAJBEPP
	{
		get
		{
			return iOGGIAJBEPP_;
		}
		set
		{
			iOGGIAJBEPP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueRoomStatus MCEBJKDJHGP
	{
		get
		{
			return mCEBJKDJHGP_;
		}
		set
		{
			mCEBJKDJHGP_ = value;
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
	public IJKNDKJLMEN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJKNDKJLMEN(IJKNDKJLMEN other)
		: this()
	{
		bJDBOEFFIAG_ = other.bJDBOEFFIAG_;
		hCMJDMFNENE_ = other.hCMJDMFNENE_;
		iOGGIAJBEPP_ = other.iOGGIAJBEPP_;
		mCEBJKDJHGP_ = other.mCEBJKDJHGP_;
		roomId_ = other.roomId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IJKNDKJLMEN Clone()
	{
		return new IJKNDKJLMEN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IJKNDKJLMEN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IJKNDKJLMEN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BJDBOEFFIAG != other.BJDBOEFFIAG)
		{
			return false;
		}
		if (HCMJDMFNENE != other.HCMJDMFNENE)
		{
			return false;
		}
		if (IOGGIAJBEPP != other.IOGGIAJBEPP)
		{
			return false;
		}
		if (MCEBJKDJHGP != other.MCEBJKDJHGP)
		{
			return false;
		}
		if (RoomId != other.RoomId)
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
		if (BJDBOEFFIAG != RogueRoomStatus.LibdgmmoiliPcpdhelpkem)
		{
			num ^= BJDBOEFFIAG.GetHashCode();
		}
		if (HCMJDMFNENE != 0)
		{
			num ^= HCMJDMFNENE.GetHashCode();
		}
		if (IOGGIAJBEPP != 0)
		{
			num ^= IOGGIAJBEPP.GetHashCode();
		}
		if (MCEBJKDJHGP != RogueRoomStatus.LibdgmmoiliPcpdhelpkem)
		{
			num ^= MCEBJKDJHGP.GetHashCode();
		}
		if (RoomId != 0)
		{
			num ^= RoomId.GetHashCode();
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
		if (BJDBOEFFIAG != RogueRoomStatus.LibdgmmoiliPcpdhelpkem)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)BJDBOEFFIAG);
		}
		if (HCMJDMFNENE != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(HCMJDMFNENE);
		}
		if (IOGGIAJBEPP != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(IOGGIAJBEPP);
		}
		if (MCEBJKDJHGP != RogueRoomStatus.LibdgmmoiliPcpdhelpkem)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)MCEBJKDJHGP);
		}
		if (RoomId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(RoomId);
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
		if (BJDBOEFFIAG != RogueRoomStatus.LibdgmmoiliPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BJDBOEFFIAG);
		}
		if (HCMJDMFNENE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCMJDMFNENE);
		}
		if (IOGGIAJBEPP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IOGGIAJBEPP);
		}
		if (MCEBJKDJHGP != RogueRoomStatus.LibdgmmoiliPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MCEBJKDJHGP);
		}
		if (RoomId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoomId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IJKNDKJLMEN other)
	{
		if (other != null)
		{
			if (other.BJDBOEFFIAG != RogueRoomStatus.LibdgmmoiliPcpdhelpkem)
			{
				BJDBOEFFIAG = other.BJDBOEFFIAG;
			}
			if (other.HCMJDMFNENE != 0)
			{
				HCMJDMFNENE = other.HCMJDMFNENE;
			}
			if (other.IOGGIAJBEPP != 0)
			{
				IOGGIAJBEPP = other.IOGGIAJBEPP;
			}
			if (other.MCEBJKDJHGP != RogueRoomStatus.LibdgmmoiliPcpdhelpkem)
			{
				MCEBJKDJHGP = other.MCEBJKDJHGP;
			}
			if (other.RoomId != 0)
			{
				RoomId = other.RoomId;
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
			case 8u:
				BJDBOEFFIAG = (RogueRoomStatus)input.ReadEnum();
				break;
			case 32u:
				HCMJDMFNENE = input.ReadUInt32();
				break;
			case 80u:
				IOGGIAJBEPP = input.ReadUInt32();
				break;
			case 88u:
				MCEBJKDJHGP = (RogueRoomStatus)input.ReadEnum();
				break;
			case 120u:
				RoomId = input.ReadUInt32();
				break;
			}
		}
	}
}
