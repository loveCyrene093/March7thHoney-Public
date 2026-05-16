using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OMBGOODFIHB : IMessage<OMBGOODFIHB>, IMessage, IEquatable<OMBGOODFIHB>, IDeepCloneable<OMBGOODFIHB>, IBufferMessage
{
	private static readonly MessageParser<OMBGOODFIHB> _parser = new MessageParser<OMBGOODFIHB>(() => new OMBGOODFIHB());

	private UnknownFieldSet _unknownFields;

	public const int RoomIdFieldNumber = 1;

	private ulong roomId_;

	public const int MMLKFJIAKKHFieldNumber = 2;

	private uint mMLKFJIAKKH_;

	public const int LDKGJBALGKCFieldNumber = 3;

	private uint lDKGJBALGKC_;

	public const int TypeFieldNumber = 4;

	private uint type_;

	public const int ReasonFieldNumber = 5;

	private uint reason_;

	public const int IFLLEKANDCBFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_iFLLEKANDCB_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> iFLLEKANDCB_ = new RepeatedField<uint>();

	public const int EOOKCILKKNBFieldNumber = 7;

	private int eOOKCILKKNB_;

	public const int DHNEEIMLKEJFieldNumber = 8;

	private uint dHNEEIMLKEJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OMBGOODFIHB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OMBGOODFIHBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong RoomId
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
	public uint MMLKFJIAKKH
	{
		get
		{
			return mMLKFJIAKKH_;
		}
		set
		{
			mMLKFJIAKKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LDKGJBALGKC
	{
		get
		{
			return lDKGJBALGKC_;
		}
		set
		{
			lDKGJBALGKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IFLLEKANDCB => iFLLEKANDCB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EOOKCILKKNB
	{
		get
		{
			return eOOKCILKKNB_;
		}
		set
		{
			eOOKCILKKNB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DHNEEIMLKEJ
	{
		get
		{
			return dHNEEIMLKEJ_;
		}
		set
		{
			dHNEEIMLKEJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMBGOODFIHB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMBGOODFIHB(OMBGOODFIHB other)
		: this()
	{
		roomId_ = other.roomId_;
		mMLKFJIAKKH_ = other.mMLKFJIAKKH_;
		lDKGJBALGKC_ = other.lDKGJBALGKC_;
		type_ = other.type_;
		reason_ = other.reason_;
		iFLLEKANDCB_ = other.iFLLEKANDCB_.Clone();
		eOOKCILKKNB_ = other.eOOKCILKKNB_;
		dHNEEIMLKEJ_ = other.dHNEEIMLKEJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMBGOODFIHB Clone()
	{
		return new OMBGOODFIHB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OMBGOODFIHB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OMBGOODFIHB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoomId != other.RoomId)
		{
			return false;
		}
		if (MMLKFJIAKKH != other.MMLKFJIAKKH)
		{
			return false;
		}
		if (LDKGJBALGKC != other.LDKGJBALGKC)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (Reason != other.Reason)
		{
			return false;
		}
		if (!iFLLEKANDCB_.Equals(other.iFLLEKANDCB_))
		{
			return false;
		}
		if (EOOKCILKKNB != other.EOOKCILKKNB)
		{
			return false;
		}
		if (DHNEEIMLKEJ != other.DHNEEIMLKEJ)
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
		if (RoomId != 0L)
		{
			num ^= RoomId.GetHashCode();
		}
		if (MMLKFJIAKKH != 0)
		{
			num ^= MMLKFJIAKKH.GetHashCode();
		}
		if (LDKGJBALGKC != 0)
		{
			num ^= LDKGJBALGKC.GetHashCode();
		}
		if (Type != 0)
		{
			num ^= Type.GetHashCode();
		}
		if (Reason != 0)
		{
			num ^= Reason.GetHashCode();
		}
		num ^= iFLLEKANDCB_.GetHashCode();
		if (EOOKCILKKNB != 0)
		{
			num ^= EOOKCILKKNB.GetHashCode();
		}
		if (DHNEEIMLKEJ != 0)
		{
			num ^= DHNEEIMLKEJ.GetHashCode();
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
		if (RoomId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RoomId);
		}
		if (MMLKFJIAKKH != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MMLKFJIAKKH);
		}
		if (LDKGJBALGKC != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(LDKGJBALGKC);
		}
		if (Type != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Type);
		}
		if (Reason != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Reason);
		}
		iFLLEKANDCB_.WriteTo(ref output, _repeated_iFLLEKANDCB_codec);
		if (EOOKCILKKNB != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(EOOKCILKKNB);
		}
		if (DHNEEIMLKEJ != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(DHNEEIMLKEJ);
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
		if (RoomId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoomId);
		}
		if (MMLKFJIAKKH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMLKFJIAKKH);
		}
		if (LDKGJBALGKC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LDKGJBALGKC);
		}
		if (Type != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Type);
		}
		if (Reason != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Reason);
		}
		num += iFLLEKANDCB_.CalculateSize(_repeated_iFLLEKANDCB_codec);
		if (EOOKCILKKNB != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EOOKCILKKNB);
		}
		if (DHNEEIMLKEJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DHNEEIMLKEJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OMBGOODFIHB other)
	{
		if (other != null)
		{
			if (other.RoomId != 0L)
			{
				RoomId = other.RoomId;
			}
			if (other.MMLKFJIAKKH != 0)
			{
				MMLKFJIAKKH = other.MMLKFJIAKKH;
			}
			if (other.LDKGJBALGKC != 0)
			{
				LDKGJBALGKC = other.LDKGJBALGKC;
			}
			if (other.Type != 0)
			{
				Type = other.Type;
			}
			if (other.Reason != 0)
			{
				Reason = other.Reason;
			}
			iFLLEKANDCB_.Add(other.iFLLEKANDCB_);
			if (other.EOOKCILKKNB != 0)
			{
				EOOKCILKKNB = other.EOOKCILKKNB;
			}
			if (other.DHNEEIMLKEJ != 0)
			{
				DHNEEIMLKEJ = other.DHNEEIMLKEJ;
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
				RoomId = input.ReadUInt64();
				break;
			case 16u:
				MMLKFJIAKKH = input.ReadUInt32();
				break;
			case 24u:
				LDKGJBALGKC = input.ReadUInt32();
				break;
			case 32u:
				Type = input.ReadUInt32();
				break;
			case 40u:
				Reason = input.ReadUInt32();
				break;
			case 48u:
			case 50u:
				iFLLEKANDCB_.AddEntriesFrom(ref input, _repeated_iFLLEKANDCB_codec);
				break;
			case 56u:
				EOOKCILKKNB = input.ReadInt32();
				break;
			case 64u:
				DHNEEIMLKEJ = input.ReadUInt32();
				break;
			}
		}
	}
}
